using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.IO;
using System.Net;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;

namespace Launcher
{
    public partial class LauncherForm : Form, IMessageFilter
    {
        Runspace rs;
        PowerShell ps;

        //Forms
        BrowserForm myBrowserForm;
        WaitForm myWaitForm;
        AuthenticationForm myAuthForm;
        WinApi myWinApi;

        private readonly KeyboardHookListener m_KeyboardHookManager;
        private readonly MouseHookListener m_MouseHookManager;

        private static bool preventClose;
        private static int clientCount;

        private static bool isRunspaceActive;
        private static bool isTunnelActive;
        private static bool isPoolActive;
        private static bool isLauncherVisible;
        private static bool isWaitFromVisible;
        private static bool isAuthFormVisible;
        private static bool isBrowserFormVisible;

        private static bool isLauncherEnabled;
        private static bool isKioskEnabled;
        private static bool isScreenEnabled;
        private static bool isKeyboardEnabled;
        private static bool isMouseEnabled;
        private static bool isSpeakerEnabled;
        private static bool isWebcamEnabled;
        private static bool isHeadsetEnabled;
        private static bool isUsbEnabled;

        private static string screenShotPath;
        private static string screenShotGroup;

        string[,] customCommands;
        
        public LauncherForm()
        {
            InitializeComponent();

            myWinApi = new WinApi();
            myAuthForm = new AuthenticationForm(this);
            myWaitForm = new WaitForm();
            myBrowserForm = new BrowserForm();

            //Keyboard & Mouse
            m_KeyboardHookManager = new KeyboardHookListener(new GlobalHooker());
            m_KeyboardHookManager.Enabled = false;
            m_MouseHookManager = new MouseHookListener(new GlobalHooker());
            m_MouseHookManager.Enabled = false;

            isRunspaceActive = false;
            isTunnelActive  = false;
            isPoolActive = false;

            isLauncherVisible = true;
            isBrowserFormVisible = false;
            isWaitFromVisible = false;
            isAuthFormVisible = false;

            isLauncherEnabled = true;
            isKioskEnabled = false;
            isScreenEnabled = true;
            isKeyboardEnabled = true;
            isMouseEnabled = true;
            isSpeakerEnabled = true;
            isWebcamEnabled = false;
            isHeadsetEnabled = false;
            isUsbEnabled = false;

            preventClose = true;
            clientCount = 0;

            timerStart.Interval = 100;
            timerShutdown.Interval = 100;
            
            customCommands = new string[12, 2];

            comboBoxAuthType.SelectedIndex = 0;
        }

        #region Public Properties

        public bool IsRunspaceActive
        {
            get { return isRunspaceActive; }
        }

        public bool IsTunnelActive
        {
            get { return isTunnelActive; }
        }

        public bool IsPoolActive
        {
            get { return isPoolActive; }
        }

        public bool IsLauncherVisible
        {
            get { return isLauncherVisible; }
            set { isLauncherVisible = value; }
        }

        public bool IsBrowserFormVisible
        {
            get { return isBrowserFormVisible; }
        }

        public bool IsWaitFormVisible
        {
            get { return isWaitFromVisible; }
        }

        public bool IsAuthFormVisible
        {
            get { return isAuthFormVisible; }
            set { isAuthFormVisible = value; }
        }

        public bool IsLauncherEnabled
        {
            get { return isLauncherEnabled; }
        }

        public bool IsKioskEnabled
        {
            get { return isKioskEnabled; }
        }

        public bool IsScreenEnabled
        {
            get { return isScreenEnabled; }
        }

        public bool IsKeyboardEnabled
        {
            get { return isKeyboardEnabled; }
        }

        public bool IsMouseEnabled
        {
            get { return isMouseEnabled; }
        }

        public bool IsSpeakersEnabled
        {
            get { return isSpeakerEnabled; }
        }

        public bool IsWebcamEnabled
        {
            get { return isWebcamEnabled; }
        }

        public bool IsHeadsetEnabled
        {
            get { return isHeadsetEnabled; }
        }

        public bool IsUsbEnabled
        {
            get { return isUsbEnabled; }
        }

        public string Log
        {
            get { return textBoxLog.Text; }
        }

        public string ScreenShotPath
        {
            get { return screenShotPath; }
            set { screenShotPath = value; }
        }

        public string ScreenShotGroup
        {
            get { return screenShotGroup; }
            set { screenShotGroup = value; }
        }

        #endregion

        #region LauncherForm Objects

        private string About()
        {
            string message = "Launcher " + Application.ProductVersion.ToString() + " - An embedded PowerShell Console" + System.Environment.NewLine + System.Environment.NewLine;
            message += "- Based on System.Management.Automation." + System.Environment.NewLine;
            message += "- Included Matthew Hobbs' PowerShell Tunnel." + System.Environment.NewLine;
            message += "- Includeded George Mamaladze's GlobalHook." + System.Environment.NewLine + System.Environment.NewLine;
            message += "Copyright © 2010-2011 Stefan Wehrli, ETH Zürich";
            return message;
        }

        private string AboutShort()
        {
            string message = "Launcher " + Application.ProductVersion.ToString() + " - An embedded PowerShell Console" + System.Environment.NewLine;
            message += "Copyright © 2010-2011 Stefan Wehrli, ETH Zürich";
            return message;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Init
            OpenRunspace();
            OpenTunnel();
            LoadClientFile(Application.StartupPath + @"\Clients.txt");
            GetCustomCommandSettings();

            //Setup Notify
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Text = "Launcher";
            notifyIcon1.Visible = true;

            //Setup Output
            textBoxLog.Text = AboutShort();
            textBoxLog.Text = textBoxLog.Text + System.Environment.NewLine + System.Environment.NewLine;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (preventClose == true)
            {
                e.Cancel = true;
            }
            else
            {
                if (isTunnelActive) CloseTunnel();
                rs.Close();
                rs.Dispose();
            }

            Properties.Settings.Default.Save();
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            timerStart.Enabled = false;
            this.Hide();
            this.Opacity = 100;
            this.ShowInTaskbar = true;
            OpenTunnel();

            if (isLauncherVisible)
            {
                ShowGui(); 
            }
            else
            {
                HideGui();
            }
            
        }

        private void timerRestart_Tick(object sender, EventArgs e)
        {
            if (isTunnelActive) CloseTunnel();
            if (isRunspaceActive) CloseRunspace();
            Application.Restart();
        }

        private void timerShutdown_Tick(object sender, EventArgs e)
        {
            if (isTunnelActive) CloseTunnel();
            if (isRunspaceActive) CloseRunspace();
            Application.Exit();
        }

        private void timerScreenEnable_Tick(object sender, EventArgs e)
        {
            timerScreenEnable.Enabled = false;
            myWinApi.ScreenState(-1);
            isScreenEnabled = true;
            AddLogEntry("Enable-Screen");
        }

        private void timerScreenDisable_Tick(object sender, EventArgs e)
        {
            timerScreenDisable.Enabled = false;
            myWinApi.ScreenState(2);
            isScreenEnabled = false;
            AddLogEntry("Disable-Screen");
        }

        private void timerScreenShot_Tick(object sender, EventArgs e)
        {
            timerScreenShot.Enabled = false;
            myWinApi.ScreenShot(screenShotPath, screenShotGroup);
            AddLogEntry("ScreenShot");
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowGui();
        }

        private void textBoxCmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                InvokeCmd();
            }
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlDetails.SelectedIndex == 0)
            {
                textBoxLog.Select(textBoxLog.Text.Length - 1, 0);
                textBoxLog.ScrollToCaret();
            }
        }

        private void buttonAuthTokenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*|Log Files (*.log)|*.log";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, System.Text.Encoding.Default);

                textBoxAuthTokens.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        #region Form Menu

        //Main Menu
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save
            //MENU FILE > Save
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*|Log Files (*.log)|*.log";
            saveFileDialog1.FilterIndex = 3;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.Default);
                sw.Write(textBoxLog.Text);
                sw.Close();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGui();
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableGui();
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableGui();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideGui();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTunnel();
        }

        private void closeTunnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseTunnel();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(About(), "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutLauncherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGui();
            string cmd = "help about_Launcher";
            InvokeCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void aboutPoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGui();
            string cmd = "help about_Pool";
            InvokeCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void aboutTunnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGui();
            string cmd = "help about_Tunnel";
            InvokeCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        //Context Menu
        private void showConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGui();
        }

        private void openTunnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTunnel();
        }

        private void closeTunnelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseTunnel();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        #endregion

        #endregion

        #region Runspace

        /// <summary>
        /// Opens a embedded PowerShell runspace.
        /// </summary>
        private void OpenRunspace()
        {
            if (!isRunspaceActive)
            {
                rs = RunspaceFactory.CreateRunspace();
                rs.ThreadOptions = PSThreadOptions.UseCurrentThread;
                ps = PowerShell.Create();
                ps.Runspace = rs;

                rs.Open();

                // Loads form objects into runspace
                LoadFormObjects();

                try
                {
                    foreach (string cmd in textBoxRunspaceStartup.Lines)
                    {
                        ps.AddScript(cmd);
                    }

                    ps.Invoke();
                    isRunspaceActive = true;
                }
                catch (Exception ex)
                {
                    textBoxLog.Text += ex.ToString() + System.Environment.NewLine;
                }
                ps.Commands.Clear();

                
            }
        }

        /// <summary>
        /// Close the embedded PowerShell runspace.
        /// </summary>
        private void CloseRunspace()
        {
            if (isRunspaceActive)
            {
                try
                {
                    ps.AddScript("Remove-Pool");
                    ps.Invoke();
                    ps.Commands.Clear();
                }
                catch (Exception ex)
                {
                    textBoxLog.Text += ex.ToString() + System.Environment.NewLine;
                }
                ps.Commands.Clear();
                ps.Dispose();
                rs.Close();
                rs.Dispose();
                isRunspaceActive = false;
            }
        }

        /// <summary>
        /// Opens a PowerShell Tunnel Host in the embedded runspace.
        /// </summary>
        private void OpenTunnel()
        {
            try
            {
                ps.AddScript("$tunnelhost = add-tunnelhost " + textBoxEndpoint.Text);
                ps.Invoke();
            }
            catch (Exception ex)
            {
                textBoxLog.Text += ex.ToString() + System.Environment.NewLine;
            }

            ps.Commands.Clear();
            isTunnelActive = true;
            
            oToolStripMenuItem.Enabled = false;
            closeTunnelToolStripMenuItem.Enabled = true;
            openTunnelToolStripMenuItem.Enabled = false;
            closeTunnelToolStripMenuItem1.Enabled = true;
            toolStripStatusLabel.Text = "TunnelHost open";
        }

        /// <summary>
        /// Close the PowerShell Tunnel Host in the embedded runspace.
        /// </summary>
        private void CloseTunnel()
        {
            try
            {
                ps.AddScript("Remove-TunnelHost $tunnelhost");
                ps.Invoke();
                ps.Commands.Clear();
            }
            catch (Exception ex)
            {
                textBoxLog.Text += ex.ToString() + System.Environment.NewLine;
            }
            ps.Commands.Clear();
            isTunnelActive = false;
            oToolStripMenuItem.Enabled = true;
            closeTunnelToolStripMenuItem.Enabled = false;
            openTunnelToolStripMenuItem.Enabled = true;
            closeTunnelToolStripMenuItem1.Enabled = false;
            toolStripStatusLabel.Text = "TunnelHost closed";
        }

        /// <summary>
        /// Load form objects into runspace
        /// </summary>
        private void LoadFormObjects()
        {
            // Launcher GUI
            rs.SessionStateProxy.SetVariable("launcher", this);
            rs.SessionStateProxy.SetVariable("launcher_notify", notifyIcon1);

            // Objects
            rs.SessionStateProxy.SetVariable("browser", myBrowserForm);
            rs.SessionStateProxy.SetVariable("waitform", myWaitForm);
            rs.SessionStateProxy.SetVariable("authform", myAuthForm);
            
            // Host Info
            string hostName = Dns.GetHostName();
            IPHostEntry hostInfo = Dns.GetHostEntry(hostName);
            rs.SessionStateProxy.SetVariable("version", Application.ProductVersion);
            rs.SessionStateProxy.SetVariable("hostname", hostName.ToLower());
            rs.SessionStateProxy.SetVariable("ip", hostInfo.AddressList[0].ToString());
        }

        /// <summary>
        /// Invoke a command and send it the runspace.
        /// </summary>
        private void InvokeCmd()
        {
            if (isPoolActive)
            {
                InvokeRemoteCmd(textBoxCmd.Text);
            }
            else
            {
                InvokeCmd(textBoxCmd.Text);
            }

            textBoxLog.Select(textBoxLog.Text.Length - 1, 0);
            textBoxLog.ScrollToCaret();
            textBoxCmd.Text = "";
            textBoxCmd.Focus();
        }

        /// <summary>
        /// Invoke a command in the embedded runspace.
        /// </summary>
        private void InvokeCmd(string cmd)
        {
            Collection<PSObject> PsResult;
            ps.AddScript(cmd);
            textBoxLog.Text += DateTime.Now.ToString() + "   " + "PS> " + cmd + System.Environment.NewLine;
            try
            {
                PsResult = ps.Invoke();
                foreach (PSObject p in PsResult)
                {
                    textBoxLog.Text += p.ToString() + System.Environment.NewLine;
                }
                textBoxLog.Text += System.Environment.NewLine;
            }
            catch (Exception ex)
            {
                textBoxLog.Text += ex.ToString() + System.Environment.NewLine;
            }
            ps.Commands.Clear();
        }

        /// <summary>
        /// Invoke a remote command in the embedded runspace.
        /// </summary>
        private void InvokeRemoteCmd(string cmd)
        {
            string remoteCmd = "Invoke-Pool { " + cmd + " }";
            if (isPoolActive)
            {
                InvokeCmd(remoteCmd);
            }
        }

        /// <summary>
        /// Add entry to log
        /// </summary>
        public void AddLogEntry(string result)
        {
            textBoxLog.AppendText(DateTime.Now.ToString() + "   " + result + System.Environment.NewLine);
            textBoxLog.Select(textBoxLog.Text.Length - 1, 0);
            textBoxLog.ScrollToCaret();
        }

        #endregion

        #region Console Gui

        /// <summary>
        /// Updates the Gui, shows/hides forms
        /// </summary>
        public void UpdateGui()
        {
            if (isLauncherEnabled)
            {
                EnableGui();
            }
            else
            {
                DisableGui();
            }

            if (isLauncherVisible)
            {
                HideGui(); 
            }
            else
            {
                ShowGui();
            }

            AddLogEntry("Gui updated");
            this.Update();
        }

        /// <summary>
        /// Show the console main window
        /// </summary>
        public void ShowGui()
        {
            this.Show();
            isLauncherVisible = true;
            AddLogEntry("Show-Launcher");
        }

        /// <summary>
        /// Hide the console main window
        /// </summary>
        public void HideGui()
        {
            this.Hide();
            isLauncherVisible = false;
            AddLogEntry("Hide-Launcher");
        }

        /// <summary>
        /// Restricts access to the console window
        /// </summary>
        public void DisableGui()
        {
            groupBoxConsole.Enabled = false;
            groupBoxDetails.Enabled = false;

            saveToolStripMenuItem.Enabled = false;
            minimizeToolStripMenuItem.Enabled = true;
            disableToolStripMenuItem.Enabled = false;
            //enableToolStripMenuItem.Enabled = true;
            clearToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = false;
            tunnelToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Enabled = false;

            tunnelToolStripContextMenuItem.Enabled = false;
            exitToolStripContextMenuItem.Enabled = false;

            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            isLauncherEnabled = false;

            AddLogEntry("Disable-Launcher");
        }

        /// <summary>
        /// Enables access to the console window
        /// </summary>
        public void EnableGui()
        {
            groupBoxConsole.Enabled = true;
            groupBoxDetails.Enabled = true;

            saveToolStripMenuItem.Enabled = true;
            minimizeToolStripMenuItem.Enabled = true;
            disableToolStripMenuItem.Enabled = true;
            enableToolStripMenuItem.Enabled = false;
            clearToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
            tunnelToolStripMenuItem.Enabled = true;
            helpToolStripMenuItem.Enabled = true;

            tunnelToolStripContextMenuItem.Enabled = true;
            exitToolStripContextMenuItem.Enabled = true;

            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripTray;

            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = true;

            isLauncherEnabled = true;

            AddLogEntry("Enable-Launcher");
        }

        /// <summary>
        /// Clear log
        /// </summary>
        public void ClearGui()
        {
            textBoxLog.Text = "";
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        public void Restart()
        {
            preventClose = false;
            timerRestart.Enabled = true;
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        public void Shutdown()
        {
            preventClose = false;
            timerShutdown.Enabled = true;
        }
        
        #endregion

        #region Forms

        public void ShowBrowser(string url)
        {
            if (isBrowserFormVisible) HideBrowser();

            myBrowserForm.Navigate(url);
            myBrowserForm.Show();
            isBrowserFormVisible = true;
            AddLogEntry("Show-Browser " + url); 
        }

        public void SendBrowser(string url, int seconds)
        {
            myBrowserForm.Navigate(url);
            myBrowserForm.Show();
            isBrowserFormVisible = true;
            AddLogEntry("Send-Browser " + url); 
            System.Threading.Thread.Sleep(1000 * seconds);
            HideBrowser();
        }

        public void HideBrowser()
        {
            myBrowserForm.Hide();
            isBrowserFormVisible = false;
            AddLogEntry("Hide-Browser"); 
        }

        public void ShowWaitForm(string text)
        {
            if (isWaitFromVisible) HideWaitForm();

            HideGui();
            myWaitForm.PreventClose = true;
            myWaitForm.WaitText = text;
            myWaitForm.Update();
            myWaitForm.Show();
            isWaitFromVisible = true;
            AddLogEntry("Show-WaitForm " + text);
        }

        public void SendWaitForm(string text, int seconds)
        {
            ShowWaitForm(text);
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000 * seconds);
            HideWaitForm();
        }

        public void HideWaitForm()
        {
            myWaitForm.PreventClose = false;
            myWaitForm.Hide();
            isWaitFromVisible = false;
            AddLogEntry("Hide-WaitForm"); 
        }

        public void ShowAuthForm()
        {
            if (isAuthFormVisible) HideAuthForm();
            HideGui();
            myAuthForm.Show();
            isAuthFormVisible = true;
            AddLogEntry("Show-AuthForm"); 
        }

        public void HideAuthForm()
        {
            myAuthForm.Hide();
            isAuthFormVisible = false;
            AddLogEntry("Hide-AuthForm"); 
        }

        public void PostAuthentication(string cmd)
        {
            InvokeCmd(cmd);
            AddLogEntry("Post-Auth: " + cmd); 
        }

        #endregion

        #region Clients

        /// <summary>
        /// Loads list of clients 
        /// </summary>
        private void LoadClientFile(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path, Encoding.Default))
                    {
                        checkedListBoxClients.Items.Clear();
                        string line = "";
                        string item = "";
                        bool check = false;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!line.StartsWith("#"))
                            {
                                check = false;
                                if (line.IndexOf(";") >= 0)
                                {
                                    string[] fields = line.Split(';');
                                    if (fields.Length == 5)
                                    {
                                        if (fields[4] == "1")
                                        {
                                            check = true;
                                        }
                                        item = fields[0] + "  #" + fields[3];
                                    }
                                }
                                else
                                {
                                    item = line;
                                }

                                //Add
                                if (check)
                                {
                                    checkedListBoxClients.Items.Add(item, CheckState.Checked);
                                }
                                else
                                {
                                    checkedListBoxClients.Items.Add(item, CheckState.Unchecked);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SelectClientGroup(string group)
        {
            for (int i = 0; i < checkedListBoxClients.Items.Count; i++)
            {
                if (checkedListBoxClients.Items[i].ToString().IndexOf(" " + group) >= 0)
                {
                    checkedListBoxClients.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        private void buttonPool_Click(object sender, EventArgs e)
        {
            string cmd = "";
            string[] clientArray;

            if (!isPoolActive)
            {
                if (textBoxClients.Text.Length > 0)
                {
                    clientArray = textBoxClients.Text.Split(',');
                    clientCount = clientArray.Length;

                    buttonPool.Text = "Remove-Pool";
                    textBoxClients.Enabled = false;
                    cmd = "Register-Pool " + textBoxClients.Text;
                    InvokeCmd(cmd);
                    tabControlDetails.SelectTab(tabPageLog);
                    textBoxCmd.Focus();
                    isPoolActive = true;
                }
                else
                {
                    tabControlDetails.SelectTab(tabPageClients);
                    textBoxClients.Focus();
                }
            }
            else
            {
                buttonPool.Text = "Register-Pool";
                textBoxClients.Enabled = true;
                cmd = "Remove-Pool";
                InvokeCmd(cmd);
                AddLogEntry("Disconnected pool");
                textBoxClients.Text = "";
                textBoxClients.Focus();
                isPoolActive = false;
            }
        }

        private void buttonInvoke_Click(object sender, EventArgs e)
        {
            InvokeCmd();
        }

        private void buttonClientsSet_Click(object sender, EventArgs e)
        {
            string clients = "";
            string temp = "";
            int pos = 0;
            foreach (object itemChecked in checkedListBoxClients.CheckedItems)
            {
                pos = 0;
                if (itemChecked.ToString().IndexOf(" #") >= 0)
                {
                    pos = itemChecked.ToString().IndexOf(" #");
                    temp = itemChecked.ToString().Substring(0, pos - 1);
                }
                else
                {
                    temp = itemChecked.ToString();
                }
                clients += temp + ", ";
            }
            if (clients.Length > 0)
            {
                clients = clients.Substring(0, clients.Length - 2);
                textBoxClients.Text = clients;
            }
            //textBoxClients.Focus();
            textBoxCmd.Focus();
            buttonPool_Click(null, null);
        }

        private void buttonClientsClear_Click(object sender, EventArgs e)
        {
            foreach (int i in checkedListBoxClients.CheckedIndices)
            {
                checkedListBoxClients.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void buttonClientsToClipboard_Click(object sender, EventArgs e)
        {

        }

        private void buttonClientsFile_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                LoadClientFile(openFileDialog1.FileName);
            }
        }

        private void buttonClientGroup1_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#1");
        }

        private void buttonClientGroup2_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#2");
        }

        private void buttonClientGroup3_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#3");
        }

        private void buttonClientGroup4_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#4");
        }

        private void buttonClientGroup5_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#5");
        }

        private void buttonClientGroup6_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#6");
        }

        private void buttonClientGroup7_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#7");
        }

        private void buttonClientGroup8_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#8");
        }

        private void buttonClientGroup9_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#9");
        }

        private void buttonClientGroup10_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#1");
            SelectClientGroup("#2");
            SelectClientGroup("#3");
            SelectClientGroup("#4");
            SelectClientGroup("#5");
            SelectClientGroup("#6");
            SelectClientGroup("#7");
            SelectClientGroup("#8");
            SelectClientGroup("#9");
        }

        private void buttonClientGroup11_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#11");
        }

        private void buttonClientGroup12_Click(object sender, EventArgs e)
        {
            SelectClientGroup("#12");
        }

        #endregion

        #region Commands

        #region Remote Commands

        private void buttonCmdsStartComputer_Click(object sender, EventArgs e)
        {
            string cmd = "Start-Pool " + textBoxClients.Text;
            InvokeCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsRestartComputer_Click(object sender, EventArgs e)
        {
            string cmd = "Restart-Computer " + textBoxClients.Text + " -f";
            InvokeCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsStopComputer_Click(object sender, EventArgs e)
        {
            string cmd = "Stop-Computer " + textBoxClients.Text + " -f";
            InvokeCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsTestService_Click(object sender, EventArgs e)
        {
            string cmd = "Test-LauncherService " + textBoxClients.Text;
            InvokeCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsGetPoolData_Click(object sender, EventArgs e)
        {
            string cmd = "Get-PoolData | Out-String";
            InvokeCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsScreenShot_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(1000);
            string cmd = "Get-ScreenShot " + num.ToString();
            InvokeRemoteCmd(cmd);
            System.Threading.Thread.Sleep(100 * clientCount);
            cmd = "Show-ScreenShot " + num.ToString();
            InvokeCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsClearScreenShot_Click(object sender, EventArgs e)
        {
            string cmd = "Clear-ScreenShotFiles";
            InvokeCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsShowWaitForm_Click(object sender, EventArgs e)
        {
            string cmd = "Show-WaitForm " + "\"" + textBoxWaitText.Text + "\"";
            InvokeRemoteCmd(cmd);
        }

        private void buttonCmdsHideWaitForm_Click(object sender, EventArgs e)
        {
            string cmd = "Hide-WaitForm";
            InvokeRemoteCmd(cmd);
        }

        private void buttonCmdsSendWaitForm_Click(object sender, EventArgs e)
        {
            string cmd = "Send-WaitForm " + "\"" + textBoxWaitText.Text + "\" " + textBoxWaitDisplayTime.Text;
            InvokeRemoteCmd(cmd);
        }

        private void buttonCmdsShowBrowser_Click(object sender, EventArgs e)
        {
            string cmd = "Show-Browser " + @"" + textBoxUrl.Text + @"";
            InvokeRemoteCmd(cmd);
        }

        private void buttonCmdsHideBrowser_Click(object sender, EventArgs e)
        {
            string cmd = "Hide-Browser"; ;
            InvokeRemoteCmd(cmd);
        }

        private void buttonCmdsSendBrowser_Click(object sender, EventArgs e)
        {
            string cmd = "Send-Browser " + @"" + textBoxUrl.Text + @"" + " " + textBoxBrowserDisplayTime.Text;
            InvokeRemoteCmd(cmd);

        }

        private void buttonCmdsSendNotify_Click(object sender, EventArgs e)
        {
            string cmd = "Send-Notify " + "\"" + textBoxNotifyText.Text + "\"";
            InvokeRemoteCmd(cmd);
        }

        #endregion

        #region Custom Commands

        private void SetCustomCommands(int index, string cmd, string cmdLabel)
        {
            customCommands[index, 0] = cmdLabel;
            customCommands[index, 1] = cmd;

            buttonCmdsCustom1.Text = GetCustomCommandLabel(1);
            buttonCmdsCustom1.Enabled = GetCustomCommandEnabled(1);

            buttonCmdsCustom2.Text = GetCustomCommandLabel(2);
            buttonCmdsCustom2.Enabled = GetCustomCommandEnabled(2);

            buttonCmdsCustom3.Text = GetCustomCommandLabel(3);
            buttonCmdsCustom3.Enabled = GetCustomCommandEnabled(3);

            buttonCmdsCustom4.Text = GetCustomCommandLabel(4);
            buttonCmdsCustom4.Enabled = GetCustomCommandEnabled(4);

            buttonCmdsCustom5.Text = GetCustomCommandLabel(5);
            buttonCmdsCustom5.Enabled = GetCustomCommandEnabled(5);

            buttonCmdsCustom6.Text = GetCustomCommandLabel(6);
            buttonCmdsCustom6.Enabled = GetCustomCommandEnabled(6);

            buttonCmdsCustom7.Text = GetCustomCommandLabel(7);
            buttonCmdsCustom7.Enabled = GetCustomCommandEnabled(7);

            buttonCmdsCustom8.Text = GetCustomCommandLabel(8);
            buttonCmdsCustom8.Enabled = GetCustomCommandEnabled(8);

            buttonCmdsCustom9.Text = GetCustomCommandLabel(9);
            buttonCmdsCustom9.Enabled = GetCustomCommandEnabled(9);

            buttonCmdsCustom10.Text = GetCustomCommandLabel(10);
            buttonCmdsCustom10.Enabled = GetCustomCommandEnabled(10);

            SetCustomCommandSettings();
        }

        private string GetCustomCommandLabel(int cmd)
        {
            return customCommands[cmd, 0];
        }

        private string GetCustomCommand(int cmd)
        {
            return customCommands[cmd, 1];
        }

        private bool GetCustomCommandEnabled(int cmd)
        {
            if (GetCustomCommand(cmd).Length > 0)
            {
                return true;
            }
            return false;
        }

        private void buttonCmdsCustomSet_Click(object sender, EventArgs e)
        {
            int cmdIndex = comboBoxCmdsCustom.SelectedIndex + 1;
            SetCustomCommands(cmdIndex, textBoxCmdsCustomCmd.Text, textBoxCmdsCustomLabel.Text);

            textBoxCmdsCustomCmd.Enabled = false;
            textBoxCmdsCustomLabel.Enabled = false;
            buttonCmdsCustomSet.Enabled = false;

            labelCustomCmdCmd.Enabled = false;
            labelCustomCmdLabel.Enabled = false;

            checkBoxCmdsCustomRemote.Enabled = false;
        }

        private void comboBoxCmdsCustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cmdIndex = comboBoxCmdsCustom.SelectedIndex + 1;
            textBoxCmdsCustomLabel.Text = customCommands[cmdIndex, 0];
            textBoxCmdsCustomCmd.Text = customCommands[cmdIndex, 1];

            textBoxCmdsCustomCmd.Enabled = true;
            textBoxCmdsCustomLabel.Enabled = true;
            buttonCmdsCustomSet.Enabled = true;

            labelCustomCmdCmd.Enabled = true;
            labelCustomCmdLabel.Enabled = true;

            checkBoxCmdsCustomRemote.Enabled = true;
        }

        private void GetCustomCommandSettings()
        {
            customCommands[1, 0] = textBoxCmdsCustomLabel1.Text;
            customCommands[1, 1] = textBoxCmdsCustom1.Text;
            customCommands[2, 0] = textBoxCmdsCustomLabel2.Text;
            customCommands[2, 1] = textBoxCmdsCustom2.Text;
            customCommands[3, 0] = textBoxCmdsCustomLabel3.Text;
            customCommands[3, 1] = textBoxCmdsCustom3.Text;
            customCommands[4, 0] = textBoxCmdsCustomLabel4.Text;
            customCommands[4, 1] = textBoxCmdsCustom4.Text;
            customCommands[5, 0] = textBoxCmdsCustomLabel5.Text;
            customCommands[5, 1] = textBoxCmdsCustom5.Text;
            customCommands[6, 0] = textBoxCmdsCustomLabel6.Text;
            customCommands[6, 1] = textBoxCmdsCustom6.Text;
            customCommands[7, 0] = textBoxCmdsCustomLabel7.Text;
            customCommands[7, 1] = textBoxCmdsCustom7.Text;
            customCommands[8, 0] = textBoxCmdsCustomLabel8.Text;
            customCommands[8, 1] = textBoxCmdsCustom8.Text;
            customCommands[9, 0] = textBoxCmdsCustomLabel9.Text;
            customCommands[9, 1] = textBoxCmdsCustom9.Text;
            customCommands[10, 0] = textBoxCmdsCustomLabel10.Text;
            customCommands[10, 1] = textBoxCmdsCustom10.Text;

            SetCustomCommands(0, "", "");
        }

        private void SetCustomCommandSettings()
        {
            textBoxCmdsCustomLabel1.Text = customCommands[1, 0];
            textBoxCmdsCustom1.Text = customCommands[1, 1];
            textBoxCmdsCustomLabel2.Text = customCommands[2, 0];
            textBoxCmdsCustom2.Text = customCommands[2, 1];
            textBoxCmdsCustomLabel3.Text = customCommands[3, 0];
            textBoxCmdsCustom3.Text = customCommands[3, 1];
            textBoxCmdsCustomLabel4.Text = customCommands[4, 0];
            textBoxCmdsCustom4.Text = customCommands[4, 1];
            textBoxCmdsCustomLabel5.Text = customCommands[5, 0];
            textBoxCmdsCustom5.Text = customCommands[5, 1];
            textBoxCmdsCustomLabel6.Text = customCommands[6, 0];
            textBoxCmdsCustom6.Text = customCommands[6, 1];
            textBoxCmdsCustomLabel7.Text = customCommands[7, 0];
            textBoxCmdsCustom7.Text = customCommands[7, 1];
            textBoxCmdsCustomLabel8.Text = customCommands[8, 0];
            textBoxCmdsCustom8.Text = customCommands[8, 1];
            textBoxCmdsCustomLabel9.Text = customCommands[9, 0];
            textBoxCmdsCustom9.Text = customCommands[9, 1];
            textBoxCmdsCustomLabel10.Text = customCommands[10, 0];
            textBoxCmdsCustom10.Text = customCommands[10, 1];
        }

        private void buttonCmdsCustom1_Click(object sender, EventArgs e)
        {
            string cmd = GetCustomCommand(1);
            if (isPoolActive)
            {
                InvokeRemoteCmd(cmd);
            }
            else
            {
                InvokeCmd(cmd);
            }
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsCustom2_Click(object sender, EventArgs e)
        {
            string cmd = GetCustomCommand(2);
            if (isPoolActive)
            {
                InvokeRemoteCmd(cmd);
            }
            else
            {
                InvokeCmd(cmd);
            }
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsCustom3_Click(object sender, EventArgs e)
        {
            string cmd = GetCustomCommand(3);
            if (isPoolActive)
            {
                InvokeRemoteCmd(cmd);
            }
            else
            {
                InvokeCmd(cmd);
            }
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsCustom4_Click(object sender, EventArgs e)
        {
            string cmd = GetCustomCommand(4);
            if (isPoolActive)
            {
                InvokeRemoteCmd(cmd);
            }
            else
            {
                InvokeCmd(cmd);
            }
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsCustom5_Click(object sender, EventArgs e)
        {
            string cmd = GetCustomCommand(5);
            if (isPoolActive)
            {
                InvokeRemoteCmd(cmd);
            }
            else
            {
                InvokeCmd(cmd);
            }
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsCustom6_Click(object sender, EventArgs e)
        {
            string cmd = GetCustomCommand(6);
            if (isPoolActive)
            {
                InvokeRemoteCmd(cmd);
            }
            else
            {
                InvokeCmd(cmd);
            }
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsCustom7_Click(object sender, EventArgs e)
        {
            string cmd = GetCustomCommand(7);
            if (isPoolActive)
            {
                InvokeRemoteCmd(cmd);
            }
            else
            {
                InvokeCmd(cmd);
            }
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsCustom8_Click(object sender, EventArgs e)
        {
            string cmd = GetCustomCommand(8);
            if (isPoolActive)
            {
                InvokeRemoteCmd(cmd);
            }
            else
            {
                InvokeCmd(cmd);
            }
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsCustom9_Click(object sender, EventArgs e)
        {
            string cmd = GetCustomCommand(9);
            if (isPoolActive)
            {
                InvokeRemoteCmd(cmd);
            }
            else
            {
                InvokeCmd(cmd);
            }
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsCustom10_Click(object sender, EventArgs e)
        {
            string cmd = GetCustomCommand(10);
            if (isPoolActive)
            {
                InvokeRemoteCmd(cmd);
            }
            else
            {
                InvokeCmd(cmd);
            }
            tabControlDetails.SelectTab(tabPageLog);
        }

        #endregion

        #region Filters

        private void buttonEnableLauncher_Click(object sender, EventArgs e)
        {
            string cmd = "Enable-Launcher";
            InvokeRemoteCmd(cmd);
        }

        private void buttonDisableLauncher_Click(object sender, EventArgs e)
        {
            string cmd = "Disable-Launcher";
            InvokeRemoteCmd(cmd);
        }

        private void buttonEnableKiosk_Click(object sender, EventArgs e)
        {
            string cmd = "Enable-KioskFilter";
            InvokeRemoteCmd(cmd);
        }

        private void buttonDisableKiosk_Click(object sender, EventArgs e)
        {
            string cmd = "Disable-KioskFilter";
            InvokeRemoteCmd(cmd);
        }

        private void buttonEnableScreen_Click(object sender, EventArgs e)
        {
            string cmd = "Hide-WaitForm";
            InvokeRemoteCmd(cmd);
        }

        private void buttonDisableScreen_Click(object sender, EventArgs e)
        {
            string cmd = "Show-WaitForm " + "\" \"";
            InvokeRemoteCmd(cmd);
        }

        private void buttonKeyboard_Click(object sender, EventArgs e)
        {
            string cmd = "Enable-Keyboard";
            InvokeRemoteCmd(cmd);
        }

        private void buttonDisableKeyboard_Click(object sender, EventArgs e)
        {
            string cmd = "Disable-Keyboard";
            InvokeRemoteCmd(cmd);
        }

        private void buttonEnableMouse_Click(object sender, EventArgs e)
        {
            string cmd = "Enable-Mouse";
            InvokeRemoteCmd(cmd);
        }

        private void buttonDisableMouse_Click(object sender, EventArgs e)
        {
            string cmd = "Disable-Mouse";
            InvokeRemoteCmd(cmd);
        }

        private void buttonEnableWebcam_Click(object sender, EventArgs e)
        {
            string cmd = "Enable-Webcam";
            InvokeRemoteCmd(cmd);
        }

        private void buttonDisableWebcam_Click(object sender, EventArgs e)
        {
            string cmd = "Disable-Webcam";
            InvokeRemoteCmd(cmd);
        }

        private void buttonEnableHeadset_Click(object sender, EventArgs e)
        {
            string cmd = "Enable-Headset";
            InvokeRemoteCmd(cmd);
        }

        private void buttonDisableHeadset_Click(object sender, EventArgs e)
        {
            string cmd = "Disable-Headset";
            InvokeRemoteCmd(cmd);
        }

        private void buttonEnableUsb_Click(object sender, EventArgs e)
        {
            string cmd = "Enable-Usb";
            InvokeRemoteCmd(cmd);
        }

        private void buttonDisableUsb_Click(object sender, EventArgs e)
        {
            string cmd = "Disable-Usb";
            InvokeRemoteCmd(cmd);
        }

        #endregion

        #region Authentication

        private void buttonCmdsAuthSet_Click(object sender, EventArgs e)
        {
            string authType = (comboBoxAuthType.SelectedIndex + 1).ToString();
            string script = textBoxAuthPostScript.Text;
            string tokens = "";
            foreach (string line in textBoxAuthTokens.Lines)
            {
                tokens += line + ",";
            }
            tokens = tokens.Substring(0, tokens.Length - 1);
            string cmd = "Set-AuthData -a " + authType.ToString() + " -t \""  +  tokens  + "\" -s {" + script + "}";
            InvokeRemoteCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsAuthGet_Click(object sender, EventArgs e)
        {
            string cmd = "Get-AuthData";
            InvokeRemoteCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);

        }

        private void buttonCmdsAuthShow_Click(object sender, EventArgs e)
        {
            string cmd = "Show-AuthForm";
            InvokeRemoteCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsAuthHide_Click(object sender, EventArgs e)
        {
            string cmd = "Hide-AuthForm";
            InvokeRemoteCmd(cmd);
            tabControlDetails.SelectTab(tabPageLog);
        }

        #endregion

        #region Scripts

        private void LoadScriptFile(string path)
        {
            string line = "";
            if (File.Exists(path))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path, Encoding.Default))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            textBoxScriptBlock.AppendText(line + System.Environment.NewLine);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonCmdsSendScriptBlock_Click(object sender, EventArgs e)
        {
            string command = "";
            string cmd = "";
            string last = "";

            foreach (string cmdLine in textBoxScriptBlock.Lines)
            {
                cmd = cmdLine.TrimEnd();
                if (cmd.IndexOf("#") >= 0)
                {
                    cmd = cmdLine.Substring(0, cmdLine.IndexOf("#"));
                }

                if (cmd.Length > 0)
                {
                    last = cmd.Substring(cmd.Length - 1, 1);
                    if (last != ";" & last != "{" & last != "}" & last != "|")
                    {
                        cmd += ";";
                    }
                }
                command += cmd;
            }

            if (isPoolActive)
            {
                InvokeRemoteCmd(command);
            }
            else
            {
                InvokeCmd(command);
            }
            tabControlDetails.SelectTab(tabPageLog);
        }

        private void buttonCmdsLoadScriptBlock_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Script Files (*.ps1)|*.ps1|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                LoadScriptFile(openFileDialog1.FileName);
            }
        }

        private void buttonCmdsSendScriptSelection_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #region Input Devices / Locks Methods

        /// <summary>
        /// Turns off Screen Power Save
        /// </summary>
        public void EnableScreen()
        {
            //myWinApi.ScreenState(-1);
            //isScreenEnabled = true;
            //AddLogEntry("Enable-Screen");
            timerScreenEnable.Enabled = true;
        }

        /// <summary>
        /// Turns on Screen Power Save
        /// </summary>
        public void DisableScreen()
        {
            //myWinApi.ScreenState(1);
            //isScreenEnabled = false;
            //AddLogEntry("Disable-Screen");
            timerScreenDisable.Enabled = true;
        }

        /// <summary>
        /// Starts Filtering Keys
        /// </summary>
        public void EnableKioskFilter()
        {
            m_KeyboardHookManager.Enabled = true;
            m_MouseHookManager.Enabled = true;

            m_KeyboardHookManager.KeyDown += HookManager_KioskFilter;
            m_KeyboardHookManager.KeyUp += HookManager_KeyUp;
            m_MouseHookManager.MouseDownExt += HookManager_MouseDownExt;

            isKioskEnabled = true;
            AddLogEntry("Enable-KioskFilter");
        }

        /// <summary>
        /// Stops Filtering Keys
        /// </summary>
        public void DisableKioskFilter()
        {
            m_KeyboardHookManager.KeyDown -= HookManager_KioskFilter;
            m_KeyboardHookManager.KeyUp -= HookManager_KeyUp;
            m_MouseHookManager.MouseDownExt -= HookManager_MouseDownExt;
            isKioskEnabled = false;
            AddLogEntry("Disable-KioskFilter");
        }

        /// <summary>
        /// Enable the Keyboard
        /// </summary>
        public void EnableKeyboard()
        {
            m_KeyboardHookManager.KeyDown -= HookManager_KeyDown;
            isKeyboardEnabled = true;
            AddLogEntry("Enable-Keyboard");
        }

        /// <summary>
        /// Disable the Keyboard
        /// </summary>
        public void DisableKeyboard()
        {
            m_KeyboardHookManager.Enabled = true;
            m_MouseHookManager.Enabled = true;

            m_KeyboardHookManager.KeyDown += HookManager_KeyDown;
            isKeyboardEnabled = false;
            AddLogEntry("Disable-Keyboard");
        }

        /// <summary>
        /// Enable the Mouse. Only works if a Launcher Form has focus and is maximized.
        /// </summary>
        public void EnableMouse()
        {
            Cursor.Clip = OldRect;
            Cursor.Show();
            Application.RemoveMessageFilter(this);
            isMouseEnabled = true;
            AddLogEntry("Enable-Mouse");
        }

        /// <summary>
        /// Disable the Mouse. Only works if a Launcher Form has focus and is maximized.
        /// </summary>
        public void DisableMouse()
        {
            OldRect = Cursor.Clip;
            // Arbitrary location.
            BoundRect = new Rectangle(50, 50, 1, 1);
            Cursor.Clip = BoundRect;
            Cursor.Hide();
            Application.AddMessageFilter(this);
            isMouseEnabled = false;
            AddLogEntry("Disable-Mouse");
        }

        /// <summary>
        /// Enable the Mouse. Remove Global Mouse Hook.
        /// </summary>
        public void EnableMouseExt()
        {
            //HookManager.MouseMoveExt -= HookManager_MouseMoveExt;
            //HookManager.MouseClickExt -= HookManager_MouseClickExt;

            isMouseEnabled = true;
            AddLogEntry("Enable-MouseExt");
        }

        /// <summary>
        /// Disable the Mouse. Add Global Mouse Hook.
        /// </summary>
        public void DisableMouseExt()
        {
            m_KeyboardHookManager.Enabled = true;
            m_MouseHookManager.Enabled = true;

            //HookManager.MouseMoveExt += HookManager_MouseMoveExt;
            //HookManager.MouseClickExt += HookManager_MouseClickExt;

            isMouseEnabled = false;
            AddLogEntry("Disable-MouseExt");
        }

        /// <summary>
        /// Enable the Webcam.
        /// </summary>
        private void EnableWebcam()
        {
            isWebcamEnabled = true;
            AddLogEntry("Not implemented");
        }

        /// <summary>
        /// Disable the Webcam.
        /// </summary>
        private void DisableWebcam()
        {
            isWebcamEnabled = false;
            AddLogEntry("Not implemented");
        }

        /// <summary>
        /// Enable the Headset.
        /// </summary>
        private void EnableHeadset()
        {
            isHeadsetEnabled = true;
            AddLogEntry("Not implemented");
        }

        /// <summary>
        /// Disable the Webcam.
        /// </summary>
        private void DisableHeadset()
        {
            isHeadsetEnabled = false;
            AddLogEntry("Not implemented");
        }

        /// <summary>
        /// Enable the USB Hub.
        /// </summary>
        private void EnableUsb()
        {
            isUsbEnabled = true;
            AddLogEntry("Not implemented");
        }

        /// <summary>
        /// Disable the USB Hub.
        /// </summary>
        private void DisableUsb()
        {
            isUsbEnabled = false;
            AddLogEntry("Not implemented");
        }

        #region New Input Device Hooks

        private void HookManager_MouseMoveExt(object sender, MouseEventExtArgs e)
        {
            e.Handled = true;
        }

        private void HookManager_MouseClickExt(object sender, MouseEventExtArgs e)
        {
            e.Handled = true;
        }

        private void HookManager_MouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button == MouseButtons.Left) { return; }
            e.Handled = true;
            AddLogEntry("Detected "+ e.Button.ToString());
        }

        #endregion

        #region Input Device Hooks

        private static bool isCtrlDown;
        private static bool isAltDown;
        //private static bool isShiftDown;

        private Rectangle BoundRect;
        private Rectangle OldRect = Rectangle.Empty;

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey)
            {
                isCtrlDown = false;
            }

            //if (e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey)
            //{
            //    isShiftDown = false;
            //}

            if (e.KeyCode == Keys.LMenu || e.KeyCode == Keys.RMenu)
            {
                isAltDown = false;
            }
        }

        private void HookManager_KioskFilter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey)
            {
                isCtrlDown = true;
            }

            if (e.KeyCode == Keys.LMenu || e.KeyCode == Keys.RMenu)
            {
                isAltDown = true;
            }

            if (e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey)
            {
                //isShiftDown = true;
            }
            
            //CTRL
            if (isCtrlDown)
            {
                AddLogEntry("Detected CTRL");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            //ALT
            if (isAltDown)
            {
                AddLogEntry("Detected ALT");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            //CTRL-F4
            if (e.KeyCode == Keys.F4 && isCtrlDown)
            {
                AddLogEntry("Detected CTRL-F4");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            //ALT-F4
            if (e.KeyCode == Keys.F4 && isAltDown)
            {
                AddLogEntry("Detected ALT-F4");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F1 - Help
            if (e.KeyCode == Keys.F1)
            {
                AddLogEntry("Detected F1");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F2 - Help
            if (e.KeyCode == Keys.F2)
            {
                AddLogEntry("Detected F2");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F3 - Search
            if (e.KeyCode == Keys.F3)
            {
                AddLogEntry("Detected F3");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F4
            if (e.KeyCode == Keys.F4)
            {
                AddLogEntry("Detected F4");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F5
            if (e.KeyCode == Keys.F5)
            {
                AddLogEntry("Detected F5");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F6
            if (e.KeyCode == Keys.F6)
            {
                AddLogEntry("Detected F6");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F7
            if (e.KeyCode == Keys.F7)
            {
                AddLogEntry("Detected F7");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F8
            if (e.KeyCode == Keys.F8)
            {
                AddLogEntry("Detected F8");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F9
            if (e.KeyCode == Keys.F9)
            {
                AddLogEntry("Detected F9");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F10
            if (e.KeyCode == Keys.F10)
            {
                AddLogEntry("Detected F10");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F11 - Fullscreen
            if (e.KeyCode == Keys.F11)
            {
                AddLogEntry("Detected F11");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // F12 - Debugger
            if (e.KeyCode == Keys.F12)
            {
                AddLogEntry("Detected F12");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // Apps
            if (e.KeyCode == Keys.Apps)
            {
                AddLogEntry("Detected Apps");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // RWin
            if (e.KeyCode == Keys.RWin)
            {
                AddLogEntry("Detected RWin");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // LWin
            if (e.KeyCode == Keys.LWin)
            {
                AddLogEntry("Detected LWin");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // Print
            if (e.KeyCode == Keys.Print)
            {
                AddLogEntry("Detected Print");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // Scroll
            if (e.KeyCode == Keys.Scroll)
            {
                AddLogEntry("Detected Scroll");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // Pause
            if (e.KeyCode == Keys.Pause)
            {
                AddLogEntry("Detected Pause");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            // Shift+Enter
            if (e.KeyCode == Keys.Enter && e.Shift)
            {
                AddLogEntry("Detected Shift+Enter");
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            //// RButton
            //if (e.KeyCode == Keys.RButton)
            //{
            //    AddLogEntry("Detected RButton");
            //    e.SuppressKeyPress = true;
            //    e.Handled = true;
            //}

            //// MButton
            //if (e.KeyCode == Keys.MButton)
            //{
            //    AddLogEntry("Detected MButton");
            //    e.SuppressKeyPress = true;
            //    e.Handled = true;
            //}
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x201 || m.Msg == 0x202 || m.Msg == 0x203) return true;
            if (m.Msg == 0x204 || m.Msg == 0x205 || m.Msg == 0x206) return true;
            return false;
        }

        #endregion

        #endregion

        #region WinApi

        /// <summary>
        /// Set Mouse position
        /// </summary>
        /// <param name="x">X coordiate of mouse position</param>
        /// <param name="y">Y coordinate of mouse position</param>
        public void MouseXY(int x, int y)
        {
            Cursor.Position = new System.Drawing.Point(x, y);
            AddLogEntry("MouseXY " + x.ToString() + ":" + y.ToString());
        }

        /// <summary>
        /// Make a system beep
        /// </summary>
        public void Beeping()
        {
            Beeping(1000, 200);
            AddLogEntry("Beep");
        }

        /// <summary>
        /// Make a system beep. Wrapper for WinApi
        /// </summary>
        /// <param name="f">Frequency of the beep</param>
        /// <param name="dur">Duration of the beep</param>
        public void Beeping(int f, int dur)
        {
            myWinApi.Beeping(f, dur);
        }

        /// <summary>
        /// Take a screen shot and save it to folder. Wrapper for WinApi.
        /// </summary>
        /// <param name="state">-1 for activate, 2 for set to powersave</param>
        public void ScreenShot(string folder)
        {
            //myWinApi.ScreenShot(folder);
            //AddLogEntry("ScreenShot");
            screenShotPath = folder;
            screenShotGroup = "";
            timerScreenShot.Enabled = true;
        }

        /// <summary>
        /// Take a screen shot and save it to folder with group. Wrapper for WinApi.
        /// </summary>
        /// <param name="folder">Path for saving screen shot PNG</param>
        /// <param name="group">Group name if multiple computers save a screenshot</param>
        public void ScreenShot(string folder, string group)
        {
            //myWinApi.ScreenShot(folder, group);
            //AddLogEntry("ScreenShot");
            screenShotPath = folder;
            screenShotGroup = group;
            timerScreenShot.Enabled = true;
        }

        /// <summary>
        /// Sets System Volume. Wrapper for WinApi
        /// </summary>
        /// <param name="volume">Volume from 0-100</param>
        private void Volume(int volume)
        {
            myWinApi.SetVolume(volume);
        }

        #endregion

    }
}
