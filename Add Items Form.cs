using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Mart_APP
{
    public partial class Add_Items_Form : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Add_Items_Form()
        {
            InitializeComponent();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametxt.Text) == true)
            {
                nametxt.Focus();
                errorProvider1.SetError(this.nametxt, "Please Enter Your Name");
            }
            else if (string.IsNullOrEmpty(pricetxt.Text) == true)
            {
                pricetxt.Focus();
                errorProvider2.SetError(this.pricetxt, "Please Enter Item's Price.");
            }
            else if (string.IsNullOrEmpty(discounttxt.Text) == true)
            {
                discounttxt.Focus();
                errorProvider3.SetError(this.discounttxt, "Please Enter Item's Discount.");
            }
            else
            {
                //errorProvider4.SetError(this.insertbtn, "Please Fill all Fields.");
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into item values(@name,@price,@discount)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", nametxt.Text);
                cmd.Parameters.AddWithValue("@price", pricetxt.Text);
                cmd.Parameters.AddWithValue("@discount", discounttxt.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Item Added Successfully..!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nametxt.Clear();
                    pricetxt.Clear();
                    discounttxt.Clear();
                    nametxt.Focus();
                }
                else
                {
                    MessageBox.Show(" Item is Not Added..!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
            }
        }

        private void Add_Items_Form_Load(object sender, EventArgs e)
        {

        }

        private void nametxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametxt.Text) == true)
            {
                nametxt.Focus();
                errorProvider1.SetError(this.nametxt, "Please Enter Your Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void pricetxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pricetxt.Text) == true)
            {
                pricetxt.Focus();
                errorProvider2.SetError(this.pricetxt, "Please Enter Item's Price.");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void discounttxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(discounttxt.Text) == true)
            {
                discounttxt.Focus();
                errorProvider3.SetError(this.discounttxt, "Please Enter Item's Discount.");
            }
            else
            {
                errorProvider3.Clear();
            }
        }
    }

}
