using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_Hashing
{
    public partial class Form1 : Form
    {
        private Encryptor encrypt;
        private string secretKey = "ThisIsASecret";

        public Form1()
        {
            encrypt = new Encryptor();

            InitializeComponent();

            cbEncryptionTypes.DataSource = encrypt.EncryptionTypes;
        }

        private void btnComputeMAC_Click(object sender, EventArgs e)
        {
            UpdateMAC();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string inputText = this.tbTextInput.Text == string.Empty ? "" : this.tbTextInput.Text;
            byte[] msgBytes = Encoding.UTF8.GetBytes(inputText);

            if (encrypt.IsMACNull())
            {
                UpdateMAC();
            }

            encrypt.EncryptText(msgBytes, out byte[] hash, out byte[] encryptedBytes);

            this.tbASCIIOutput.Text = Convert.ToBase64String(encryptedBytes);
            this.tbHexOutput.Text = Convert.ToHexString(encryptedBytes);
        }

        private void UpdateMAC()
        {
            string keyText = this.tbKeyInput.Text == string.Empty ? secretKey : this.tbKeyInput.Text;
            byte[] key = Encoding.UTF8.GetBytes(keyText);

            string encryptionType = this.cbEncryptionTypes.SelectedValue.ToString();
            encrypt.CreateMAC(encryptionType, key);
            this.tbMACOutput.Text = encrypt.GetMAC();
        }
    }
}