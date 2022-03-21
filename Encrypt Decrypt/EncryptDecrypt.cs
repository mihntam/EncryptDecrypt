using Encrypt_Decrypt.Algorithms;

namespace EncryptDecrypt
{
    public partial class EncryptDecrypt : Form
    {
        public EncryptDecrypt()
        {
            InitializeComponent();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInput.Text) || String.IsNullOrEmpty(txtKey.Text))
            {
                MessageBox.Show("Input and key can't be blank !!!");
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
                MessageBox.Show("Input and key can't be blank !!!");
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

    }
}