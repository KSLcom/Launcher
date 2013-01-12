//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;

namespace PowerShellTunnel.Embeddable
{
	/// <summary>
	/// An example PSHostUserInterface implementation with no output.
	/// 
	/// This is useful for a PowerShell Runspace hosted (embedded) within an
	/// application where you don't want a physical console for it.
	/// 
	/// In some applications you might want to log or otherwise handle some of
	/// these methods.
	/// </summary>
	internal class EmbeddablePSHostUserInterface : PSHostUserInterface
	{
		public override Dictionary<string, PSObject> Prompt(string caption, string message, System.Collections.ObjectModel.Collection<FieldDescription> descriptions)
		{
			throw new NotImplementedException("Prompt is not implemented.");
		}

		public override int PromptForChoice(string caption, string message, System.Collections.ObjectModel.Collection<ChoiceDescription> choices, int defaultChoice)
		{
			throw new NotImplementedException("PromptForChoice is not implemented.");
		}

		public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName)
		{
			throw new NotImplementedException("PromptForCredential is not implemented.");
		}

		public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName, PSCredentialTypes allowedCredentialTypes, PSCredentialUIOptions options)
		{
			throw new NotImplementedException("PromptForCredential is not implemented.");
		}

		public override PSHostRawUserInterface RawUI
		{
			get { return null; }
		}

		public override string ReadLine()
		{
			throw new NotImplementedException("ReadLine is not implemented.");
		}

		public override System.Security.SecureString ReadLineAsSecureString()
		{
			throw new NotImplementedException("ReadLineAsSecureString is not implemented.");
		}

		public override void Write(string value)
		{
		}

		public override void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
		{
		}

		public override void WriteDebugLine(string message)
		{
		}

		public override void WriteErrorLine(string value)
		{
		}

		public override void WriteLine()
		{
		}

		public override void WriteLine(string value)
		{
		}

		public override void WriteLine(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
		{
		}

		public override void WriteProgress(long sourceId, ProgressRecord record)
		{
		}

		public override void WriteVerboseLine(string message)
		{
		}

		public override void WriteWarningLine(string message)
		{
		}
	}
}