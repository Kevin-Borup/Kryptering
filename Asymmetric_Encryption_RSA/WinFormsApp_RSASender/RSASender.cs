using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_RSASender
{
    public partial class RSASender : Form
    {
        private Encryptor encryptor;

        public RSASender()
        {
            InitializeComponent();

            encryptor = new Encryptor();

            // Gets the public key data, and displays it
            var publicData = encryptor.GetPublicData();

            this.tbExponent.Text = publicData.Exponent;
            this.tbModulus.Text = publicData.Modulus;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = this.tbPlainText.Text;

            if (!string.IsNullOrWhiteSpace(input))
            {
                // The text is encrypted and displayed to the user.
                byte[] cipherText = encryptor.EncryptText(input);

                this.tbCipherText.Text = Convert.ToBase64String(cipherText);
            }
        }

        private void tbPlainText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }
    }
}
