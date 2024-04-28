namespace SocietySync.User_Controls
{
    partial class TemplateSociety
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateSociety));
            TemplateSocietyPicture = new PictureBox();
            TemplateSocietyLabel = new Label();
            TemplateSocietySettingsButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TemplateSocietyPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TemplateSocietySettingsButton).BeginInit();
            SuspendLayout();
            // 
            // TemplateSocietyPicture
            // 
            TemplateSocietyPicture.BackColor = Color.OrangeRed;
            TemplateSocietyPicture.BackgroundImage = (Image)resources.GetObject("TemplateSocietyPicture.BackgroundImage");
            TemplateSocietyPicture.BackgroundImageLayout = ImageLayout.Stretch;
            TemplateSocietyPicture.Cursor = Cursors.Hand;
            TemplateSocietyPicture.Location = new Point(105, 50);
            TemplateSocietyPicture.Name = "TemplateSocietyPicture";
            TemplateSocietyPicture.Size = new Size(100, 100);
            TemplateSocietyPicture.TabIndex = 7;
            TemplateSocietyPicture.TabStop = false;
            // 
            // TemplateSocietyLabel
            // 
            TemplateSocietyLabel.Cursor = Cursors.Hand;
            TemplateSocietyLabel.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            TemplateSocietyLabel.ForeColor = Color.Black;
            TemplateSocietyLabel.Location = new Point(25, 160);
            TemplateSocietyLabel.Name = "TemplateSocietyLabel";
            TemplateSocietyLabel.Size = new Size(260, 75);
            TemplateSocietyLabel.TabIndex = 10;
            TemplateSocietyLabel.Text = "Community Service Society";
            TemplateSocietyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TemplateSocietySettingsButton
            // 
            TemplateSocietySettingsButton.BackColor = Color.Transparent;
            TemplateSocietySettingsButton.BackgroundImage = (Image)resources.GetObject("TemplateSocietySettingsButton.BackgroundImage");
            TemplateSocietySettingsButton.BackgroundImageLayout = ImageLayout.Stretch;
            TemplateSocietySettingsButton.Cursor = Cursors.Hand;
            TemplateSocietySettingsButton.Location = new Point(230, 25);
            TemplateSocietySettingsButton.Name = "TemplateSocietySettingsButton";
            TemplateSocietySettingsButton.Size = new Size(20, 20);
            TemplateSocietySettingsButton.TabIndex = 11;
            TemplateSocietySettingsButton.TabStop = false;
            // 
            // TemplateSociety
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(TemplateSocietySettingsButton);
            Controls.Add(TemplateSocietyPicture);
            Controls.Add(TemplateSocietyLabel);
            Cursor = Cursors.Hand;
            Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TemplateSociety";
            Size = new Size(310, 241);
            ((System.ComponentModel.ISupportInitialize)TemplateSocietyPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)TemplateSocietySettingsButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox TemplateSocietyPicture;
        private Label TemplateSocietyLabel;
        private PictureBox TemplateSocietySettingsButton;
    }
}
