namespace Mart_APP
{
    partial class Add_Items_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Items_Form));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            insertbtn = new Button();
            discounttxt = new TextBox();
            label4 = new Label();
            pricetxt = new TextBox();
            label3 = new Label();
            nametxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(insertbtn);
            panel1.Controls.Add(discounttxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pricetxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nametxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(175, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 314);
            panel1.TabIndex = 2;
            // 
            // insertbtn
            // 
            insertbtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertbtn.Location = new Point(133, 243);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(208, 50);
            insertbtn.TabIndex = 3;
            insertbtn.Text = "Insert";
            insertbtn.UseVisualStyleBackColor = true;
            insertbtn.Click += insertbtn_Click;
            // 
            // discounttxt
            // 
            discounttxt.Location = new Point(133, 191);
            discounttxt.Name = "discounttxt";
            discounttxt.Size = new Size(299, 31);
            discounttxt.TabIndex = 2;
            discounttxt.Leave += discounttxt_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 191);
            label4.Name = "label4";
            label4.Size = new Size(110, 26);
            label4.TabIndex = 1;
            label4.Text = "Discount:";
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(133, 132);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(299, 31);
            pricetxt.TabIndex = 1;
            pricetxt.Leave += pricetxt_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 132);
            label3.Name = "label3";
            label3.Size = new Size(75, 26);
            label3.TabIndex = 1;
            label3.Text = "Price:";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(133, 73);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(299, 31);
            nametxt.TabIndex = 0;
            nametxt.Leave += nametxt_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 73);
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
            label1.Text = "Add Items";
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
            // Add_Items_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 663);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Add_Items_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Items_Form";
            Load += Add_Items_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button insertbtn;
        private TextBox discounttxt;
        private Label label4;
        private TextBox pricetxt;
        private Label label3;
        private TextBox nametxt;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
    }
}