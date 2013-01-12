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
    public partial class SelectComputerForm : Form
    {
        public Pool myPool;

        public SelectComputerForm()
        {
            InitializeComponent();
            myPool = new Pool();
            myPool.LoadFile();
            RefreshList();
        }

        #region Selection Buttons

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            Program.PoolResult = "";
            string result = myPool.GetSelection(false);
            if(!string.IsNullOrEmpty(result)) Program.PoolResult = result;
            this.Close();
        }

        private void buttonToClipboard_Click(object sender, EventArgs e)
        {
            string result = myPool.GetSelection(false);
            if(!string.IsNullOrEmpty(result)) Clipboard.SetText(result, TextDataFormat.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            myPool.ClearSelection();
            RefreshList();
        }

        #endregion

        #region List Buttons

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                myPool.LoadFile(openFileDialog1.FileName);
                RefreshList();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form addComputer = new AddComputerForm(this);
            addComputer.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (Computer c in myPool.Computers)
            {
                if (c.Selected == true)
                {
                    myPool.RemoveComputer(c.ComputerName);
                }
            }
            RefreshList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            RefreshList();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 3;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myPool.SaveFile(saveFileDialog1.FileName);
            }
        }

        #endregion

        #region SubPool Buttons

        private void buttonClientGroup1_Click(object sender, EventArgs e)
        {
            myPool.GroupSelection(1);
            RefreshList();
        }

        private void buttonClientGroup2_Click(object sender, EventArgs e)
        {
            myPool.GroupSelection(2);
            RefreshList();
        }

        private void buttonClientGroup3_Click(object sender, EventArgs e)
        {
            myPool.GroupSelection(3);
            RefreshList();
        }

        private void buttonClientGroup4_Click(object sender, EventArgs e)
        {
            myPool.GroupSelection(4);
            RefreshList();
        }

        private void buttonClientGroup5_Click(object sender, EventArgs e)
        {
            myPool.GroupSelection(5);
            RefreshList();
        }

        private void buttonClientGroup6_Click(object sender, EventArgs e)
        {
            myPool.GroupSelection(6);
            RefreshList();
        }

        private void buttonClientGroup7_Click(object sender, EventArgs e)
        {
            myPool.GroupSelection(7);
            RefreshList();
        }

        private void buttonClientGroup8_Click(object sender, EventArgs e)
        {
            myPool.GroupSelection(8);
            RefreshList();
        }

        private void buttonClientGroup9_Click(object sender, EventArgs e)
        {
            myPool.GroupSelection(9);
            RefreshList();
        }

        private void buttonClientGroupAll_Click(object sender, EventArgs e)
        {
            myPool.GroupSelection(0);
            RefreshList();
        }

        #endregion

        #region List

        public void RefreshList()
        {
            checkedListBoxClients.Items.Clear();
            foreach (Computer c in myPool.Computers)
            {
                checkedListBoxClients.Items.Add(c.ComputerName + "\t[" + c.SubPool + "]", c.Selected);
            }
        }

        private void SelectComputerForm_Layout(object sender, LayoutEventArgs e)
        {
            RefreshList();
        }

        private void checkedListBoxClients_Click(object sender, EventArgs e)
        {
            try
            {
                string computerName = myPool.GetComputerName(checkedListBoxClients.SelectedItem.ToString());
                bool isSelected = !checkedListBoxClients.GetItemChecked(checkedListBoxClients.SelectedIndex);
                myPool.SelectComputer(computerName, isSelected);
                RefreshList();
            }
            catch
            {
                //Swallow this
            }
        }

        private void checkedListBoxClients_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string computerName = myPool.GetComputerName(checkedListBoxClients.SelectedItem.ToString());
                bool isSelected = checkedListBoxClients.GetItemChecked(checkedListBoxClients.SelectedIndex);
                int index = checkedListBoxClients.SelectedIndex;
                myPool.SelectComputer(computerName, isSelected);
                RefreshList();
                checkedListBoxClients.SelectedIndex = index;
            }
            catch
            {
                //Swallow this
            }
        }

        #endregion

    }
}
