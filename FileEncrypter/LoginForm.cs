using System;
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
    public partial class LoginForm : Form
    {
        public EncryptionKey myKey = null;
        public LoginForm(EncryptionKey key)
        {
            InitializeComponent();
            myKey = key;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text != myKey.Password)
            {
                txbPassword.Clear();
                MessageBox.Show("Error Wrong Password!\n", "Key Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(System.Windows.Forms.Application.OpenForms["FileEncrypterForm"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["FileEncrypterForm"] as FileEncrypterForm).LoadKeyInfo(myKey);
                }
                this.Close();
            }
        }
    }
}
