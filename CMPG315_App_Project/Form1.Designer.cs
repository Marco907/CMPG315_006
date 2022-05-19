namespace CMPG315_App_Project
{
    partial class frm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(574, 406);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 35);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(98, 86);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(538, 242);
            this.txtInfo.TabIndex = 4;
            this.txtInfo.Text = " ";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(100, 339);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(536, 26);
            this.txtMessage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 344);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(434, 406);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 35);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(98, 46);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(536, 26);
            this.txtIP.TabIndex = 13;
            this.txtIP.Text = "192.168.0.2:9000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Server";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnConnect);
            this.MaximizeBox = false;
            this.Name = "frm1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
    }
}

