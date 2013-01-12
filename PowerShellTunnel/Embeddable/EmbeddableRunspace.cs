//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;
using System.ServiceModel;
using PowerShellTunnel.Host;

namespace PowerShellTunnel.Embeddable
{
	/// <summary>
	/// A simple embeddable PowerShell runspace that does not have any console or
	/// output.  You might want to extend this to log error output.
	/// 
	/// A)	Use ExposeObject() for each object you want to 'publish' to the hosted
	/// runspace, e.g.
	/// 
	///		ExposeObject("myvar1", obj)
	///	
	///	which will set a runspace variable $myvar1 to obj where it will be
	///	available for any tunnels.
	///	
	/// B)	Use AddTunnelHost() to do an add-tunnelhost (to allow client tunnels to
	/// connect to the runspace).
	///	
	/// C)	Use another PowerShell console to tunnel (connect) into the
	/// embedded runspace using add-tunnel, and then invoke-tunnel.
	/// 
	/// Assumptions (prerequisites):
	/// 
	/// * As we are using WCF Http by default, we assume that access has been
	/// granted (from an admin console), e.g. (note that this only needs to be
	/// done once).
	/// 
	///		netsh http add urlacl url="...your host address..." user="YOURMACHINENAME\YOURUSERNAME"
	/// 
	/// Note that this embeddable runspace example application requires access to PowerShellTunnel.dll
	/// but it does not require that it be installed (it does not use any PowerShellTunnel cmdlets).
	/// </summary>
	public class EmbeddableRunspace : IDisposable
	{
		#region private state
		private readonly EmbeddablePSHost embeddedPSHost;
		private readonly Runspace runspace;
		private readonly object lockerRunScript = new object();
		#endregion

		#region constructor
		public EmbeddableRunspace(NotifyPSHostExit notifyPSHostExit)
		{
			this.embeddedPSHost = new EmbeddablePSHost(notifyPSHostExit);
			this.runspace = RunspaceFactory.CreateRunspace(embeddedPSHost);
			this.runspace.Open();
			RunScript("add-pssnapin PowerShellTunnel");
		}
		#endregion

		#region public methods
		public void ExposeObject(string powerShellVariableName, object objectToExpose)
		{
			embeddedPSHost.Expose(powerShellVariableName, objectToExpose);
			RunScript(String.Format("${0} = $host.PrivateData[\"{0}\"]", powerShellVariableName));
		}

		public void AddTunnelHost(string tunnelhostVariableName, string hostAddress)
		{
			ServiceHost serviceHost = TunnelHost.CreateTunnelHost(runspace, hostAddress);
			ExposeObject(tunnelhostVariableName, serviceHost);
		}
		#endregion

		#region IDisposable
		public void Dispose()
		{
			runspace.Dispose();
		}
		#endregion

		#region private methods
		private void RunScript(string script)
		{
			lock (lockerRunScript)
			{
				using (Pipeline pipe = this.runspace.CreatePipeline())
				{
					pipe.Commands.AddScript(script);
					pipe.Invoke();
				}
			}
		}
		#endregion
	}
}
