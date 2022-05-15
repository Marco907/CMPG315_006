
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
            this.txtSenderIP = new System.Windows.Forms.TextBox();
            this.txtSenderMessage = new System.Windows.Forms.TextBox();
            this.lblTMessage = new System.Windows.Forms.Label();
            this.txtTypeMessage = new System.Windows.Forms.TextBox();
            this.btnSenderSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSenderIP
            // 
            this.lblSenderIP.AutoSize = true;
            this.lblSenderIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderIP.Location = new System.Drawing.Point(82, 49);
            this.lblSenderIP.Name = "lblSenderIP";
            this.lblSenderIP.Size = new System.Drawing.Size(124, 29);
            this.lblSenderIP.TabIndex = 0;
            this.lblSenderIP.Text = "Server  IP:";
            // 
            // txtSenderIP
            // 
            this.txtSenderIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderIP.Location = new System.Drawing.Point(221, 46);
            this.txtSenderIP.Multiline = true;
            this.txtSenderIP.Name = "txtSenderIP";
            this.txtSenderIP.Size = new System.Drawing.Size(262, 45);
            this.txtSenderIP.TabIndex = 1;
            // 
            // txtSenderMessage
            // 
            this.txtSenderMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderMessage.Location = new System.Drawing.Point(87, 109);
            this.txtSenderMessage.Multiline = true;
            this.txtSenderMessage.Name = "txtSenderMessage";
            this.txtSenderMessage.Size = new System.Drawing.Size(619, 370);
            this.txtSenderMessage.TabIndex = 2;
            // 
            // lblTMessage
            // 
            this.lblTMessage.AutoSize = true;
            this.lblTMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTMessage.Location = new System.Drawing.Point(87, 495);
            this.lblTMessage.Name = "lblTMessage";
            this.lblTMessage.Size = new System.Drawing.Size(234, 29);
            this.lblTMessage.TabIndex = 3;
            this.lblTMessage.Text = "Type message here:";
            // 
            // txtTypeMessage
            // 
            this.txtTypeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeMessage.Location = new System.Drawing.Point(327, 495);
            this.txtTypeMessage.Multiline = true;
            this.txtTypeMessage.Name = "txtTypeMessage";
            this.txtTypeMessage.Size = new System.Drawing.Size(379, 45);
            this.txtTypeMessage.TabIndex = 4;
            // 
            // btnSenderSend
            // 
            this.btnSenderSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenderSend.Location = new System.Drawing.Point(544, 546);
            this.btnSenderSend.Name = "btnSenderSend";
            this.btnSenderSend.Size = new System.Drawing.Size(162, 50);
            this.btnSenderSend.TabIndex = 5;
            this.btnSenderSend.Text = "Send";
            this.btnSenderSend.UseVisualStyleBackColor = true;
            // 
            // Sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 608);
            this.Controls.Add(this.btnSenderSend);
            this.Controls.Add(this.txtTypeMessage);
            this.Controls.Add(this.lblTMessage);
            this.Controls.Add(this.txtSenderMessage);
            this.Controls.Add(this.txtSenderIP);
            this.Controls.Add(this.lblSenderIP);
            this.Name = "Sender";
            this.Text = "Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenderIP;
        private System.Windows.Forms.TextBox txtSenderIP;
        private System.Windows.Forms.TextBox txtSenderMessage;
        private System.Windows.Forms.Label lblTMessage;
        private System.Windows.Forms.TextBox txtTypeMessage;
        private System.Windows.Forms.Button btnSenderSend;
    }
}