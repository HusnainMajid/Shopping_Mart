using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Mart_APP
{
    public partial class Login : Form
    {
        public static string username = "";
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from signup where name =@username and password = @password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", usernametxt.Text);
            cmd.Parameters.AddWithValue("@password", passwordtxt.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Login Successfull...!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username = usernametxt.Text;
                this.Hide();
                Form1 mainform = new Form1();
                mainform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed...!!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:
                    passwordtxt.UseSystemPasswordChar = false;
                    break;

                default:
                    passwordtxt.UseSystemPasswordChar = true;
                    break;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp su = new SignUp();
            this.Hide();
            su.ShowDialog();
        }
    }
}
