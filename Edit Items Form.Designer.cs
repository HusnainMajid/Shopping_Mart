namespace Mart_APP
{
    partial class Edit_Items_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Items_Form));
            panel1 = new Panel();
            deletebtn = new Button();
            updatebtn = new Button();
            discounttxt = new TextBox();
            label4 = new Label();
            pricetxt = new TextBox();
            label3 = new Label();
            idtxt = new TextBox();
            label5 = new Label();
            nametxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(deletebtn);
            panel1.Controls.Add(updatebtn);
            panel1.Controls.Add(discounttxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pricetxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(idtxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(nametxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(159, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 364);
            panel1.TabIndex = 4;
            // 
            // deletebtn
            // 
            deletebtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtn.Location = new Point(237, 292);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(208, 50);
            deletebtn.TabIndex = 5;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.Location = new Point(23, 292);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(208, 50);
            updatebtn.TabIndex = 4;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // discounttxt
            // 
            discounttxt.Location = new Point(133, 232);
            discounttxt.Name = "discounttxt";
            discounttxt.Size = new Size(299, 31);
            discounttxt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 232);
            label4.Name = "label4";
            label4.Size = new Size(110, 26);
            label4.TabIndex = 1;
            label4.Text = "Discount:";
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(133, 173);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(299, 31);
            pricetxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 173);
            label3.Name = "label3";
            label3.Size = new Size(75, 26);
            label3.TabIndex = 1;
            label3.Text = "Price:";
            // 
            // idtxt
            // 
            idtxt.Location = new Point(133, 57);
            idtxt.Name = "idtxt";
            idtxt.ReadOnly = true;
            idtxt.Size = new Size(299, 31);
            idtxt.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 57);
            label5.Name = "label5";
            label5.Size = new Size(42, 26);
            label5.TabIndex = 1;
            label5.Text = "Id:";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(133, 114);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(299, 31);
            nametxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 114);
            label2.Name = "label2";
            label2.Size = new Size(79, 26);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 41);
            label1.TabIndex = 0;
            label1.Text = "Edit Items";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 579);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(774, 231);
            dataGridView1.TabIndex = 5;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // Edit_Items_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 822);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Edit_Items_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit_Items_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button deletebtn;
        private Button updatebtn;
        private TextBox discounttxt;
        private Label label4;
        private TextBox pricetxt;
        private Label label3;
        private TextBox idtxt;
        private Label label5;
        private TextBox nametxt;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
    }
}