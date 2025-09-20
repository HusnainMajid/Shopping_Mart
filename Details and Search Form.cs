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
    public partial class Details_and_Search_Form : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Details_and_Search_Form()
        {
            InitializeComponent();
            bindgridview();
        }

        void bindgridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SP_GETBOTHTABLEDATA";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SP_GETBOTHTABLEDATAbyinvoice";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@invoiceID", textBox1.Text);
            SqlDataAdapter sda = new SqlDataAdapter();
            //sda.SelectCommand.Parameters.AddWithValue("@inoivceId", textBox1.Text);
            sda.SelectCommand = cmd;
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[10].Visible = false;
            finalcostxt.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
        }

        private void searchdatetimebtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "SP_GETBOTHTABLEDATAbydatetime";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstdate", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@seconddate", dateTimePicker2.Value);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);

            dataGridView1.DataSource = data;

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            bindgridview();
        }

        private void finalcostxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

    }
}
