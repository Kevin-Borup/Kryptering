using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinFormsApp_RSATCPSender
{
    public partial class Form1 : Form
    {
        NetworkStream netStream;

        public Form1()
        {
            InitializeComponent();

            netStream = ConnectToServer().Result;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = this.tbPlainText.Text;

            if (!string.IsNullOrWhiteSpace(text))
            {
                netStream.Write(Encoding.UTF8.GetBytes(text));
            }
        }

        private async Task<NetworkStream> ConnectToServer()
        {
            TcpClient client = new TcpClient("client", 81);

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            //ip = Dns.Resolve("localhost").AddressList[0];
            int port = 80;

            await client.ConnectAsync(ip, port);

            NetworkStream netStream = client.GetStream();

            return netStream;
        }
    }
}