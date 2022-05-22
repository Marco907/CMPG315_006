using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void frm1_Load(object sender, EventArgs e)
        {
            
            var vIP = getLocalIP() + ":9000";
            txtIP.Text = vIP;
            btnSend.Enabled = false;
            server = new SimpleTcpServer(vIP);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;

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

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            var vMessage = "";
            this.Invoke((MethodInvoker)delegate
            {
                vMessage += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                txtInfo.Text += vMessage;
                
                
                if (lstClientIP.Items.Count > 1)
                {
                    for (int i = 0; i < lstClientIP.Items.Count; i++)
                    {
                        var vIP = lstClientIP.Items[i].ToString();
                        if (vIP != e.IpPort)
                        {
                            server.Send(vIP, vMessage);
                        }
                    }
                }
                
            });
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            var vMessage = "";
            this.Invoke((MethodInvoker)delegate
            {
                vMessage += $"{e.IpPort} disconnected{Environment.NewLine}";
                txtInfo.Text += vMessage;
                
                if (lstClientIP.Items.Count > 1)
                {
                    for (int i = 0; i < lstClientIP.Items.Count; i++)
                    {
                        var vIP = lstClientIP.Items[i].ToString();
                        if (vIP != e.IpPort)
                        {
                            server.Send(vIP, vMessage);
                        }
                    }
                }
                lstClientIP.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            var vMessage = "";
            this.Invoke((MethodInvoker)delegate
            {
                vMessage += $"{e.IpPort} connected{Environment.NewLine}";
                txtInfo.Text += vMessage;
                if (lstClientIP.Items.Count >=0)
                {
                    for (int i = 0; i < lstClientIP.Items.Count; i++)
                    {
                        var vIP = lstClientIP.Items[i].ToString();
                        if (vIP != e.IpPort)
                        {
                            server.Send(vIP, vMessage);
                        }
                    }
                }
                lstClientIP.Items.Add(e.IpPort);
            });
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            txtInfo.Text = $"Starting....{Environment.NewLine}";
            btnStart.Enabled = false;
            btnSend.Enabled = true;
            
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txtMessage.Text) && lstClientIP.SelectedItem != null)
                {
                    server.Send(lstClientIP.SelectedItem.ToString(), txtMessage.Text);
                    txtInfo.Text += $"{txtMessage.Text}{Environment.NewLine}";
                    txtMessage.Text = string.Empty;
                }
            }
            
        }
    }
}
