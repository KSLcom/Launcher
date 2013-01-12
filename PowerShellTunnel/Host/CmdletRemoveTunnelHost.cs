//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Collections.Generic;
using System.Management.Automation; //PowerShell
using System.ServiceModel;
using System.ServiceModel.Description;

namespace PowerShellTunnel.Host
{
	/// <summary>
	/// Remove (close) a tunnel host connection.
	/// </summary>
	[Cmdlet(VerbsCommon.Remove, "TunnelHost")]
	public class CmdletRemoveTunnelHost : System.Management.Automation.Cmdlet
	{
		private ServiceHost[] serviceHost;

		[Parameter(Position = 0, ValueFromPipeline = true, ValueFromPipelineByPropertyName = false, Mandatory = true, HelpMessage = "Remove (close) the tunnel host.")]
		public ServiceHost[] ServiceHost
		{
			get { return serviceHost; }
			set { serviceHost = value; }
		}

		protected override void ProcessRecord()
		{
			foreach (ServiceHost servicehost in ServiceHost)
				servicehost.Close();

			base.ProcessRecord();
		}
	}
}
