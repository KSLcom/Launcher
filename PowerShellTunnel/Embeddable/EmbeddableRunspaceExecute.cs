//(c) Matthew Hobbs, 1/22/2008.  Licensed under Microsoft Public License (Ms-PL) (http://code.msdn.microsoft.com/PowerShellTunnel/Project/License.aspx)
using System;
using System.Threading;

namespace PowerShellTunnel.Embeddable
{
	public class EmbeddableRunspaceExecute
	{
		#region private state
		private readonly bool preventCloseOnInvokedExit;
		private readonly ManualResetEvent waitForClose = new ManualResetEvent(false);
		private readonly Thread threadEmbeddableRunspace;
		private readonly EmbeddableRunspace embeddableRunspace;
		#endregion

		#region constructor
		public EmbeddableRunspaceExecute(bool preventCloseOnInvokedExit)
		{
			this.preventCloseOnInvokedExit = preventCloseOnInvokedExit;
			this.embeddableRunspace = new EmbeddableRunspace(NotifyPSHostExit);
			this.threadEmbeddableRunspace = new Thread(new ThreadStart(EmbeddableRunspaceThreadExecute));
		}
		#endregion

		#region public methods
		public void ExposeObject(string powerShellVariableName, object objectToExpose)
		{
			embeddableRunspace.ExposeObject(powerShellVariableName, objectToExpose);
		}

		public void AddTunnelHost(string tunnelHostName, string hostAddress)
		{
			embeddableRunspace.AddTunnelHost(tunnelHostName, hostAddress);
		}

		public void Startup()
		{
			if (threadEmbeddableRunspace.ThreadState == ThreadState.Unstarted)
				threadEmbeddableRunspace.Start();
		}

		public void Shutdown()
		{
			Close(); //Allow the threadEmbeddableRunspace to close.
			threadEmbeddableRunspace.Join();
		}
		#endregion

		#region private methods
		private void EmbeddableRunspaceThreadExecute()
		{
			using (embeddableRunspace)
			{
				//Wait for a client (any client) to issue an "exit" on this (hosted)
				//runspace.  In practice you may not want to use this approach but
				//instead do nothing here and manage the lifecycle of this runspace
				//yourself.
				waitForClose.WaitOne();
			}
		}

		/// <summary>
		/// This callback (delegate) will be called if a client does an 'exit'
		/// on the embedded runspace.  How you handle this depends on what you
		/// want to do.  Here we just allow the EmbeddableRunspace to close.
		/// </summary>
		private void NotifyPSHostExit(int exitCode)
		{
			if (!preventCloseOnInvokedExit)
				Close();
		}

		private void Close()
		{
			waitForClose.Set();
		}
		#endregion
	}
}
