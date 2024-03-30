namespace SocietySync
{
    partial class Join_society
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
            comboBox1 = new ComboBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 43);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Join a society";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 114);
            label2.Name = "label2";
            label2.Size = new Size(297, 25);
            label2.TabIndex = 1;
            label2.Text = "choose the society you want to join:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Community service society", "Fast Gaming Club", "Google developers society club", "Fast quran and sunnah society", "Women in computing", "Fast production society", "Fast Adventure club" });
            comboBox1.Location = new Point(67, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(96, 387);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(153, 25);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "View society infos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 266);
            label3.Name = "label3";
            label3.Size = new Size(297, 25);
            label3.TabIndex = 4;
            label3.Text = "choose the society you want to join:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "President", "Secretary", "Head", "Member" });
            comboBox2.Location = new Point(67, 306);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 5;
            // 
            // Join_society
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Join_society";
            Text = "Join_society";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private LinkLabel linkLabel1;
        private Label label3;
        private ComboBox comboBox2;
    }
}