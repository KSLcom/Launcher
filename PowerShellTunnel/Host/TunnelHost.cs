//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace PowerShellTunnel.Host
{
	[ServiceBehavior(IncludeExceptionDetailInFaults = true, InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
	public class TunnelHost : ITunnelHost
	{
		#region private state
		private readonly Runspace runspace;
		#endregion

		#region public properties
		public Runspace Runspace
		{
			get { return runspace; }
		}
		#endregion

		#region constructor
		private TunnelHost(Runspace runspace)
		{
			this.runspace = runspace;
		}
		#endregion

		#region ITunnelHost
		//Called on a WCF worker thread.
		byte[][] ITunnelHost.RunScript(string script, byte[][] pipeInput, bool pipeOutput)
		{
			try
			{
				Collection<PSObject> invokeResult;
				using (Pipeline pipe = Runspace.CreatePipeline(script))
				{
					if (!pipeOutput)
					{
						Command command = new Command("Out-String");
						command.Parameters.Add("-stream");
						pipe.Commands.Add(command);
					}
					if (pipeInput != null)
					{
						foreach (byte[] byteArray in pipeInput)
							pipe.Input.Write(DeserializeToObject(byteArray), false);
						pipe.Input.Close();
					}
					invokeResult = pipe.Invoke();
				}

				return SerializedPSObjectCollection(invokeResult);
			}
			catch (Exception ex)
			{
				//Prevent the WCF connection from entering the Faulted state.
				throw new FaultException(ex.ToString());
			}
		}
		#endregion

		#region public static methods
		public static ServiceHost CreateTunnelHost(Runspace runspace, string baseAddress)
		{
			baseAddress = baseAddress.ToLower();
			Uri baseAddressUri = new Uri(baseAddress);
			ServiceHost serviceHost = new ServiceHost(new TunnelHost(runspace), baseAddressUri);

			serviceHost.AddServiceEndpoint(typeof(ITunnelHost), new WSHttpBinding(), "");
			ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
			smb.HttpGetEnabled = true;
			serviceHost.Description.Behaviors.Add(smb);
			serviceHost.Open();

			return serviceHost;
		}
		#endregion

		#region private static methods
		//PSObject is not serializable.
		private static byte[][] SerializedPSObjectCollection(Collection<PSObject> psObjectCollection)
		{
			if (psObjectCollection == null)
			{
				return null;
			}
			else
			{
				byte[][] result = new byte[psObjectCollection.Count][];
				for (int i = 0; i < psObjectCollection.Count; i++)
					if ((psObjectCollection[i] != null) && (psObjectCollection[i].BaseObject != null))
						result[i] = SerializeObject(psObjectCollection[i].BaseObject);
				return result;
			}
		}

		private static byte[] SerializeObject(object obj)
		{
			if (obj == null)
				return null;

			BinaryFormatter binaryFormatter = new BinaryFormatter();
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				binaryFormatter.Serialize(memoryStream, obj);
			}
			catch
			{
				//obj is not serializable, just use its ToString().
				memoryStream = new MemoryStream();
				binaryFormatter.Serialize(memoryStream, obj.ToString());
			}
			return memoryStream.ToArray();
		}

		//PSObject is not serializable.
		private static string[] PSObjectCollectionToStringArray(Collection<PSObject> psObjectCollection)
		{
			if (psObjectCollection == null)
			{
				return null;
			}
			else
			{
				string[] result = new string[psObjectCollection.Count];
				for (int i = 0; i < psObjectCollection.Count; i++)
					if (psObjectCollection[i].BaseObject != null)
						result[i] = psObjectCollection[i].BaseObject.ToString();
				return result;
			}
		}

		private static object DeserializeToObject(byte[] byteArray)
		{
			if (byteArray == null)
				return null;

			BinaryFormatter binaryFormatter = new BinaryFormatter();
			return binaryFormatter.Deserialize(new MemoryStream(byteArray));
		}
		#endregion
	}
}
