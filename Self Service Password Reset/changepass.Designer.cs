namespace resetpassword
{
    partial class changepass
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
            this.newpass = new System.Windows.Forms.TextBox();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm New Password";
            // 
            // newpass
            // 
            this.newpass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.newpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newpass.Font = new System.Drawing.Font("Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.newpass.Location = new System.Drawing.Point(182, 55);
            this.newpass.Name = "newpass";
            this.newpass.PasswordChar = '*';
            this.newpass.Size = new System.Drawing.Size(137, 16);
            this.newpass.TabIndex = 2;
            // 
            // confirmpass
            // 
            this.confirmpass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmpass.Font = new System.Drawing.Font("Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.confirmpass.Location = new System.Drawing.Point(182, 132);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.PasswordChar = '*';
            this.confirmpass.Size = new System.Drawing.Size(137, 16);
            this.confirmpass.TabIndex = 3;
            this.confirmpass.TextChanged += new System.EventHandler(this.confirmpass_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(113, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(376, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changepass";
            this.Text = "changepass";
            this.Load += new System.EventHandler(this.changepass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox confirmpass;
        private System.Windows.Forms.Button button1;
    }
}