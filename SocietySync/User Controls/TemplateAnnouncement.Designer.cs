namespace SocietySync
{
    partial class TemplateAnnouncement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TemplateAnnouncementName = new Label();
            TemplateAnnouncementSociety = new Label();
            TemplateAnnouncementText = new Label();
            TemplateAnnouncementDate = new Label();
            SuspendLayout();
            // 
            // TemplateAnnouncementName
            // 
            TemplateAnnouncementName.AutoSize = true;
            TemplateAnnouncementName.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateAnnouncementName.ForeColor = Color.Black;
            TemplateAnnouncementName.Location = new Point(25, 25);
            TemplateAnnouncementName.Name = "TemplateAnnouncementName";
            TemplateAnnouncementName.Size = new Size(133, 24);
            TemplateAnnouncementName.TabIndex = 0;
            TemplateAnnouncementName.Text = "Ibrahim Khan";
            // 
            // TemplateAnnouncementSociety
            // 
            TemplateAnnouncementSociety.AutoSize = true;
            TemplateAnnouncementSociety.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateAnnouncementSociety.ForeColor = Color.Gray;
            TemplateAnnouncementSociety.Location = new Point(158, 25);
            TemplateAnnouncementSociety.Name = "TemplateAnnouncementSociety";
            TemplateAnnouncementSociety.Size = new Size(208, 24);
            TemplateAnnouncementSociety.TabIndex = 1;
            TemplateAnnouncementSociety.Text = "| Community Service";
            // 
            // TemplateAnnouncementText
            // 
            TemplateAnnouncementText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TemplateAnnouncementText.Font = new Font("Inter Italic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateAnnouncementText.ForeColor = Color.Black;
            TemplateAnnouncementText.Location = new Point(25, 59);
            TemplateAnnouncementText.Name = "TemplateAnnouncementText";
            TemplateAnnouncementText.Size = new Size(1117, 51);
            TemplateAnnouncementText.TabIndex = 2;
            TemplateAnnouncementText.Text = "“Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.”";
            // 
            // TemplateAnnouncementDate
            // 
            TemplateAnnouncementDate.AutoSize = true;
            TemplateAnnouncementDate.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateAnnouncementDate.ForeColor = Color.Gray;
            TemplateAnnouncementDate.Location = new Point(25, 120);
            TemplateAnnouncementDate.Name = "TemplateAnnouncementDate";
            TemplateAnnouncementDate.Size = new Size(323, 24);
            TemplateAnnouncementDate.TabIndex = 3;
            TemplateAnnouncementDate.Text = "- Wednesday, 10th April at 23:30";
            // 
            // TemplateAnnouncement
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(TemplateAnnouncementName);
            Controls.Add(TemplateAnnouncementSociety);
            Controls.Add(TemplateAnnouncementText);
            Controls.Add(TemplateAnnouncementDate);
            Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TemplateAnnouncement";
            Size = new Size(685, 175);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TemplateAnnouncementName;
        private Label TemplateAnnouncementSociety;
        private Label TemplateAnnouncementText;
        private Label TemplateAnnouncementDate;
    }
}
