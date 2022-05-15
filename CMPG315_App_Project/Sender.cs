using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace CMPG315_App_Project
{
    public partial class Sender : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recievedMessage;
        public string textToSend;

        public Sender()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtServerIP.Text = address.ToString();
                }
            }
        }

        private void Sender_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(tbxPort.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(tbxCleintIP.Text), int.Parse(tbxClientPort.Text));
            try
            {
                tbxScreen.AppendText("Connecting.....");
                client.Connect(IpEnd);
                if (client.Connected)
                {
                    tbxScreen.AppendText("Connected to server");
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lost connection");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recievedMessage = STR.ReadLine();
                    this.Invoke((MethodInvoker)delegate { tbxScreen.AppendText("You:" + recievedMessage + "\n"); }); // verandeer \r\n na you to \n
                    recievedMessage = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Lost connection");
                    break;
                }
            }  
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(textToSend);
                this.tbxScreen.Invoke((MethodInvoker)delegate { tbxScreen.AppendText("Me:" + textToSend + "\n"); });// verandeer \r\n na me to \n
            }
            else
            {
                MessageBox.Show("Lost connection");
            }

            backgroundWorker2.CancelAsync();
        }

        private void btnSenderSend_Click(object sender, EventArgs e)
        {
            if (txtTypeMessage.Text != "")
            {
                textToSend = txtTypeMessage.Text;
                backgroundWorker2.RunWorkerAsync();
                txtTypeMessage.Text = "";
            }
            else
            {
                MessageBox.Show("Please type a message");
            }
        }
    }
}
