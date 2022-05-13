
namespace CMPG315_App_Project
{
    partial class Register
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
            this.btnReg = new System.Windows.Forms.Button();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(243, 341);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(171, 53);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.Location = new System.Drawing.Point(12, 9);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(205, 29);
            this.lblRegistration.TabIndex = 1;
            this.lblRegistration.Text = "Registartion Page";
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegEmail.Location = new System.Drawing.Point(14, 151);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(80, 29);
            this.lblRegEmail.TabIndex = 2;
            this.lblRegEmail.Text = "Email:";
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPassword.Location = new System.Drawing.Point(14, 252);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(126, 29);
            this.lblRegPassword.TabIndex = 3;
            this.lblRegPassword.Text = "Password:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(16, 88);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(422, 29);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Please enter the following information:";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegEmail.Location = new System.Drawing.Point(154, 148);
            this.txtRegEmail.Multiline = true;
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(260, 49);
            this.txtRegEmail.TabIndex = 5;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPassword.Location = new System.Drawing.Point(154, 249);
            this.txtRegPassword.Multiline = true;
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(260, 47);
            this.txtRegPassword.TabIndex = 6;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblRegPassword);
            this.Controls.Add(this.lblRegEmail);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.btnReg);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.TextBox txtRegPassword;
    }
}