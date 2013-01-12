/* Copyright (c) Stefan Wehrli, 1/10/2013, MIT License */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LauncherPool
{
    public partial class AddComputerForm : Form
    {
        SelectComputerForm SelectComputerForm;

        public AddComputerForm()
        {
            SelectComputerForm = new SelectComputerForm();
            InitializeComponent();
        }

        public AddComputerForm(SelectComputerForm parent)
        {
            SelectComputerForm = parent;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            myComputer.ComputerName = textBoxComputerName.Text;
            myComputer.IPAddress = textBoxIPAddress.Text;
            myComputer.MACAddress = textBoxMACAddress.Text;
            myComputer.SubPool = Convert.ToInt32(textBoxSubPool.Text);
            myComputer.Selected = checkBoxSelected.Checked;
            SelectComputerForm.myPool.AddComputer(myComputer);
            SelectComputerForm.RefreshList();
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            textBoxComputerName.Text = "";
            textBoxIPAddress.Text = "";
            textBoxMACAddress.Text = "";
            textBoxSubPool.Text = "";
            checkBoxSelected.Checked = false;
        }

    }
}
