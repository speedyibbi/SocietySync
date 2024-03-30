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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            button3 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 30);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "society";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 95);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 1;
            label2.Text = "Society members:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(292, 225);
            dataGridView1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 105);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 3;
            label3.Text = "Assign roles:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 153);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 4;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 195);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 5;
            label5.Text = "position:";
            // 
            // button1
            // 
            button1.Location = new Point(79, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "go back";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(609, 404);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "save changes";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Head", "vice head", "secretary", "deputy secretary", "member(by default)" });
            comboBox1.Location = new Point(450, 195);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(466, 265);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 9;
            button3.Text = "confirm";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 315);
            label6.Name = "label6";
            label6.Size = new Size(670, 75);
            label6.TabIndex = 10;
            label6.Text = resources.GetString("label6.Text");
            // 
            // team_member_management
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "team_member_management";
            Text = "team_member_management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Button button3;
        private Label label6;
    }
}