namespace Mart_APP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            Loginbtn = new Button();
            passwordtxt = new TextBox();
            label3 = new Label();
            usernametxt = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 20);
            label1.Name = "label1";
            label1.Size = new Size(260, 41);
            label1.TabIndex = 0;
            label1.Text = "LOGIN FORM";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(Loginbtn);
            groupBox1.Controls.Add(passwordtxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(usernametxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(327, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 292);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOGIN";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(72, 245);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(316, 26);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Not Register Yet? Click Here.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(135, 159);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(166, 27);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Loginbtn
            // 
            Loginbtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbtn.Location = new Point(6, 192);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(417, 50);
            Loginbtn.TabIndex = 4;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(135, 116);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(270, 30);
            passwordtxt.TabIndex = 1;
            passwordtxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 116);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(135, 68);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(270, 30);
            usernametxt.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(123, 26);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 410);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox usernametxt;
        private Label label2;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Button Loginbtn;
        private TextBox passwordtxt;
        private Label label3;
    }
}