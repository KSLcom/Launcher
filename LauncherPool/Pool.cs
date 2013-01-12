/* Copyright (c) Stefan Wehrli, 1/10/2013, MIT License */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LauncherPool
{
    public class Pool
    {
        public List<Computer> Computers { get; set; }
        public string FileName { get; set; }

        public Pool()
        {
            Computers = new List<Computer>();
            FileName = "";
        }

        public void AddComputer(Computer computer)
        {
            Computers.Add(computer);
        }

        public void RemoveComputer(Computer computer)
        {
            Computers.Remove(computer);
        }

        public void RemoveComputer(string computerName)
        {
            var comps = from c in Computers
                        where c.ComputerName != computerName
                        select c;

            Computers = comps.ToList();
        }

        public Computer GetComputer(string computerName)
        {
            var comps = from c in Computers
                        where c.ComputerName == computerName
                        select c;

            return comps.FirstOrDefault();
        }

        public void SelectComputer(string computerName, bool select)
        {
            if (select)
            {
                foreach (Computer c in Computers)
                {
                    if (c.ComputerName == computerName) c.Selected = true;
                }
            }
            else
            {
                foreach (Computer c in Computers)
                {
                    if (c.ComputerName == computerName) c.Selected = false;
                }
            }
            
        }

        public void LoadFile()
        {
            if (!string.IsNullOrEmpty(FileName))
            {
                LoadFile(FileName);
            }
            else
            {
                string path = "clients.txt";
                if (File.Exists(path))
                {
                    LoadFile(path);
                    return;
                }
                path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + path;
                if (File.Exists(path))
                {
                    LoadFile(path);
                    return;
                }                
            }
        }

        public void LoadFile(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    Computers.Clear();
                    Computer myComputer = new Computer();

                    string line = "";

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.StartsWith("#"))
                        {
                            if (line.IndexOf(";") >= 0)
                            {
                                string[] fields = line.Split(';');
                                myComputer = new Computer();
                                myComputer.ComputerName = fields[0];
                                myComputer.IPAddress = fields[1];
                                myComputer.MACAddress = fields[2];
                                myComputer.SubPool = Convert.ToInt32(fields[3]);
                                myComputer.PreSelected = false;
                                if (fields.Length == 5)
                                {
                                    if (fields[4].IndexOf("1") >= 0)
                                    {
                                        myComputer.PreSelected = true;
                                    }
                                }
                                Computers.Add(myComputer);
                            }
                        }
                    }
                }
                SetPreselected();
            }
        }

        public void SaveFile(string path)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("#ComputerName;IPAddress;MACAddress;SubPool;Selected");
            foreach (Computer c in Computers)
            {
                sb.AppendLine(c.ComputerName + ";" + c.IPAddress + ";" + c.MACAddress + ";" + c.SubPool + ";" + Convert.ToInt32(c.Selected).ToString());
            }

            using (StreamWriter outfile = new StreamWriter(path, false, Encoding.Default))
            {
                outfile.Write(sb.ToString());
            }
        }

        public void GroupSelection(int group)
        {
            foreach (Computer c in Computers)
            {
                if (c.SubPool == group) c.Selected = true;
                if (group == 0) c.Selected = true;
            }
        }

        public void ClearSelection()
        {
            foreach (Computer c in Computers)
            {
                    c.Selected = false;
            }
        }

        public string GetSelection(bool all)
        {
            string result = "";
            foreach (Computer c in Computers)
            {
                if (c.Selected | all)
                {
                    result += c.ComputerName + ",";
                }
            }
            //Kill last comma
            if (result.Length > 2)
            {
                return result.Substring(0, result.Length - 1);
            }
            return "";
        }

        public string GetComputerName(string item)
        {
            if (item.IndexOf("[") > 0)
            {
                return item.Substring(0, item.IndexOf("[")).Trim();
            }
            return item;
        }

        private void SetPreselected()
        {
            foreach (Computer c in Computers)
            {
                if (c.PreSelected) c.Selected = true;
            }
        }

    }
}
