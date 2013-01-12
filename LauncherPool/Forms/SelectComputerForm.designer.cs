namespace LauncherPool
{
    partial class SelectComputerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectComputerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonToClipboard = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonClientGroupAll = new System.Windows.Forms.Button();
            this.buttonClientGroup9 = new System.Windows.Forms.Button();
            this.buttonClientGroup8 = new System.Windows.Forms.Button();
            this.buttonClientGroup7 = new System.Windows.Forms.Button();
            this.buttonClientGroup6 = new System.Windows.Forms.Button();
            this.buttonClientGroup5 = new System.Windows.Forms.Button();
            this.buttonClientGroup4 = new System.Windows.Forms.Button();
            this.buttonClientGroup3 = new System.Windows.Forms.Button();
            this.buttonClientGroup2 = new System.Windows.Forms.Button();
            this.buttonClientGroup1 = new System.Windows.Forms.Button();
            this.checkedListBoxClients = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.checkedListBoxClients);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.buttonLoad);
            this.groupBox4.Controls.Add(this.buttonSave);
            this.groupBox4.Controls.Add(this.buttonRemove);
            this.groupBox4.Controls.Add(this.buttonAdd);
            this.groupBox4.Location = new System.Drawing.Point(669, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(98, 150);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(11, 19);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(11, 107);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(11, 77);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(11, 48);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonSelect);
            this.groupBox3.Controls.Add(this.buttonToClipboard);
            this.groupBox3.Controls.Add(this.buttonClear);
            this.groupBox3.Location = new System.Drawing.Point(669, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 116);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Pool";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(12, 19);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonToClipboard
            // 
            this.buttonToClipboard.Location = new System.Drawing.Point(12, 48);
            this.buttonToClipboard.Name = "buttonToClipboard";
            this.buttonToClipboard.Size = new System.Drawing.Size(75, 23);
            this.buttonToClipboard.TabIndex = 4;
            this.buttonToClipboard.Text = "ToClipboard";
            this.buttonToClipboard.UseVisualStyleBackColor = true;
            this.buttonToClipboard.Click += new System.EventHandler(this.buttonToClipboard_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 77);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonClientGroupAll);
            this.groupBox2.Controls.Add(this.buttonClientGroup9);
            this.groupBox2.Controls.Add(this.buttonClientGroup8);
            this.groupBox2.Controls.Add(this.buttonClientGroup7);
            this.groupBox2.Controls.Add(this.buttonClientGroup6);
            this.groupBox2.Controls.Add(this.buttonClientGroup5);
            this.groupBox2.Controls.Add(this.buttonClientGroup4);
            this.groupBox2.Controls.Add(this.buttonClientGroup3);
            this.groupBox2.Controls.Add(this.buttonClientGroup2);
            this.groupBox2.Controls.Add(this.buttonClientGroup1);
            this.groupBox2.Location = new System.Drawing.Point(669, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 185);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sub Pools";
            // 
            // buttonClientGroupAll
            // 
            this.buttonClientGroupAll.Location = new System.Drawing.Point(47, 135);
            this.buttonClientGroupAll.Name = "buttonClientGroupAll";
            this.buttonClientGroupAll.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroupAll.TabIndex = 21;
            this.buttonClientGroupAll.Text = "A";
            this.buttonClientGroupAll.UseVisualStyleBackColor = true;
            this.buttonClientGroupAll.Click += new System.EventHandler(this.buttonClientGroupAll_Click);
            // 
            // buttonClientGroup9
            // 
            this.buttonClientGroup9.Location = new System.Drawing.Point(14, 135);
            this.buttonClientGroup9.Name = "buttonClientGroup9";
            this.buttonClientGroup9.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup9.TabIndex = 20;
            this.buttonClientGroup9.Text = "9";
            this.buttonClientGroup9.UseVisualStyleBackColor = true;
            this.buttonClientGroup9.Click += new System.EventHandler(this.buttonClientGroup9_Click);
            // 
            // buttonClientGroup8
            // 
            this.buttonClientGroup8.Location = new System.Drawing.Point(47, 106);
            this.buttonClientGroup8.Name = "buttonClientGroup8";
            this.buttonClientGroup8.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup8.TabIndex = 19;
            this.buttonClientGroup8.Text = "8";
            this.buttonClientGroup8.UseVisualStyleBackColor = true;
            this.buttonClientGroup8.Click += new System.EventHandler(this.buttonClientGroup8_Click);
            // 
            // buttonClientGroup7
            // 
            this.buttonClientGroup7.Location = new System.Drawing.Point(14, 106);
            this.buttonClientGroup7.Name = "buttonClientGroup7";
            this.buttonClientGroup7.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup7.TabIndex = 18;
            this.buttonClientGroup7.Text = "7";
            this.buttonClientGroup7.UseVisualStyleBackColor = true;
            this.buttonClientGroup7.Click += new System.EventHandler(this.buttonClientGroup7_Click);
            // 
            // buttonClientGroup6
            // 
            this.buttonClientGroup6.Location = new System.Drawing.Point(47, 77);
            this.buttonClientGroup6.Name = "buttonClientGroup6";
            this.buttonClientGroup6.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup6.TabIndex = 17;
            this.buttonClientGroup6.Text = "6";
            this.buttonClientGroup6.UseVisualStyleBackColor = true;
            this.buttonClientGroup6.Click += new System.EventHandler(this.buttonClientGroup6_Click);
            // 
            // buttonClientGroup5
            // 
            this.buttonClientGroup5.Location = new System.Drawing.Point(14, 77);
            this.buttonClientGroup5.Name = "buttonClientGroup5";
            this.buttonClientGroup5.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup5.TabIndex = 16;
            this.buttonClientGroup5.Text = "5";
            this.buttonClientGroup5.UseVisualStyleBackColor = true;
            this.buttonClientGroup5.Click += new System.EventHandler(this.buttonClientGroup5_Click);
            // 
            // buttonClientGroup4
            // 
            this.buttonClientGroup4.Location = new System.Drawing.Point(47, 48);
            this.buttonClientGroup4.Name = "buttonClientGroup4";
            this.buttonClientGroup4.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup4.TabIndex = 15;
            this.buttonClientGroup4.Text = "4";
            this.buttonClientGroup4.UseVisualStyleBackColor = true;
            this.buttonClientGroup4.Click += new System.EventHandler(this.buttonClientGroup4_Click);
            // 
            // buttonClientGroup3
            // 
            this.buttonClientGroup3.Location = new System.Drawing.Point(14, 48);
            this.buttonClientGroup3.Name = "buttonClientGroup3";
            this.buttonClientGroup3.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup3.TabIndex = 14;
            this.buttonClientGroup3.Text = "3";
            this.buttonClientGroup3.UseVisualStyleBackColor = true;
            this.buttonClientGroup3.Click += new System.EventHandler(this.buttonClientGroup3_Click);
            // 
            // buttonClientGroup2
            // 
            this.buttonClientGroup2.Location = new System.Drawing.Point(47, 19);
            this.buttonClientGroup2.Name = "buttonClientGroup2";
            this.buttonClientGroup2.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup2.TabIndex = 13;
            this.buttonClientGroup2.Text = "2";
            this.buttonClientGroup2.UseVisualStyleBackColor = true;
            this.buttonClientGroup2.Click += new System.EventHandler(this.buttonClientGroup2_Click);
            // 
            // buttonClientGroup1
            // 
            this.buttonClientGroup1.Location = new System.Drawing.Point(14, 19);
            this.buttonClientGroup1.Name = "buttonClientGroup1";
            this.buttonClientGroup1.Size = new System.Drawing.Size(30, 23);
            this.buttonClientGroup1.TabIndex = 12;
            this.buttonClientGroup1.Text = "1";
            this.buttonClientGroup1.UseVisualStyleBackColor = true;
            this.buttonClientGroup1.Click += new System.EventHandler(this.buttonClientGroup1_Click);
            // 
            // checkedListBoxClients
            // 
            this.checkedListBoxClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxClients.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBoxClients.CheckOnClick = true;
            this.checkedListBoxClients.FormattingEnabled = true;
            this.checkedListBoxClients.Items.AddRange(new object[] {
            "localhost"});
            this.checkedListBoxClients.Location = new System.Drawing.Point(11, 15);
            this.checkedListBoxClients.MultiColumn = true;
            this.checkedListBoxClients.Name = "checkedListBoxClients";
            this.checkedListBoxClients.Size = new System.Drawing.Size(652, 454);
            this.checkedListBoxClients.TabIndex = 1;
            this.checkedListBoxClients.Click += new System.EventHandler(this.checkedListBoxClients_Click);
            this.checkedListBoxClients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkedListBoxClients_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 497);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectComputerForm";
            this.Text = "Select-Pool";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.SelectComputerForm_Layout);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxClients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonToClipboard;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonClientGroupAll;
        private System.Windows.Forms.Button buttonClientGroup9;
        private System.Windows.Forms.Button buttonClientGroup8;
        private System.Windows.Forms.Button buttonClientGroup7;
        private System.Windows.Forms.Button buttonClientGroup6;
        private System.Windows.Forms.Button buttonClientGroup5;
        private System.Windows.Forms.Button buttonClientGroup4;
        private System.Windows.Forms.Button buttonClientGroup3;
        private System.Windows.Forms.Button buttonClientGroup2;
        private System.Windows.Forms.Button buttonClientGroup1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

