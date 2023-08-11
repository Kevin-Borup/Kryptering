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
            encryptor.EncryptorTextHandledEvent += Encryptor_EncryptorTextHandledEvent;

            UpdateUI();

            encryptor.SetupServer();
        }

        /// <summary>
        /// A function triggered by an event invoked by the encryptor.
        /// This is when it has recieved data from the socket, and decrypted the data for display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Encryptor_EncryptorTextHandledEvent(object sender, EncryptorTextEventArgs e)
        {
            if (e.Text != null)
            {
                string text = e.Text;

                this.tbDecrypted.Invoke((MethodInvoker)delegate
                {
                    this.tbDecrypted.Text = text;
                });
            }

            if (e.Bytes != null)
            {
                byte[] cipherBytes = e.Bytes;

                this.tbCipherBytes.Invoke((MethodInvoker)delegate
                {
                    this.tbCipherBytes.Text = Convert.ToBase64String(cipherBytes);
                });
            }
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
    }
}