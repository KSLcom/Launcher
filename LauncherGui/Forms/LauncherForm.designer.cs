namespace Launcher
{
    partial class LauncherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showConsoleToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tunnelToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTunnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTunnelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tunnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTunnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLauncherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTunnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.timerShutdown = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxConsole = new System.Windows.Forms.GroupBox();
            this.textBoxCmd = new System.Windows.Forms.TextBox();
            this.buttonInvoke = new System.Windows.Forms.Button();
            this.buttonPool = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClients = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.tabControlDetails = new System.Windows.Forms.TabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.buttonClientsToClipboard = new System.Windows.Forms.Button();
            this.groupBoxClientGroups = new System.Windows.Forms.GroupBox();
            this.buttonClientGroup10 = new System.Windows.Forms.Button();
            this.buttonClientGroup9 = new System.Windows.Forms.Button();
            this.buttonClientGroup8 = new System.Windows.Forms.Button();
            this.buttonClientGroup7 = new System.Windows.Forms.Button();
            this.buttonClientGroup6 = new System.Windows.Forms.Button();
            this.buttonClientGroup5 = new System.Windows.Forms.Button();
            this.buttonClientGroup4 = new System.Windows.Forms.Button();
            this.buttonClientGroup3 = new System.Windows.Forms.Button();
            this.buttonClientGroup2 = new System.Windows.Forms.Button();
            this.buttonClientGroup1 = new System.Windows.Forms.Button();
            this.buttonClientsFile = new System.Windows.Forms.Button();
            this.buttonClientsClear = new System.Windows.Forms.Button();
            this.buttonClientsSet = new System.Windows.Forms.Button();
            this.checkedListBoxClients = new System.Windows.Forms.CheckedListBox();
            this.tabPageCommands = new System.Windows.Forms.TabPage();
            this.groupBoxCustomCmds = new System.Windows.Forms.GroupBox();
            this.checkBoxCmdsCustomRemote = new System.Windows.Forms.CheckBox();
            this.textBoxCmdsCustomLabel10 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustom10 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustomLabel9 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustom9 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustomLabel8 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustom8 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustomLabel7 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustom7 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustomLabel6 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustom6 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustomLabel5 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustom5 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustomLabel4 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustom4 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustomLabel3 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustom3 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustomLabel2 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustom2 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustomLabel1 = new System.Windows.Forms.TextBox();
            this.textBoxCmdsCustom1 = new System.Windows.Forms.TextBox();
            this.buttonCmdsCustomSet = new System.Windows.Forms.Button();
            this.labelCustomCmdCmd = new System.Windows.Forms.Label();
            this.labelCustomCmdLabel = new System.Windows.Forms.Label();
            this.buttonCmdsCustom10 = new System.Windows.Forms.Button();
            this.buttonCmdsCustom9 = new System.Windows.Forms.Button();
            this.buttonCmdsCustom8 = new System.Windows.Forms.Button();
            this.buttonCmdsCustom7 = new System.Windows.Forms.Button();
            this.textBoxCmdsCustomCmd = new System.Windows.Forms.TextBox();
            this.comboBoxCmdsCustom = new System.Windows.Forms.ComboBox();
            this.textBoxCmdsCustomLabel = new System.Windows.Forms.TextBox();
            this.buttonCmdsCustom6 = new System.Windows.Forms.Button();
            this.buttonCmdsCustom5 = new System.Windows.Forms.Button();
            this.buttonCmdsCustom4 = new System.Windows.Forms.Button();
            this.buttonCmdsCustom3 = new System.Windows.Forms.Button();
            this.buttonCmdsCustom2 = new System.Windows.Forms.Button();
            this.buttonCmdsCustom1 = new System.Windows.Forms.Button();
            this.groupBoxStdCmd = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonCmdsGetPoolData = new System.Windows.Forms.Button();
            this.buttonCmdsClearScreenShot = new System.Windows.Forms.Button();
            this.buttonCmdsRestartComputer = new System.Windows.Forms.Button();
            this.buttonCmdsScreenShot = new System.Windows.Forms.Button();
            this.buttonCmdsStartComputer = new System.Windows.Forms.Button();
            this.buttonCmdsStopComputer = new System.Windows.Forms.Button();
            this.buttonCmdsTestService = new System.Windows.Forms.Button();
            this.groupBoxNotify = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNotifyDisplayTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNotifyText = new System.Windows.Forms.TextBox();
            this.buttonCmdsSendNotify = new System.Windows.Forms.Button();
            this.groupBoxBrowser = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBrowserDisplayTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCmdsSendBrowser = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonCmdsHideBrowser = new System.Windows.Forms.Button();
            this.buttonCmdsShowBrowser = new System.Windows.Forms.Button();
            this.groupBoxWait = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxWaitDisplayTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCmdsSendWaitForm = new System.Windows.Forms.Button();
            this.buttonCmdsHideWaitForm = new System.Windows.Forms.Button();
            this.buttonCmdsShowWaitForm = new System.Windows.Forms.Button();
            this.textBoxWaitText = new System.Windows.Forms.TextBox();
            this.tabPageFilters = new System.Windows.Forms.TabPage();
            this.groupBoxAuth = new System.Windows.Forms.GroupBox();
            this.buttonCmdsAuthGet = new System.Windows.Forms.Button();
            this.buttonCmdsAuthHide = new System.Windows.Forms.Button();
            this.buttonCmdsAuthShow = new System.Windows.Forms.Button();
            this.buttonCmdsAuthSet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxAuthType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAuthPostScript = new System.Windows.Forms.TextBox();
            this.textBoxAuthTokens = new System.Windows.Forms.TextBox();
            this.buttonAuthTokenFile = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDisableLauncher = new System.Windows.Forms.Button();
            this.buttonEnableLauncher = new System.Windows.Forms.Button();
            this.buttonDisableUsb = new System.Windows.Forms.Button();
            this.buttonEnableUsb = new System.Windows.Forms.Button();
            this.buttonDisableHeadset = new System.Windows.Forms.Button();
            this.buttonEnableHeadset = new System.Windows.Forms.Button();
            this.buttonDisableWebcam = new System.Windows.Forms.Button();
            this.buttonEnableWebcam = new System.Windows.Forms.Button();
            this.buttonDisableKiosk = new System.Windows.Forms.Button();
            this.buttonEnableKiosk = new System.Windows.Forms.Button();
            this.buttonEnableScreen = new System.Windows.Forms.Button();
            this.buttonDisableScreen = new System.Windows.Forms.Button();
            this.buttonKeyboard = new System.Windows.Forms.Button();
            this.buttonDisableMouse = new System.Windows.Forms.Button();
            this.buttonEnableMouse = new System.Windows.Forms.Button();
            this.buttonDisableKeyboard = new System.Windows.Forms.Button();
            this.tabPageScripts = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxScriptBlock = new System.Windows.Forms.TextBox();
            this.buttonCmdsLoadScriptBlock = new System.Windows.Forms.Button();
            this.buttonCmdsSendScriptBlock = new System.Windows.Forms.Button();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWorkingDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.textBoxEndpoint = new System.Windows.Forms.TextBox();
            this.textBoxRunspaceStartup = new System.Windows.Forms.TextBox();
            this.timerRestart = new System.Windows.Forms.Timer(this.components);
            this.timerScreenEnable = new System.Windows.Forms.Timer(this.components);
            this.timerScreenDisable = new System.Windows.Forms.Timer(this.components);
            this.timerScreenShot = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripTray.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxConsole.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.tabControlDetails.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            this.groupBoxClientGroups.SuspendLayout();
            this.tabPageCommands.SuspendLayout();
            this.groupBoxCustomCmds.SuspendLayout();
            this.groupBoxStdCmd.SuspendLayout();
            this.groupBoxNotify.SuspendLayout();
            this.groupBoxBrowser.SuspendLayout();
            this.groupBoxWait.SuspendLayout();
            this.tabPageFilters.SuspendLayout();
            this.groupBoxAuth.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.tabPageScripts.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showConsoleToolStripContextMenuItem,
            this.tunnelToolStripContextMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripContextMenuItem});
            this.contextMenuStripTray.Name = "contextMenuStrip1";
            this.contextMenuStripTray.Size = new System.Drawing.Size(118, 76);
            // 
            // showConsoleToolStripContextMenuItem
            // 
            this.showConsoleToolStripContextMenuItem.Name = "showConsoleToolStripContextMenuItem";
            this.showConsoleToolStripContextMenuItem.Size = new System.Drawing.Size(117, 22);
            this.showConsoleToolStripContextMenuItem.Text = "&Console";
            this.showConsoleToolStripContextMenuItem.Click += new System.EventHandler(this.showConsoleToolStripMenuItem_Click);
            // 
            // tunnelToolStripContextMenuItem
            // 
            this.tunnelToolStripContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTunnelToolStripMenuItem,
            this.closeTunnelToolStripMenuItem1});
            this.tunnelToolStripContextMenuItem.Name = "tunnelToolStripContextMenuItem";
            this.tunnelToolStripContextMenuItem.Size = new System.Drawing.Size(117, 22);
            this.tunnelToolStripContextMenuItem.Text = "&Tunnel";
            // 
            // openTunnelToolStripMenuItem
            // 
            this.openTunnelToolStripMenuItem.Name = "openTunnelToolStripMenuItem";
            this.openTunnelToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openTunnelToolStripMenuItem.Text = "&Open Tunnel";
            this.openTunnelToolStripMenuItem.Click += new System.EventHandler(this.openTunnelToolStripMenuItem_Click);
            // 
            // closeTunnelToolStripMenuItem1
            // 
            this.closeTunnelToolStripMenuItem1.Enabled = false;
            this.closeTunnelToolStripMenuItem1.Name = "closeTunnelToolStripMenuItem1";
            this.closeTunnelToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.closeTunnelToolStripMenuItem1.Text = "&Close Tunnel";
            this.closeTunnelToolStripMenuItem1.Click += new System.EventHandler(this.closeTunnelToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolStripContextMenuItem
            // 
            this.exitToolStripContextMenuItem.Name = "exitToolStripContextMenuItem";
            this.exitToolStripContextMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripContextMenuItem.Text = "&Exit";
            this.exitToolStripContextMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tunnelToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator2,
            this.disableToolStripMenuItem,
            this.enableToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "&Console";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveToolStripMenuItem.Text = "&Save Log";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clearToolStripMenuItem.Text = "&Clear Log";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.disableToolStripMenuItem.Text = "&Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Enabled = false;
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.enableToolStripMenuItem.Text = "&Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.minimizeToolStripMenuItem.Text = "&Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tunnelToolStripMenuItem
            // 
            this.tunnelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oToolStripMenuItem,
            this.closeTunnelToolStripMenuItem});
            this.tunnelToolStripMenuItem.Name = "tunnelToolStripMenuItem";
            this.tunnelToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.tunnelToolStripMenuItem.Text = "&Tunnel";
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.oToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.oToolStripMenuItem.Text = "&Open TunnelHost";
            this.oToolStripMenuItem.Click += new System.EventHandler(this.oToolStripMenuItem_Click);
            // 
            // closeTunnelToolStripMenuItem
            // 
            this.closeTunnelToolStripMenuItem.Name = "closeTunnelToolStripMenuItem";
            this.closeTunnelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.closeTunnelToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.closeTunnelToolStripMenuItem.Text = "&Close TunnelHost";
            this.closeTunnelToolStripMenuItem.Click += new System.EventHandler(this.closeTunnelToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutLauncherToolStripMenuItem,
            this.aboutPoolToolStripMenuItem,
            this.aboutTunnelToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutLauncherToolStripMenuItem
            // 
            this.aboutLauncherToolStripMenuItem.Name = "aboutLauncherToolStripMenuItem";
            this.aboutLauncherToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutLauncherToolStripMenuItem.Text = "about_Launcher";
            this.aboutLauncherToolStripMenuItem.Click += new System.EventHandler(this.aboutLauncherToolStripMenuItem_Click);
            // 
            // aboutPoolToolStripMenuItem
            // 
            this.aboutPoolToolStripMenuItem.Name = "aboutPoolToolStripMenuItem";
            this.aboutPoolToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutPoolToolStripMenuItem.Text = "about_Pool";
            this.aboutPoolToolStripMenuItem.Click += new System.EventHandler(this.aboutPoolToolStripMenuItem_Click);
            // 
            // aboutTunnelToolStripMenuItem
            // 
            this.aboutTunnelToolStripMenuItem.Name = "aboutTunnelToolStripMenuItem";
            this.aboutTunnelToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutTunnelToolStripMenuItem.Text = "about_Tunnel";
            this.aboutTunnelToolStripMenuItem.Click += new System.EventHandler(this.aboutTunnelToolStripMenuItem_Click);
            // 
            // timerStart
            // 
            this.timerStart.Enabled = true;
            this.timerStart.Interval = 1;
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // timerShutdown
            // 
            this.timerShutdown.Interval = 3000;
            this.timerShutdown.Tick += new System.EventHandler(this.timerShutdown_Tick);
            // 
            // contextMenuStripEmpty
            // 
            this.contextMenuStripEmpty.Name = "contextMenuStripEmpty";
            this.contextMenuStripEmpty.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxConsole
            // 
            this.groupBoxConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConsole.Controls.Add(this.textBoxCmd);
            this.groupBoxConsole.Controls.Add(this.buttonInvoke);
            this.groupBoxConsole.Controls.Add(this.buttonPool);
            this.groupBoxConsole.Controls.Add(this.label4);
            this.groupBoxConsole.Controls.Add(this.label3);
            this.groupBoxConsole.Controls.Add(this.textBoxClients);
            this.groupBoxConsole.Location = new System.Drawing.Point(12, 27);
            this.groupBoxConsole.Name = "groupBoxConsole";
            this.groupBoxConsole.Size = new System.Drawing.Size(664, 75);
            this.groupBoxConsole.TabIndex = 0;
            this.groupBoxConsole.TabStop = false;
            // 
            // textBoxCmd
            // 
            this.textBoxCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd.Location = new System.Drawing.Point(53, 43);
            this.textBoxCmd.Name = "textBoxCmd";
            this.textBoxCmd.Size = new System.Drawing.Size(485, 20);
            this.textBoxCmd.TabIndex = 3;
            this.textBoxCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCmd_KeyPress);
            // 
            // buttonInvoke
            // 
            this.buttonInvoke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInvoke.Location = new System.Drawing.Point(544, 41);
            this.buttonInvoke.Name = "buttonInvoke";
            this.buttonInvoke.Size = new System.Drawing.Size(110, 23);
            this.buttonInvoke.TabIndex = 4;
            this.buttonInvoke.Text = "Invoke-Pool";
            this.buttonInvoke.UseVisualStyleBackColor = true;
            this.buttonInvoke.Click += new System.EventHandler(this.buttonInvoke_Click);
            // 
            // buttonPool
            // 
            this.buttonPool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPool.Location = new System.Drawing.Point(544, 15);
            this.buttonPool.Name = "buttonPool";
            this.buttonPool.Size = new System.Drawing.Size(109, 23);
            this.buttonPool.TabIndex = 2;
            this.buttonPool.Text = "Register-Pool";
            this.buttonPool.UseVisualStyleBackColor = true;
            this.buttonPool.Click += new System.EventHandler(this.buttonPool_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cmd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Clients:";
            // 
            // textBoxClients
            // 
            this.textBoxClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClients.Location = new System.Drawing.Point(53, 17);
            this.textBoxClients.Name = "textBoxClients";
            this.textBoxClients.Size = new System.Drawing.Size(485, 20);
            this.textBoxClients.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDetails.Controls.Add(this.tabControlDetails);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 103);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(664, 459);
            this.groupBoxDetails.TabIndex = 5;
            this.groupBoxDetails.TabStop = false;
            // 
            // tabControlDetails
            // 
            this.tabControlDetails.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlDetails.Controls.Add(this.tabPageLog);
            this.tabControlDetails.Controls.Add(this.tabPageClients);
            this.tabControlDetails.Controls.Add(this.tabPageCommands);
            this.tabControlDetails.Controls.Add(this.tabPageFilters);
            this.tabControlDetails.Controls.Add(this.tabPageScripts);
            this.tabControlDetails.Controls.Add(this.tabPageSettings);
            this.tabControlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDetails.Location = new System.Drawing.Point(3, 16);
            this.tabControlDetails.Name = "tabControlDetails";
            this.tabControlDetails.SelectedIndex = 0;
            this.tabControlDetails.Size = new System.Drawing.Size(658, 440);
            this.tabControlDetails.TabIndex = 6;
            this.tabControlDetails.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.textBoxLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 25);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(650, 411);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.AcceptsTab = true;
            this.textBoxLog.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(3, 3);
            this.textBoxLog.MaxLength = 1000000;
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(644, 405);
            this.textBoxLog.TabIndex = 7;
            this.textBoxLog.TabStop = false;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.buttonClientsToClipboard);
            this.tabPageClients.Controls.Add(this.groupBoxClientGroups);
            this.tabPageClients.Controls.Add(this.buttonClientsFile);
            this.tabPageClients.Controls.Add(this.buttonClientsClear);
            this.tabPageClients.Controls.Add(this.buttonClientsSet);
            this.tabPageClients.Controls.Add(this.checkedListBoxClients);
            this.tabPageClients.Location = new System.Drawing.Point(4, 25);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(650, 411);
            this.tabPageClients.TabIndex = 1;
            this.tabPageClients.Text = "Clients";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // buttonClientsToClipboard
            // 
            this.buttonClientsToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClientsToClipboard.Enabled = false;
            this.buttonClientsToClipboard.Location = new System.Drawing.Point(565, 94);
            this.buttonClientsToClipboard.Name = "buttonClientsToClipboard";
            this.buttonClientsToClipboard.Size = new System.Drawing.Size(79, 23);
            this.buttonClientsToClipboard.TabIndex = 12;
            this.buttonClientsToClipboard.Text = "ToClipboard";
            this.buttonClientsToClipboard.UseVisualStyleBackColor = true;
            this.buttonClientsToClipboard.Click += new System.EventHandler(this.buttonClientsToClipboard_Click);
            // 
            // groupBoxClientGroups
            // 
            this.groupBoxClientGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxClientGroups.Controls.Add(this.buttonClientGroup10);
            this.groupBoxClientGroups.Controls.Add(this.buttonClientGroup9);
            this.groupBoxClientGroups.Controls.Add(this.buttonClientGroup8);
            this.groupBoxClientGroups.Controls.Add(this.buttonClientGroup7);
            this.groupBoxClientGroups.Controls.Add(this.buttonClientGroup6);
            this.groupBoxClientGroups.Controls.Add(this.buttonClientGroup5);
            this.groupBoxClientGroups.Controls.Add(this.buttonClientGroup4);
            this.groupBoxClientGroups.Controls.Add(this.buttonClientGroup3);
            this.groupBoxClientGroups.Controls.Add(this.buttonClientGroup2);
            this.groupBoxClientGroups.Controls.Add(this.buttonClientGroup1);
            this.groupBoxClientGroups.Location = new System.Drawing.Point(565, 123);
            this.groupBoxClientGroups.Name = "groupBoxClientGroups";
            this.groupBoxClientGroups.Size = new System.Drawing.Size(79, 169);
            this.groupBoxClientGroups.TabIndex = 19;
            this.groupBoxClientGroups.TabStop = false;
            this.groupBoxClientGroups.Text = "Sub Pools";
            // 
            // buttonClientGroup10
            // 
            this.buttonClientGroup10.Location = new System.Drawing.Point(39, 135);
            this.buttonClientGroup10.Name = "buttonClientGroup10";
            this.buttonClientGroup10.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup10.TabIndex = 25;
            this.buttonClientGroup10.Text = "A";
            this.buttonClientGroup10.UseVisualStyleBackColor = true;
            this.buttonClientGroup10.Click += new System.EventHandler(this.buttonClientGroup10_Click);
            // 
            // buttonClientGroup9
            // 
            this.buttonClientGroup9.Location = new System.Drawing.Point(6, 135);
            this.buttonClientGroup9.Name = "buttonClientGroup9";
            this.buttonClientGroup9.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup9.TabIndex = 24;
            this.buttonClientGroup9.Text = "9";
            this.buttonClientGroup9.UseVisualStyleBackColor = true;
            this.buttonClientGroup9.Click += new System.EventHandler(this.buttonClientGroup9_Click);
            // 
            // buttonClientGroup8
            // 
            this.buttonClientGroup8.Location = new System.Drawing.Point(39, 106);
            this.buttonClientGroup8.Name = "buttonClientGroup8";
            this.buttonClientGroup8.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup8.TabIndex = 23;
            this.buttonClientGroup8.Text = "8";
            this.buttonClientGroup8.UseVisualStyleBackColor = true;
            this.buttonClientGroup8.Click += new System.EventHandler(this.buttonClientGroup8_Click);
            // 
            // buttonClientGroup7
            // 
            this.buttonClientGroup7.Location = new System.Drawing.Point(6, 106);
            this.buttonClientGroup7.Name = "buttonClientGroup7";
            this.buttonClientGroup7.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup7.TabIndex = 22;
            this.buttonClientGroup7.Text = "7";
            this.buttonClientGroup7.UseVisualStyleBackColor = true;
            this.buttonClientGroup7.Click += new System.EventHandler(this.buttonClientGroup7_Click);
            // 
            // buttonClientGroup6
            // 
            this.buttonClientGroup6.Location = new System.Drawing.Point(39, 77);
            this.buttonClientGroup6.Name = "buttonClientGroup6";
            this.buttonClientGroup6.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup6.TabIndex = 21;
            this.buttonClientGroup6.Text = "6";
            this.buttonClientGroup6.UseVisualStyleBackColor = true;
            this.buttonClientGroup6.Click += new System.EventHandler(this.buttonClientGroup6_Click);
            // 
            // buttonClientGroup5
            // 
            this.buttonClientGroup5.Location = new System.Drawing.Point(6, 77);
            this.buttonClientGroup5.Name = "buttonClientGroup5";
            this.buttonClientGroup5.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup5.TabIndex = 20;
            this.buttonClientGroup5.Text = "5";
            this.buttonClientGroup5.UseVisualStyleBackColor = true;
            this.buttonClientGroup5.Click += new System.EventHandler(this.buttonClientGroup5_Click);
            // 
            // buttonClientGroup4
            // 
            this.buttonClientGroup4.Location = new System.Drawing.Point(39, 48);
            this.buttonClientGroup4.Name = "buttonClientGroup4";
            this.buttonClientGroup4.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup4.TabIndex = 19;
            this.buttonClientGroup4.Text = "4";
            this.buttonClientGroup4.UseVisualStyleBackColor = true;
            this.buttonClientGroup4.Click += new System.EventHandler(this.buttonClientGroup4_Click);
            // 
            // buttonClientGroup3
            // 
            this.buttonClientGroup3.Location = new System.Drawing.Point(6, 48);
            this.buttonClientGroup3.Name = "buttonClientGroup3";
            this.buttonClientGroup3.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup3.TabIndex = 18;
            this.buttonClientGroup3.Text = "3";
            this.buttonClientGroup3.UseVisualStyleBackColor = true;
            this.buttonClientGroup3.Click += new System.EventHandler(this.buttonClientGroup3_Click);
            // 
            // buttonClientGroup2
            // 
            this.buttonClientGroup2.Location = new System.Drawing.Point(39, 19);
            this.buttonClientGroup2.Name = "buttonClientGroup2";
            this.buttonClientGroup2.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup2.TabIndex = 17;
            this.buttonClientGroup2.Text = "2";
            this.buttonClientGroup2.UseVisualStyleBackColor = true;
            this.buttonClientGroup2.Click += new System.EventHandler(this.buttonClientGroup2_Click);
            // 
            // buttonClientGroup1
            // 
            this.buttonClientGroup1.Location = new System.Drawing.Point(6, 19);
            this.buttonClientGroup1.Name = "buttonClientGroup1";
            this.buttonClientGroup1.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup1.TabIndex = 16;
            this.buttonClientGroup1.Text = "1";
            this.buttonClientGroup1.UseVisualStyleBackColor = true;
            this.buttonClientGroup1.Click += new System.EventHandler(this.buttonClientGroup1_Click);
            // 
            // buttonClientsFile
            // 
            this.buttonClientsFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClientsFile.Location = new System.Drawing.Point(565, 36);
            this.buttonClientsFile.Name = "buttonClientsFile";
            this.buttonClientsFile.Size = new System.Drawing.Size(79, 23);
            this.buttonClientsFile.TabIndex = 10;
            this.buttonClientsFile.Text = "Load";
            this.buttonClientsFile.UseVisualStyleBackColor = true;
            this.buttonClientsFile.Click += new System.EventHandler(this.buttonClientsFile_Click);
            // 
            // buttonClientsClear
            // 
            this.buttonClientsClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClientsClear.Location = new System.Drawing.Point(565, 65);
            this.buttonClientsClear.Name = "buttonClientsClear";
            this.buttonClientsClear.Size = new System.Drawing.Size(79, 23);
            this.buttonClientsClear.TabIndex = 11;
            this.buttonClientsClear.Text = "Clear";
            this.buttonClientsClear.UseVisualStyleBackColor = true;
            this.buttonClientsClear.Click += new System.EventHandler(this.buttonClientsClear_Click);
            // 
            // buttonClientsSet
            // 
            this.buttonClientsSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClientsSet.Location = new System.Drawing.Point(565, 7);
            this.buttonClientsSet.Name = "buttonClientsSet";
            this.buttonClientsSet.Size = new System.Drawing.Size(79, 23);
            this.buttonClientsSet.TabIndex = 9;
            this.buttonClientsSet.Text = "Register";
            this.buttonClientsSet.UseVisualStyleBackColor = true;
            this.buttonClientsSet.Click += new System.EventHandler(this.buttonClientsSet_Click);
            // 
            // checkedListBoxClients
            // 
            this.checkedListBoxClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxClients.FormattingEnabled = true;
            this.checkedListBoxClients.Items.AddRange(new object[] {
            "localhost"});
            this.checkedListBoxClients.Location = new System.Drawing.Point(6, 7);
            this.checkedListBoxClients.MultiColumn = true;
            this.checkedListBoxClients.Name = "checkedListBoxClients";
            this.checkedListBoxClients.Size = new System.Drawing.Size(553, 394);
            this.checkedListBoxClients.TabIndex = 8;
            // 
            // tabPageCommands
            // 
            this.tabPageCommands.Controls.Add(this.groupBoxCustomCmds);
            this.tabPageCommands.Controls.Add(this.groupBoxStdCmd);
            this.tabPageCommands.Controls.Add(this.groupBoxNotify);
            this.tabPageCommands.Controls.Add(this.groupBoxBrowser);
            this.tabPageCommands.Controls.Add(this.groupBoxWait);
            this.tabPageCommands.Location = new System.Drawing.Point(4, 25);
            this.tabPageCommands.Name = "tabPageCommands";
            this.tabPageCommands.Size = new System.Drawing.Size(650, 411);
            this.tabPageCommands.TabIndex = 2;
            this.tabPageCommands.Text = "Commands";
            this.tabPageCommands.UseVisualStyleBackColor = true;
            // 
            // groupBoxCustomCmds
            // 
            this.groupBoxCustomCmds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCustomCmds.Controls.Add(this.checkBoxCmdsCustomRemote);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomLabel10);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustom10);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomLabel9);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustom9);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomLabel8);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustom8);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomLabel7);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustom7);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomLabel6);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustom6);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomLabel5);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustom5);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomLabel4);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustom4);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomLabel3);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustom3);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomLabel2);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustom2);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomLabel1);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustom1);
            this.groupBoxCustomCmds.Controls.Add(this.buttonCmdsCustomSet);
            this.groupBoxCustomCmds.Controls.Add(this.labelCustomCmdCmd);
            this.groupBoxCustomCmds.Controls.Add(this.labelCustomCmdLabel);
            this.groupBoxCustomCmds.Controls.Add(this.buttonCmdsCustom10);
            this.groupBoxCustomCmds.Controls.Add(this.buttonCmdsCustom9);
            this.groupBoxCustomCmds.Controls.Add(this.buttonCmdsCustom8);
            this.groupBoxCustomCmds.Controls.Add(this.buttonCmdsCustom7);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomCmd);
            this.groupBoxCustomCmds.Controls.Add(this.comboBoxCmdsCustom);
            this.groupBoxCustomCmds.Controls.Add(this.textBoxCmdsCustomLabel);
            this.groupBoxCustomCmds.Controls.Add(this.buttonCmdsCustom6);
            this.groupBoxCustomCmds.Controls.Add(this.buttonCmdsCustom5);
            this.groupBoxCustomCmds.Controls.Add(this.buttonCmdsCustom4);
            this.groupBoxCustomCmds.Controls.Add(this.buttonCmdsCustom3);
            this.groupBoxCustomCmds.Controls.Add(this.buttonCmdsCustom2);
            this.groupBoxCustomCmds.Controls.Add(this.buttonCmdsCustom1);
            this.groupBoxCustomCmds.Location = new System.Drawing.Point(6, 143);
            this.groupBoxCustomCmds.Name = "groupBoxCustomCmds";
            this.groupBoxCustomCmds.Size = new System.Drawing.Size(240, 252);
            this.groupBoxCustomCmds.TabIndex = 39;
            this.groupBoxCustomCmds.TabStop = false;
            this.groupBoxCustomCmds.Text = "Custom Commands";
            // 
            // checkBoxCmdsCustomRemote
            // 
            this.checkBoxCmdsCustomRemote.AutoSize = true;
            this.checkBoxCmdsCustomRemote.Enabled = false;
            this.checkBoxCmdsCustomRemote.Location = new System.Drawing.Point(197, 198);
            this.checkBoxCmdsCustomRemote.Name = "checkBoxCmdsCustomRemote";
            this.checkBoxCmdsCustomRemote.Size = new System.Drawing.Size(34, 17);
            this.checkBoxCmdsCustomRemote.TabIndex = 52;
            this.checkBoxCmdsCustomRemote.Text = "R";
            this.checkBoxCmdsCustomRemote.UseVisualStyleBackColor = true;
            // 
            // textBoxCmdsCustomLabel10
            // 
            this.textBoxCmdsCustomLabel10.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmdLabel10", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustomLabel10.Enabled = false;
            this.textBoxCmdsCustomLabel10.Location = new System.Drawing.Point(412, 135);
            this.textBoxCmdsCustomLabel10.Name = "textBoxCmdsCustomLabel10";
            this.textBoxCmdsCustomLabel10.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustomLabel10.TabIndex = 57;
            this.textBoxCmdsCustomLabel10.TabStop = false;
            this.textBoxCmdsCustomLabel10.Text = global::Launcher.Properties.Settings.Default.CustomCmdLabel10;
            // 
            // textBoxCmdsCustom10
            // 
            this.textBoxCmdsCustom10.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmd10", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustom10.Enabled = false;
            this.textBoxCmdsCustom10.Location = new System.Drawing.Point(359, 135);
            this.textBoxCmdsCustom10.Name = "textBoxCmdsCustom10";
            this.textBoxCmdsCustom10.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustom10.TabIndex = 56;
            this.textBoxCmdsCustom10.TabStop = false;
            this.textBoxCmdsCustom10.Text = global::Launcher.Properties.Settings.Default.CustomCmd10;
            // 
            // textBoxCmdsCustomLabel9
            // 
            this.textBoxCmdsCustomLabel9.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmdLabel9", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustomLabel9.Enabled = false;
            this.textBoxCmdsCustomLabel9.Location = new System.Drawing.Point(306, 135);
            this.textBoxCmdsCustomLabel9.Name = "textBoxCmdsCustomLabel9";
            this.textBoxCmdsCustomLabel9.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustomLabel9.TabIndex = 55;
            this.textBoxCmdsCustomLabel9.TabStop = false;
            this.textBoxCmdsCustomLabel9.Text = global::Launcher.Properties.Settings.Default.CustomCmdLabel9;
            // 
            // textBoxCmdsCustom9
            // 
            this.textBoxCmdsCustom9.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmd9", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustom9.Enabled = false;
            this.textBoxCmdsCustom9.Location = new System.Drawing.Point(253, 135);
            this.textBoxCmdsCustom9.Name = "textBoxCmdsCustom9";
            this.textBoxCmdsCustom9.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustom9.TabIndex = 54;
            this.textBoxCmdsCustom9.TabStop = false;
            this.textBoxCmdsCustom9.Text = global::Launcher.Properties.Settings.Default.CustomCmd9;
            // 
            // textBoxCmdsCustomLabel8
            // 
            this.textBoxCmdsCustomLabel8.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmdLabel8", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustomLabel8.Enabled = false;
            this.textBoxCmdsCustomLabel8.Location = new System.Drawing.Point(412, 109);
            this.textBoxCmdsCustomLabel8.Name = "textBoxCmdsCustomLabel8";
            this.textBoxCmdsCustomLabel8.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustomLabel8.TabIndex = 53;
            this.textBoxCmdsCustomLabel8.TabStop = false;
            this.textBoxCmdsCustomLabel8.Text = global::Launcher.Properties.Settings.Default.CustomCmdLabel8;
            // 
            // textBoxCmdsCustom8
            // 
            this.textBoxCmdsCustom8.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmd8", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustom8.Enabled = false;
            this.textBoxCmdsCustom8.Location = new System.Drawing.Point(359, 109);
            this.textBoxCmdsCustom8.Name = "textBoxCmdsCustom8";
            this.textBoxCmdsCustom8.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustom8.TabIndex = 52;
            this.textBoxCmdsCustom8.TabStop = false;
            this.textBoxCmdsCustom8.Text = global::Launcher.Properties.Settings.Default.CustomCmd8;
            // 
            // textBoxCmdsCustomLabel7
            // 
            this.textBoxCmdsCustomLabel7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmdLabel7", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustomLabel7.Enabled = false;
            this.textBoxCmdsCustomLabel7.Location = new System.Drawing.Point(306, 109);
            this.textBoxCmdsCustomLabel7.Name = "textBoxCmdsCustomLabel7";
            this.textBoxCmdsCustomLabel7.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustomLabel7.TabIndex = 51;
            this.textBoxCmdsCustomLabel7.TabStop = false;
            this.textBoxCmdsCustomLabel7.Text = global::Launcher.Properties.Settings.Default.CustomCmdLabel7;
            // 
            // textBoxCmdsCustom7
            // 
            this.textBoxCmdsCustom7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmd7", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustom7.Enabled = false;
            this.textBoxCmdsCustom7.Location = new System.Drawing.Point(253, 108);
            this.textBoxCmdsCustom7.Name = "textBoxCmdsCustom7";
            this.textBoxCmdsCustom7.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustom7.TabIndex = 50;
            this.textBoxCmdsCustom7.TabStop = false;
            this.textBoxCmdsCustom7.Text = global::Launcher.Properties.Settings.Default.CustomCmd7;
            // 
            // textBoxCmdsCustomLabel6
            // 
            this.textBoxCmdsCustomLabel6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmdLabel6", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustomLabel6.Enabled = false;
            this.textBoxCmdsCustomLabel6.Location = new System.Drawing.Point(412, 81);
            this.textBoxCmdsCustomLabel6.Name = "textBoxCmdsCustomLabel6";
            this.textBoxCmdsCustomLabel6.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustomLabel6.TabIndex = 49;
            this.textBoxCmdsCustomLabel6.TabStop = false;
            this.textBoxCmdsCustomLabel6.Text = global::Launcher.Properties.Settings.Default.CustomCmdLabel6;
            // 
            // textBoxCmdsCustom6
            // 
            this.textBoxCmdsCustom6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmd6", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustom6.Enabled = false;
            this.textBoxCmdsCustom6.Location = new System.Drawing.Point(359, 80);
            this.textBoxCmdsCustom6.Name = "textBoxCmdsCustom6";
            this.textBoxCmdsCustom6.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustom6.TabIndex = 48;
            this.textBoxCmdsCustom6.TabStop = false;
            this.textBoxCmdsCustom6.Text = global::Launcher.Properties.Settings.Default.CustomCmd6;
            // 
            // textBoxCmdsCustomLabel5
            // 
            this.textBoxCmdsCustomLabel5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmdLabel5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustomLabel5.Enabled = false;
            this.textBoxCmdsCustomLabel5.Location = new System.Drawing.Point(306, 79);
            this.textBoxCmdsCustomLabel5.Name = "textBoxCmdsCustomLabel5";
            this.textBoxCmdsCustomLabel5.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustomLabel5.TabIndex = 47;
            this.textBoxCmdsCustomLabel5.TabStop = false;
            this.textBoxCmdsCustomLabel5.Text = global::Launcher.Properties.Settings.Default.CustomCmdLabel5;
            // 
            // textBoxCmdsCustom5
            // 
            this.textBoxCmdsCustom5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmd5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustom5.Enabled = false;
            this.textBoxCmdsCustom5.Location = new System.Drawing.Point(253, 79);
            this.textBoxCmdsCustom5.Name = "textBoxCmdsCustom5";
            this.textBoxCmdsCustom5.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustom5.TabIndex = 46;
            this.textBoxCmdsCustom5.TabStop = false;
            this.textBoxCmdsCustom5.Text = global::Launcher.Properties.Settings.Default.CustomCmd5;
            // 
            // textBoxCmdsCustomLabel4
            // 
            this.textBoxCmdsCustomLabel4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmdLabel4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustomLabel4.Enabled = false;
            this.textBoxCmdsCustomLabel4.Location = new System.Drawing.Point(412, 50);
            this.textBoxCmdsCustomLabel4.Name = "textBoxCmdsCustomLabel4";
            this.textBoxCmdsCustomLabel4.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustomLabel4.TabIndex = 45;
            this.textBoxCmdsCustomLabel4.TabStop = false;
            this.textBoxCmdsCustomLabel4.Text = global::Launcher.Properties.Settings.Default.CustomCmdLabel4;
            // 
            // textBoxCmdsCustom4
            // 
            this.textBoxCmdsCustom4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmd4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustom4.Enabled = false;
            this.textBoxCmdsCustom4.Location = new System.Drawing.Point(359, 51);
            this.textBoxCmdsCustom4.Name = "textBoxCmdsCustom4";
            this.textBoxCmdsCustom4.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustom4.TabIndex = 44;
            this.textBoxCmdsCustom4.TabStop = false;
            this.textBoxCmdsCustom4.Text = global::Launcher.Properties.Settings.Default.CustomCmd4;
            // 
            // textBoxCmdsCustomLabel3
            // 
            this.textBoxCmdsCustomLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmdLabel3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustomLabel3.Enabled = false;
            this.textBoxCmdsCustomLabel3.Location = new System.Drawing.Point(306, 50);
            this.textBoxCmdsCustomLabel3.Name = "textBoxCmdsCustomLabel3";
            this.textBoxCmdsCustomLabel3.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustomLabel3.TabIndex = 43;
            this.textBoxCmdsCustomLabel3.TabStop = false;
            this.textBoxCmdsCustomLabel3.Text = global::Launcher.Properties.Settings.Default.CustomCmdLabel3;
            // 
            // textBoxCmdsCustom3
            // 
            this.textBoxCmdsCustom3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmd3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustom3.Enabled = false;
            this.textBoxCmdsCustom3.Location = new System.Drawing.Point(253, 50);
            this.textBoxCmdsCustom3.Name = "textBoxCmdsCustom3";
            this.textBoxCmdsCustom3.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustom3.TabIndex = 42;
            this.textBoxCmdsCustom3.TabStop = false;
            this.textBoxCmdsCustom3.Text = global::Launcher.Properties.Settings.Default.CustomCmd3;
            // 
            // textBoxCmdsCustomLabel2
            // 
            this.textBoxCmdsCustomLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmdLabel2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustomLabel2.Enabled = false;
            this.textBoxCmdsCustomLabel2.Location = new System.Drawing.Point(412, 20);
            this.textBoxCmdsCustomLabel2.Name = "textBoxCmdsCustomLabel2";
            this.textBoxCmdsCustomLabel2.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustomLabel2.TabIndex = 41;
            this.textBoxCmdsCustomLabel2.TabStop = false;
            this.textBoxCmdsCustomLabel2.Text = global::Launcher.Properties.Settings.Default.CustomCmdLabel2;
            // 
            // textBoxCmdsCustom2
            // 
            this.textBoxCmdsCustom2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmd2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustom2.Enabled = false;
            this.textBoxCmdsCustom2.Location = new System.Drawing.Point(359, 20);
            this.textBoxCmdsCustom2.Name = "textBoxCmdsCustom2";
            this.textBoxCmdsCustom2.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustom2.TabIndex = 40;
            this.textBoxCmdsCustom2.TabStop = false;
            this.textBoxCmdsCustom2.Text = global::Launcher.Properties.Settings.Default.CustomCmd2;
            // 
            // textBoxCmdsCustomLabel1
            // 
            this.textBoxCmdsCustomLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmdLabel1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustomLabel1.Enabled = false;
            this.textBoxCmdsCustomLabel1.Location = new System.Drawing.Point(306, 20);
            this.textBoxCmdsCustomLabel1.Name = "textBoxCmdsCustomLabel1";
            this.textBoxCmdsCustomLabel1.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustomLabel1.TabIndex = 39;
            this.textBoxCmdsCustomLabel1.TabStop = false;
            this.textBoxCmdsCustomLabel1.Text = global::Launcher.Properties.Settings.Default.CustomCmdLabel1;
            // 
            // textBoxCmdsCustom1
            // 
            this.textBoxCmdsCustom1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "CustomCmd1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCmdsCustom1.Enabled = false;
            this.textBoxCmdsCustom1.Location = new System.Drawing.Point(253, 20);
            this.textBoxCmdsCustom1.Name = "textBoxCmdsCustom1";
            this.textBoxCmdsCustom1.Size = new System.Drawing.Size(47, 20);
            this.textBoxCmdsCustom1.TabIndex = 38;
            this.textBoxCmdsCustom1.TabStop = false;
            this.textBoxCmdsCustom1.Text = global::Launcher.Properties.Settings.Default.CustomCmd1;
            // 
            // buttonCmdsCustomSet
            // 
            this.buttonCmdsCustomSet.Enabled = false;
            this.buttonCmdsCustomSet.Location = new System.Drawing.Point(188, 169);
            this.buttonCmdsCustomSet.Name = "buttonCmdsCustomSet";
            this.buttonCmdsCustomSet.Size = new System.Drawing.Size(43, 23);
            this.buttonCmdsCustomSet.TabIndex = 54;
            this.buttonCmdsCustomSet.Text = "Set";
            this.buttonCmdsCustomSet.UseVisualStyleBackColor = true;
            this.buttonCmdsCustomSet.Click += new System.EventHandler(this.buttonCmdsCustomSet_Click);
            // 
            // labelCustomCmdCmd
            // 
            this.labelCustomCmdCmd.AutoSize = true;
            this.labelCustomCmdCmd.Enabled = false;
            this.labelCustomCmdCmd.Location = new System.Drawing.Point(4, 225);
            this.labelCustomCmdCmd.Name = "labelCustomCmdCmd";
            this.labelCustomCmdCmd.Size = new System.Drawing.Size(28, 13);
            this.labelCustomCmdCmd.TabIndex = 36;
            this.labelCustomCmdCmd.Text = "Cmd";
            // 
            // labelCustomCmdLabel
            // 
            this.labelCustomCmdLabel.AutoSize = true;
            this.labelCustomCmdLabel.Enabled = false;
            this.labelCustomCmdLabel.Location = new System.Drawing.Point(4, 199);
            this.labelCustomCmdLabel.Name = "labelCustomCmdLabel";
            this.labelCustomCmdLabel.Size = new System.Drawing.Size(33, 13);
            this.labelCustomCmdLabel.TabIndex = 35;
            this.labelCustomCmdLabel.Text = "Label";
            // 
            // buttonCmdsCustom10
            // 
            this.buttonCmdsCustom10.Location = new System.Drawing.Point(122, 136);
            this.buttonCmdsCustom10.Name = "buttonCmdsCustom10";
            this.buttonCmdsCustom10.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsCustom10.TabIndex = 49;
            this.buttonCmdsCustom10.Text = "Custom10";
            this.buttonCmdsCustom10.UseVisualStyleBackColor = true;
            this.buttonCmdsCustom10.Click += new System.EventHandler(this.buttonCmdsCustom10_Click);
            // 
            // buttonCmdsCustom9
            // 
            this.buttonCmdsCustom9.Location = new System.Drawing.Point(7, 136);
            this.buttonCmdsCustom9.Name = "buttonCmdsCustom9";
            this.buttonCmdsCustom9.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsCustom9.TabIndex = 48;
            this.buttonCmdsCustom9.Text = "Custom9";
            this.buttonCmdsCustom9.UseVisualStyleBackColor = true;
            this.buttonCmdsCustom9.Click += new System.EventHandler(this.buttonCmdsCustom9_Click);
            // 
            // buttonCmdsCustom8
            // 
            this.buttonCmdsCustom8.Location = new System.Drawing.Point(122, 107);
            this.buttonCmdsCustom8.Name = "buttonCmdsCustom8";
            this.buttonCmdsCustom8.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsCustom8.TabIndex = 47;
            this.buttonCmdsCustom8.Text = "Custom8";
            this.buttonCmdsCustom8.UseVisualStyleBackColor = true;
            this.buttonCmdsCustom8.Click += new System.EventHandler(this.buttonCmdsCustom8_Click);
            // 
            // buttonCmdsCustom7
            // 
            this.buttonCmdsCustom7.Location = new System.Drawing.Point(7, 107);
            this.buttonCmdsCustom7.Name = "buttonCmdsCustom7";
            this.buttonCmdsCustom7.Size = new System.Drawing.Size(108, 23);
            this.buttonCmdsCustom7.TabIndex = 46;
            this.buttonCmdsCustom7.Text = "Custom7";
            this.buttonCmdsCustom7.UseVisualStyleBackColor = true;
            this.buttonCmdsCustom7.Click += new System.EventHandler(this.buttonCmdsCustom7_Click);
            // 
            // textBoxCmdsCustomCmd
            // 
            this.textBoxCmdsCustomCmd.Enabled = false;
            this.textBoxCmdsCustomCmd.Location = new System.Drawing.Point(45, 222);
            this.textBoxCmdsCustomCmd.Name = "textBoxCmdsCustomCmd";
            this.textBoxCmdsCustomCmd.Size = new System.Drawing.Size(186, 20);
            this.textBoxCmdsCustomCmd.TabIndex = 53;
            // 
            // comboBoxCmdsCustom
            // 
            this.comboBoxCmdsCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCmdsCustom.FormattingEnabled = true;
            this.comboBoxCmdsCustom.Items.AddRange(new object[] {
            "Custom-Command 1",
            "Custom-Command 2",
            "Custom-Command 3",
            "Custom-Command 4",
            "Custom-Command 5",
            "Custom-Command 6",
            "Custom-Command 7",
            "Custom-Command 8",
            "Custom-Command 9",
            "Custom-Command 10"});
            this.comboBoxCmdsCustom.Location = new System.Drawing.Point(7, 169);
            this.comboBoxCmdsCustom.Name = "comboBoxCmdsCustom";
            this.comboBoxCmdsCustom.Size = new System.Drawing.Size(175, 21);
            this.comboBoxCmdsCustom.TabIndex = 50;
            this.comboBoxCmdsCustom.SelectedIndexChanged += new System.EventHandler(this.comboBoxCmdsCustom_SelectedIndexChanged);
            // 
            // textBoxCmdsCustomLabel
            // 
            this.textBoxCmdsCustomLabel.Enabled = false;
            this.textBoxCmdsCustomLabel.Location = new System.Drawing.Point(45, 196);
            this.textBoxCmdsCustomLabel.Name = "textBoxCmdsCustomLabel";
            this.textBoxCmdsCustomLabel.Size = new System.Drawing.Size(137, 20);
            this.textBoxCmdsCustomLabel.TabIndex = 51;
            // 
            // buttonCmdsCustom6
            // 
            this.buttonCmdsCustom6.Location = new System.Drawing.Point(122, 78);
            this.buttonCmdsCustom6.Name = "buttonCmdsCustom6";
            this.buttonCmdsCustom6.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsCustom6.TabIndex = 45;
            this.buttonCmdsCustom6.Text = "Custom6";
            this.buttonCmdsCustom6.UseVisualStyleBackColor = true;
            this.buttonCmdsCustom6.Click += new System.EventHandler(this.buttonCmdsCustom6_Click);
            // 
            // buttonCmdsCustom5
            // 
            this.buttonCmdsCustom5.Location = new System.Drawing.Point(7, 78);
            this.buttonCmdsCustom5.Name = "buttonCmdsCustom5";
            this.buttonCmdsCustom5.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsCustom5.TabIndex = 44;
            this.buttonCmdsCustom5.Text = "Custom5";
            this.buttonCmdsCustom5.UseVisualStyleBackColor = true;
            this.buttonCmdsCustom5.Click += new System.EventHandler(this.buttonCmdsCustom5_Click);
            // 
            // buttonCmdsCustom4
            // 
            this.buttonCmdsCustom4.Location = new System.Drawing.Point(122, 49);
            this.buttonCmdsCustom4.Name = "buttonCmdsCustom4";
            this.buttonCmdsCustom4.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsCustom4.TabIndex = 43;
            this.buttonCmdsCustom4.Text = "Custom4";
            this.buttonCmdsCustom4.UseVisualStyleBackColor = true;
            this.buttonCmdsCustom4.Click += new System.EventHandler(this.buttonCmdsCustom4_Click);
            // 
            // buttonCmdsCustom3
            // 
            this.buttonCmdsCustom3.Location = new System.Drawing.Point(7, 49);
            this.buttonCmdsCustom3.Name = "buttonCmdsCustom3";
            this.buttonCmdsCustom3.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsCustom3.TabIndex = 42;
            this.buttonCmdsCustom3.Text = "Custom3";
            this.buttonCmdsCustom3.UseVisualStyleBackColor = true;
            this.buttonCmdsCustom3.Click += new System.EventHandler(this.buttonCmdsCustom3_Click);
            // 
            // buttonCmdsCustom2
            // 
            this.buttonCmdsCustom2.Location = new System.Drawing.Point(123, 20);
            this.buttonCmdsCustom2.Name = "buttonCmdsCustom2";
            this.buttonCmdsCustom2.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsCustom2.TabIndex = 41;
            this.buttonCmdsCustom2.Text = "Custom2";
            this.buttonCmdsCustom2.UseVisualStyleBackColor = true;
            this.buttonCmdsCustom2.Click += new System.EventHandler(this.buttonCmdsCustom2_Click);
            // 
            // buttonCmdsCustom1
            // 
            this.buttonCmdsCustom1.Location = new System.Drawing.Point(7, 20);
            this.buttonCmdsCustom1.Name = "buttonCmdsCustom1";
            this.buttonCmdsCustom1.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsCustom1.TabIndex = 40;
            this.buttonCmdsCustom1.Text = "Custom1";
            this.buttonCmdsCustom1.UseVisualStyleBackColor = true;
            this.buttonCmdsCustom1.Click += new System.EventHandler(this.buttonCmdsCustom1_Click);
            // 
            // groupBoxStdCmd
            // 
            this.groupBoxStdCmd.Controls.Add(this.button12);
            this.groupBoxStdCmd.Controls.Add(this.buttonCmdsGetPoolData);
            this.groupBoxStdCmd.Controls.Add(this.buttonCmdsClearScreenShot);
            this.groupBoxStdCmd.Controls.Add(this.buttonCmdsRestartComputer);
            this.groupBoxStdCmd.Controls.Add(this.buttonCmdsScreenShot);
            this.groupBoxStdCmd.Controls.Add(this.buttonCmdsStartComputer);
            this.groupBoxStdCmd.Controls.Add(this.buttonCmdsStopComputer);
            this.groupBoxStdCmd.Controls.Add(this.buttonCmdsTestService);
            this.groupBoxStdCmd.Location = new System.Drawing.Point(6, 3);
            this.groupBoxStdCmd.Name = "groupBoxStdCmd";
            this.groupBoxStdCmd.Size = new System.Drawing.Size(240, 134);
            this.groupBoxStdCmd.TabIndex = 30;
            this.groupBoxStdCmd.TabStop = false;
            this.groupBoxStdCmd.Text = "Standard Commands";
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(124, 46);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(110, 23);
            this.button12.TabIndex = 34;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // buttonCmdsGetPoolData
            // 
            this.buttonCmdsGetPoolData.Location = new System.Drawing.Point(121, 104);
            this.buttonCmdsGetPoolData.Name = "buttonCmdsGetPoolData";
            this.buttonCmdsGetPoolData.Size = new System.Drawing.Size(110, 23);
            this.buttonCmdsGetPoolData.TabIndex = 38;
            this.buttonCmdsGetPoolData.Text = "Get-PoolData";
            this.buttonCmdsGetPoolData.UseVisualStyleBackColor = true;
            this.buttonCmdsGetPoolData.Click += new System.EventHandler(this.buttonCmdsGetPoolData_Click);
            // 
            // buttonCmdsClearScreenShot
            // 
            this.buttonCmdsClearScreenShot.Location = new System.Drawing.Point(122, 75);
            this.buttonCmdsClearScreenShot.Name = "buttonCmdsClearScreenShot";
            this.buttonCmdsClearScreenShot.Size = new System.Drawing.Size(110, 23);
            this.buttonCmdsClearScreenShot.TabIndex = 36;
            this.buttonCmdsClearScreenShot.Text = "Clear-ScreenShot";
            this.buttonCmdsClearScreenShot.UseVisualStyleBackColor = true;
            this.buttonCmdsClearScreenShot.Click += new System.EventHandler(this.buttonCmdsClearScreenShot_Click);
            // 
            // buttonCmdsRestartComputer
            // 
            this.buttonCmdsRestartComputer.Location = new System.Drawing.Point(6, 46);
            this.buttonCmdsRestartComputer.Name = "buttonCmdsRestartComputer";
            this.buttonCmdsRestartComputer.Size = new System.Drawing.Size(110, 23);
            this.buttonCmdsRestartComputer.TabIndex = 33;
            this.buttonCmdsRestartComputer.Text = "Restart-Computer";
            this.buttonCmdsRestartComputer.UseVisualStyleBackColor = true;
            this.buttonCmdsRestartComputer.Click += new System.EventHandler(this.buttonCmdsRestartComputer_Click);
            // 
            // buttonCmdsScreenShot
            // 
            this.buttonCmdsScreenShot.Location = new System.Drawing.Point(6, 75);
            this.buttonCmdsScreenShot.Name = "buttonCmdsScreenShot";
            this.buttonCmdsScreenShot.Size = new System.Drawing.Size(110, 23);
            this.buttonCmdsScreenShot.TabIndex = 35;
            this.buttonCmdsScreenShot.Text = "Show-ScreenShot";
            this.buttonCmdsScreenShot.UseVisualStyleBackColor = true;
            this.buttonCmdsScreenShot.Click += new System.EventHandler(this.buttonCmdsScreenShot_Click);
            // 
            // buttonCmdsStartComputer
            // 
            this.buttonCmdsStartComputer.Location = new System.Drawing.Point(6, 19);
            this.buttonCmdsStartComputer.Name = "buttonCmdsStartComputer";
            this.buttonCmdsStartComputer.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsStartComputer.TabIndex = 31;
            this.buttonCmdsStartComputer.Text = "Start-Computer";
            this.buttonCmdsStartComputer.UseVisualStyleBackColor = true;
            this.buttonCmdsStartComputer.Click += new System.EventHandler(this.buttonCmdsStartComputer_Click);
            // 
            // buttonCmdsStopComputer
            // 
            this.buttonCmdsStopComputer.Location = new System.Drawing.Point(124, 19);
            this.buttonCmdsStopComputer.Name = "buttonCmdsStopComputer";
            this.buttonCmdsStopComputer.Size = new System.Drawing.Size(110, 23);
            this.buttonCmdsStopComputer.TabIndex = 32;
            this.buttonCmdsStopComputer.Text = "Stop-Computer";
            this.buttonCmdsStopComputer.UseVisualStyleBackColor = true;
            this.buttonCmdsStopComputer.Click += new System.EventHandler(this.buttonCmdsStopComputer_Click);
            // 
            // buttonCmdsTestService
            // 
            this.buttonCmdsTestService.Location = new System.Drawing.Point(7, 104);
            this.buttonCmdsTestService.Name = "buttonCmdsTestService";
            this.buttonCmdsTestService.Size = new System.Drawing.Size(110, 23);
            this.buttonCmdsTestService.TabIndex = 37;
            this.buttonCmdsTestService.Text = "Test-Service";
            this.buttonCmdsTestService.UseVisualStyleBackColor = true;
            this.buttonCmdsTestService.Click += new System.EventHandler(this.buttonCmdsTestService_Click);
            // 
            // groupBoxNotify
            // 
            this.groupBoxNotify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNotify.Controls.Add(this.label10);
            this.groupBoxNotify.Controls.Add(this.textBoxNotifyDisplayTime);
            this.groupBoxNotify.Controls.Add(this.label11);
            this.groupBoxNotify.Controls.Add(this.textBoxNotifyText);
            this.groupBoxNotify.Controls.Add(this.buttonCmdsSendNotify);
            this.groupBoxNotify.Location = new System.Drawing.Point(259, 160);
            this.groupBoxNotify.Name = "groupBoxNotify";
            this.groupBoxNotify.Size = new System.Drawing.Size(380, 92);
            this.groupBoxNotify.TabIndex = 61;
            this.groupBoxNotify.TabStop = false;
            this.groupBoxNotify.Text = "Notification";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "seconds";
            // 
            // textBoxNotifyDisplayTime
            // 
            this.textBoxNotifyDisplayTime.Location = new System.Drawing.Point(142, 64);
            this.textBoxNotifyDisplayTime.Name = "textBoxNotifyDisplayTime";
            this.textBoxNotifyDisplayTime.Size = new System.Drawing.Size(37, 20);
            this.textBoxNotifyDisplayTime.TabIndex = 64;
            this.textBoxNotifyDisplayTime.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "for";
            // 
            // textBoxNotifyText
            // 
            this.textBoxNotifyText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNotifyText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "NotificationText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxNotifyText.Location = new System.Drawing.Point(6, 19);
            this.textBoxNotifyText.Multiline = true;
            this.textBoxNotifyText.Name = "textBoxNotifyText";
            this.textBoxNotifyText.Size = new System.Drawing.Size(362, 37);
            this.textBoxNotifyText.TabIndex = 62;
            this.textBoxNotifyText.Text = global::Launcher.Properties.Settings.Default.NotificationText;
            // 
            // buttonCmdsSendNotify
            // 
            this.buttonCmdsSendNotify.Location = new System.Drawing.Point(6, 61);
            this.buttonCmdsSendNotify.Name = "buttonCmdsSendNotify";
            this.buttonCmdsSendNotify.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsSendNotify.TabIndex = 63;
            this.buttonCmdsSendNotify.Text = "Send-Notify";
            this.buttonCmdsSendNotify.UseVisualStyleBackColor = true;
            this.buttonCmdsSendNotify.Click += new System.EventHandler(this.buttonCmdsSendNotify_Click);
            // 
            // groupBoxBrowser
            // 
            this.groupBoxBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBrowser.Controls.Add(this.label8);
            this.groupBoxBrowser.Controls.Add(this.textBoxBrowserDisplayTime);
            this.groupBoxBrowser.Controls.Add(this.label9);
            this.groupBoxBrowser.Controls.Add(this.buttonCmdsSendBrowser);
            this.groupBoxBrowser.Controls.Add(this.textBoxUrl);
            this.groupBoxBrowser.Controls.Add(this.buttonCmdsHideBrowser);
            this.groupBoxBrowser.Controls.Add(this.buttonCmdsShowBrowser);
            this.groupBoxBrowser.Location = new System.Drawing.Point(259, 3);
            this.groupBoxBrowser.Name = "groupBoxBrowser";
            this.groupBoxBrowser.Size = new System.Drawing.Size(380, 151);
            this.groupBoxBrowser.TabIndex = 55;
            this.groupBoxBrowser.TabStop = false;
            this.groupBoxBrowser.Text = "Browser";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "seconds";
            // 
            // textBoxBrowserDisplayTime
            // 
            this.textBoxBrowserDisplayTime.Location = new System.Drawing.Point(141, 111);
            this.textBoxBrowserDisplayTime.Name = "textBoxBrowserDisplayTime";
            this.textBoxBrowserDisplayTime.Size = new System.Drawing.Size(30, 20);
            this.textBoxBrowserDisplayTime.TabIndex = 60;
            this.textBoxBrowserDisplayTime.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "for";
            // 
            // buttonCmdsSendBrowser
            // 
            this.buttonCmdsSendBrowser.Location = new System.Drawing.Point(6, 109);
            this.buttonCmdsSendBrowser.Name = "buttonCmdsSendBrowser";
            this.buttonCmdsSendBrowser.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsSendBrowser.TabIndex = 59;
            this.buttonCmdsSendBrowser.Text = "Send-Browser";
            this.buttonCmdsSendBrowser.UseVisualStyleBackColor = true;
            this.buttonCmdsSendBrowser.Click += new System.EventHandler(this.buttonCmdsSendBrowser_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "BrowserUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxUrl.Location = new System.Drawing.Point(6, 19);
            this.textBoxUrl.Multiline = true;
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(366, 54);
            this.textBoxUrl.TabIndex = 56;
            this.textBoxUrl.Text = global::Launcher.Properties.Settings.Default.BrowserUrl;
            // 
            // buttonCmdsHideBrowser
            // 
            this.buttonCmdsHideBrowser.Location = new System.Drawing.Point(121, 79);
            this.buttonCmdsHideBrowser.Name = "buttonCmdsHideBrowser";
            this.buttonCmdsHideBrowser.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsHideBrowser.TabIndex = 58;
            this.buttonCmdsHideBrowser.Text = "Hide-Browser";
            this.buttonCmdsHideBrowser.UseVisualStyleBackColor = true;
            this.buttonCmdsHideBrowser.Click += new System.EventHandler(this.buttonCmdsHideBrowser_Click);
            // 
            // buttonCmdsShowBrowser
            // 
            this.buttonCmdsShowBrowser.Location = new System.Drawing.Point(6, 79);
            this.buttonCmdsShowBrowser.Name = "buttonCmdsShowBrowser";
            this.buttonCmdsShowBrowser.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsShowBrowser.TabIndex = 57;
            this.buttonCmdsShowBrowser.Text = "Show-Browser";
            this.buttonCmdsShowBrowser.UseVisualStyleBackColor = true;
            this.buttonCmdsShowBrowser.Click += new System.EventHandler(this.buttonCmdsShowBrowser_Click);
            // 
            // groupBoxWait
            // 
            this.groupBoxWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWait.Controls.Add(this.label7);
            this.groupBoxWait.Controls.Add(this.textBoxWaitDisplayTime);
            this.groupBoxWait.Controls.Add(this.label6);
            this.groupBoxWait.Controls.Add(this.buttonCmdsSendWaitForm);
            this.groupBoxWait.Controls.Add(this.buttonCmdsHideWaitForm);
            this.groupBoxWait.Controls.Add(this.buttonCmdsShowWaitForm);
            this.groupBoxWait.Controls.Add(this.textBoxWaitText);
            this.groupBoxWait.Location = new System.Drawing.Point(259, 258);
            this.groupBoxWait.Name = "groupBoxWait";
            this.groupBoxWait.Size = new System.Drawing.Size(380, 137);
            this.groupBoxWait.TabIndex = 65;
            this.groupBoxWait.TabStop = false;
            this.groupBoxWait.Text = "WaitForm";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "seconds";
            // 
            // textBoxWaitDisplayTime
            // 
            this.textBoxWaitDisplayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxWaitDisplayTime.Location = new System.Drawing.Point(147, 101);
            this.textBoxWaitDisplayTime.Name = "textBoxWaitDisplayTime";
            this.textBoxWaitDisplayTime.Size = new System.Drawing.Size(30, 20);
            this.textBoxWaitDisplayTime.TabIndex = 70;
            this.textBoxWaitDisplayTime.Text = "5";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "for";
            // 
            // buttonCmdsSendWaitForm
            // 
            this.buttonCmdsSendWaitForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCmdsSendWaitForm.Location = new System.Drawing.Point(6, 99);
            this.buttonCmdsSendWaitForm.Name = "buttonCmdsSendWaitForm";
            this.buttonCmdsSendWaitForm.Size = new System.Drawing.Size(110, 23);
            this.buttonCmdsSendWaitForm.TabIndex = 69;
            this.buttonCmdsSendWaitForm.Text = "Send-WaitForm";
            this.buttonCmdsSendWaitForm.UseVisualStyleBackColor = true;
            this.buttonCmdsSendWaitForm.Click += new System.EventHandler(this.buttonCmdsSendWaitForm_Click);
            // 
            // buttonCmdsHideWaitForm
            // 
            this.buttonCmdsHideWaitForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCmdsHideWaitForm.Location = new System.Drawing.Point(121, 68);
            this.buttonCmdsHideWaitForm.Name = "buttonCmdsHideWaitForm";
            this.buttonCmdsHideWaitForm.Size = new System.Drawing.Size(109, 23);
            this.buttonCmdsHideWaitForm.TabIndex = 68;
            this.buttonCmdsHideWaitForm.Text = "Hide-WaitForm";
            this.buttonCmdsHideWaitForm.UseVisualStyleBackColor = true;
            this.buttonCmdsHideWaitForm.Click += new System.EventHandler(this.buttonCmdsHideWaitForm_Click);
            // 
            // buttonCmdsShowWaitForm
            // 
            this.buttonCmdsShowWaitForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCmdsShowWaitForm.Location = new System.Drawing.Point(6, 68);
            this.buttonCmdsShowWaitForm.Name = "buttonCmdsShowWaitForm";
            this.buttonCmdsShowWaitForm.Size = new System.Drawing.Size(110, 23);
            this.buttonCmdsShowWaitForm.TabIndex = 67;
            this.buttonCmdsShowWaitForm.Text = "Show-WaitForm";
            this.buttonCmdsShowWaitForm.UseVisualStyleBackColor = true;
            this.buttonCmdsShowWaitForm.Click += new System.EventHandler(this.buttonCmdsShowWaitForm_Click);
            // 
            // textBoxWaitText
            // 
            this.textBoxWaitText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWaitText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "WaitFormText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxWaitText.Location = new System.Drawing.Point(6, 17);
            this.textBoxWaitText.Multiline = true;
            this.textBoxWaitText.Name = "textBoxWaitText";
            this.textBoxWaitText.Size = new System.Drawing.Size(362, 45);
            this.textBoxWaitText.TabIndex = 66;
            this.textBoxWaitText.Text = global::Launcher.Properties.Settings.Default.WaitFormText;
            // 
            // tabPageFilters
            // 
            this.tabPageFilters.Controls.Add(this.groupBoxAuth);
            this.tabPageFilters.Controls.Add(this.groupBoxFilters);
            this.tabPageFilters.Location = new System.Drawing.Point(4, 25);
            this.tabPageFilters.Name = "tabPageFilters";
            this.tabPageFilters.Size = new System.Drawing.Size(650, 411);
            this.tabPageFilters.TabIndex = 5;
            this.tabPageFilters.Text = "Filters";
            this.tabPageFilters.UseVisualStyleBackColor = true;
            // 
            // groupBoxAuth
            // 
            this.groupBoxAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAuth.Controls.Add(this.buttonCmdsAuthGet);
            this.groupBoxAuth.Controls.Add(this.buttonCmdsAuthHide);
            this.groupBoxAuth.Controls.Add(this.buttonCmdsAuthShow);
            this.groupBoxAuth.Controls.Add(this.buttonCmdsAuthSet);
            this.groupBoxAuth.Controls.Add(this.label14);
            this.groupBoxAuth.Controls.Add(this.comboBoxAuthType);
            this.groupBoxAuth.Controls.Add(this.label13);
            this.groupBoxAuth.Controls.Add(this.label12);
            this.groupBoxAuth.Controls.Add(this.textBoxAuthPostScript);
            this.groupBoxAuth.Controls.Add(this.textBoxAuthTokens);
            this.groupBoxAuth.Controls.Add(this.buttonAuthTokenFile);
            this.groupBoxAuth.Enabled = false;
            this.groupBoxAuth.Location = new System.Drawing.Point(249, 3);
            this.groupBoxAuth.Name = "groupBoxAuth";
            this.groupBoxAuth.Size = new System.Drawing.Size(397, 405);
            this.groupBoxAuth.TabIndex = 98;
            this.groupBoxAuth.TabStop = false;
            this.groupBoxAuth.Text = "Authentication";
            // 
            // buttonCmdsAuthGet
            // 
            this.buttonCmdsAuthGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCmdsAuthGet.Location = new System.Drawing.Point(108, 368);
            this.buttonCmdsAuthGet.Name = "buttonCmdsAuthGet";
            this.buttonCmdsAuthGet.Size = new System.Drawing.Size(90, 23);
            this.buttonCmdsAuthGet.TabIndex = 104;
            this.buttonCmdsAuthGet.Text = "Get-AuthData";
            this.buttonCmdsAuthGet.UseVisualStyleBackColor = true;
            this.buttonCmdsAuthGet.Click += new System.EventHandler(this.buttonCmdsAuthGet_Click);
            // 
            // buttonCmdsAuthHide
            // 
            this.buttonCmdsAuthHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCmdsAuthHide.Location = new System.Drawing.Point(300, 368);
            this.buttonCmdsAuthHide.Name = "buttonCmdsAuthHide";
            this.buttonCmdsAuthHide.Size = new System.Drawing.Size(90, 23);
            this.buttonCmdsAuthHide.TabIndex = 106;
            this.buttonCmdsAuthHide.Text = "Hide-AuthForm";
            this.buttonCmdsAuthHide.UseVisualStyleBackColor = true;
            this.buttonCmdsAuthHide.Click += new System.EventHandler(this.buttonCmdsAuthHide_Click);
            // 
            // buttonCmdsAuthShow
            // 
            this.buttonCmdsAuthShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCmdsAuthShow.Location = new System.Drawing.Point(204, 368);
            this.buttonCmdsAuthShow.Name = "buttonCmdsAuthShow";
            this.buttonCmdsAuthShow.Size = new System.Drawing.Size(90, 23);
            this.buttonCmdsAuthShow.TabIndex = 105;
            this.buttonCmdsAuthShow.Text = "Show-AuthForm";
            this.buttonCmdsAuthShow.UseVisualStyleBackColor = true;
            this.buttonCmdsAuthShow.Click += new System.EventHandler(this.buttonCmdsAuthShow_Click);
            // 
            // buttonCmdsAuthSet
            // 
            this.buttonCmdsAuthSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCmdsAuthSet.Location = new System.Drawing.Point(12, 368);
            this.buttonCmdsAuthSet.Name = "buttonCmdsAuthSet";
            this.buttonCmdsAuthSet.Size = new System.Drawing.Size(90, 23);
            this.buttonCmdsAuthSet.TabIndex = 103;
            this.buttonCmdsAuthSet.Text = "Set-AuthData";
            this.buttonCmdsAuthSet.UseVisualStyleBackColor = true;
            this.buttonCmdsAuthSet.Click += new System.EventHandler(this.buttonCmdsAuthSet_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Authentication Type";
            // 
            // comboBoxAuthType
            // 
            this.comboBoxAuthType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthType.FormattingEnabled = true;
            this.comboBoxAuthType.Items.AddRange(new object[] {
            "1 : Token Based Security"});
            this.comboBoxAuthType.Location = new System.Drawing.Point(9, 49);
            this.comboBoxAuthType.Name = "comboBoxAuthType";
            this.comboBoxAuthType.Size = new System.Drawing.Size(379, 21);
            this.comboBoxAuthType.TabIndex = 99;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Authentication Tokens";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Post Authentication Script";
            // 
            // textBoxAuthPostScript
            // 
            this.textBoxAuthPostScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthPostScript.Location = new System.Drawing.Point(12, 310);
            this.textBoxAuthPostScript.Multiline = true;
            this.textBoxAuthPostScript.Name = "textBoxAuthPostScript";
            this.textBoxAuthPostScript.Size = new System.Drawing.Size(376, 52);
            this.textBoxAuthPostScript.TabIndex = 102;
            this.textBoxAuthPostScript.Text = "Start-Zleaf $server $name";
            // 
            // textBoxAuthTokens
            // 
            this.textBoxAuthTokens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthTokens.Location = new System.Drawing.Point(12, 105);
            this.textBoxAuthTokens.Multiline = true;
            this.textBoxAuthTokens.Name = "textBoxAuthTokens";
            this.textBoxAuthTokens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAuthTokens.Size = new System.Drawing.Size(376, 141);
            this.textBoxAuthTokens.TabIndex = 100;
            // 
            // buttonAuthTokenFile
            // 
            this.buttonAuthTokenFile.Location = new System.Drawing.Point(12, 252);
            this.buttonAuthTokenFile.Name = "buttonAuthTokenFile";
            this.buttonAuthTokenFile.Size = new System.Drawing.Size(72, 23);
            this.buttonAuthTokenFile.TabIndex = 101;
            this.buttonAuthTokenFile.Text = "Load";
            this.buttonAuthTokenFile.UseVisualStyleBackColor = true;
            this.buttonAuthTokenFile.Click += new System.EventHandler(this.buttonAuthTokenFile_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxFilters.Controls.Add(this.button10);
            this.groupBoxFilters.Controls.Add(this.button9);
            this.groupBoxFilters.Controls.Add(this.button8);
            this.groupBoxFilters.Controls.Add(this.button7);
            this.groupBoxFilters.Controls.Add(this.button6);
            this.groupBoxFilters.Controls.Add(this.button5);
            this.groupBoxFilters.Controls.Add(this.button4);
            this.groupBoxFilters.Controls.Add(this.button3);
            this.groupBoxFilters.Controls.Add(this.button2);
            this.groupBoxFilters.Controls.Add(this.button1);
            this.groupBoxFilters.Controls.Add(this.buttonDisableLauncher);
            this.groupBoxFilters.Controls.Add(this.buttonEnableLauncher);
            this.groupBoxFilters.Controls.Add(this.buttonDisableUsb);
            this.groupBoxFilters.Controls.Add(this.buttonEnableUsb);
            this.groupBoxFilters.Controls.Add(this.buttonDisableHeadset);
            this.groupBoxFilters.Controls.Add(this.buttonEnableHeadset);
            this.groupBoxFilters.Controls.Add(this.buttonDisableWebcam);
            this.groupBoxFilters.Controls.Add(this.buttonEnableWebcam);
            this.groupBoxFilters.Controls.Add(this.buttonDisableKiosk);
            this.groupBoxFilters.Controls.Add(this.buttonEnableKiosk);
            this.groupBoxFilters.Controls.Add(this.buttonEnableScreen);
            this.groupBoxFilters.Controls.Add(this.buttonDisableScreen);
            this.groupBoxFilters.Controls.Add(this.buttonKeyboard);
            this.groupBoxFilters.Controls.Add(this.buttonDisableMouse);
            this.groupBoxFilters.Controls.Add(this.buttonEnableMouse);
            this.groupBoxFilters.Controls.Add(this.buttonDisableKeyboard);
            this.groupBoxFilters.Enabled = false;
            this.groupBoxFilters.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(240, 405);
            this.groupBoxFilters.TabIndex = 71;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Devices Filters";
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(122, 368);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(110, 23);
            this.button10.TabIndex = 97;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(6, 368);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 23);
            this.button9.TabIndex = 96;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(122, 339);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 23);
            this.button8.TabIndex = 95;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(6, 339);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 23);
            this.button7.TabIndex = 94;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(121, 310);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 23);
            this.button6.TabIndex = 93;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(6, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 92;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(120, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 91;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(5, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 90;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(120, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 83;
            this.button2.Text = "Disable-Speakers";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(5, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = "Enable-Speakers";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonDisableLauncher
            // 
            this.buttonDisableLauncher.Location = new System.Drawing.Point(122, 20);
            this.buttonDisableLauncher.Name = "buttonDisableLauncher";
            this.buttonDisableLauncher.Size = new System.Drawing.Size(109, 23);
            this.buttonDisableLauncher.TabIndex = 73;
            this.buttonDisableLauncher.Text = "Disable-Launcher";
            this.buttonDisableLauncher.UseVisualStyleBackColor = true;
            this.buttonDisableLauncher.Click += new System.EventHandler(this.buttonDisableLauncher_Click);
            // 
            // buttonEnableLauncher
            // 
            this.buttonEnableLauncher.Location = new System.Drawing.Point(6, 20);
            this.buttonEnableLauncher.Name = "buttonEnableLauncher";
            this.buttonEnableLauncher.Size = new System.Drawing.Size(110, 23);
            this.buttonEnableLauncher.TabIndex = 72;
            this.buttonEnableLauncher.Text = "Enable-Launcher";
            this.buttonEnableLauncher.UseVisualStyleBackColor = true;
            this.buttonEnableLauncher.Click += new System.EventHandler(this.buttonEnableLauncher_Click);
            // 
            // buttonDisableUsb
            // 
            this.buttonDisableUsb.Enabled = false;
            this.buttonDisableUsb.Location = new System.Drawing.Point(122, 253);
            this.buttonDisableUsb.Name = "buttonDisableUsb";
            this.buttonDisableUsb.Size = new System.Drawing.Size(109, 23);
            this.buttonDisableUsb.TabIndex = 89;
            this.buttonDisableUsb.Text = "Disable-Usb";
            this.buttonDisableUsb.UseVisualStyleBackColor = true;
            this.buttonDisableUsb.Click += new System.EventHandler(this.buttonDisableUsb_Click);
            // 
            // buttonEnableUsb
            // 
            this.buttonEnableUsb.Enabled = false;
            this.buttonEnableUsb.Location = new System.Drawing.Point(6, 253);
            this.buttonEnableUsb.Name = "buttonEnableUsb";
            this.buttonEnableUsb.Size = new System.Drawing.Size(110, 23);
            this.buttonEnableUsb.TabIndex = 88;
            this.buttonEnableUsb.Text = "Enable-Usb";
            this.buttonEnableUsb.UseVisualStyleBackColor = true;
            this.buttonEnableUsb.Click += new System.EventHandler(this.buttonEnableUsb_Click);
            // 
            // buttonDisableHeadset
            // 
            this.buttonDisableHeadset.Enabled = false;
            this.buttonDisableHeadset.Location = new System.Drawing.Point(122, 224);
            this.buttonDisableHeadset.Name = "buttonDisableHeadset";
            this.buttonDisableHeadset.Size = new System.Drawing.Size(109, 23);
            this.buttonDisableHeadset.TabIndex = 87;
            this.buttonDisableHeadset.Text = "Disable-Headset";
            this.buttonDisableHeadset.UseVisualStyleBackColor = true;
            this.buttonDisableHeadset.Click += new System.EventHandler(this.buttonDisableHeadset_Click);
            // 
            // buttonEnableHeadset
            // 
            this.buttonEnableHeadset.Enabled = false;
            this.buttonEnableHeadset.Location = new System.Drawing.Point(6, 224);
            this.buttonEnableHeadset.Name = "buttonEnableHeadset";
            this.buttonEnableHeadset.Size = new System.Drawing.Size(110, 23);
            this.buttonEnableHeadset.TabIndex = 86;
            this.buttonEnableHeadset.Text = "Enable-Headset";
            this.buttonEnableHeadset.UseVisualStyleBackColor = true;
            this.buttonEnableHeadset.Click += new System.EventHandler(this.buttonEnableHeadset_Click);
            // 
            // buttonDisableWebcam
            // 
            this.buttonDisableWebcam.Enabled = false;
            this.buttonDisableWebcam.Location = new System.Drawing.Point(122, 195);
            this.buttonDisableWebcam.Name = "buttonDisableWebcam";
            this.buttonDisableWebcam.Size = new System.Drawing.Size(109, 23);
            this.buttonDisableWebcam.TabIndex = 85;
            this.buttonDisableWebcam.Text = "Disable-Webcam";
            this.buttonDisableWebcam.UseVisualStyleBackColor = true;
            this.buttonDisableWebcam.Click += new System.EventHandler(this.buttonDisableWebcam_Click);
            // 
            // buttonEnableWebcam
            // 
            this.buttonEnableWebcam.Enabled = false;
            this.buttonEnableWebcam.Location = new System.Drawing.Point(6, 195);
            this.buttonEnableWebcam.Name = "buttonEnableWebcam";
            this.buttonEnableWebcam.Size = new System.Drawing.Size(110, 23);
            this.buttonEnableWebcam.TabIndex = 84;
            this.buttonEnableWebcam.Text = "Enable-Webcam";
            this.buttonEnableWebcam.UseVisualStyleBackColor = true;
            this.buttonEnableWebcam.Click += new System.EventHandler(this.buttonEnableWebcam_Click);
            // 
            // buttonDisableKiosk
            // 
            this.buttonDisableKiosk.Location = new System.Drawing.Point(122, 49);
            this.buttonDisableKiosk.Name = "buttonDisableKiosk";
            this.buttonDisableKiosk.Size = new System.Drawing.Size(110, 23);
            this.buttonDisableKiosk.TabIndex = 75;
            this.buttonDisableKiosk.Text = "Disable-KioskFilter";
            this.buttonDisableKiosk.UseVisualStyleBackColor = true;
            this.buttonDisableKiosk.Click += new System.EventHandler(this.buttonDisableKiosk_Click);
            // 
            // buttonEnableKiosk
            // 
            this.buttonEnableKiosk.Location = new System.Drawing.Point(6, 49);
            this.buttonEnableKiosk.Name = "buttonEnableKiosk";
            this.buttonEnableKiosk.Size = new System.Drawing.Size(109, 23);
            this.buttonEnableKiosk.TabIndex = 74;
            this.buttonEnableKiosk.Text = "Enable-KioskFilter";
            this.buttonEnableKiosk.UseVisualStyleBackColor = true;
            this.buttonEnableKiosk.Click += new System.EventHandler(this.buttonEnableKiosk_Click);
            // 
            // buttonEnableScreen
            // 
            this.buttonEnableScreen.Location = new System.Drawing.Point(6, 78);
            this.buttonEnableScreen.Name = "buttonEnableScreen";
            this.buttonEnableScreen.Size = new System.Drawing.Size(110, 23);
            this.buttonEnableScreen.TabIndex = 76;
            this.buttonEnableScreen.Text = "Enable-Screen";
            this.buttonEnableScreen.UseVisualStyleBackColor = true;
            this.buttonEnableScreen.Click += new System.EventHandler(this.buttonEnableScreen_Click);
            // 
            // buttonDisableScreen
            // 
            this.buttonDisableScreen.Location = new System.Drawing.Point(122, 78);
            this.buttonDisableScreen.Name = "buttonDisableScreen";
            this.buttonDisableScreen.Size = new System.Drawing.Size(110, 23);
            this.buttonDisableScreen.TabIndex = 77;
            this.buttonDisableScreen.Text = "Disable-Screen";
            this.buttonDisableScreen.UseVisualStyleBackColor = true;
            this.buttonDisableScreen.Click += new System.EventHandler(this.buttonDisableScreen_Click);
            // 
            // buttonKeyboard
            // 
            this.buttonKeyboard.Location = new System.Drawing.Point(6, 107);
            this.buttonKeyboard.Name = "buttonKeyboard";
            this.buttonKeyboard.Size = new System.Drawing.Size(110, 23);
            this.buttonKeyboard.TabIndex = 78;
            this.buttonKeyboard.Text = "Enable-Keyboard";
            this.buttonKeyboard.UseVisualStyleBackColor = true;
            this.buttonKeyboard.Click += new System.EventHandler(this.buttonKeyboard_Click);
            // 
            // buttonDisableMouse
            // 
            this.buttonDisableMouse.Location = new System.Drawing.Point(122, 136);
            this.buttonDisableMouse.Name = "buttonDisableMouse";
            this.buttonDisableMouse.Size = new System.Drawing.Size(109, 23);
            this.buttonDisableMouse.TabIndex = 81;
            this.buttonDisableMouse.Text = "Disable-Mouse";
            this.buttonDisableMouse.UseVisualStyleBackColor = true;
            this.buttonDisableMouse.Click += new System.EventHandler(this.buttonDisableMouse_Click);
            // 
            // buttonEnableMouse
            // 
            this.buttonEnableMouse.Location = new System.Drawing.Point(6, 136);
            this.buttonEnableMouse.Name = "buttonEnableMouse";
            this.buttonEnableMouse.Size = new System.Drawing.Size(110, 23);
            this.buttonEnableMouse.TabIndex = 80;
            this.buttonEnableMouse.Text = "Enable-Mouse";
            this.buttonEnableMouse.UseVisualStyleBackColor = true;
            this.buttonEnableMouse.Click += new System.EventHandler(this.buttonEnableMouse_Click);
            // 
            // buttonDisableKeyboard
            // 
            this.buttonDisableKeyboard.Location = new System.Drawing.Point(122, 107);
            this.buttonDisableKeyboard.Name = "buttonDisableKeyboard";
            this.buttonDisableKeyboard.Size = new System.Drawing.Size(110, 23);
            this.buttonDisableKeyboard.TabIndex = 79;
            this.buttonDisableKeyboard.Text = "Disable-Keyboard";
            this.buttonDisableKeyboard.UseVisualStyleBackColor = true;
            this.buttonDisableKeyboard.Click += new System.EventHandler(this.buttonDisableKeyboard_Click);
            // 
            // tabPageScripts
            // 
            this.tabPageScripts.Controls.Add(this.splitContainer1);
            this.tabPageScripts.Location = new System.Drawing.Point(4, 25);
            this.tabPageScripts.Name = "tabPageScripts";
            this.tabPageScripts.Size = new System.Drawing.Size(650, 411);
            this.tabPageScripts.TabIndex = 4;
            this.tabPageScripts.Text = "Scripts";
            this.tabPageScripts.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxScriptBlock);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonCmdsLoadScriptBlock);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCmdsSendScriptBlock);
            this.splitContainer1.Size = new System.Drawing.Size(650, 411);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 34;
            this.splitContainer1.TabStop = false;
            // 
            // textBoxScriptBlock
            // 
            this.textBoxScriptBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxScriptBlock.Location = new System.Drawing.Point(0, 0);
            this.textBoxScriptBlock.Multiline = true;
            this.textBoxScriptBlock.Name = "textBoxScriptBlock";
            this.textBoxScriptBlock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxScriptBlock.Size = new System.Drawing.Size(650, 375);
            this.textBoxScriptBlock.TabIndex = 107;
            this.textBoxScriptBlock.Text = "# Enter your scripts here, e.g.\r\n$a = 1\r\n$b = 2\r\n$c = 3\r\n$a + $b + $c";
            // 
            // buttonCmdsLoadScriptBlock
            // 
            this.buttonCmdsLoadScriptBlock.Location = new System.Drawing.Point(119, 3);
            this.buttonCmdsLoadScriptBlock.Name = "buttonCmdsLoadScriptBlock";
            this.buttonCmdsLoadScriptBlock.Size = new System.Drawing.Size(110, 23);
            this.buttonCmdsLoadScriptBlock.TabIndex = 109;
            this.buttonCmdsLoadScriptBlock.Text = "Load-Script";
            this.buttonCmdsLoadScriptBlock.UseVisualStyleBackColor = true;
            this.buttonCmdsLoadScriptBlock.Click += new System.EventHandler(this.buttonCmdsLoadScriptBlock_Click);
            // 
            // buttonCmdsSendScriptBlock
            // 
            this.buttonCmdsSendScriptBlock.Location = new System.Drawing.Point(3, 3);
            this.buttonCmdsSendScriptBlock.Name = "buttonCmdsSendScriptBlock";
            this.buttonCmdsSendScriptBlock.Size = new System.Drawing.Size(110, 23);
            this.buttonCmdsSendScriptBlock.TabIndex = 108;
            this.buttonCmdsSendScriptBlock.Text = "Send-Script";
            this.buttonCmdsSendScriptBlock.UseVisualStyleBackColor = true;
            this.buttonCmdsSendScriptBlock.Click += new System.EventHandler(this.buttonCmdsSendScriptBlock_Click);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.label5);
            this.tabPageSettings.Controls.Add(this.textBoxWorkingDir);
            this.tabPageSettings.Controls.Add(this.label2);
            this.tabPageSettings.Controls.Add(this.label1);
            this.tabPageSettings.Controls.Add(this.buttonSaveSettings);
            this.tabPageSettings.Controls.Add(this.textBoxEndpoint);
            this.tabPageSettings.Controls.Add(this.textBoxRunspaceStartup);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(650, 411);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "Working Directory";
            // 
            // textBoxWorkingDir
            // 
            this.textBoxWorkingDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorkingDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "WorkingDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxWorkingDir.Location = new System.Drawing.Point(12, 312);
            this.textBoxWorkingDir.Name = "textBoxWorkingDir";
            this.textBoxWorkingDir.Size = new System.Drawing.Size(634, 20);
            this.textBoxWorkingDir.TabIndex = 111;
            this.textBoxWorkingDir.Text = global::Launcher.Properties.Settings.Default.WorkingDirectory;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Endpoint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Startup Script";
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveSettings.Location = new System.Drawing.Point(12, 377);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(92, 23);
            this.buttonSaveSettings.TabIndex = 113;
            this.buttonSaveSettings.Text = "Save Settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // textBoxEndpoint
            // 
            this.textBoxEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEndpoint.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "Endpoint", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxEndpoint.Location = new System.Drawing.Point(12, 351);
            this.textBoxEndpoint.Name = "textBoxEndpoint";
            this.textBoxEndpoint.Size = new System.Drawing.Size(634, 20);
            this.textBoxEndpoint.TabIndex = 112;
            this.textBoxEndpoint.Text = global::Launcher.Properties.Settings.Default.Endpoint;
            // 
            // textBoxRunspaceStartup
            // 
            this.textBoxRunspaceStartup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRunspaceStartup.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Launcher.Properties.Settings.Default, "StartupScript", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxRunspaceStartup.Location = new System.Drawing.Point(12, 25);
            this.textBoxRunspaceStartup.Multiline = true;
            this.textBoxRunspaceStartup.Name = "textBoxRunspaceStartup";
            this.textBoxRunspaceStartup.Size = new System.Drawing.Size(634, 268);
            this.textBoxRunspaceStartup.TabIndex = 110;
            this.textBoxRunspaceStartup.Text = global::Launcher.Properties.Settings.Default.StartupScript;
            // 
            // timerRestart
            // 
            this.timerRestart.Interval = 3000;
            this.timerRestart.Tick += new System.EventHandler(this.timerRestart_Tick);
            // 
            // timerScreenEnable
            // 
            this.timerScreenEnable.Tick += new System.EventHandler(this.timerScreenEnable_Tick);
            // 
            // timerScreenDisable
            // 
            this.timerScreenDisable.Tick += new System.EventHandler(this.timerScreenDisable_Tick);
            // 
            // timerScreenShot
            // 
            this.timerScreenShot.Tick += new System.EventHandler(this.timerScreenShot_Tick);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 599);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxConsole);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LauncherForm";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripTray.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxConsole.ResumeLayout(false);
            this.groupBoxConsole.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.tabControlDetails.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.tabPageClients.ResumeLayout(false);
            this.groupBoxClientGroups.ResumeLayout(false);
            this.tabPageCommands.ResumeLayout(false);
            this.groupBoxCustomCmds.ResumeLayout(false);
            this.groupBoxCustomCmds.PerformLayout();
            this.groupBoxStdCmd.ResumeLayout(false);
            this.groupBoxNotify.ResumeLayout(false);
            this.groupBoxNotify.PerformLayout();
            this.groupBoxBrowser.ResumeLayout(false);
            this.groupBoxBrowser.PerformLayout();
            this.groupBoxWait.ResumeLayout(false);
            this.groupBoxWait.PerformLayout();
            this.tabPageFilters.ResumeLayout(false);
            this.groupBoxAuth.ResumeLayout(false);
            this.groupBoxAuth.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.tabPageScripts.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.ToolStripMenuItem tunnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTunnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLauncherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timerShutdown;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showConsoleToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tunnelToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTunnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTunnelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.GroupBox groupBoxConsole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClients;
        private System.Windows.Forms.Button buttonPool;
        private System.Windows.Forms.Button buttonInvoke;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TabControl tabControlDetails;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageCommands;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.GroupBox groupBoxClientGroups;
        private System.Windows.Forms.Button buttonClientGroup10;
        private System.Windows.Forms.Button buttonClientGroup9;
        private System.Windows.Forms.Button buttonClientGroup8;
        private System.Windows.Forms.Button buttonClientGroup7;
        private System.Windows.Forms.Button buttonClientGroup6;
        private System.Windows.Forms.Button buttonClientGroup5;
        private System.Windows.Forms.Button buttonClientGroup4;
        private System.Windows.Forms.Button buttonClientGroup3;
        private System.Windows.Forms.Button buttonClientGroup2;
        private System.Windows.Forms.Button buttonClientGroup1;
        private System.Windows.Forms.Button buttonClientsFile;
        private System.Windows.Forms.Button buttonClientsClear;
        private System.Windows.Forms.Button buttonClientsSet;
        private System.Windows.Forms.CheckedListBox checkedListBoxClients;
        private System.Windows.Forms.TabPage tabPageScripts;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxScriptBlock;
        private System.Windows.Forms.Button buttonCmdsSendScriptBlock;
        private System.Windows.Forms.GroupBox groupBoxBrowser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBrowserDisplayTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCmdsSendBrowser;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonCmdsHideBrowser;
        private System.Windows.Forms.Button buttonCmdsShowBrowser;
        private System.Windows.Forms.GroupBox groupBoxWait;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxWaitDisplayTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCmdsSendWaitForm;
        private System.Windows.Forms.Button buttonCmdsHideWaitForm;
        private System.Windows.Forms.Button buttonCmdsShowWaitForm;
        private System.Windows.Forms.TextBox textBoxWaitText;
        private System.Windows.Forms.GroupBox groupBoxStdCmd;
        private System.Windows.Forms.Button buttonCmdsClearScreenShot;
        private System.Windows.Forms.Button buttonCmdsRestartComputer;
        private System.Windows.Forms.Button buttonCmdsScreenShot;
        private System.Windows.Forms.Button buttonCmdsStartComputer;
        private System.Windows.Forms.Button buttonCmdsStopComputer;
        private System.Windows.Forms.Button buttonCmdsTestService;
        private System.Windows.Forms.GroupBox groupBoxNotify;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNotifyDisplayTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNotifyText;
        private System.Windows.Forms.Button buttonCmdsSendNotify;
        private System.Windows.Forms.TabPage tabPageFilters;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Button buttonEnableScreen;
        private System.Windows.Forms.Button buttonDisableScreen;
        private System.Windows.Forms.Button buttonKeyboard;
        private System.Windows.Forms.Button buttonDisableMouse;
        private System.Windows.Forms.Button buttonEnableMouse;
        private System.Windows.Forms.Button buttonDisableKeyboard;
        private System.Windows.Forms.Button buttonDisableKiosk;
        private System.Windows.Forms.Button buttonEnableKiosk;
        private System.Windows.Forms.Button buttonDisableWebcam;
        private System.Windows.Forms.Button buttonEnableWebcam;
        private System.Windows.Forms.Button buttonDisableUsb;
        private System.Windows.Forms.Button buttonEnableUsb;
        private System.Windows.Forms.Button buttonDisableHeadset;
        private System.Windows.Forms.Button buttonEnableHeadset;
        private System.Windows.Forms.GroupBox groupBoxAuth;
        private System.Windows.Forms.TextBox textBoxCmd;
        private System.Windows.Forms.Button buttonCmdsLoadScriptBlock;
        private System.Windows.Forms.TextBox textBoxRunspaceStartup;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEndpoint;
        private System.Windows.Forms.Button buttonDisableLauncher;
        private System.Windows.Forms.Button buttonEnableLauncher;
        private System.Windows.Forms.GroupBox groupBoxCustomCmds;
        private System.Windows.Forms.Button buttonCmdsCustom6;
        private System.Windows.Forms.Button buttonCmdsCustom5;
        private System.Windows.Forms.Button buttonCmdsCustom4;
        private System.Windows.Forms.Button buttonCmdsCustom3;
        private System.Windows.Forms.Button buttonCmdsCustom2;
        private System.Windows.Forms.Button buttonCmdsCustom1;
        private System.Windows.Forms.ComboBox comboBoxCmdsCustom;
        private System.Windows.Forms.TextBox textBoxCmdsCustomLabel;
        private System.Windows.Forms.TextBox textBoxCmdsCustomCmd;
        private System.Windows.Forms.Button buttonCmdsCustomSet;
        private System.Windows.Forms.Label labelCustomCmdCmd;
        private System.Windows.Forms.Label labelCustomCmdLabel;
        private System.Windows.Forms.Button buttonCmdsCustom10;
        private System.Windows.Forms.Button buttonCmdsCustom9;
        private System.Windows.Forms.Button buttonCmdsCustom8;
        private System.Windows.Forms.Button buttonCmdsCustom7;
        private System.Windows.Forms.TextBox textBoxCmdsCustom1;
        private System.Windows.Forms.TextBox textBoxCmdsCustomLabel1;
        private System.Windows.Forms.TextBox textBoxCmdsCustomLabel10;
        private System.Windows.Forms.TextBox textBoxCmdsCustom10;
        private System.Windows.Forms.TextBox textBoxCmdsCustomLabel9;
        private System.Windows.Forms.TextBox textBoxCmdsCustom9;
        private System.Windows.Forms.TextBox textBoxCmdsCustomLabel8;
        private System.Windows.Forms.TextBox textBoxCmdsCustom8;
        private System.Windows.Forms.TextBox textBoxCmdsCustomLabel7;
        private System.Windows.Forms.TextBox textBoxCmdsCustom7;
        private System.Windows.Forms.TextBox textBoxCmdsCustomLabel6;
        private System.Windows.Forms.TextBox textBoxCmdsCustom6;
        private System.Windows.Forms.TextBox textBoxCmdsCustomLabel5;
        private System.Windows.Forms.TextBox textBoxCmdsCustom5;
        private System.Windows.Forms.TextBox textBoxCmdsCustomLabel4;
        private System.Windows.Forms.TextBox textBoxCmdsCustom4;
        private System.Windows.Forms.TextBox textBoxCmdsCustomLabel3;
        private System.Windows.Forms.TextBox textBoxCmdsCustom3;
        private System.Windows.Forms.TextBox textBoxCmdsCustomLabel2;
        private System.Windows.Forms.TextBox textBoxCmdsCustom2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAuthTokens;
        private System.Windows.Forms.Button buttonAuthTokenFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAuthPostScript;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxAuthType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonCmdsAuthSet;
        private System.Windows.Forms.Button buttonCmdsAuthGet;
        private System.Windows.Forms.Button buttonCmdsAuthHide;
        private System.Windows.Forms.Button buttonCmdsAuthShow;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button buttonCmdsGetPoolData;
        private System.Windows.Forms.Button buttonClientsToClipboard;
        private System.Windows.Forms.CheckBox checkBoxCmdsCustomRemote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWorkingDir;
        private System.Windows.Forms.ToolStripMenuItem aboutPoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTunnelToolStripMenuItem;
        private System.Windows.Forms.Timer timerRestart;
        private System.Windows.Forms.Timer timerScreenEnable;
        private System.Windows.Forms.Timer timerScreenDisable;
        private System.Windows.Forms.Timer timerScreenShot;
    }
}

