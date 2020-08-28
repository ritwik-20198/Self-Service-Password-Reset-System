using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace resetpassword
{
    public partial class sendcode : Form
    {
        string otpcode;
        public static string to;

        public sendcode()
        {
            InitializeComponent();
        }

        private void btnsendotp_Click(object sender, EventArgs e)
        {
          

            string from, pass, messagebody;
            Random ran = new Random();
            otpcode = (ran.Next(999999)).ToString();
            MailMessage msg = new MailMessage();
            to = (txtemail.Text).ToString();
            from = "onestopsolutions8182@gmail.com";
            pass = "1Js17cs08182";
            messagebody = "To Reset your Password , Verification code is " + otpcode;
            msg.To.Add(to); 
            msg.From = new MailAddress(from);
            msg.Body = messagebody;
            msg.Subject = "Password Reset OTP";

            //networking part
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = resetpassword; password = ritwik123");
            con.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("select * from  tblforgetpass  where Useremail='" + txtemail.Text +"'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
           
            if (dt.Rows.Count > 0)
            {
                try
                {
                    smtp.Send(msg);
                    MessageBox.Show("Code sent successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("E-mail not registered!");
            }

        }

        private void btnverifyotp_Click(object sender, EventArgs e)
        {
            if (otpcode== (txtotp.Text).ToString()) 
            {
                to = txtemail.Text;
                changepass cp = new changepass();
                this.Hide();
                cp.Show();
            }
            else
            {
                MessageBox.Show("otp incorrect");
            }
        }

        private void sendcode_Load(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
