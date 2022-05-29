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

namespace CMPG315_App_Project
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }
        
        SimpleTcpClient client;

        private void frm1_Load(object sender, EventArgs e)
        {
            var bCheck = isIP();

            if (bCheck == false)
            {
                MessageBox.Show("Please enter an IP address");
            }
            else
            {
                client = new SimpleTcpClient(txtIP.Text);
                client.Events.Connected += Events_Connected;
                client.Events.Disconnected += Events_Disconnected;
                client.Events.DataReceived += Events_dataReceived;
                btnSend.Enabled = false;
            }
            
        }
        
        private bool isIP ()
        {
            if (txtIP.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Events_dataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server:{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server disconnected.{Environment.NewLine}";
            });
            
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server connected.{Environment.NewLine}";
            });
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                frm1_Load(sender, e);
                client.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtMessage.Text))
                {
                    client.Send(Encoding.UTF8.GetBytes(txtMessage.Text));
                    txtInfo.Text += $"Me: {txtMessage.Text}{Environment.NewLine}";
                    txtMessage.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sender sender1 = new Sender();
            sender1.Show();
            this.Hide();
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
