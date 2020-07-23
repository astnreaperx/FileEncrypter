using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Security.Cryptography;

namespace FileEncrypter
{
    public partial class GenerateKeyForm : Form
    {
        public GenerateKeyForm()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the form and errors 
            errorProvider.Clear();
            txbFirstName.Text = string.Empty;
            txbLastName.Text = string.Empty;
            txbPassword.Text = string.Empty;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Serialize();
        }

        /// <summary>
        /// Serialize XML
        /// </summary>
        private void Serialize()
        {
            bool errorflag = false;
            errorProvider.Clear();
            // Validate the Form
            if (txbFirstName.Text == string.Empty) // Checks to see if First Name textbox is Empty
            {
                errorProvider.SetError(txbFirstName, "Please Enter a First Name!");
                errorflag = true;
            } 
            if(txbLastName.Text == string.Empty) // Checks to see if the Last Name textbox is empty
            {
                errorProvider.SetError(txbLastName, "Please Enter a Last Name!");
                errorflag = true;
            }
            if(txbPassword.Text == string.Empty) // Checks to see if the Password textbox is empty
            {
                errorProvider.SetError(txbPassword, "Please Enter a Password!");
                errorflag = true;
            }

            // See if the errorflag has been tripped 
            if (errorflag == false)
            {
                // Open a save file dialog box to select the path
                // Would like to save a PKF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "MyKey|*.pkf";


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the file you want to save 
                    string path = saveFileDialog.FileName;

                    using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        EncryptionKey encryptionKey = GenerateKey();

                        XmlSerializer serializer = new XmlSerializer(typeof(EncryptionKey));
                        serializer.Serialize(stream, encryptionKey);
                        stream.Close();
                        this.Close();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Generate an Encryption Key
        /// </summary>
        /// <returns></returns>
        private EncryptionKey GenerateKey()
        {
            // Compute the Hash based on the users Password
            string key = ComputeSha256Hash(txbPassword.Text);
            EncryptionKey NewKey = new EncryptionKey(txbFirstName.Text,txbLastName.Text,key);
            return NewKey;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rawData"></param>
        /// <returns></returns>
        static string ComputeSha256Hash(string rawData)
        {
            // Create a Secure Hash Algorithm
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute the hash the passed Password(rawdata)
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
