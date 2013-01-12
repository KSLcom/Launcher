using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LauncherForm myLauncher = new LauncherForm();
            myLauncher.IsLauncherVisible = false;

            if (args.Length > 0)
            {
                foreach (string arg in args)
                {
                    switch (arg)
                    {
                        case "-i":
                            myLauncher.IsLauncherVisible = true;
                            break;
                    }
                }
            }

            Application.Run(myLauncher);
        }
    }
}
