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
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 39);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(231, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 286);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(61, 167);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 31);
            maskedTextBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 27);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 2;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 139);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(301, 388);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(173, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click here to sign up";
            // 
            // button1
            // 
            button1.Location = new Point(76, 217);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}