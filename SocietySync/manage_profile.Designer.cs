namespace SocietySync
{
    partial class manage_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage_profile));
            label4 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            label17 = new Label();
            label18 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label20 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(501, 8);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(237, 10);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 9;
            label7.Text = "label7";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 68);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(180, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 47);
            panel1.TabIndex = 24;
            panel1.Paint += panel1_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(52, 83);
            label14.Name = "label14";
            label14.Size = new Size(151, 23);
            label14.TabIndex = 12;
            label14.Text = "Confirm Password";
            label14.Click += label14_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(73, 14);
            label13.Name = "label13";
            label13.Size = new Size(121, 23);
            label13.TabIndex = 11;
            label13.Text = "New Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(354, 10);
            label12.Name = "label12";
            label12.Size = new Size(91, 23);
            label12.TabIndex = 8;
            label12.Text = "Last Name";
            label12.Click += label12_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(368, 113);
            label8.Name = "label8";
            label8.Size = new Size(234, 29);
            label8.TabIndex = 6;
            label8.Text = "Update your profile";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(82, 83);
            label17.Name = "label17";
            label17.Size = new Size(92, 23);
            label17.TabIndex = 5;
            label17.Text = "New Email";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(80, 12);
            label18.Name = "label18";
            label18.Size = new Size(94, 23);
            label18.TabIndex = 2;
            label18.Text = "First Name";
            label18.Click += label18_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(21, 40);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(219, 31);
            maskedTextBox2.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(21, 111);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(219, 31);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(20, 40);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(219, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 31);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(44, 14);
            label20.Name = "label20";
            label20.Size = new Size(162, 23);
            label20.TabIndex = 16;
            label20.Text = "Update Contact No";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(180, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 167);
            panel2.TabIndex = 26;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkMagenta;
            button3.Location = new Point(417, 520);
            button3.Name = "button3";
            button3.Size = new Size(176, 59);
            button3.TabIndex = 21;
            button3.Text = "Save Changes";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(-6, -10);
            panel3.Name = "panel3";
            panel3.Size = new Size(996, 95);
            panel3.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(396, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 46);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(266, 69);
            label3.Name = "label3";
            label3.Size = new Size(456, 26);
            label3.TabIndex = 5;
            label3.Text = "Your one stop solution to society management!";
            label3.Click += label3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(maskedTextBox2);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(label17);
            panel4.Location = new Point(559, 315);
            panel4.Name = "panel4";
            panel4.Size = new Size(256, 167);
            panel4.TabIndex = 27;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(180, 237);
            panel5.Name = "panel5";
            panel5.Size = new Size(635, 47);
            panel5.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(237, 10);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 15;
            label5.Text = "label11";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(75, 12);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 14;
            label6.Text = "Contact No";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(354, 12);
            label9.Name = "label9";
            label9.Size = new Size(120, 23);
            label9.TabIndex = 17;
            label9.Text = "Current Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(511, 10);
            label10.Name = "label10";
            label10.Size = new Size(59, 25);
            label10.TabIndex = 18;
            label10.Text = "label2";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(835, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 114);
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // manage_profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(976, 604);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label8);
            Name = "manage_profile";
            Text = "manage_profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label7;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label8;
        private Label label17;
        private Label label18;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label20;
        private Panel panel2;
        private Button button3;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel4;
        private Panel panel5;
        private Label label10;
        private Label label5;
        private Label label9;
        private Label label6;
        private PictureBox pictureBox3;
    }
}