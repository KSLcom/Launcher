/* Copyright (c) Stefan Wehrli, 1/10/2013, MIT License */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace LauncherPool
{
    static class Program
    {
        public static string PoolResult { get; set; }
        public static string FileName { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SelectComputerForm mySelectorForm = new SelectComputerForm();
            PoolResult = "";

            StringBuilder sb = new StringBuilder();
            if (args.Length == 0 | args.Any(i => i == "/?") | args.Any(i => i == "/h") | args.Any(i => i == "-h"))
            {
                sb.AppendLine("LauncherPool Usage:");
                sb.AppendLine();
                sb.AppendLine("-f   Filename of computer list");
                sb.AppendLine("-s   Return selected computers in console");
                sb.AppendLine("-a   Return all computer names in console");
                sb.AppendLine("-i   Interactive selection");
                sb.AppendLine("-h   This help file");
                sb.AppendLine();
                Console.Write(sb);
                return;
            }

            if (args.Any(i => i == "/f") | args.Any(i => i == "-f"))
            {
                
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "/f" | args[i] == "-f")
                    {
                        FileName = args[i + 1];
                        break;
                    }
                }
                if (System.IO.File.Exists(FileName))
                {
                    mySelectorForm.myPool.FileName = FileName;
                    mySelectorForm.myPool.LoadFile();
                } 
            }

            if (args.Any(i => i == "/s") | args.Any(i => i == "-s"))
            {
                if (!System.IO.File.Exists(FileName)) return;
                PoolResult = mySelectorForm.myPool.GetSelection(false);
                Console.WriteLine(PoolResult);
                return;
            }

            if (args.Any(i => i == "/a") | args.Any(i => i == "-a"))
            {
                if (!System.IO.File.Exists(FileName)) return;
                PoolResult = mySelectorForm.myPool.GetSelection(true);
                Console.WriteLine(PoolResult);
                return;
            }

            if (args.Any(i => i == "/i") | args.Any(i => i == "-i"))
            {
                Application.Run(mySelectorForm);
                PoolResult = mySelectorForm.myPool.GetSelection(false);
                Console.WriteLine(PoolResult);
            }
        }
    }
}
