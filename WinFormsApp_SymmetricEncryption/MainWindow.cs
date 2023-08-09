using System.Diagnostics;

namespace WinFormsApp_SymmetricEncryption
{
    public partial class MainWindow : Form
    {
        private readonly Encryptor _encryptor = new Encryptor();

        public MainWindow()
        {
            InitializeComponent();

            // Connects the combobox to a dictionary, with a Display string, and an enum value for return.
            this.cbEncryptType.DataSource = new BindingSource(_encryptor.EncryptionTypes, null);
            this.cbEncryptType.DisplayMember = "Key";
            this.cbEncryptType.ValueMember = "Value";

            this.lblErrorMsg.Visible = false;
        }

        /// <summary>
        /// Any change to the Encryption Type combobox forces a new generation of keys and IVs (or Nonces).
        /// This gaurentees an encryption type when clicking encrypt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEncryptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encryption encryptionType = (Encryption)(cbEncryptType.SelectedIndex);
            var encryption = _encryptor.GetKeyAndIV(encryptionType);

            this.lblKey.Text = "Key";
            this.lblIV.Text = "IV";
            this.tbKey.Text = Convert.ToBase64String(encryption.Key);
            this.tbIV.Text = Convert.ToBase64String(encryption.IV);

            if (encryptionType == Encryption.AesGcm)
            {
                this.lblIV.Text = "Nonce";
            }
        }

        /// <summary>
        /// On Encrypt btn click. Gets the text in plain and encryted, to then display it.
        /// Encryption time is measured and displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = this.tbPlainASCII.Text;
            this.tbPlainHEX.Text = _encryptor.ConvertToHEX(plainText);

            Stopwatch sw = new Stopwatch();

            sw.Start();
            string cipherText = _encryptor.EncryptText(plainText);
            sw.Stop();

            if (string.IsNullOrEmpty(cipherText))
                this.lblErrorMsg.Visible = true;
            else
            {
                this.lblErrorMsg.Visible = false;
                this.tbCipherASCII.Text = cipherText;
                this.tbCipherHEX.Text = _encryptor.ConvertToHEX(cipherText);
            }

            this.lblEncryptTime.Text = $"Encryption Time:\n{sw.Elapsed}";

        }

        /// <summary>
        /// On Decrypt btn click. 
        /// Gets the Encrypted Base64 text, gets it decrypted and displays the decrypt value and corresponding hex value. 
        /// Decryption time is measured and displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedText = this.tbCipherASCII.Text;

            Stopwatch sw = new Stopwatch();

            sw.Start();
            string decryptedText = _encryptor.DecryptText(encryptedText);
            sw.Stop();

            if (string.IsNullOrEmpty(decryptedText))
                this.lblErrorMsg.Visible = true;
            else
            {
                this.lblErrorMsg.Visible = false;
                this.tbDecryptedASCII.Text = decryptedText;
                this.tbDecryptedHEX.Text = _encryptor.ConvertToHEX(decryptedText);
            }


            this.lblDecryptTime.Text = $"Decryption Time:\n{sw.Elapsed}";

        }


    }
}