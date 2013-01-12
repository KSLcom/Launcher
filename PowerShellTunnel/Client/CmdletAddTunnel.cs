//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Collections.Generic;
using System.Management.Automation; //PowerShell
using System.Management.Automation.Runspaces;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace PowerShellTunnel.Client
{
	/// <summary>
	/// Add a tunnel: a client connection to anotehr PowerShell session in which
	/// add-tunnelhost has been called to allow one or many client connections to
	/// run script blocks host allowing another PowerShell session to connect to
	/// this PowerShell session and run scripts on it.
	/// 
	/// The nature of the connection and any security, etc., we defer to WCF.
	/// 
	/// Specify only a HostAddress for a default WSHttpBinding.
	/// </summary>
	[Cmdlet(VerbsCommon.Add, "Tunnel")]
	public class CmdletAddTunnel : System.Management.Automation.Cmdlet
	{
		private string[] hostAddress;
		private Binding[] binding;
		private SwitchParameter noSelect;

		[Parameter(Position = 0, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, Mandatory = true, HelpMessage = "Address of WCF tunnel host, e.g. \"http://localhost:8000/PowerShellTunnel/Host1\".")]
		public string[] HostAddress
		{
			get { return hostAddress; }
			set { hostAddress = value; }
		}

		[Parameter(Position = 1, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, Mandatory = false, HelpMessage = "Optional Binding object if not using the default WsHttpBinding.")]
		public Binding[] Binding
		{
			get { return binding; }
			set { binding = value; }
		}

		[Parameter(Position = 2, ValueFromPipeline = false, ValueFromPipelineByPropertyName = false, Mandatory = false, HelpMessage = "Optional switch to prevent the new tunnel from automatically being selected as the default (i.e. bypass doing a select-tunnel).")]
		public SwitchParameter NoSelect
		{
			get { return noSelect; }
			set { noSelect = value; }
		}

		protected override void ProcessRecord()
		{
			Runspace runspace = System.Management.Automation.Runspaces.Runspace.DefaultRunspace;

			for (int i = 0; i < HostAddress.Length; i++)
			{
				Binding binding = ((Binding != null) && (i < Binding.Length)) ? Binding[i] : CreateDefaultBinding();
				Tunnel tunnel = new Tunnel(runspace, binding, new EndpointAddress(HostAddress[i]));
				if (!NoSelect.IsPresent)
					tunnel.SetAsCurrent();
				this.WriteObject(tunnel);
			}

			base.ProcessRecord();
		}

		private Binding CreateDefaultBinding()
		{
			WSHttpBinding wSHttpBinding = new WSHttpBinding();
			wSHttpBinding.MaxReceivedMessageSize = 1000000000; //bytes (default is 65,536 bytes)
			return wSHttpBinding;
		}
	}
}
