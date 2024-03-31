namespace SocietySync
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
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(78, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 430);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(117, 48);
            label4.Name = "label4";
            label4.Size = new Size(117, 49);
            label4.TabIndex = 6;
            label4.Text = "LogIn";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(124, 207);
            label1.Name = "label1";
            label1.Size = new Size(103, 27);
            label1.TabIndex = 5;
            label1.Text = "Password";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Trebuchet MS", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(122, 292);
            button1.Name = "button1";
            button1.Size = new Size(112, 46);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(126, 605);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(260, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "New here? Click here to sign up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(124, 117);
            label2.Name = "label2";
            label2.Size = new Size(110, 27);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(69, 237);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(219, 31);
            maskedTextBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 31);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(331, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 46);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(201, 63);
            label3.Name = "label3";
            label3.Size = new Size(456, 26);
            label3.TabIndex = 5;
            label3.Text = "Your one stop solution to society management!";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(1, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 89);
            panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(509, 239);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 278);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(854, 700);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}