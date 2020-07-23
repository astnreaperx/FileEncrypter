namespace FileEncrypter
{
    partial class FileEncrypterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileEncrypterForm));
            this.txbText = new System.Windows.Forms.TextBox();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.tsiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDecrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiLoadKey = new System.Windows.Forms.ToolStripMenuItem();
            this.generateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.grbKeyInfo = new System.Windows.Forms.GroupBox();
            this.lblTextEditorTitle = new System.Windows.Forms.Label();
            this.mnsMain.SuspendLayout();
            this.grbKeyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbText
            // 
            this.txbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbText.Location = new System.Drawing.Point(11, 58);
            this.txbText.Margin = new System.Windows.Forms.Padding(2);
            this.txbText.Multiline = true;
            this.txbText.Name = "txbText";
            this.txbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbText.Size = new System.Drawing.Size(458, 241);
            this.txbText.TabIndex = 2;
            // 
            // mnsMain
            // 
            this.mnsMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.ImeMode = System.Windows.Forms.ImeMode.On;
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiFile,
            this.encryptionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnsMain.Size = new System.Drawing.Size(480, 24);
            this.mnsMain.TabIndex = 3;
            this.mnsMain.Text = "menuStrip1";
            // 
            // tsiFile
            // 
            this.tsiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiLoad,
            this.tsiSave,
            this.toolStripMenuItem1,
            this.tsiExit});
            this.tsiFile.Name = "tsiFile";
            this.tsiFile.Size = new System.Drawing.Size(37, 20);
            this.tsiFile.Text = "&File";
            // 
            // tsiLoad
            // 
            this.tsiLoad.Name = "tsiLoad";
            this.tsiLoad.Size = new System.Drawing.Size(123, 22);
            this.tsiLoad.Text = "&Load";
            this.tsiLoad.Click += new System.EventHandler(this.tsiLoad_Click);
            // 
            // tsiSave
            // 
            this.tsiSave.Name = "tsiSave";
            this.tsiSave.Size = new System.Drawing.Size(123, 22);
            this.tsiSave.Text = "&Save As...";
            this.tsiSave.Click += new System.EventHandler(this.tsiSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // tsiExit
            // 
            this.tsiExit.Name = "tsiExit";
            this.tsiExit.Size = new System.Drawing.Size(123, 22);
            this.tsiExit.Text = "&Exit";
            this.tsiExit.Click += new System.EventHandler(this.tsiExit_Click);
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiEncrypt,
            this.tsiDecrypt,
            this.toolStripMenuItem2,
            this.tsiLoadKey,
            this.generateKeyToolStripMenuItem});
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.encryptionToolStripMenuItem.Text = "&Encryption";
            // 
            // tsiEncrypt
            // 
            this.tsiEncrypt.Name = "tsiEncrypt";
            this.tsiEncrypt.Size = new System.Drawing.Size(143, 22);
            this.tsiEncrypt.Text = "&Encrypt";
            this.tsiEncrypt.Click += new System.EventHandler(this.tsiEncrypt_Click);
            // 
            // tsiDecrypt
            // 
            this.tsiDecrypt.Name = "tsiDecrypt";
            this.tsiDecrypt.Size = new System.Drawing.Size(143, 22);
            this.tsiDecrypt.Text = "&Decrypt";
            this.tsiDecrypt.Click += new System.EventHandler(this.tsiDecrypt_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(140, 6);
            // 
            // tsiLoadKey
            // 
            this.tsiLoadKey.Name = "tsiLoadKey";
            this.tsiLoadKey.Size = new System.Drawing.Size(143, 22);
            this.tsiLoadKey.Text = "&Load Key";
            this.tsiLoadKey.Click += new System.EventHandler(this.tsiLoadKey_Click);
            // 
            // generateKeyToolStripMenuItem
            // 
            this.generateKeyToolStripMenuItem.Name = "generateKeyToolStripMenuItem";
            this.generateKeyToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.generateKeyToolStripMenuItem.Text = "&Generate Key";
            this.generateKeyToolStripMenuItem.Click += new System.EventHandler(this.generateKeyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAbout,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tsiAbout
            // 
            this.tsiAbout.Name = "tsiAbout";
            this.tsiAbout.Size = new System.Drawing.Size(107, 22);
            this.tsiAbout.Text = "&About";
            this.tsiAbout.Click += new System.EventHandler(this.tsiAbout_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(14, 42);
            this.lblKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "Key";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue.Location = new System.Drawing.Point(46, 42);
            this.lblValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(18, 15);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "...";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameValue.Location = new System.Drawing.Point(46, 19);
            this.lblNameValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(18, 15);
            this.lblNameValue.TabIndex = 8;
            this.lblNameValue.Text = "...";
            // 
            // grbKeyInfo
            // 
            this.grbKeyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbKeyInfo.Controls.Add(this.lblNameValue);
            this.grbKeyInfo.Controls.Add(this.lblName);
            this.grbKeyInfo.Controls.Add(this.lblValue);
            this.grbKeyInfo.Controls.Add(this.lblKey);
            this.grbKeyInfo.Location = new System.Drawing.Point(11, 303);
            this.grbKeyInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grbKeyInfo.Name = "grbKeyInfo";
            this.grbKeyInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grbKeyInfo.Size = new System.Drawing.Size(458, 74);
            this.grbKeyInfo.TabIndex = 9;
            this.grbKeyInfo.TabStop = false;
            this.grbKeyInfo.Text = "Key Info";
            // 
            // lblTextEditorTitle
            // 
            this.lblTextEditorTitle.AutoSize = true;
            this.lblTextEditorTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextEditorTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTextEditorTitle.Location = new System.Drawing.Point(14, 33);
            this.lblTextEditorTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextEditorTitle.Name = "lblTextEditorTitle";
            this.lblTextEditorTitle.Size = new System.Drawing.Size(104, 23);
            this.lblTextEditorTitle.TabIndex = 10;
            this.lblTextEditorTitle.Text = "Goose Editor";
            // 
            // FileEncrypterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(480, 388);
            this.Controls.Add(this.lblTextEditorTitle);
            this.Controls.Add(this.grbKeyInfo);
            this.Controls.Add(this.txbText);
            this.Controls.Add(this.mnsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FileEncrypterForm";
            this.Text = "Goose Encrypt";
            this.Load += new System.EventHandler(this.FileEncrypterForm_Load);
            this.Shown += new System.EventHandler(this.FileEncrypterForm_Shown);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.grbKeyInfo.ResumeLayout(false);
            this.grbKeyInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbText;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiEncrypt;
        private System.Windows.Forms.ToolStripMenuItem tsiDecrypt;
        private System.Windows.Forms.ToolStripMenuItem tsiLoadKey;
        private System.Windows.Forms.ToolStripMenuItem generateKeyToolStripMenuItem;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.GroupBox grbKeyInfo;
        private System.Windows.Forms.Label lblTextEditorTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsiFile;
        private System.Windows.Forms.ToolStripMenuItem tsiLoad;
        private System.Windows.Forms.ToolStripMenuItem tsiSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsiExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}

