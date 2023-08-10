using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp_RSAReciever
{
    public partial class RSAReciever : Form
    {
        Encryptor encryptor;
        public RSAReciever()
        {
            InitializeComponent();

            encryptor = new Encryptor();

            UpdateUI();
        }

        /// <summary>
        /// Updates the UI to represent the private and public key values of the RSA key
        /// </summary>
        private void UpdateUI()
        {
            string[] parameters = encryptor.GetRSAParameters();

            this.tbExponent.Text = parameters[0];
            this.tbModulus.Text = parameters[1];
            this.tbD.Text = parameters[2];
            this.tbDP.Text = parameters[3];
            this.tbDQ.Text = parameters[4];
            this.tbIQ.Text = parameters[5];
            this.tbP.Text = parameters[6];
            this.tbQ.Text = parameters[7];
        }

        /// <summary>
        /// On click, the message written it acquired, as well as decrypted with the private key. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            byte[] cipherBytes = encryptor.GetCipherBytes();

            string decrypted = encryptor.DecryptBytes(cipherBytes);

            this.tbCipherBytes.Text = Convert.ToBase64String(cipherBytes);
            this.tbDecrypted.Text = decrypted;
        }
    }
}