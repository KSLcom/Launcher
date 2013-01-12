using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Launcher
{
    public partial class WaitForm : Form
    {
        bool preventClose;
        string m_waitText;
        int m_fontSize;
        int m_Borders;

        public WaitForm()
        {
            preventClose = true;
            m_waitText = "";
            m_fontSize = 25;
            m_Borders = 33;
            InitializeComponent();
        }

        #region Properties

        public bool PreventClose
        {
            get { return preventClose; }
            set { preventClose = value; }
        }

        public string WaitText
        {
            get { return m_waitText; }
            set { m_waitText = value; }
        }

        public int FontSize
        {
            get { return m_fontSize; }
            set { m_fontSize = value; }
        }

        public int Borders
        {
            get { return m_Borders; }
            set { m_Borders = value; }
        }

        public string FormColor
        {
            get { return this.BackColor.Name; }
        }

        public string FontColor
        {
            get { return lblWaitText.ForeColor.Name; }
        }

        #endregion

        public void FormWindowMaximize()
        {
            this.WindowState = FormWindowState.Maximized;
        }
        
        public void FormWindowNormal()
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void WaitForm_Layout(object sender, LayoutEventArgs e)
        {
            lblWaitText.Text = m_waitText;
            lblWaitText.Font = new Font("", m_fontSize);

            TableLayoutColumnStyleCollection styles = tableLayoutPanel1.ColumnStyles;
            styles[0].Width = m_Borders;
            styles[1].Width = 100 - 2 * m_Borders;
            styles[2].Width = m_Borders;
        }

        private void WaitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (preventClose == true)
            {
                e.Cancel = true;
            }
        }
    }
}
