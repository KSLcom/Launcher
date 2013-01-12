/* Copyright (c) Stefan Wehrli, 1/10/2013, MIT License */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LauncherPool
{
    public class Computer
    {
        public int Id { get; set; }
        public string ComputerName { get; set; }
        public string MACAddress { get; set; }
        public string IPAddress { get; set; }
        public int SubPool { get; set; }
        public bool PreSelected { get; set; }
        public bool Selected { get; set; }

        public Computer()
        {
            Id = 0;
            ComputerName = "";
            MACAddress = "";
            IPAddress = "";
            SubPool = 0;
            PreSelected = false;
            Selected = false;
        }

        public Computer(int id, string computerName, string macAddress, string ipAddress, int subPool, bool selected)
        {
            ComputerName = computerName;
            MACAddress = macAddress;
            IPAddress = ipAddress;
            SubPool = subPool;
            Selected = selected;
        }

    }
}
