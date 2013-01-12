//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Collections.Generic;
using System.Management.Automation; //PowerShell
using System.ServiceModel;
using System.ServiceModel.Description;

namespace PowerShellTunnel.Client
{
	/// <summary>
	/// Remove (close) a tunnel (client) connection.
	/// </summary>
	[Cmdlet(VerbsCommon.Remove, "Tunnel")]
	public class CmdletRemoveTunnel : System.Management.Automation.Cmdlet
	{
		private Tunnel[] tunnel;

		[Parameter(Position = 0, ValueFromPipeline = true, ValueFromPipelineByPropertyName = false, Mandatory = true, HelpMessage = "Tunnel to remove (close).")]
		public Tunnel[] Tunnel
		{
			get { return tunnel; }
			set { tunnel = value; }
		}

		protected override void ProcessRecord()
		{
			foreach (Tunnel tunnel in Tunnel)
				tunnel.Close();

			base.ProcessRecord();
		}
	}
}
