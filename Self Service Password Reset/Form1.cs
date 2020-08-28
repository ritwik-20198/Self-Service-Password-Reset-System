using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace resetpassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            sendcode sc = new sendcode();
            this.Hide();
            sc.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=resetpassword; password = ritwik123");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from  tblforgetpass  where useremail='" + txtuser.Text + "' and password='"+txtpass.Text+"'", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt); 
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Sucessful");
            }
            else
            {
                MessageBox.Show("Login fail Error..try again");
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
