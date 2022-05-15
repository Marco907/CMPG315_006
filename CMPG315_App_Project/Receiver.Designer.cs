
namespace CMPG315_App_Project
{
    partial class Receiver
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
            this.lblRIP = new System.Windows.Forms.Label();
            this.txtReceiverIP = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtRType = new System.Windows.Forms.TextBox();
            this.lblRMessage = new System.Windows.Forms.Label();
            this.btnReceiverSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRIP
            // 
            this.lblRIP.AutoSize = true;
            this.lblRIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRIP.Location = new System.Drawing.Point(38, 38);
            this.lblRIP.Name = "lblRIP";
            this.lblRIP.Size = new System.Drawing.Size(118, 29);
            this.lblRIP.TabIndex = 0;
            this.lblRIP.Text = "Server IP:";
            // 
            // txtReceiverIP
            // 
            this.txtReceiverIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverIP.Location = new System.Drawing.Point(187, 35);
            this.txtReceiverIP.Multiline = true;
            this.txtReceiverIP.Name = "txtReceiverIP";
            this.txtReceiverIP.Size = new System.Drawing.Size(240, 40);
            this.txtReceiverIP.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 105);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(615, 363);
            this.textBox2.TabIndex = 2;
            // 
            // txtRType
            // 
            this.txtRType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRType.Location = new System.Drawing.Point(275, 482);
            this.txtRType.Multiline = true;
            this.txtRType.Name = "txtRType";
            this.txtRType.Size = new System.Drawing.Size(381, 45);
            this.txtRType.TabIndex = 3;
            // 
            // lblRMessage
            // 
            this.lblRMessage.AutoSize = true;
            this.lblRMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMessage.Location = new System.Drawing.Point(36, 485);
            this.lblRMessage.Name = "lblRMessage";
            this.lblRMessage.Size = new System.Drawing.Size(234, 29);
            this.lblRMessage.TabIndex = 4;
            this.lblRMessage.Text = "Type message here:";
            // 
            // btnReceiverSend
            // 
            this.btnReceiverSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiverSend.Location = new System.Drawing.Point(505, 541);
            this.btnReceiverSend.Name = "btnReceiverSend";
            this.btnReceiverSend.Size = new System.Drawing.Size(151, 49);
            this.btnReceiverSend.TabIndex = 5;
            this.btnReceiverSend.Text = "Send";
            this.btnReceiverSend.UseVisualStyleBackColor = true;
            // 
            // Receiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 602);
            this.Controls.Add(this.btnReceiverSend);
            this.Controls.Add(this.lblRMessage);
            this.Controls.Add(this.txtRType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtReceiverIP);
            this.Controls.Add(this.lblRIP);
            this.Name = "Receiver";
            this.Text = "Receiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRIP;
        private System.Windows.Forms.TextBox txtReceiverIP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtRType;
        private System.Windows.Forms.Label lblRMessage;
        private System.Windows.Forms.Button btnReceiverSend;
    }
}