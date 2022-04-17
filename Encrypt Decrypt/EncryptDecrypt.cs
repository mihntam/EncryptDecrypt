using Encrypt_Decrypt.Algorithms;
using System.Security.Cryptography;

namespace EncryptDecrypt
{
    public partial class EncryptDecrypt : Form
    {
        private int keySize = 512;
        public EncryptDecrypt()
        {
            InitializeComponent();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInput.Text) || String.IsNullOrEmpty(txtKey.Text))
            {
                MessageBox.Show("Input and key can't be empty !!!");
            }
            else
            {
                string input = txtInput.Text;
                string key = txtKey.Text;
                string output;

                Vigenere vigenere = new Vigenere(key, input, null);
                vigenere.Encrypt();

                output = vigenere.CipherText;

                txtOutput.Text = output;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInput.Text) || String.IsNullOrEmpty(txtKey.Text))
            {
                MessageBox.Show("Input and key can't be empty !!!");
            }
            else
            {
                string input = txtInput.Text;
                string key = txtKey.Text;
                string output;

                Vigenere vigenere = new Vigenere(key, null, input);
                vigenere.Decrypt();

                output = vigenere.PlainText;

                txtOutput.Text = output;
            }
        }


        private void btnGenerateKeyPair_Click(object sender, EventArgs e)
        {
            try
            {
                var keypair = RSACryptography.GenerateKeyPair(keySize);

                txtPublicKey.Text = keypair.publicKey;
                txtPrivateKey.Text = keypair.privateKey;
            }
            catch
            {
                MessageBox.Show("Something went wrong !!!");
            }
        }


        private void btnRSAEncrypt_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(txtPublicKey.Text) && String.IsNullOrEmpty(txtPlainTextEnc.Text))
                {
                    MessageBox.Show("Public Key & Plain Text can't be empty !!!");
                }
                else
                {

                    string publicKey = txtPublicKey.Text;
                    string plainText = txtPlainTextEnc.Text;
                    string cipherText;

                    cipherText = RSACryptography.Encryption(plainText, publicKey, keySize);

                    System.Diagnostics.Debug.WriteLine(cipherText);

                    txtEncOutput.Text = cipherText;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong !!!");
            }
        }

        private void btnRSADecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtPrivateKey.Text) && String.IsNullOrEmpty(txtCipherTextDec.Text))
                {
                    MessageBox.Show("Private Key & Cipher Text can't be empty !!!");
                }
                else
                {
                    string privateKey = txtPrivateKey.Text;
                    string cipherText = txtCipherTextDec.Text;
                    string plainText;

                    plainText = RSACryptography.Decryption(cipherText, privateKey, keySize);

                    txtDecOutput.Text = plainText;
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong !!!");
            }
        }

        private void EncryptDecrypt_Load(object sender, EventArgs e)
        {

            this.cboKeyPairSize.Items.Add("512 bits");
            this.cboKeyPairSize.Items.Add("1024 bits");
            this.cboKeyPairSize.Items.Add("2048 bits");
            this.cboKeyPairSize.Items.Add("4096 bits");

        }

        private void cboKeyPairSize_SelectedValueChanged(object sender, EventArgs e)
        {
            string choosen;
            choosen = cboKeyPairSize.Text;

            switch (choosen)
            {
                case "512 bits":
                    keySize = 512;
                    break;
                case "1024 bits":
                    keySize = 1024;
                    break;
                case "2048 bits":
                    keySize = 2048;
                    break;
                case "4096 bits":
                    keySize = 4096;
                    break;
                default:
                    keySize = 512;
                    break;
            }

            System.Diagnostics.Debug.WriteLine(keySize);
        }

        private void btnImportKey_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtPublicKey.Clear();
                this.txtPrivateKey.Clear();

                string pathPublicKey = "null";
                string pathPrivateKey = "null";

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Pem File|*.pem|All File|*.*";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        if (file.Contains(".pub.pem"))
                        { 
                            pathPublicKey = file;
                        }
                        else
                        {
                            pathPrivateKey = file;
                        }
                    }
                }

                if (pathPublicKey != "null")
                    txtPublicKey.Text = File.ReadAllText(pathPublicKey);
                if (pathPrivateKey != "null")
                    txtPrivateKey.Text = File.ReadAllText(pathPrivateKey);
            }
            catch
            {
                MessageBox.Show("Something went wrong !!!");
            }
        }

        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (false
                    //String.IsNullOrEmpty(txtPublicKey.Text) || String.IsNullOrEmpty(txtPrivateKey.Text)
                    )
                {
                    MessageBox.Show("Private Key can't be empty !!!");
                }
                else
                {
                    string publicKey = txtPublicKey.Text;
                    string privateKey = txtPrivateKey.Text;

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.DefaultExt = "pem";
                    saveFileDialog.Filter = "Pem File|*.pem|All File|*.*";
                    saveFileDialog.Title = "File name";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        saveFileDialog.RestoreDirectory = true;

                        string pathPrivateKey = saveFileDialog.FileName;
                        string pathPublicKey = pathPrivateKey.Replace(".pem", ".pub.pem");

                        System.Diagnostics.Debug.WriteLine(pathPrivateKey);
                        System.Diagnostics.Debug.WriteLine(pathPublicKey);

                        File.WriteAllText(pathPrivateKey, privateKey);
                        File.WriteAllText(pathPublicKey, publicKey);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong !!!");
            }
        }
    }
}