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
    public partial class Edit_Items_Form : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Edit_Items_Form()
        {
            InitializeComponent();
            bindgridview();
        }

        void bindgridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from item";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            pricetxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            discounttxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void updatebtn_Click(object sender, EventArgs e)
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
                //errorProvider4.SetError(this.updatebtn, "Please Fill all Fields.");
                SqlConnection con = new SqlConnection(cs);
                string query = "update item set item_name=@name , item_price=@price ,item_discount=@discount where item_id=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idtxt.Text);
                cmd.Parameters.AddWithValue("@name", nametxt.Text);
                cmd.Parameters.AddWithValue("@price", pricetxt.Text);
                cmd.Parameters.AddWithValue("@discount", discounttxt.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Item Updated Successfully..!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindgridview();
                    idtxt.Clear();
                    nametxt.Clear();
                    pricetxt.Clear();
                    discounttxt.Clear();
                    nametxt.Focus();
                }
                else
                {
                    MessageBox.Show(" Item is Not Updated..!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
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
                SqlConnection con = new SqlConnection(cs);
                string query = "delete from item where item_id=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idtxt.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Item Deleted Successfully..!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindgridview();
                    idtxt.Clear();
                    nametxt.Clear();
                    pricetxt.Clear();
                    discounttxt.Clear();
                    nametxt.Focus();
                }
                else
                {
                    MessageBox.Show(" Item is Not Deleted..!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
        }
    }
}
