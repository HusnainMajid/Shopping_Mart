namespace Mart_APP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            invoicetxt = new TextBox();
            label3 = new Label();
            usertxt = new TextBox();
            label4 = new Label();
            itemcb = new ComboBox();
            label5 = new Label();
            pricetxt = new TextBox();
            label6 = new Label();
            discounttxt = new TextBox();
            label7 = new Label();
            quantitytxt = new TextBox();
            label8 = new Label();
            totalcosttxt = new TextBox();
            label9 = new Label();
            finalcosttxt = new TextBox();
            label10 = new Label();
            subtotaltxt = new TextBox();
            label11 = new Label();
            amounttxt = new TextBox();
            label12 = new Label();
            changetxt = new TextBox();
            label13 = new Label();
            taxtxt = new TextBox();
            addbtn = new Button();
            resetbtn = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            Insertbtn = new Button();
            Printprebtn = new Button();
            Printbtn = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addItemsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            editItemsToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            viewDataToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            detailsAndSearchToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 241);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Invoice No:";
            // 
            // invoicetxt
            // 
            invoicetxt.Location = new Point(33, 269);
            invoicetxt.Name = "invoicetxt";
            invoicetxt.ReadOnly = true;
            invoicetxt.Size = new Size(233, 31);
            invoicetxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 303);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 1;
            label3.Text = "User:";
            // 
            // usertxt
            // 
            usertxt.Location = new Point(33, 331);
            usertxt.Name = "usertxt";
            usertxt.ReadOnly = true;
            usertxt.Size = new Size(233, 31);
            usertxt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 366);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 1;
            label4.Text = "Select Items:";
            // 
            // itemcb
            // 
            itemcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            itemcb.AutoCompleteSource = AutoCompleteSource.ListItems;
            itemcb.FormattingEnabled = true;
            itemcb.Location = new Point(33, 394);
            itemcb.Name = "itemcb";
            itemcb.Size = new Size(233, 33);
            itemcb.TabIndex = 0;
            itemcb.SelectedIndexChanged += itemcb_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 427);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 1;
            label5.Text = "Unit Price:";
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(33, 455);
            pricetxt.Name = "pricetxt";
            pricetxt.ReadOnly = true;
            pricetxt.Size = new Size(233, 31);
            pricetxt.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 490);
            label6.Name = "label6";
            label6.Size = new Size(191, 25);
            label6.TabIndex = 1;
            label6.Text = "Discount Per Item:";
            // 
            // discounttxt
            // 
            discounttxt.Location = new Point(33, 518);
            discounttxt.Name = "discounttxt";
            discounttxt.ReadOnly = true;
            discounttxt.Size = new Size(233, 31);
            discounttxt.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(307, 241);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 1;
            label7.Text = "Quantity:";
            // 
            // quantitytxt
            // 
            quantitytxt.Enabled = false;
            quantitytxt.Location = new Point(307, 269);
            quantitytxt.MaxLength = 2;
            quantitytxt.Name = "quantitytxt";
            quantitytxt.Size = new Size(233, 31);
            quantitytxt.TabIndex = 3;
            quantitytxt.TextChanged += quantitytxt_TextChanged;
            quantitytxt.KeyPress += quantitytxt_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(307, 427);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 1;
            label8.Text = "Total Cost:";
            // 
            // totalcosttxt
            // 
            totalcosttxt.Location = new Point(307, 455);
            totalcosttxt.Name = "totalcosttxt";
            totalcosttxt.ReadOnly = true;
            totalcosttxt.Size = new Size(233, 31);
            totalcosttxt.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(307, 490);
            label9.Name = "label9";
            label9.Size = new Size(117, 25);
            label9.TabIndex = 1;
            label9.Text = "Final Cost:";
            // 
            // finalcosttxt
            // 
            finalcosttxt.Location = new Point(307, 518);
            finalcosttxt.Name = "finalcosttxt";
            finalcosttxt.ReadOnly = true;
            finalcosttxt.Size = new Size(233, 31);
            finalcosttxt.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(307, 303);
            label10.Name = "label10";
            label10.Size = new Size(110, 25);
            label10.TabIndex = 1;
            label10.Text = "Sub-Total:";
            // 
            // subtotaltxt
            // 
            subtotaltxt.Location = new Point(307, 331);
            subtotaltxt.Name = "subtotaltxt";
            subtotaltxt.ReadOnly = true;
            subtotaltxt.Size = new Size(233, 31);
            subtotaltxt.TabIndex = 4;
            subtotaltxt.TextChanged += subtotaltxt_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(573, 241);
            label11.Name = "label11";
            label11.Size = new Size(143, 25);
            label11.TabIndex = 1;
            label11.Text = "Amount Paid:";
            // 
            // amounttxt
            // 
            amounttxt.Location = new Point(573, 269);
            amounttxt.Name = "amounttxt";
            amounttxt.Size = new Size(233, 31);
            amounttxt.TabIndex = 8;
            amounttxt.TextChanged += amounttxt_TextChanged;
            amounttxt.KeyPress += amounttxt_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(573, 303);
            label12.Name = "label12";
            label12.Size = new Size(91, 25);
            label12.TabIndex = 1;
            label12.Text = "Change:";
            // 
            // changetxt
            // 
            changetxt.Location = new Point(573, 331);
            changetxt.Name = "changetxt";
            changetxt.ReadOnly = true;
            changetxt.Size = new Size(233, 31);
            changetxt.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(307, 365);
            label13.Name = "label13";
            label13.Size = new Size(54, 25);
            label13.TabIndex = 1;
            label13.Text = "Tax:";
            // 
            // taxtxt
            // 
            taxtxt.Location = new Point(307, 393);
            taxtxt.Name = "taxtxt";
            taxtxt.ReadOnly = true;
            taxtxt.Size = new Size(233, 31);
            taxtxt.TabIndex = 5;
            taxtxt.TextChanged += taxtxt_TextChanged;
            // 
            // addbtn
            // 
            addbtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbtn.Location = new Point(38, 568);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(112, 34);
            addbtn.TabIndex = 4;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetbtn.Location = new Point(181, 568);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(112, 34);
            resetbtn.TabIndex = 4;
            resetbtn.Text = "RESET";
            resetbtn.UseVisualStyleBackColor = true;
            resetbtn.Click += resetbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 624);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(813, 208);
            dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(813, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(274, 847);
            button1.Name = "button1";
            button1.Size = new Size(266, 34);
            button1.TabIndex = 11;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Insertbtn
            // 
            Insertbtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertbtn.Location = new Point(321, 568);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(119, 34);
            Insertbtn.TabIndex = 12;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = true;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // Printprebtn
            // 
            Printprebtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Printprebtn.Location = new Point(604, 393);
            Printprebtn.Name = "Printprebtn";
            Printprebtn.Size = new Size(131, 71);
            Printprebtn.TabIndex = 13;
            Printprebtn.Text = "Print Preview";
            Printprebtn.UseVisualStyleBackColor = true;
            Printprebtn.Click += Printprebtn_Click;
            // 
            // Printbtn
            // 
            Printbtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Printbtn.Location = new Point(604, 483);
            Printbtn.Name = "Printbtn";
            Printbtn.Size = new Size(131, 71);
            Printbtn.TabIndex = 14;
            Printbtn.Text = "Print";
            Printbtn.UseVisualStyleBackColor = true;
            Printbtn.Click += Printbtn_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolStripMenuItem1, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(837, 33);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addItemsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // addItemsToolStripMenuItem
            // 
            addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            addItemsToolStripMenuItem.Size = new Size(197, 34);
            addItemsToolStripMenuItem.Text = "Add Items";
            addItemsToolStripMenuItem.Click += addItemsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(197, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editItemsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // editItemsToolStripMenuItem
            // 
            editItemsToolStripMenuItem.Name = "editItemsToolStripMenuItem";
            editItemsToolStripMenuItem.Size = new Size(193, 34);
            editItemsToolStripMenuItem.Text = "Edit Items";
            editItemsToolStripMenuItem.Click += editItemsToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewDataToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // viewDataToolStripMenuItem
            // 
            viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            viewDataToolStripMenuItem.Size = new Size(193, 34);
            viewDataToolStripMenuItem.Text = "View Data";
            viewDataToolStripMenuItem.Click += viewDataToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { detailsAndSearchToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(81, 29);
            toolStripMenuItem1.Text = "Details";
            // 
            // detailsAndSearchToolStripMenuItem
            // 
            detailsAndSearchToolStripMenuItem.Name = "detailsAndSearchToolStripMenuItem";
            detailsAndSearchToolStripMenuItem.Size = new Size(259, 34);
            detailsAndSearchToolStripMenuItem.Text = "Details and Search";
            detailsAndSearchToolStripMenuItem.Click += detailsAndSearchToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(78, 29);
            aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(151, 34);
            helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 886);
            Controls.Add(Printbtn);
            Controls.Add(Printprebtn);
            Controls.Add(Insertbtn);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(resetbtn);
            Controls.Add(addbtn);
            Controls.Add(itemcb);
            Controls.Add(taxtxt);
            Controls.Add(changetxt);
            Controls.Add(subtotaltxt);
            Controls.Add(label13);
            Controls.Add(usertxt);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(finalcosttxt);
            Controls.Add(discounttxt);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(totalcosttxt);
            Controls.Add(label8);
            Controls.Add(amounttxt);
            Controls.Add(pricetxt);
            Controls.Add(quantitytxt);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(invoicetxt);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ROYAL MART ";
            Activated += Form1_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox invoicetxt;
        private Label label3;
        private TextBox usertxt;
        private Label label4;
        private ComboBox itemcb;
        private Label label5;
        private TextBox pricetxt;
        private Label label6;
        private TextBox discounttxt;
        private Label label7;
        private TextBox quantitytxt;
        private Label label8;
        private TextBox totalcosttxt;
        private Label label9;
        private TextBox finalcosttxt;
        private Label label10;
        private TextBox subtotaltxt;
        private Label label11;
        private TextBox amounttxt;
        private Label label12;
        private TextBox changetxt;
        private Label label13;
        private TextBox taxtxt;
        private Button addbtn;
        private Button resetbtn;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button Insertbtn;
        private Button Printprebtn;
        private Button Printbtn;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addItemsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem editItemsToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem viewDataToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem detailsAndSearchToolStripMenuItem;
    }
}
