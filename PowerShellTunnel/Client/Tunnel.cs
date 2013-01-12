//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Collections.Generic;
using System.IO;
using System.Management.Automation.Runspaces;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;

namespace PowerShellTunnel.Client
{
	public class Tunnel : System.ServiceModel.ClientBase<ITunnel>, ITunnel
	{
		#region private state
		private Runspace runspace;
		#endregion

		#region private static state
		private const string backupTabExpansionFunction = "PowerShellTunnel_Original_TabExpansion";
		private static Tunnel tunnelCurrent;
		private static bool initialized;
		private static readonly IList<Tunnel> tunnelActiveList = new List<Tunnel>();
		private static readonly BinaryFormatter binaryFormatter = new BinaryFormatter();
		#endregion

		#region constructors
		public Tunnel(Runspace runspace, string endpointConfigurationName)
			: base(endpointConfigurationName)
		{
			Init(runspace);
		}

		public Tunnel(Runspace runspace, string endpointConfigurationName, string remoteAddress)
			: base(endpointConfigurationName, remoteAddress)
		{
			Init(runspace);
		}

		public Tunnel(Runspace runspace, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress)
			: base(endpointConfigurationName, remoteAddress)
		{
			Init(runspace);
		}

		public Tunnel(Runspace runspace, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
			: base(binding, remoteAddress)
		{
			Init(runspace);
		}
		#endregion

		#region public static properties
		public static Tunnel TunnelCurrent
		{
			get
			{
				if (tunnelCurrent == null)
					throw new ApplicationException("Tunnel - no current Tunnel set.");
				return tunnelCurrent;
			}
			set
			{
				tunnelCurrent = value;
			}
		}
		#endregion

		#region public properties
		public bool IsCurrent
		{
			get
			{
				return ReferenceEquals(this, tunnelCurrent);
			}
		}
		#endregion

		#region public methods
		public void SetAsCurrent()
		{
			tunnelCurrent = this;
		}

		public new void Close()
		{
			if (tunnelCurrent == this)
				tunnelCurrent = null;
			tunnelActiveList.Remove(this);
			base.Close();
			if (tunnelActiveList.Count == 0)
			{
				RestoreTabExpansion();
			}
		}

		public byte[][] RunScript(string script, byte[][] pipeInput, bool pipeOutput)
		{
			return base.Channel.RunScript(script, pipeInput, pipeOutput);
		}

		public string[] TabExpansion(string line, string lastWord)
		{
			byte[][] byteArrayArray = RunScript(String.Format("tabexpansion '{0}' '{1}'", line, lastWord), null, true);
			string[] result = new string[byteArrayArray.Length];

			for (int i = 0; i < byteArrayArray.Length; i++)
			{
				object deserialized = DeserializeToObject(byteArrayArray[i]);
				result[i] = (deserialized != null) ? deserialized.ToString() : null;
			}

			return result;
		}
		#endregion

		#region private methods
		private void Init(Runspace runspace)
		{
			this.runspace = runspace;
			CheckInitialization();
			tunnelActiveList.Add(this);
			Open();
		}
		#endregion

		#region internal static methods
		internal static object DeserializeToObject(byte[] byteArray)
		{
			return (byteArray == null) ? null : binaryFormatter.Deserialize(new MemoryStream(byteArray));
		}

		internal static byte[] SerializeToByteArray(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			else
			{
				MemoryStream memoryStream = new MemoryStream();
				binaryFormatter.Serialize(memoryStream, obj);
				return memoryStream.ToArray();
			}
		}
		#endregion

		#region private methods
		private void CheckInitialization()
		{
			if (!initialized)
			{
				initialized = true;

				//Set tabexpansion: 1/2) backup current tabexpansion to a unique name.
				RunLocalScript("rename-item -path function:tabexpansion -newname " + backupTabExpansionFunction);
				//-verbose? RunLocalScript(String.Format("write-host 'Function tabexpansion renamed to {0} until [PowerShellTunnel.Client.Tunnel]::Restore() is called.'", backupTabExpansionFunction));

				//Set tabexpansion: 2/2) define a new tabexpansion that uses the tunnel instead.
				RunLocalScript(
				"function tabexpansion {\n" +
				"	param($line, $lastword)\n" +
				"	& {\n" +
				"		[PowerShellTunnel.Client.Tunnel]::TunnelCurrent.TabExpansion($line, $lastword)\n" +
				"	}\n" +
				"}");
				//-verbose? RunLocalScript("write-host 'Tabexpansion diverted to [PowerShellTunnel.Client.Tunnel]::TunnelCurrent.TabExpansion().'");
			}
		}

		private void RestoreTabExpansion()
		{
			RunLocalScript("remove-item function:tabexpansion");
			//RunLocalScript("write-host 'Function tabexpansion removed.'");
			RunLocalScript(String.Format("rename-item -path function:{0} -newname tabexpansion", backupTabExpansionFunction));
			//RunLocalScript(String.Format("write-host 'Function {0} renamed back to tabexpansion.'", backupTabExpansionFunction));
			initialized = false;
		}

		//Called on a WCF worker thread.
		private void RunLocalScript(string script)
		{
			using (Pipeline pipe = runspace.CreateNestedPipeline())
			{
				pipe.Commands.AddScript(script);
				pipe.Invoke();
			}
		}
		#endregion
	}
}
