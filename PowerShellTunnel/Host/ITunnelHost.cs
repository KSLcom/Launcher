//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Management.Automation;
using PowerShellTunnel.Common;

namespace PowerShellTunnel.Host
{
	[ServiceContract(Namespace = "http://PowerShellTunnel")]
	public interface ITunnelHost
	{
		[OperationContract]
		[WCFCustomDataContractSerializer(MaxItemsInObjectGraph = Int32.MaxValue)]
		byte[][] RunScript(string script, byte[][] pipeInput, bool pipeOutput);
	}
}
