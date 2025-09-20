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
    public partial class View_Data_Form : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public View_Data_Form()
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

        private void addbtn_Click(object sender, EventArgs e)
        {
            Add_Items_Form adf = new Add_Items_Form();
            adf.ShowDialog();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Edit_Items_Form edf = new Edit_Items_Form();
            edf.ShowDialog();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Edit_Items_Form edf = new Edit_Items_Form();
            edf.ShowDialog();
        }

        private void View_Data_Form_Activated(object sender, EventArgs e)
        {
            bindgridview();
        }
    }
}
