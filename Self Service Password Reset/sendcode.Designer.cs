namespace resetpassword
{
    partial class sendcode
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtotp = new System.Windows.Forms.TextBox();
            this.btnsendotp = new System.Windows.Forms.Button();
            this.btnverifyotp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Verification Code:";
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Location = new System.Drawing.Point(181, 51);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(190, 13);
            this.txtemail.TabIndex = 2;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtotp
            // 
            this.txtotp.BackColor = System.Drawing.SystemColors.Window;
            this.txtotp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtotp.Location = new System.Drawing.Point(181, 129);
            this.txtotp.Name = "txtotp";
            this.txtotp.Size = new System.Drawing.Size(190, 13);
            this.txtotp.TabIndex = 3;
            // 
            // btnsendotp
            // 
            this.btnsendotp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsendotp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsendotp.Location = new System.Drawing.Point(389, 46);
            this.btnsendotp.Name = "btnsendotp";
            this.btnsendotp.Size = new System.Drawing.Size(75, 23);
            this.btnsendotp.TabIndex = 4;
            this.btnsendotp.Text = "Send OTP";
            this.btnsendotp.UseVisualStyleBackColor = false;
            this.btnsendotp.Click += new System.EventHandler(this.btnsendotp_Click);
            // 
            // btnverifyotp
            // 
            this.btnverifyotp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnverifyotp.Location = new System.Drawing.Point(386, 129);
            this.btnverifyotp.Name = "btnverifyotp";
            this.btnverifyotp.Size = new System.Drawing.Size(75, 23);
            this.btnverifyotp.TabIndex = 5;
            this.btnverifyotp.Text = "Verify OTP";
            this.btnverifyotp.UseVisualStyleBackColor = false;
            this.btnverifyotp.Click += new System.EventHandler(this.btnverifyotp_Click);
            // 
            // sendcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(476, 246);
            this.Controls.Add(this.btnverifyotp);
            this.Controls.Add(this.btnsendotp);
            this.Controls.Add(this.txtotp);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sendcode";
            this.Text = "sendcode";
            this.Load += new System.EventHandler(this.sendcode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtotp;
        private System.Windows.Forms.Button btnsendotp;
        private System.Windows.Forms.Button btnverifyotp;
    }
}