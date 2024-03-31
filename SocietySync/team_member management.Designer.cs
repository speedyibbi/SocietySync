namespace SocietySync
{
    partial class team_member_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(team_member_management));
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(110, 127);
            label2.Name = "label2";
            label2.Size = new Size(181, 27);
            label2.TabIndex = 1;
            label2.Text = "Society members";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(110, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(292, 376);
            dataGridView1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(492, 195);
            label3.Name = "label3";
            label3.Size = new Size(138, 29);
            label3.TabIndex = 3;
            label3.Text = "Assign roles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(492, 272);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 4;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(492, 327);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 5;
            label5.Text = "Position:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Head", "vice head", "secretary", "deputy secretary", "member(by default)" });
            comboBox1.Location = new Point(604, 324);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 33);
            comboBox1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 524);
            label6.Name = "label6";
            label6.Size = new Size(670, 75);
            label6.TabIndex = 10;
            label6.Text = resources.GetString("label6.Text");
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, -9);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 101);
            panel2.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(393, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 46);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 68);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(257, 75);
            label1.Name = "label1";
            label1.Size = new Size(456, 26);
            label1.TabIndex = 5;
            label1.Text = "Your one stop solution to society management!";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(604, 272);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 31);
            textBox1.TabIndex = 23;
            // 
            // button3
            // 
            button3.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkMagenta;
            button3.Location = new Point(757, 387);
            button3.Name = "button3";
            button3.Size = new Size(108, 39);
            button3.TabIndex = 24;
            button3.Text = "Confirm";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(206, 566);
            button1.Name = "button1";
            button1.Size = new Size(196, 33);
            button1.TabIndex = 25;
            button1.Text = "Reject Members";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(827, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 114);
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(355, 95);
            label7.Name = "label7";
            label7.Size = new Size(275, 29);
            label7.TabIndex = 26;
            label7.Text = "Manage Team members";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // team_member_management
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(987, 611);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "team_member_management";
            Text = "team_member_management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Button button1;
        private PictureBox pictureBox3;
        private Label label7;
    }
}