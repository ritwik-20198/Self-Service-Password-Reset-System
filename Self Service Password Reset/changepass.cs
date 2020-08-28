using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace resetpassword
{
    public partial class changepass : Form
    {
        string username = sendcode.to;
        public changepass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(newpass.Text==confirmpass.Text)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=resetpassword; password = ritwik123");
                MySqlCommand cmd = new MySqlCommand("update tblforgetpass set password='"+confirmpass.Text+"' where useremail='"+username+"'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Reset successfully");
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();



            }
            else
            {
                MessageBox.Show("the new password do not match ,Please Try Again!!");

            }
        }

        private void confirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void changepass_Load(object sender, EventArgs e)
        {

        }
    }
}
