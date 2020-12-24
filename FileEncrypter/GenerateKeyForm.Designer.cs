namespace FileEncrypter
{
    partial class GenerateKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateKeyForm));
            this.grbEncryptionKey = new System.Windows.Forms.GroupBox();
            this.txbUserPasswordTwo = new System.Windows.Forms.TextBox();
            this.txbUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserPasswordTwo = new System.Windows.Forms.Label();
            this.txbPassphrase = new System.Windows.Forms.TextBox();
            this.lblPassphrase = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.grbEncryptionKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEncryptionKey
            // 
            this.grbEncryptionKey.Controls.Add(this.txbUserPasswordTwo);
            this.grbEncryptionKey.Controls.Add(this.txbUserPassword);
            this.grbEncryptionKey.Controls.Add(this.lblUserPassword);
            this.grbEncryptionKey.Controls.Add(this.lblUserPasswordTwo);
            this.grbEncryptionKey.Controls.Add(this.txbPassphrase);
            this.grbEncryptionKey.Controls.Add(this.lblPassphrase);
            this.grbEncryptionKey.Controls.Add(this.txbLastName);
            this.grbEncryptionKey.Controls.Add(this.lblLastName);
            this.grbEncryptionKey.Controls.Add(this.txbFirstName);
            this.grbEncryptionKey.Controls.Add(this.lblFirstName);
            this.grbEncryptionKey.Location = new System.Drawing.Point(15, 32);
            this.grbEncryptionKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbEncryptionKey.Name = "grbEncryptionKey";
            this.grbEncryptionKey.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbEncryptionKey.Size = new System.Drawing.Size(336, 290);
            this.grbEncryptionKey.TabIndex = 0;
            this.grbEncryptionKey.TabStop = false;
            this.grbEncryptionKey.Text = "Key Info";
            // 
            // txbUserPasswordTwo
            // 
            this.txbUserPasswordTwo.Location = new System.Drawing.Point(93, 241);
            this.txbUserPasswordTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserPasswordTwo.Name = "txbUserPasswordTwo";
            this.txbUserPasswordTwo.Size = new System.Drawing.Size(221, 22);
            this.txbUserPasswordTwo.TabIndex = 9;
            // 
            // txbUserPassword
            // 
            this.txbUserPassword.Location = new System.Drawing.Point(92, 211);
            this.txbUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserPassword.Name = "txbUserPassword";
            this.txbUserPassword.Size = new System.Drawing.Size(221, 22);
            this.txbUserPassword.TabIndex = 8;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(6, 216);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(73, 17);
            this.lblUserPassword.TabIndex = 7;
            this.lblUserPassword.Text = "Password:";
            // 
            // lblUserPasswordTwo
            // 
            this.lblUserPasswordTwo.AutoSize = true;
            this.lblUserPasswordTwo.Location = new System.Drawing.Point(6, 244);
            this.lblUserPasswordTwo.Name = "lblUserPasswordTwo";
            this.lblUserPasswordTwo.Size = new System.Drawing.Size(73, 17);
            this.lblUserPasswordTwo.TabIndex = 6;
            this.lblUserPasswordTwo.Text = "Password:";
            // 
            // txbPassphrase
            // 
            this.txbPassphrase.Location = new System.Drawing.Point(93, 82);
            this.txbPassphrase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPassphrase.Multiline = true;
            this.txbPassphrase.Name = "txbPassphrase";
            this.txbPassphrase.Size = new System.Drawing.Size(221, 118);
            this.txbPassphrase.TabIndex = 5;
            // 
            // lblPassphrase
            // 
            this.lblPassphrase.AutoSize = true;
            this.lblPassphrase.Location = new System.Drawing.Point(5, 86);
            this.lblPassphrase.Name = "lblPassphrase";
            this.lblPassphrase.Size = new System.Drawing.Size(87, 17);
            this.lblPassphrase.TabIndex = 4;
            this.lblPassphrase.Text = "Passphrase:";
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(93, 55);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(221, 22);
            this.txbLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(5, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(93, 27);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(221, 22);
            this.txbFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(5, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(203, 34);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(53, 34);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(115, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate Key";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(386, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(116, 26);
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.btnGenerate);
            this.grpAction.Controls.Add(this.btnClear);
            this.grpAction.Location = new System.Drawing.Point(16, 349);
            this.grpAction.Margin = new System.Windows.Forms.Padding(4);
            this.grpAction.Name = "grpAction";
            this.grpAction.Padding = new System.Windows.Forms.Padding(4);
            this.grpAction.Size = new System.Drawing.Size(335, 82);
            this.grpAction.TabIndex = 7;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Action";
            // 
            // GenerateKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 460);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.grbEncryptionKey);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GenerateKeyForm";
            this.Text = "GenerateKeyForm";
            this.grbEncryptionKey.ResumeLayout(false);
            this.grbEncryptionKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEncryptionKey;
        private System.Windows.Forms.TextBox txbPassphrase;
        private System.Windows.Forms.Label lblPassphrase;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.TextBox txbUserPasswordTwo;
        private System.Windows.Forms.TextBox txbUserPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserPasswordTwo;
    }
}