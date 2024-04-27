namespace SocietySync.User_Controls
{
    partial class TemplateEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateEvent));
            TemplateEventName = new Label();
            TemplateEventText = new Label();
            TemplateEventSociety = new Label();
            TemplateEventSettingsButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TemplateEventSettingsButton).BeginInit();
            SuspendLayout();
            // 
            // TemplateEventName
            // 
            TemplateEventName.AutoSize = true;
            TemplateEventName.Cursor = Cursors.Hand;
            TemplateEventName.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TemplateEventName.ForeColor = Color.Black;
            TemplateEventName.Location = new Point(25, 25);
            TemplateEventName.Name = "TemplateEventName";
            TemplateEventName.Size = new Size(362, 36);
            TemplateEventName.TabIndex = 0;
            TemplateEventName.Text = "Dog Shelter Fund Raiser";
            // 
            // TemplateEventText
            // 
            TemplateEventText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TemplateEventText.Cursor = Cursors.Hand;
            TemplateEventText.Font = new Font("Inter Italic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateEventText.ForeColor = Color.Black;
            TemplateEventText.Location = new Point(25, 76);
            TemplateEventText.Name = "TemplateEventText";
            TemplateEventText.Size = new Size(1120, 51);
            TemplateEventText.TabIndex = 2;
            TemplateEventText.Text = "“Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.”";
            // 
            // TemplateEventSociety
            // 
            TemplateEventSociety.AutoSize = true;
            TemplateEventSociety.Cursor = Cursors.Hand;
            TemplateEventSociety.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateEventSociety.ForeColor = Color.Gray;
            TemplateEventSociety.Location = new Point(25, 142);
            TemplateEventSociety.Name = "TemplateEventSociety";
            TemplateEventSociety.Size = new Size(287, 24);
            TemplateEventSociety.TabIndex = 3;
            TemplateEventSociety.Text = "- Community Service Society";
            // 
            // TemplateEventSettingsButton
            // 
            TemplateEventSettingsButton.BackColor = Color.Transparent;
            TemplateEventSettingsButton.BackgroundImage = (Image)resources.GetObject("TemplateEventSettingsButton.BackgroundImage");
            TemplateEventSettingsButton.BackgroundImageLayout = ImageLayout.Stretch;
            TemplateEventSettingsButton.Cursor = Cursors.Hand;
            TemplateEventSettingsButton.Location = new Point(640, 33);
            TemplateEventSettingsButton.Name = "TemplateEventSettingsButton";
            TemplateEventSettingsButton.Size = new Size(20, 20);
            TemplateEventSettingsButton.TabIndex = 13;
            TemplateEventSettingsButton.TabStop = false;
            // 
            // TemplateEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(TemplateEventName);
            Controls.Add(TemplateEventText);
            Controls.Add(TemplateEventSociety);
            Controls.Add(TemplateEventSettingsButton);
            Cursor = Cursors.Hand;
            Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TemplateEvent";
            Size = new Size(685, 181);
            ((System.ComponentModel.ISupportInitialize)TemplateEventSettingsButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TemplateEventName;
        private Label TemplateEventText;
        private Label TemplateEventSociety;
        private PictureBox TemplateEventSettingsButton;
    }
}
