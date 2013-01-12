//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Management.Automation; //PowerShell
using System.ServiceModel;
using System.ServiceModel.Description;

namespace PowerShellTunnel.Client
{
	/// <summary>
	/// Invoke a script on the host of the optionally specified tunnel.
	/// If no tunnel is specified, the current tunnel (specified by the last call to
	/// select-tunnel or add-tunnel without specifying the -noselect switch) is used.
	/// </summary>
	[Cmdlet("Invoke", "Tunnel")]
	public class CmdletInvokeTunnel : System.Management.Automation.Cmdlet
	{
		private ScriptBlock scriptBlock;
		private Tunnel tunnel;
		private object input;
		private SwitchParameter pipeOutput;
		private readonly ArrayList entirePipeLine = new ArrayList();

		[Parameter(Position = 0, ValueFromPipeline = false, ValueFromPipelineByPropertyName = false, Mandatory = true, HelpMessage = "Script to execute on the tunnel host PowerShell console or runspace.")]
		public ScriptBlock ScriptBlock
		{
			get { return scriptBlock; }
			set { scriptBlock = value; }
		}

		[Parameter(Position = 1, Mandatory = false, HelpMessage = "The tunnel (Tunnel) instance to invoke the script on (defaults to the current tunnel).")]
		public Tunnel Tunnel
		{
			get { return tunnel; }
			set { tunnel = value; }
		}

		[Parameter(Position = 2, ValueFromPipeline = true, ValueFromPipelineByPropertyName = false, Mandatory = false, HelpMessage = "Optional input piped into the command.")]
		public object Input
		{
			get { return input; }
			set { input = value; }
		}

		[Parameter(Position = 3, ValueFromPipeline = false, ValueFromPipelineByPropertyName = false, Mandatory = false, HelpMessage = "Optional switch to serialize (if possible) any piped output and sent back to the client.")]
		public SwitchParameter PipeOutput
		{
			get { return pipeOutput; }
			set { pipeOutput = value; }
		}

		protected override void ProcessRecord()
		{
			if (Input is PSObject)
				entirePipeLine.Add((Input as PSObject).BaseObject);
			else
				entirePipeLine.Add(Input);

			base.ProcessRecord();
		}

		protected override void EndProcessing()
		{
			Tunnel tunnel = (Tunnel != null) ? Tunnel : Tunnel.TunnelCurrent;
			if (tunnel == null)
				throw new ApplicationException("Invoke-Tunnel failed: no specified or current tunnel.");

			byte[][] pipeAsByteArrayArray;

			if (entirePipeLine.Count == 0)
			{
				pipeAsByteArrayArray = null;
			}
			else
			{
				pipeAsByteArrayArray = new byte[entirePipeLine.Count][];
				for (int i = 0; i < entirePipeLine.Count; i++)
				{
					pipeAsByteArrayArray[i] = Tunnel.SerializeToByteArray(entirePipeLine[i]);
				}
			}

			if (scriptBlock != null)
			{
				byte[][] byteArrayArray = tunnel.RunScript(scriptBlock.ToString(), pipeAsByteArrayArray, PipeOutput.IsPresent);

				foreach (byte[] byteArray in byteArrayArray)
					this.WriteObject(Tunnel.DeserializeToObject(byteArray));
			}

			base.EndProcessing();
		}
	}
}
