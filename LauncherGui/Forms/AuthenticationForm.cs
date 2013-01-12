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
    public partial class AuthenticationForm : Form
    {
        private bool preventClose;
        private int authenticationType;
        private string uid;
        private string password;
        private string loginTime;
        private int trials;
        private bool login;
        private string postAuthScript;
        private DataTable dtTokens;
        private string pingUrl;
        private string pingResult;
        LauncherForm myLauncher;
        
        public AuthenticationForm(LauncherForm launcher)
        {
            InitializeComponent();

            preventClose = true;
            authenticationType = 1;
            uid = "";
            password = "";
            loginTime = DateTime.MinValue.ToString();
            trials = 0;
            login = false;
            postAuthScript = "";
            dtTokens = InitTokens();
            pingUrl = "";
            pingResult = "";
            myLauncher = launcher;
        }

        #region Public Properties

        public bool PreventClose
        {
            get { return preventClose; }
            set { preventClose = value; }
        }

        public int AuthenticationType
        {
            get { return authenticationType; }
            set { authenticationType = value; }
        }

        public string Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Login
        {
            get { return login; }
            set { login = value; }
        }

        public string LoginTime
        {
            get { return loginTime; }
            set { loginTime = value; }
        }

        public string Tokens
        {
            get { return GetTokens(); }
            set { InsertTokens(value); }
        }

        public int TokenCount
        {
            get { return dtTokens.Rows.Count; }
        }

        public int Trials
        {
            get { return trials; }
            set { trials = value; }
        }

        public string PostAuthScript
        {
            get { return postAuthScript; }
            set { postAuthScript = value; }
        }

        public string PingUrl
        {
            get { return pingUrl; }
            set { pingUrl = value; }
        }

        public string PingResult
        {
            get { return pingResult; }
            set { pingResult = value; }
        }

        #endregion

        #region Token Based Security

        private DataTable InitTokens()
        {

            DataTable tokens = new DataTable();
            DataColumn column;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Uid";
            column.ReadOnly = false;
            column.Unique = false;
            tokens.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Password";
            column.ReadOnly = false;
            column.Unique = false;
            tokens.Columns.Add(column);

            return tokens;
        }

        private void ClearTokens()
        {
            dtTokens.Clear();
        }

        private void AddToken(string uid, string password)
        {
            DataRow row;
            row = dtTokens.NewRow();
            row["Uid"] = uid;
            row["Password"] = password;
            dtTokens.Rows.Add(row);
        }

        private bool TestToken(string uid, string password)
        {
            foreach (DataRow row in dtTokens.Rows)
            {
                if ((string)row["Uid"] == uid && (string)row["Password"] == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void InsertTokens(string myTokens)
        {
            ClearTokens();
            try
            {
                string[] tokenItems = myTokens.Split(new Char[] { ',' });
                foreach (string item in tokenItems)
                {
                    AddToken(item, "");
                }
            }
            catch
            {

            }
        }

        private string GetTokens()
        {
            string result = "";
            foreach (DataRow row in dtTokens.Rows)
            {
                result += row["uid"].ToString() + ",";
            }
            if (dtTokens.Rows.Count > 0)
            {
                result = result.Substring(0, result.Length - 1);
            }
            return result;
        }

        #endregion

        #region Form Elements

        private void AuthenticationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (preventClose == true)
            {
                e.Cancel = true;
            }
        }

        private void AuthenticationForm_Activated(object sender, EventArgs e)
        {
            trials = 0;
            switch (authenticationType)
            {
                case 1: //"Token Based Security":
                    textBoxUid.Text = "";
                    textBoxPassword.Visible = false;
                    textBoxPassword.Text = "";
                    labelPassword.Visible = false;
                    break;
                case 2: //"Username / Password Security":
                    textBoxUid.Text = "";
                    textBoxPassword.Visible = true;
                    textBoxPassword.Text = "";
                    labelPassword.Visible = true;
                    break;
                case 3: //"Active Directory Security":
                    textBoxUid.Text = "";
                    textBoxPassword.Visible = true;
                    textBoxPassword.Text = "";
                    labelPassword.Visible = true;
                    break;
            }
        }

        private void textBoxUid_TextChanged(object sender, EventArgs e)
        {
            labelResult.Text = "";
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelResult.Text = "";
        }

        #endregion

        private void buttonAuthenticate_Click(object sender, EventArgs e)
        {
            trials++;
            uid = textBoxUid.Text.ToUpper();
            password = textBoxPassword.Text;

            if (authenticationType == 1) // "Token Based Security"
            {
                login = TestToken(uid, "");
                if (login)
                {
                    loginTime = DateTime.Now.ToString();
                    myLauncher.PostAuthentication(UpdatePostAuthScript(postAuthScript));
                    PingAuthenticate(uid, password);
                    myLauncher.IsAuthFormVisible = false;
                    preventClose = false;
                    this.Hide();
                }
                else
                {
                    if (trials < 4)
                    {
                        textBoxUid.Focus();
                        textBoxUid.Text = "";
                        textBoxPassword.Text = "";
                        labelResult.Text = "Wrong entry! Try again.";
                    }
                    else
                    {
                        textBoxUid.Focus();
                        textBoxUid.Text = "";
                        textBoxPassword.Text = "";
                        labelResult.Text = "Please call the supervisor!";
                    }
                }
            }

            //if (authenticationType == 2) // "Username / Password Security"
            //{

            //}

            //if (authenticationType == 3) // "Active Directory Security"
            //{

            //}

        }

        private string UpdatePostAuthScript(string script)
        {
            string result = script;
            result = result.Replace("@uid@", uid);
            result = result.Replace("@password@", password);
            return result;
        }

        public void Authenticate(string uid, string password)
        {
            login = TestToken(uid, "");
            if (login)
            {
                loginTime = DateTime.Now.ToString();
                myLauncher.PostAuthentication(UpdatePostAuthScript(postAuthScript));
                PingAuthenticate(uid, password);
                myLauncher.IsAuthFormVisible = false;
                preventClose = false;
                this.Hide();
            }
        }

        public void PingAuthenticate(string uid, string password)
        {
            if (pingUrl.Length > 0)
            {
                //pingResult = myNet.PingAuthenticate(pingUrl, uid, password);
            }
        }

    }
}
