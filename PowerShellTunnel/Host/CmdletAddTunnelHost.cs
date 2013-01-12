//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Collections.Generic;
using System.Management.Automation; //PowerShell
using System.Management.Automation.Runspaces;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace PowerShellTunnel.Host
{
	/// <summary>
	/// Add a tunnel host allowing another PowerShell session to connect to
	/// this PowerShell session and run scripts on it.
	/// 
	/// Instances of ServiceHost are returned.  The nature of the connection and any
	/// security, etc., we defer to WCF.
	/// </summary>
	[Cmdlet(VerbsCommon.Add, "TunnelHost")]
	public class CmdletAddTunnelHost : System.Management.Automation.Cmdlet
	{
		#region private state
		private string[] baseAddress;
		#endregion

		#region Cmdlet implementation
		[Parameter(Position = 0, ValueFromPipeline = true, ValueFromPipelineByPropertyName = false, Mandatory = true, HelpMessage = "Base address of WCF tunnel host, e.g. \"http://localhost:8000/PowerShellTunnel/Host1\".")]
		public string[] BaseAddress
		{
			get { return baseAddress; }
			set { baseAddress = value; }
		}

		protected override void ProcessRecord()
		{
			Runspace runspace = System.Management.Automation.Runspaces.Runspace.DefaultRunspace;
			if (runspace == null)
				throw new ApplicationException("Add-TunnelHost - unable to get the DefaultRunspace.");

			foreach (string baseAddress in BaseAddress)
			{
				ServiceHost serviceHost = TunnelHost.CreateTunnelHost(runspace, baseAddress);
				this.WriteObject(serviceHost);
			}

			base.ProcessRecord();
		}
		#endregion
	}
}
