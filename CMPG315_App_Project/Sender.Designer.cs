
namespace CMPG315_App_Project
{
    partial class Sender
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
            this.lblSenderIP = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lblTMessage = new System.Windows.Forms.Label();
            this.txtTypeMessage = new System.Windows.Forms.TextBox();
            this.btnSenderSend = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxClientPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCleintIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbxScreen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSenderIP
            // 
            this.lblSenderIP.AutoSize = true;
            this.lblSenderIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderIP.Location = new System.Drawing.Point(36, 41);
            this.lblSenderIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenderIP.Name = "lblSenderIP";
            this.lblSenderIP.Size = new System.Drawing.Size(96, 24);
            this.lblSenderIP.TabIndex = 0;
            this.lblSenderIP.Text = "Server  IP:";
            // 
            // txtServerIP
            // 
            this.txtServerIP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerIP.Location = new System.Drawing.Point(140, 38);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServerIP.Multiline = true;
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(198, 37);
            this.txtServerIP.TabIndex = 1;
            // 
            // lblTMessage
            // 
            this.lblTMessage.AutoSize = true;
            this.lblTMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTMessage.Location = new System.Drawing.Point(17, 486);
            this.lblTMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTMessage.Name = "lblTMessage";
            this.lblTMessage.Size = new System.Drawing.Size(184, 24);
            this.lblTMessage.TabIndex = 3;
            this.lblTMessage.Text = "Type message here:";
            // 
            // txtTypeMessage
            // 
            this.txtTypeMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTypeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeMessage.Location = new System.Drawing.Point(214, 480);
            this.txtTypeMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTypeMessage.Multiline = true;
            this.txtTypeMessage.Name = "txtTypeMessage";
            this.txtTypeMessage.Size = new System.Drawing.Size(570, 37);
            this.txtTypeMessage.TabIndex = 4;
            // 
            // btnSenderSend
            // 
            this.btnSenderSend.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSenderSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenderSend.Location = new System.Drawing.Point(788, 480);
            this.btnSenderSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSenderSend.Name = "btnSenderSend";
            this.btnSenderSend.Size = new System.Drawing.Size(75, 37);
            this.btnSenderSend.TabIndex = 5;
            this.btnSenderSend.Text = "Send";
            this.btnSenderSend.UseVisualStyleBackColor = false;
            this.btnSenderSend.Click += new System.EventHandler(this.btnSenderSend_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tbxPort
            // 
            this.tbxPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPort.Location = new System.Drawing.Point(512, 38);
            this.tbxPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPort.Multiline = true;
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(198, 37);
            this.tbxPort.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "PORT:";
            // 
            // tbxClientPort
            // 
            this.tbxClientPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxClientPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClientPort.Location = new System.Drawing.Point(512, 93);
            this.tbxClientPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxClientPort.Multiline = true;
            this.tbxClientPort.Name = "tbxClientPort";
            this.tbxClientPort.Size = new System.Drawing.Size(198, 37);
            this.tbxClientPort.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "PORT:";
            // 
            // tbxCleintIP
            // 
            this.tbxCleintIP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxCleintIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCleintIP.Location = new System.Drawing.Point(140, 93);
            this.tbxCleintIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCleintIP.Multiline = true;
            this.tbxCleintIP.Name = "tbxCleintIP";
            this.tbxCleintIP.Size = new System.Drawing.Size(198, 37);
            this.tbxCleintIP.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client  IP:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(740, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 40);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbxScreen
            // 
            this.lbxScreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbxScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxScreen.FormattingEnabled = true;
            this.lbxScreen.Location = new System.Drawing.Point(40, 159);
            this.lbxScreen.Name = "lbxScreen";
            this.lbxScreen.Size = new System.Drawing.Size(822, 290);
            this.lbxScreen.TabIndex = 14;
            // 
            // Sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 615);
            this.Controls.Add(this.lbxScreen);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbxClientPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCleintIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSenderSend);
            this.Controls.Add(this.txtTypeMessage);
            this.Controls.Add(this.lblTMessage);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.lblSenderIP);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sender";
            this.Load += new System.EventHandler(this.Sender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenderIP;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label lblTMessage;
        private System.Windows.Forms.TextBox txtTypeMessage;
        private System.Windows.Forms.Button btnSenderSend;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxClientPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCleintIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbxScreen;
    }
}