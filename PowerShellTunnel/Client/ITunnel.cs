//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.ServiceModel;
using PowerShellTunnel.Common;

namespace PowerShellTunnel.Client
{
	[System.ServiceModel.ServiceContractAttribute(Namespace = "http://PowerShellTunnel", ConfigurationName = "ITunnel")]
	public interface ITunnel
	{
		[OperationContractAttribute(Action = "http://PowerShellTunnel/ITunnelHost/RunScript", ReplyAction = "http://PowerShellTunnel/ITunnelHost/RunScriptResponse")]
		[WCFCustomDataContractSerializer(MaxItemsInObjectGraph = Int32.MaxValue)]
		byte[][] RunScript(string script, byte[][] pipeInput, bool pipeOutput);
	}
}
