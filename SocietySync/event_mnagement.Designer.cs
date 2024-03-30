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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 31);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 0;
            label1.Text = "Event management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 12);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Add event ";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(37, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 300);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 53);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 2;
            label3.Text = "event date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 108);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 4;
            label4.Text = "event head:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 156);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 5;
            label5.Text = "Audience no:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 204);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 6;
            label6.Text = "event description:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(176, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(147, 49);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(129, 260);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Add event";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(507, 78);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 2;
            label7.Text = "View events:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(437, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(333, 300);
            dataGridView1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(40, 416);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "go back";
            button2.UseVisualStyleBackColor = true;
            // 
            // event_mnagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "event_mnagement";
            Text = "event_mnagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button1;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button2;
    }
}