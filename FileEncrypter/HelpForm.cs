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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void tsiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            string welcomeText = "  If you have not generated a key, make sure to go to the \"Encryption\" tab and hit the \"Generate Key\" button. You can save this file to anywhere you want, make sure to keep it in a secure location " +
                "\n\n   To encrypt a file, load your key from the encryption tab, and select the key you encrypted the file with. Then, you can encrypt your file by clicking the \"Encrypt\" button from the encryption tab." +
                "\n\n   To decrypt a file, load your key from the encryption tab, and select the key you encrypted the file with. You can decrypt the file by clicking the \"Decrypt\" button from the encryption tab.";

            richTextBox1.Text = welcomeText;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] words = txtSearch.Text.Split(',');
            foreach (string word in words)
            {
                int startindex = 0;
                while (startindex < richTextBox1.TextLength)
                {
                    int wordstartIndex = richTextBox1.Find(word, startindex, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        richTextBox1.SelectionStart = wordstartIndex;
                        richTextBox1.SelectionLength = word.Length;
                        richTextBox1.SelectionBackColor = Color.GreenYellow;
                    }
                    else
                        break;
                    startindex += wordstartIndex + word.Length;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;  
        }
    }
}
