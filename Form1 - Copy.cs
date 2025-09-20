using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Mart_APP
{
    public partial class Form1 : Form
    {
        int FinalCost = 0;
        int SrNo = 0;
        int tax = 0;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            Getinvoice_id();
            Getitems();
            usertxt.Text = Login.username;
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Sr No.";
            dataGridView1.Columns[1].Name = "Item Name";
            dataGridView1.Columns[2].Name = "Unit Price";
            dataGridView1.Columns[3].Name = "Discount Per Item";
            dataGridView1.Columns[4].Name = "Qunatity";
            dataGridView1.Columns[5].Name = "Sub Total";
            dataGridView1.Columns[6].Name = "Tax";
            dataGridView1.Columns[7].Name = "Total Cost";
        }

        void Getitems()
        {
            itemcb.Items.Clear();
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from item";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string item_names = dr.GetString(1);
                itemcb.Items.Add(item_names);
            }
            itemcb.Sorted = true;
            con.Close();
        }

        void Getprice()
        {
            if (itemcb.SelectedItem == null)
            {

            }
            else
            {
                int price = 0;
                SqlConnection con = new SqlConnection(cs);
                string query = "select item_price from item where item_name= @name";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", itemcb.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    price = Convert.ToInt32(data.Rows[0]["item_price"]);
                }
                pricetxt.Text = price.ToString();
            }
        }

        void Getdiscount()
        {
            if (itemcb.SelectedItem == null)
            {

            }
            else
            {

                int discount = 0;
                SqlConnection con = new SqlConnection(cs);
                string query = "select item_discount from item where item_name= @name";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", itemcb.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    discount = Convert.ToInt32(data.Rows[0]["item_discount"]);
                }
                discounttxt.Text = discount.ToString();
            }
        }

        private void itemcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Getprice();
            Getdiscount();
            quantitytxt.Enabled = true;
        }

        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantitytxt.Text) == true)
            {

            }
            else
            {
                int price = Convert.ToInt32(pricetxt.Text);
                int discount = Convert.ToInt32(discounttxt.Text);
                int quantity = Convert.ToInt32(quantitytxt.Text);

                int subtotal = price * quantity;
                subtotal = subtotal - discount * quantity;
                subtotaltxt.Text = subtotal.ToString();
            }
        }

        private void subtotaltxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(subtotaltxt.Text) == true)
            {

            }
            else
            {
                int subtotal = Convert.ToInt32(subtotaltxt.Text);

                if (subtotal >= 10000)
                {
                    tax = Convert.ToInt32(subtotal * 0.15);
                    taxtxt.Text = tax.ToString();
                }
                else if (subtotal >= 6000)
                {
                    tax = Convert.ToInt32(subtotal * 0.10);
                    taxtxt.Text = tax.ToString();
                }
                else if (subtotal >= 3000)
                {
                    tax = Convert.ToInt32(subtotal * 0.07);
                    taxtxt.Text = tax.ToString();
                }
                else if (subtotal >= 1000)
                {
                    tax = Convert.ToInt32(subtotal * 0.05);
                    taxtxt.Text = tax.ToString();
                }
                else
                {
                    tax = Convert.ToInt32(subtotal * 0.03);
                    taxtxt.Text = tax.ToString();
                }
            }
        }

        private void taxtxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taxtxt.Text) == true)
            {

            }
            else
            {
                int subtotal = Convert.ToInt32(subtotaltxt.Text);
                int tax = Convert.ToInt32(taxtxt.Text);

                int Totalcost = subtotal + tax;
                totalcosttxt.Text = Totalcost.ToString();
            }
        }

        void add_data_Gridview(string Sr_No, string item_name, string unit_price, string discount, string quantiy, string sub_total, string tax, string Total_cost)
        {
            string[] row = { Sr_No, item_name, unit_price, discount, quantiy, sub_total, tax, Total_cost };
            dataGridView1.Rows.Add(row);

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (itemcb.SelectedItem == null)
            {
                MessageBox.Show("Please Select the Items Firts...!!");
            }
            else
            {
                add_data_Gridview((++SrNo).ToString(), itemcb.SelectedItem.ToString(), pricetxt.Text, discounttxt.Text, quantitytxt.Text, subtotaltxt.Text, taxtxt.Text, totalcosttxt.Text);
                Reset_cntrls();
                calculate_finalcost();
            }
        }

        void Reset_cntrls()
        {
            itemcb.SelectedItem = null;
            pricetxt.Clear();
            discounttxt.Clear();
            quantitytxt.Clear();
            subtotaltxt.Clear();
            taxtxt.Clear();
            totalcosttxt.Clear();
            finalcosttxt.Clear();
            amounttxt.Clear();
            changetxt.Clear();
            quantitytxt.Enabled = false;
        }

        void calculate_finalcost()
        {
            FinalCost = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                FinalCost = FinalCost + Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
            }
            finalcosttxt.Text = FinalCost.ToString();
        }

        private void amounttxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amounttxt.Text) == true)
            {

            }
            else
            {
                int amountpaid = Convert.ToInt32(amounttxt.Text);
                int Fcost = Convert.ToInt32(finalcosttxt.Text);
                int change = amountpaid - Fcost;
                changetxt.Text = change.ToString();
            }

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset_cntrls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SrNo = 0;
        }
        void Getinvoice_id()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select invoice_id from order_master";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count < 1)
            {
                invoicetxt.Text = "1";
            }
            else
            {
                string query2 = "select max(invoice_id) from order_master";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                a = a + 1;
                invoicetxt.Text = a.ToString();


                con.Close();
            }
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into order_master values(@id, @user, @datetime, @finalcost)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", invoicetxt.Text);
            cmd.Parameters.AddWithValue("@user", usertxt.Text);
            cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@finalcost", finalcosttxt.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Inserted Successfully!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Getinvoice_id();
                Reset_cntrls();

            }
            else
            {
                MessageBox.Show("Insertion Failed...!!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            insertintoorderdetails();
        }

        int getlastinsertedinvoiceid()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select max(invoice_id) from order_master";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int MaxinvoiceId = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return MaxinvoiceId;
        }

        void insertintoorderdetails()
        {
            int a = 0;
            SqlConnection con = new SqlConnection(cs);
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells[1].Value == null) continue;

                    string query = @"INSERT INTO ORDER_DETAILS
                    (INVOICE_ID, ITEM_NAME, ITEM_PRICE, UNIT_PRICE, DISCOUNT_PER_ITEM, QUANTITY, SUB_TOTAL, TAX, TOTAL_COST)
                     VALUES (@invoice_id, @name, @item_price, @unit_price, @discount, @quantity, @subtotal, @tax, @totalcost)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@invoice_id", getlastinsertedinvoiceid());
                        cmd.Parameters.AddWithValue("@name", row.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@item_price", Convert.ToInt32(row.Cells[2].Value ?? 0));
                        cmd.Parameters.AddWithValue("@unit_price", Convert.ToInt32(row.Cells[2].Value ?? 0));
                        cmd.Parameters.AddWithValue("@discount", Convert.ToInt32(row.Cells[3].Value ?? 0));
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells[4].Value ?? 0));
                        cmd.Parameters.AddWithValue("@subtotal", Convert.ToInt32(row.Cells[5].Value ?? 0));
                        cmd.Parameters.AddWithValue("@tax", Convert.ToInt32(row.Cells[6].Value ?? 0));
                        cmd.Parameters.AddWithValue("@totalcost", Convert.ToInt32(row.Cells[7].Value ?? 0));

                        con.Open();
                        a = a + cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

            }
            catch
            {

            }
            
        }

        private void quantitytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void amounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Printprebtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Mart_removebg_preview;
            Image img = bmp;
            e.Graphics.DrawImage(img, 30, 5, 800, 250);
            e.Graphics.DrawString("Invoice Id : " + invoicetxt.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 300));
            e.Graphics.DrawString("Username : " + usertxt.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 330));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToShortDateString(), new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 360));
            e.Graphics.DrawString("Time : " + DateTime.Now.ToShortTimeString(), new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 390));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString("ITEMS", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(60, 480));
            e.Graphics.DrawString("QUANTITY", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(290, 480));
            e.Graphics.DrawString("PRICE", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(480, 480));
            e.Graphics.DrawString("DISCOUNT", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(620, 480));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 500));

            int gap1 = 540;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value != null)
                        {
                            e.Graphics.DrawString(
                                dataGridView1.Rows[i].Cells[1].Value.ToString(),
                                new Font("Times New Roman", 18, FontStyle.Regular),
                                Brushes.Black,
                                new Point(60, gap1)
                            );
                            gap1 = gap1 + 30;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            int gap2 = 540;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[4].Value != null)
                        {
                            e.Graphics.DrawString(
                                dataGridView1.Rows[i].Cells[4].Value.ToString(),
                                new Font("Times New Roman", 18, FontStyle.Regular),
                                Brushes.Black,
                                new Point(340, gap2)
                            );
                            gap2 = gap2 + 30;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            int gap3 = 540;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value != null)
                        {
                            e.Graphics.DrawString(
                                dataGridView1.Rows[i].Cells[2].Value.ToString(),
                                new Font("Times New Roman", 18, FontStyle.Regular),
                                Brushes.Black,
                                new Point(505, gap3)
                            );
                            gap3 = gap3 + 30;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            int gap4 = 540;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[3].Value != null)
                        {
                            e.Graphics.DrawString(
                                dataGridView1.Rows[i].Cells[3].Value.ToString(),
                                new Font("Times New Roman", 18, FontStyle.Regular),
                                Brushes.Black,
                                new Point(670, gap4)
                            );
                            gap4 = gap4 + 30;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            int subtotalprint = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                subtotalprint = subtotalprint + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            e.Graphics.DrawString("-------------------------------------------------------", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 850));
            e.Graphics.DrawString("Sub-Total : " + subtotalprint.ToString(), new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(70, 880));

            int taxprint = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                taxprint = taxprint + Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            e.Graphics.DrawString("Tax : " + taxprint.ToString(), new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(70, 910));
            e.Graphics.DrawString("Final-Cost : " + finalcosttxt.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(70, 940));
            e.Graphics.DrawString("-------------------------------------------------------", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 970));
            e.Graphics.DrawString("Amount Paid : " + amounttxt.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(70, 1000));
            e.Graphics.DrawString("Change : " + changetxt.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(70, 1030));
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Items_Form adf = new Add_Items_Form();
            adf.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Getitems();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Items_Form edf = new Edit_Items_Form();
            edf.ShowDialog();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Data_Form vdf = new View_Data_Form();
            vdf.ShowDialog();
        }

        private void detailsAndSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details_and_Search_Form das = new Details_and_Search_Form();
            das.ShowDialog();
        }
    }
}
