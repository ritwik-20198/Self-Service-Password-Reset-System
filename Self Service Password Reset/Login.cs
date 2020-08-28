using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace resetpassword
{
    public partial class Login : Form
    {
        public Login()
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
            SqlConnection con = new SqlConnection(@"Data Source=ME20198\SQL123;Initial Catalog=userdetails;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter("select * from  tblForgetpass  where UserEmail='" + txtuser.Text + "' and Password='" + txtpass.Text + "'", con);
            con.Open();
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
