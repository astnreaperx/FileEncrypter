﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEncrypter
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void tsiExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            txtDescription.Text = "This is a Encryption program";
                
        }
    }
}
