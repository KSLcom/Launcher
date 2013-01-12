//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.ComponentModel;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text.RegularExpressions;
using PowerShellTunnel.Client;
using PowerShellTunnel.Host;

namespace PowerShellTunnel.Install
{
	[RunInstaller(true)]
	public class SnapIn : CustomPSSnapIn
	{
		private Collection<CmdletConfigurationEntry> cmdlets = new Collection<CmdletConfigurationEntry>();
		private Collection<ProviderConfigurationEntry> providers = new Collection<ProviderConfigurationEntry>();
		private Collection<TypeConfigurationEntry> types = new Collection<TypeConfigurationEntry>();
		private Collection<FormatConfigurationEntry> formats = new Collection<FormatConfigurationEntry>();

		public SnapIn()
			: base()
		{
			cmdlets.Add(new CmdletConfigurationEntry("Add-TunnelHost", typeof(CmdletAddTunnelHost), null));
			cmdlets.Add(new CmdletConfigurationEntry("Remove-TunnelHost", typeof(CmdletRemoveTunnelHost), null));
			cmdlets.Add(new CmdletConfigurationEntry("Add-Tunnel", typeof(CmdletAddTunnel), null));
			cmdlets.Add(new CmdletConfigurationEntry("Remove-Tunnel", typeof(CmdletRemoveTunnel), null));
			cmdlets.Add(new CmdletConfigurationEntry("Invoke-Tunnel", typeof(CmdletInvokeTunnel), null));
			cmdlets.Add(new CmdletConfigurationEntry("Select-Tunnel", typeof(CmdletSelectTunnel), null));
		}

		public override string Name
		{
			get { return "PowerShellTunnel"; }
		}

		public override string Vendor
		{
			get { return "Matthew Hobbs"; }
		}

		public override string Description
		{
			get { return "Add/Remove/Select/Invoke a Tunnel (client) or Add/Remove a TunnelHost (host service)."; }
		}

		public override Collection<CmdletConfigurationEntry> Cmdlets
		{
			get { return cmdlets; }
		}

		public override Collection<ProviderConfigurationEntry> Providers
		{
			get { return providers; }
		}

		public override Collection<TypeConfigurationEntry> Types
		{
			get { return types; }
		}

		public override Collection<FormatConfigurationEntry> Formats
		{
			get { return formats; }
		}
	}
}
