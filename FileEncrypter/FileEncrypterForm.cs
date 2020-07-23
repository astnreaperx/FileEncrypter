using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace FileEncrypter
{
    public partial class FileEncrypterForm : Form
    {
        ///----- Things to Add -----
        /// - Error log file
        /// - Warning when no key is loaded
        /// - Form to view Encryption Settings
        /// - Global Variables when possible and appropriate 


        public string Key;
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);


        /// <summary>
        /// 
        /// </summary>
        public FileEncrypterForm()
        {
            InitializeComponent();
            // Disable Encryption buttons until the key is loaded
            tsiDecrypt.Enabled = false;
            tsiEncrypt.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileEncrypterForm_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileEncrypterForm_Shown(object sender, EventArgs e)
        {
            string welcomeText = "  If you have not generated a key, make sure to go to the \"Encryption\" tab and hit the \"Generate Key\" button. You can save this file to anywhere you want, make sure to keep it in a secure location " +
                "\n\n   To encrypt a file, load your key from the encryption tab, and select the key you encrypted the file with. Then, you can encrypt your file by clicking the \"Encrypt\" button from the encryption tab." +
                "\n\n   To decrypt a file, load your key from the encryption tab, and select the key you encrypted the file with. You can decrypt the file by clicking the \"Decrypt\" button from the encryption tab.";

            MessageBox.Show(welcomeText, "Honk !!!", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Tool strip Exit click event, closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Loads a plane text file into the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiLoad_Click(object sender, EventArgs e)
        {
            LoadText();

        }

        /// <summary>
        /// Saves the text in the text box as a plane text files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiSave_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        /// <summary>
        /// XML serialization to store the key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiLoadKey_Click(object sender, EventArgs e)
        {
            Deserialize();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the Key Generation Form
            GenerateKeyForm generateKey = new GenerateKeyForm();
            generateKey.Show();
        }

        /// <summary>
        /// Event for when the encrypt tool strip item is clicked
        /// opens a save dialog box and saves the files as encrypted text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiEncrypt_Click(object sender, EventArgs e)
        {
            // Encrypts the text in the textbook to a .aes file
            FileEncrypt();
        }

        /// <summary>
        /// Event for when the Decrypt tool strip item is clicked 
        /// Decrypts the encrypted text and displays it in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiDecrypt_Click(object sender, EventArgs e)
        {
            FileDecrypt();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        /// <summary>
        /// Encrypts a file from its path and a plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="password"></param>
        /// Change this to make it a inputText
        private void FileEncrypt()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".aes";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputFile = saveFileDialog.FileName;
                string inputText = txbText.Text;
                string password = lblValue.Text;

                // For additional security Pin the password of your files
                GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);
                //generate random salt
                byte[] salt = GenerateRandomSalt();

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Create);

                var plainTextBytes = Encoding.UTF8.GetBytes(inputText);

                //convert password string to byte array
                byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

                //Set encryption algorithm
                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;
                AES.BlockSize = 128;
                AES.Padding = PaddingMode.PKCS7;
                var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Mode = CipherMode.CFB;

                // write salt to the beginning of the output file, so in this case can be random every time
                fsCrypt.Write(salt, 0, salt.Length);

                // Write the encrypted data
                CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);
                // Start at 0 and write to the End
                cs.Write(plainTextBytes, 0, plainTextBytes.Length);

                MessageBox.Show("Text has been Encrypted\n"+ saveFileDialog.FileName ,"File Encrypted" , MessageBoxButtons.OK);

                // Close up the streams
                cs.Close();
                fsCrypt.Close();

                // Remove password from memory(RAM)
                 ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
                gch.Free();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Decrypts an encrypted file with the FileEncrypt method through its path and the plain password.
        /// Needs:
        ///     - Invalid Key Error / makes it to reader.readtoend
        /// </summary
        /// <param name="inputFile"> a file that is inputed  </param>
        /// <param name="password"></param>
        private void FileDecrypt()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            // openFile.Filter = ".aes";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string inputFile = openFile.FileName;
                string password = lblValue.Text;    

                // For additional security Pin the password of your files
                GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);

                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] salt = new byte[32];

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
                fsCrypt.Read(salt, 0, salt.Length);

                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;
                AES.BlockSize = 128;
                var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Padding = PaddingMode.PKCS7;
                AES.Mode = CipherMode.CFB;

                try
                {
                    CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);
                    StreamReader reader = new StreamReader(cs);
                    txbText.Text = reader.ReadToEnd();
                    fsCrypt.Close();
                    cs.Close();
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Decrypting Data!\n" + e.StackTrace, "Decryption Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Remove password from memory(RAM)
                ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
                gch.Free();
            }
            else
            {
                return;
            }

        }

        /// <summary>
        /// Method for loading the plain text
        /// </summary>
        public void LoadText()
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog();

            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = loadFileDialog.FileName;
                string fileText = File.ReadAllText(filePath);
                txbText.Text = fileText;
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Method for saving plain text 
        /// </summary>
        public void SaveText()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                TextWriter textWriter = new StreamWriter(filePath);
                textWriter.Write(txbText.Text);
                textWriter.Close();
            }
            else
            {
                return;
            }
        }


        /// <summary>
        /// De-serialize XML
        /// I.E load the key into the application
        /// only if Dialogbox.Ok
        /// </summary>
        private void Deserialize()
        {
            OpenFileDialog fb = new OpenFileDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {

                string path = fb.FileName;

                using (FileStream fileStream = File.OpenRead(path))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(EncryptionKey));
                    EncryptionKey tempObj = null;
                    try
                    {
                        tempObj = (EncryptionKey)deserializer.Deserialize(fileStream);
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Error Loading Key!\n" + e.StackTrace, "Key Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    fileStream.Close();

                    lblNameValue.Text = tempObj.FirstName + " " + tempObj.LastName;
                    lblValue.Text = tempObj.Key;
                    tsiDecrypt.Enabled = true;
                    tsiEncrypt.Enabled = true;

                }
            }
            else
            {
                return;
            }
        }


        /// <summary>
        /// Generate Random Salt for Encryption
        /// </summary>
        /// <returns></returns>
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Fill the buffer with the generated data
                    rng.GetBytes(data);
                }
            }
            return data;
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
