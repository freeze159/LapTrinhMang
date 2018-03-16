using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Socket server;
        Socket client;
        IPEndPoint ipe;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipe = new IPEndPoint(IPAddress.Any, 1234);
            server.Bind(ipe);
            server.Listen(5);
            client = server.Accept();
            txt_ClientIP.Text = (client.RemoteEndPoint).ToString();
            byte[] data = new byte[1024];
            client.Receive(data);
            listBox1.Items.Add("Client :" + Encoding.ASCII.GetString(data));

            
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string text = txt_Message.Text;
            listBox1.Items.Add("Server :" + text);
            txt_Message.Text = "";
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(text);
            client.Send(data);
            data = new byte[1024];
            client.Receive(data);
            listBox1.Items.Add("Client: " + Encoding.ASCII.GetString(data));
        }

        
    }
}
