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
    public partial class BrowserForm : Form
    {
        private string lastClick;
        private string lastEntry;

        public BrowserForm()
        {
            InitializeComponent();
            
            lastClick = DateTime.MinValue.ToString();
            lastEntry = DateTime.MinValue.ToString();
        }

        #region Properties

        public bool ScriptErrorsSuppressed
        {
            get { return ScriptErrorsSuppressed; }
            set { ScriptErrorsSuppressed = value; }
        }

        public bool ScrollBarsEnabled
        {
            get { return webBrowser.ScrollBarsEnabled; }
            set { webBrowser.ScrollBarsEnabled = value; }
        }

        public string Html
        {
            get { return webBrowser.DocumentText; }
            set { webBrowser.DocumentText = value; }
        }

        public string Url
        {
            get { return webBrowser.Url.ToString(); }
        }

        public string BrowserWindowState
        {

            get { return this.WindowState.ToString(); }
            set
            {
                switch (value.ToLower())
                {
                    case "normal":
                        this.WindowState = FormWindowState.Normal;
                        break;
                    case "minimized":
                        this.WindowState = FormWindowState.Minimized;
                        break;
                    case "maximized":
                        this.WindowState = FormWindowState.Maximized;
                        break;
                    default:
                        this.WindowState = FormWindowState.Maximized;
                        break;
                }
            }
        }

        public int BrowserWidth
        {
            get { return this.Width; }
            set { this.Width = value; }
        }

        public int SecondsToClose
        {
            get { return this.timerClose.Interval/1000; }
            set { this.timerClose.Interval = value*1000;
            timerClose.Enabled = true;
            }
        }

        public string LastClick
        {
            get { return lastClick; }
        }

        public string LastEntry
        {
            get { return lastEntry; }
        }

        #endregion

        #region Methods

        public void Navigate(string url)
        {
            webBrowser.Navigate(url);
        }

        public void GoBack()
        {
            webBrowser.GoBack();
        }

        public void GoForward()
        {
            webBrowser.GoForward();
        }

        public void GoHome()
        {
            webBrowser.GoHome();
        }

        public void PrintPage()
        {
            webBrowser.Print();
        }

        public void RefreshPage()
        {
            webBrowser.Refresh();
        }

        public void Stop()
        {
            webBrowser.Stop();
        }

        #endregion

        private void timerClose_Tick(object sender, EventArgs e)
        {
            timerClose.Enabled = false;
            this.Hide();
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            lastClick = DateTime.Now.ToString();
        }

        private void webBrowser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lastEntry = DateTime.Now.ToString();
        }
    }
}
