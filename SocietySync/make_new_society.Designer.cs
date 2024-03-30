namespace SocietySync
{
    partial class make_new_society
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 31);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 0;
            label1.Text = "Make a new society";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 97);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 1;
            label2.Text = "Founder name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 156);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 2;
            label3.Text = "Society name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 224);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 3;
            label4.Text = "batch";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 292);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 4;
            label5.Text = "Society type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "20", "21", "22" });
            comboBox1.Location = new Point(147, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(90, 33);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Educational ", "entertainment", "Gaming", "health", "sports" });
            comboBox2.Location = new Point(203, 292);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 354);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 7;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(527, 97);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 8;
            label7.Text = "intial members:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(534, 248);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 9;
            label8.Text = "Main purpose:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(178, 357);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 12;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(534, 276);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(220, 132);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(534, 125);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(202, 116);
            richTextBox2.TabIndex = 14;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(58, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 15;
            button1.Text = "go back";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(655, 414);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 16;
            button2.Text = "Apply";
            button2.UseVisualStyleBackColor = true;
            // 
            // make_new_society
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "make_new_society";
            Text = "make_new_society";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private Button button2;
    }
}