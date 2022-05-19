namespace TCPServer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstClientIP = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(148, 45);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(536, 26);
            this.txtIP.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(574, 478);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 35);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(148, 85);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(536, 315);
            this.txtInfo.TabIndex = 4;
            this.txtInfo.Text = " ";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(148, 411);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(536, 26);
            this.txtMessage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 415);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(434, 478);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 35);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstClientIP
            // 
            this.lstClientIP.FormattingEnabled = true;
            this.lstClientIP.ItemHeight = 20;
            this.lstClientIP.Location = new System.Drawing.Point(716, 85);
            this.lstClientIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstClientIP.Name = "lstClientIP";
            this.lstClientIP.Size = new System.Drawing.Size(294, 424);
            this.lstClientIP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Client IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstClientIP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP/IP Server";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstClientIP;
        private System.Windows.Forms.Label label3;
    }
}

