using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinFormsApp_RSATCPReciever
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream netStream;

        public Form1()
        {
            InitializeComponent();

            client = SetupServer().Result;
            netStream = client.GetStream();

            this.tbText.Invoke((MethodInvoker)delegate
            {
                while (true)
                {
                    while (netStream.DataAvailable)
                    {
                        byte[] bytes = new byte[client.Available];
                        netStream.Read(bytes, 0, bytes.Length);
                        this.tbText.Text = Encoding.UTF8.GetString(bytes);
                    }
                }
            });
        }

        private async Task<TcpClient> SetupServer()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            //ip = Dns.Resolve("localhost").AddressList[0];
            int port = 80;
            TcpListener server = new TcpListener(ip, port);
            server.Start();

            TcpClient client = await server.AcceptTcpClientAsync();

            return client;
        }




    }
}