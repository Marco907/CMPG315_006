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
        /* private TcpClient client;
         public StreamReader STR;
         public StreamWriter STW;
         public string recievedMessage;
         public string textToSend;*/

        Socket Socket;
        EndPoint epLocal, Remote;

        public Sender()
         {
             InitializeComponent();

            /*IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtServerIP.Text = address.ToString();
                }
            }
            */

            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            txtServerIP.Text = getLocalIP();
            tbxCleintIP.Text = getLocalIP();// gaan later uithaal
        }

        private string getLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                Socket Socket = (Socket)aResult.AsyncState; // probleem
                int size = Socket.EndReceiveFrom(aResult, ref Remote);
                if (size > 0)
                {
                    byte[] recievedData = new byte[1464];
                    recievedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string recievedMessage = eEncoding.GetString(recievedData);
                    tbxScreen.AppendText("Friend: " + recievedMessage);
                }
                byte[] buffer = new byte[1500]; 
                Socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref Remote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Sender_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            /* TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(tbxPort.Text));
             listener.Start();
             client = listener.AcceptTcpClient();
             STR = new StreamReader(client.GetStream());
             STW = new StreamWriter(client.GetStream());
             STW.AutoFlush = true;
             backgroundWorker1.RunWorkerAsync();
             backgroundWorker2.WorkerSupportsCancellation = true; */
            
            var ServerPort = Convert.ToInt32(tbxPort.Text);
            var Address = IPAddress.Parse(txtServerIP.Text);
            var ServerCPort = Convert.ToInt32(tbxClientPort.Text);
            var CAddress = IPAddress.Parse(tbxCleintIP.Text);
            try
            {
                epLocal = new IPEndPoint(Address, ServerPort);
                Socket.Bind(epLocal);

                Remote = new IPEndPoint(CAddress, ServerCPort);
                Socket.Connect(Remote);

                byte[] buffer = new byte[1500];
                Socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref Remote, new AsyncCallback(MessageCallBack), buffer);

                btnConnect.Text = "Connected";
                btnStart.Enabled = false;
                txtTypeMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            /* client = new TcpClient();
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
             */
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            /* while (client.Connected)
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
             */
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            /*if (client.Connected)
            {
                STW.WriteLine(textToSend);
                this.tbxScreen.Invoke((MethodInvoker)delegate { tbxScreen.AppendText("Me:" + textToSend + "\n"); });// verandeer \r\n na me to \n
            }
            else
            {
                MessageBox.Show("Lost connection");
            }

            backgroundWorker2.CancelAsync(); */
        }

        private void btnSenderSend_Click(object sender, EventArgs e)
        {
           /* if (txtTypeMessage.Text != "")
            {
                textToSend = txtTypeMessage.Text;
                backgroundWorker2.RunWorkerAsync();
                txtTypeMessage.Text = "";
            }
            else
            {
                MessageBox.Show("Please type a message");
            }*/

            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(txtTypeMessage.Text);
                Socket.Send(msg);

                tbxScreen.AppendText("Me: " + txtTypeMessage.Text + "\n");
                txtTypeMessage.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
