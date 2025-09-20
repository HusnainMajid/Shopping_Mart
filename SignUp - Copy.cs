using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mart_APP
{
    public partial class SignUp : Form
    {
        string pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
        string passpattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public SignUp()
        {
            InitializeComponent();
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nametxt.Text) == true)
            {
                Nametxt.Focus();
                errorProvider1.SetError(this.Nametxt, "Enter Your Name.");
            }
            
            else if (string.IsNullOrEmpty(Srnametxt.Text) == true)
            {
                Srnametxt.Focus();
                errorProvider2.SetError(this.Srnametxt, "Enter Your Sur Name.");
            }
            else if (Gendercb.SelectedItem == null)
            {
                Gendercb.Focus();
                errorProvider3.SetError(this.Gendercb, "Please select Gender.");
            }
            else if (numericUpDown1.Value == 0)
            {
                numericUpDown1.Focus();
                errorProvider4.SetError(this.numericUpDown1, "Please SelectYour Class.");
            }
            else if (string.IsNullOrEmpty(Addresstxt.Text) == true)
            {
                Addresstxt.Focus();
                errorProvider5.SetError(this.Addresstxt, "Enter Your Address.");
            }
            else if (Regex.IsMatch(Emailtxt.Text, pattern) == false)
            {
                Emailtxt.Focus();
                errorProvider6.SetError(this.Emailtxt, "Please Enter Valid Email.");
            }
            else if (Regex.IsMatch(Passwordtxt.Text, passpattern) == false)
            {
                Passwordtxt.Focus();
                errorProvider7.SetError(this.Passwordtxt, "Uppercase , lowercase, Digit, symbol");
            }
            else if (Passwordtxt.Text != Cpasswordtxt.Text)
            {
                Cpasswordtxt.Focus();
                errorProvider8.SetError(this.Cpasswordtxt, "Password does not match.");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into signup values(@name,@sr_name,@gender,@age,@address,@email,@password)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", Nametxt.Text);
                cmd.Parameters.AddWithValue("@sr_name", Srnametxt.Text);
                cmd.Parameters.AddWithValue("@gender", Gendercb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@address", Addresstxt.Text);
                cmd.Parameters.AddWithValue("@email", Emailtxt.Text);
                cmd.Parameters.AddWithValue("@password", Passwordtxt.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Register Successfully..!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(" Username is: " + Nametxt.Text + "\n\n" + " Password is: " + Passwordtxt.Text, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login lg = new Login();
                    lg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Registeration Failed..!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
            }
        }

        private void Nametxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nametxt.Text) == true)
            {
                Nametxt.Focus();
                errorProvider1.SetError(this.Nametxt, "Enetr Your Name.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)   /* for backspace*/
            {
                e.Handled = false;
            }
            else if (ch == 32) /* for spacebar*/
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Srnametxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Srnametxt.Text) == true)
            {
                Srnametxt.Focus();
                errorProvider2.SetError(this.Srnametxt, "Enetr Your Sr Name.");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void Srnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)   /* for backspace*/
            {
                e.Handled = false;
            }
            else if (ch == 32) /* for spacebar*/
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Gendercb_Leave(object sender, EventArgs e)
        {
            if (Gendercb.SelectedItem == null)
            {
                Gendercb.Focus();
                errorProvider3.SetError(this.Gendercb, "Please select Gender.");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                numericUpDown1.Focus();
                errorProvider4.SetError(this.numericUpDown1, "Please SelectYour Age.");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void Addresstxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Addresstxt.Text) == true)
            {
                Addresstxt.Focus();
                errorProvider5.SetError(this.Addresstxt, "Enetr Your Address.");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void Emailtxt_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Emailtxt.Text, pattern) == false)
            {
                Emailtxt.Focus();
                errorProvider6.SetError(this.Emailtxt, "Please Enter Valid Email.");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void Passwordtxt_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Passwordtxt.Text, passpattern) == false)
            {
                Passwordtxt.Focus();
                errorProvider7.SetError(this.Passwordtxt, "Uppercase , lowercase, Digit, symbol");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void Cpasswordtxt_Leave(object sender, EventArgs e)
        {
            if (Passwordtxt.Text != Cpasswordtxt.Text)
            {
                Cpasswordtxt.Focus();
                errorProvider8.SetError(this.Cpasswordtxt, "Password does not match.");
            }
            else
            {
                errorProvider8.Clear();
            }
        }
    }
}
