namespace SocietySync
{
    partial class event_mnagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(event_mnagement));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 119);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(506, 152);
            label2.Name = "label2";
            label2.Size = new Size(170, 26);
            label2.TabIndex = 1;
            label2.Text = "Add a new event ";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(506, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 300);
            panel1.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(244, 46);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(190, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(244, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 31);
            textBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 233);
            label6.Name = "label6";
            label6.Size = new Size(179, 26);
            label6.TabIndex = 6;
            label6.Text = "Event Description:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 170);
            label5.Name = "label5";
            label5.Size = new Size(130, 26);
            label5.TabIndex = 5;
            label5.Text = "Audience no:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 108);
            label4.Name = "label4";
            label4.Size = new Size(121, 26);
            label4.TabIndex = 4;
            label4.Text = "Event head:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 51);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 2;
            label3.Text = "Event date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(85, 152);
            label7.Name = "label7";
            label7.Size = new Size(129, 26);
            label7.TabIndex = 2;
            label7.Text = "View events:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(85, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(333, 300);
            dataGridView1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1031, 97);
            panel2.TabIndex = 29;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(826, -17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 114);
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(418, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 46);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkMagenta;
            label8.Location = new Point(287, 61);
            label8.Name = "label8";
            label8.Size = new Size(456, 26);
            label8.TabIndex = 5;
            label8.Text = "Your one stop solution to society management!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 68);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(403, 101);
            label9.Name = "label9";
            label9.Size = new Size(228, 29);
            label9.TabIndex = 30;
            label9.Text = "Event Management";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkMagenta;
            button3.Location = new Point(816, 524);
            button3.Name = "button3";
            button3.Size = new Size(145, 42);
            button3.TabIndex = 31;
            button3.Text = "Add event";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // event_mnagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1011, 601);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "event_mnagement";
            Text = "event_mnagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private DataGridView dataGridView1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label9;
        private Button button3;
    }
}