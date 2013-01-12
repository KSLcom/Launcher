//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Collections.Generic;
using System.Management.Automation; //PowerShell
using System.ServiceModel;
using System.ServiceModel.Description;

namespace PowerShellTunnel.Client
{
	/// <summary>
	/// Select which tunnel is the current tunnel (for tab expansion and
	/// invoke-tunnel default).
	/// </summary>
	[Cmdlet(VerbsCommon.Select, "Tunnel")]
	public class CmdletSelectTunnel : System.Management.Automation.Cmdlet
	{
		private Tunnel tunnel;

		[Parameter(Position = 0, ValueFromPipeline = false, ValueFromPipelineByPropertyName = false, Mandatory = false, HelpMessage = "The tunnel to use for tab expansion and as the default for Invoke-Tunnel.")]
		public Tunnel Tunnel
		{
			get { return tunnel; }
			set { tunnel = value; }
		}

		protected override void ProcessRecord()
		{
			Tunnel.TunnelCurrent = Tunnel;
			base.ProcessRecord();
		}
	}
}
