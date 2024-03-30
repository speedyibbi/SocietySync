namespace SocietySync
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Sidebar = new Panel();
            Logo = new PictureBox();
            HomeButton = new GroupBox();
            HomeIcon = new PictureBox();
            HomeLabel = new Label();
            HomeButtonBG = new Panel();
            SocietiesButton = new GroupBox();
            SocietiesIcon = new PictureBox();
            SocietiesLabel = new Label();
            SocietiesButtonBG = new Panel();
            SettingsButton = new GroupBox();
            SettingsIcon = new PictureBox();
            SettingsLabel = new Label();
            SettingsButtonBG = new Panel();
            HomePanel = new Panel();
            HomePanelLabel = new Label();
            NavigationPanels = new GroupBox();
            SocietiesPanel = new Panel();
            SocietySearchbarPanel = new Panel();
            SocietySearchbarText = new TextBox();
            SocietySearchbarFooter = new Panel();
            SocietiesPanelLabel = new Label();
            SettingsPanel = new Panel();
            SettingsPanelLabel = new Label();
            LoggedInUserName = new Label();
            LoggedInUserNameEntry = new Panel();
            LoggedInUserNameEntryText = new Label();
            LoggedInUserEmail = new Label();
            LoggedInUserEmailEntry = new Panel();
            LoggedInUserEmailEntryText = new Label();
            LoggedInUserPhoneNumber = new Label();
            LoggedInUserPhoneNumberEntry = new Panel();
            LoggedInUserPhoneNumberEntryText = new TextBox();
            LoggedInUserPhoneNumberEntryFooter = new Panel();
            LoggedInUserPassword = new Label();
            LoggedInUserPasswordEntry = new Panel();
            LoggedInUserPasswordEntryText = new TextBox();
            LoggedInUserPasswordEntryFooter = new Panel();
            SaveSettingsButton = new Button();
            Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            HomeButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomeIcon).BeginInit();
            SocietiesButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SocietiesIcon).BeginInit();
            SettingsButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SettingsIcon).BeginInit();
            HomePanel.SuspendLayout();
            NavigationPanels.SuspendLayout();
            SocietiesPanel.SuspendLayout();
            SocietySearchbarPanel.SuspendLayout();
            SettingsPanel.SuspendLayout();
            LoggedInUserNameEntry.SuspendLayout();
            LoggedInUserEmailEntry.SuspendLayout();
            LoggedInUserPhoneNumberEntry.SuspendLayout();
            LoggedInUserPasswordEntry.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.White;
            Sidebar.Controls.Add(Logo);
            Sidebar.Controls.Add(HomeButton);
            Sidebar.Controls.Add(SocietiesButton);
            Sidebar.Controls.Add(SettingsButton);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(300, 673);
            Sidebar.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.Location = new Point(35, 35);
            Logo.Name = "Logo";
            Logo.Size = new Size(201, 37);
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.White;
            HomeButton.Controls.Add(HomeIcon);
            HomeButton.Controls.Add(HomeLabel);
            HomeButton.Controls.Add(HomeButtonBG);
            HomeButton.Cursor = Cursors.Hand;
            HomeButton.Location = new Point(35, 150);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(230, 50);
            HomeButton.TabIndex = 1;
            HomeButton.TabStop = false;
            // 
            // HomeIcon
            // 
            HomeIcon.BackgroundImage = (Image)resources.GetObject("HomeIcon.BackgroundImage");
            HomeIcon.Location = new Point(15, 10);
            HomeIcon.Name = "HomeIcon";
            HomeIcon.Size = new Size(32, 32);
            HomeIcon.TabIndex = 1;
            HomeIcon.TabStop = false;
            // 
            // HomeLabel
            // 
            HomeLabel.AutoSize = true;
            HomeLabel.Location = new Point(48, 17);
            HomeLabel.Name = "HomeLabel";
            HomeLabel.Size = new Size(56, 23);
            HomeLabel.TabIndex = 2;
            HomeLabel.Text = "Home";
            // 
            // HomeButtonBG
            // 
            HomeButtonBG.BackColor = Color.White;
            HomeButtonBG.Location = new Point(0, 0);
            HomeButtonBG.Name = "HomeButtonBG";
            HomeButtonBG.Size = new Size(230, 50);
            HomeButtonBG.TabIndex = 2;
            
            // 
            // SocietiesButton
            // 
            SocietiesButton.BackColor = Color.White;
            SocietiesButton.Controls.Add(SocietiesIcon);
            SocietiesButton.Controls.Add(SocietiesLabel);
            SocietiesButton.Controls.Add(SocietiesButtonBG);
            SocietiesButton.Cursor = Cursors.Hand;
            SocietiesButton.Location = new Point(35, 205);
            SocietiesButton.Name = "SocietiesButton";
            SocietiesButton.Size = new Size(230, 50);
            SocietiesButton.TabIndex = 2;
            SocietiesButton.TabStop = false;
            // 
            // SocietiesIcon
            // 
            SocietiesIcon.BackgroundImage = (Image)resources.GetObject("SocietiesIcon.BackgroundImage");
            SocietiesIcon.Location = new Point(15, 10);
            SocietiesIcon.Name = "SocietiesIcon";
            SocietiesIcon.Size = new Size(32, 32);
            SocietiesIcon.TabIndex = 3;
            SocietiesIcon.TabStop = false;
            // 
            // SocietiesLabel
            // 
            SocietiesLabel.AutoSize = true;
            SocietiesLabel.Location = new Point(48, 17);
            SocietiesLabel.Name = "SocietiesLabel";
            SocietiesLabel.Size = new Size(82, 23);
            SocietiesLabel.TabIndex = 1;
            SocietiesLabel.Text = "Societies";
            // 
            // SocietiesButtonBG
            // 
            SocietiesButtonBG.BackColor = Color.White;
            SocietiesButtonBG.Location = new Point(0, 0);
            SocietiesButtonBG.Name = "SocietiesButtonBG";
            SocietiesButtonBG.Size = new Size(230, 50);
            SocietiesButtonBG.TabIndex = 2;
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SettingsButton.BackColor = Color.White;
            SettingsButton.Controls.Add(SettingsIcon);
            SettingsButton.Controls.Add(SettingsLabel);
            SettingsButton.Controls.Add(SettingsButtonBG);
            SettingsButton.Cursor = Cursors.Hand;
            SettingsButton.Location = new Point(35, 588);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(230, 50);
            SettingsButton.TabIndex = 5;
            SettingsButton.TabStop = false;
            // 
            // SettingsIcon
            // 
            SettingsIcon.BackgroundImage = (Image)resources.GetObject("SettingsIcon.BackgroundImage");
            SettingsIcon.Location = new Point(15, 10);
            SettingsIcon.Name = "SettingsIcon";
            SettingsIcon.Size = new Size(32, 32);
            SettingsIcon.TabIndex = 4;
            SettingsIcon.TabStop = false;
            // 
            // SettingsLabel
            // 
            SettingsLabel.AutoSize = true;
            SettingsLabel.Location = new Point(48, 17);
            SettingsLabel.Name = "SettingsLabel";
            SettingsLabel.Size = new Size(74, 23);
            SettingsLabel.TabIndex = 1;
            SettingsLabel.Text = "Settings";
            SettingsLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // SettingsButtonBG
            // 
            SettingsButtonBG.BackColor = Color.White;
            SettingsButtonBG.Location = new Point(0, 0);
            SettingsButtonBG.Name = "SettingsButtonBG";
            SettingsButtonBG.Size = new Size(230, 50);
            SettingsButtonBG.TabIndex = 2;
            // 
            // HomePanel
            // 
            HomePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HomePanel.Controls.Add(HomePanelLabel);
            HomePanel.Location = new Point(0, 0);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(956, 649);
            HomePanel.TabIndex = 6;
            // 
            // HomePanelLabel
            // 
            HomePanelLabel.AutoSize = true;
            HomePanelLabel.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            HomePanelLabel.Location = new Point(100, 100);
            HomePanelLabel.Name = "HomePanelLabel";
            HomePanelLabel.Size = new Size(86, 71);
            HomePanelLabel.TabIndex = 0;
            HomePanelLabel.Text = "Hi";
            // 
            // NavigationPanels
            // 
            NavigationPanels.Controls.Add(HomePanel);
            NavigationPanels.Controls.Add(SocietiesPanel);
            NavigationPanels.Controls.Add(SettingsPanel);
            NavigationPanels.Dock = DockStyle.Fill;
            NavigationPanels.Location = new Point(300, 0);
            NavigationPanels.Name = "NavigationPanels";
            NavigationPanels.Size = new Size(962, 673);
            NavigationPanels.TabIndex = 7;
            NavigationPanels.TabStop = false;
            // 
            // SocietiesPanel
            // 
            SocietiesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SocietiesPanel.AutoScroll = true;
            SocietiesPanel.Controls.Add(SocietySearchbarPanel);
            SocietiesPanel.Controls.Add(SocietiesPanelLabel);
            SocietiesPanel.Location = new Point(0, 0);
            SocietiesPanel.Name = "SocietiesPanel";
            SocietiesPanel.Size = new Size(956, 649);
            SocietiesPanel.TabIndex = 7;
            // 
            // SocietySearchbarPanel
            // 
            SocietySearchbarPanel.Controls.Add(SocietySearchbarText);
            SocietySearchbarPanel.Controls.Add(SocietySearchbarFooter);
            SocietySearchbarPanel.Location = new Point(346, 120);
            SocietySearchbarPanel.Name = "SocietySearchbarPanel";
            SocietySearchbarPanel.Size = new Size(240, 28);
            SocietySearchbarPanel.TabIndex = 3;
            // 
            // SocietySearchbarText
            // 
            SocietySearchbarText.BackColor = Color.FromArgb(242, 242, 242);
            SocietySearchbarText.BorderStyle = BorderStyle.None;
            SocietySearchbarText.Location = new Point(5, 5);
            SocietySearchbarText.Name = "SocietySearchbarText";
            SocietySearchbarText.Size = new Size(230, 21);
            SocietySearchbarText.TabIndex = 2;
            SocietySearchbarText.Text = "Search societies";
            // 
            // SocietySearchbarFooter
            // 
            SocietySearchbarFooter.BackColor = SystemColors.WindowText;
            SocietySearchbarFooter.Location = new Point(0, 26);
            SocietySearchbarFooter.Name = "SocietySearchbarFooter";
            SocietySearchbarFooter.Size = new Size(240, 2);
            SocietySearchbarFooter.TabIndex = 4;
            // 
            // SocietiesPanelLabel
            // 
            SocietiesPanelLabel.AutoSize = true;
            SocietiesPanelLabel.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            SocietiesPanelLabel.Location = new Point(100, 100);
            SocietiesPanelLabel.Name = "SocietiesPanelLabel";
            SocietiesPanelLabel.Size = new Size(268, 71);
            SocietiesPanelLabel.TabIndex = 1;
            SocietiesPanelLabel.Text = "Societies";
            // 
            // SettingsPanel
            // 
            SettingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SettingsPanel.Controls.Add(SettingsPanelLabel);
            SettingsPanel.Controls.Add(LoggedInUserName);
            SettingsPanel.Controls.Add(LoggedInUserNameEntry);
            SettingsPanel.Controls.Add(LoggedInUserEmail);
            SettingsPanel.Controls.Add(LoggedInUserEmailEntry);
            SettingsPanel.Controls.Add(LoggedInUserPhoneNumber);
            SettingsPanel.Controls.Add(LoggedInUserPhoneNumberEntry);
            SettingsPanel.Controls.Add(LoggedInUserPassword);
            SettingsPanel.Controls.Add(LoggedInUserPasswordEntry);
            SettingsPanel.Controls.Add(SaveSettingsButton);
            SettingsPanel.Location = new Point(0, 0);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(956, 649);
            SettingsPanel.TabIndex = 8;
            // 
            // SettingsPanelLabel
            // 
            SettingsPanelLabel.AutoSize = true;
            SettingsPanelLabel.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            SettingsPanelLabel.Location = new Point(100, 100);
            SettingsPanelLabel.Name = "SettingsPanelLabel";
            SettingsPanelLabel.Size = new Size(243, 71);
            SettingsPanelLabel.TabIndex = 2;
            SettingsPanelLabel.Text = "Settings";
            // 
            // LoggedInUserName
            // 
            LoggedInUserName.AutoSize = true;
            LoggedInUserName.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoggedInUserName.Location = new Point(100, 225);
            LoggedInUserName.Name = "LoggedInUserName";
            LoggedInUserName.Size = new Size(86, 36);
            LoggedInUserName.TabIndex = 3;
            LoggedInUserName.Text = "Name";
            // 
            // LoggedInUserNameEntry
            // 
            LoggedInUserNameEntry.Controls.Add(LoggedInUserNameEntryText);
            LoggedInUserNameEntry.Location = new Point(290, 225);
            LoggedInUserNameEntry.Name = "LoggedInUserNameEntry";
            LoggedInUserNameEntry.Size = new Size(240, 28);
            LoggedInUserNameEntry.TabIndex = 7;
            // 
            // LoggedInUserNameEntryText
            // 
            LoggedInUserNameEntryText.AutoSize = true;
            LoggedInUserNameEntryText.Location = new Point(5, 5);
            LoggedInUserNameEntryText.Name = "LoggedInUserNameEntryText";
            LoggedInUserNameEntryText.Size = new Size(0, 23);
            LoggedInUserNameEntryText.TabIndex = 8;
            // 
            // LoggedInUserEmail
            // 
            LoggedInUserEmail.AutoSize = true;
            LoggedInUserEmail.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoggedInUserEmail.Location = new Point(100, 285);
            LoggedInUserEmail.Name = "LoggedInUserEmail";
            LoggedInUserEmail.Size = new Size(84, 36);
            LoggedInUserEmail.TabIndex = 4;
            LoggedInUserEmail.Text = "Email";
            // 
            // LoggedInUserEmailEntry
            // 
            LoggedInUserEmailEntry.Controls.Add(LoggedInUserEmailEntryText);
            LoggedInUserEmailEntry.Location = new Point(290, 285);
            LoggedInUserEmailEntry.Name = "LoggedInUserEmailEntry";
            LoggedInUserEmailEntry.Size = new Size(240, 28);
            LoggedInUserEmailEntry.TabIndex = 8;
            // 
            // LoggedInUserEmailEntryText
            // 
            LoggedInUserEmailEntryText.AutoSize = true;
            LoggedInUserEmailEntryText.Location = new Point(5, 5);
            LoggedInUserEmailEntryText.Name = "LoggedInUserEmailEntryText";
            LoggedInUserEmailEntryText.Size = new Size(0, 23);
            LoggedInUserEmailEntryText.TabIndex = 8;
            // 
            // LoggedInUserPhoneNumber
            // 
            LoggedInUserPhoneNumber.AutoSize = true;
            LoggedInUserPhoneNumber.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoggedInUserPhoneNumber.Location = new Point(100, 345);
            LoggedInUserPhoneNumber.Name = "LoggedInUserPhoneNumber";
            LoggedInUserPhoneNumber.Size = new Size(141, 36);
            LoggedInUserPhoneNumber.TabIndex = 6;
            LoggedInUserPhoneNumber.Text = "Phone No.";
            // 
            // LoggedInUserPhoneNumberEntry
            // 
            LoggedInUserPhoneNumberEntry.Controls.Add(LoggedInUserPhoneNumberEntryText);
            LoggedInUserPhoneNumberEntry.Controls.Add(LoggedInUserPhoneNumberEntryFooter);
            LoggedInUserPhoneNumberEntry.Location = new Point(290, 345);
            LoggedInUserPhoneNumberEntry.Name = "LoggedInUserPhoneNumberEntry";
            LoggedInUserPhoneNumberEntry.Size = new Size(240, 28);
            LoggedInUserPhoneNumberEntry.TabIndex = 9;
            // 
            // LoggedInUserPhoneNumberEntryText
            // 
            LoggedInUserPhoneNumberEntryText.BackColor = Color.FromArgb(242, 242, 242);
            LoggedInUserPhoneNumberEntryText.BorderStyle = BorderStyle.None;
            LoggedInUserPhoneNumberEntryText.Location = new Point(5, 5);
            LoggedInUserPhoneNumberEntryText.Name = "LoggedInUserPhoneNumberEntryText";
            LoggedInUserPhoneNumberEntryText.Size = new Size(230, 21);
            LoggedInUserPhoneNumberEntryText.TabIndex = 2;
            // 
            // LoggedInUserPhoneNumberEntryFooter
            // 
            LoggedInUserPhoneNumberEntryFooter.BackColor = SystemColors.WindowText;
            LoggedInUserPhoneNumberEntryFooter.Location = new Point(0, 26);
            LoggedInUserPhoneNumberEntryFooter.Name = "LoggedInUserPhoneNumberEntryFooter";
            LoggedInUserPhoneNumberEntryFooter.Size = new Size(240, 2);
            LoggedInUserPhoneNumberEntryFooter.TabIndex = 4;
            // 
            // LoggedInUserPassword
            // 
            LoggedInUserPassword.AutoSize = true;
            LoggedInUserPassword.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoggedInUserPassword.Location = new Point(100, 405);
            LoggedInUserPassword.Name = "LoggedInUserPassword";
            LoggedInUserPassword.Size = new Size(130, 36);
            LoggedInUserPassword.TabIndex = 5;
            LoggedInUserPassword.Text = "Password";
            // 
            // LoggedInUserPasswordEntry
            // 
            LoggedInUserPasswordEntry.Controls.Add(LoggedInUserPasswordEntryText);
            LoggedInUserPasswordEntry.Controls.Add(LoggedInUserPasswordEntryFooter);
            LoggedInUserPasswordEntry.Location = new Point(290, 405);
            LoggedInUserPasswordEntry.Name = "LoggedInUserPasswordEntry";
            LoggedInUserPasswordEntry.Size = new Size(240, 28);
            LoggedInUserPasswordEntry.TabIndex = 10;
            // 
            // LoggedInUserPasswordEntryText
            // 
            LoggedInUserPasswordEntryText.BackColor = Color.FromArgb(242, 242, 242);
            LoggedInUserPasswordEntryText.BorderStyle = BorderStyle.None;
            LoggedInUserPasswordEntryText.Location = new Point(5, 5);
            LoggedInUserPasswordEntryText.Name = "LoggedInUserPasswordEntryText";
            LoggedInUserPasswordEntryText.PasswordChar = '*';
            LoggedInUserPasswordEntryText.Size = new Size(230, 21);
            LoggedInUserPasswordEntryText.TabIndex = 2;
            // 
            // LoggedInUserPasswordEntryFooter
            // 
            LoggedInUserPasswordEntryFooter.BackColor = SystemColors.WindowText;
            LoggedInUserPasswordEntryFooter.Location = new Point(0, 26);
            LoggedInUserPasswordEntryFooter.Name = "LoggedInUserPasswordEntryFooter";
            LoggedInUserPasswordEntryFooter.Size = new Size(240, 2);
            LoggedInUserPasswordEntryFooter.TabIndex = 4;
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.BackColor = Color.White;
            SaveSettingsButton.Location = new Point(100, 525);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new Size(94, 29);
            SaveSettingsButton.TabIndex = 11;
            SaveSettingsButton.Text = "Save";
            SaveSettingsButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1262, 673);
            Controls.Add(NavigationPanels);
            Controls.Add(Sidebar);
            Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SocietySync";
            Load += MainForm_Load;
            Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            HomeButton.ResumeLayout(false);
            HomeButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomeIcon).EndInit();
            SocietiesButton.ResumeLayout(false);
            SocietiesButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SocietiesIcon).EndInit();
            SettingsButton.ResumeLayout(false);
            SettingsButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SettingsIcon).EndInit();
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            NavigationPanels.ResumeLayout(false);
            SocietiesPanel.ResumeLayout(false);
            SocietiesPanel.PerformLayout();
            SocietySearchbarPanel.ResumeLayout(false);
            SocietySearchbarPanel.PerformLayout();
            SettingsPanel.ResumeLayout(false);
            SettingsPanel.PerformLayout();
            LoggedInUserNameEntry.ResumeLayout(false);
            LoggedInUserNameEntry.PerformLayout();
            LoggedInUserEmailEntry.ResumeLayout(false);
            LoggedInUserEmailEntry.PerformLayout();
            LoggedInUserPhoneNumberEntry.ResumeLayout(false);
            LoggedInUserPhoneNumberEntry.PerformLayout();
            LoggedInUserPasswordEntry.ResumeLayout(false);
            LoggedInUserPasswordEntry.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Sidebar;
        private PictureBox Logo;
        private Label SocietiesLabel;
        private PictureBox SettingsIcon;
        private Label SettingsLabel;
        private PictureBox SocietiesIcon;
        private GroupBox HomeButton;
        private PictureBox HomeIcon;
        private Label HomeLabel;
        private Panel HomeButtonBG;
        private GroupBox SocietiesButton;
        private Panel SocietiesButtonBG;
        private GroupBox SettingsButton;
        private Label SocietiesPanelLabel;
        private Panel SettingsButtonBG;
        private Panel HomePanel;
        private Label HomePanelLabel;
        private GroupBox NavigationPanels;
        private Panel SocietiesPanel;
        private Panel SettingsPanel;
        private Label SettingsPanelLabel;
        private TextBox SocietySearchbarText;
        private Panel SocietySearchbarPanel;
        private Panel SocietySearchbarFooter;
        private Label LoggedInUserName;
        private Label LoggedInUserEmail;
        private Label LoggedInUserPassword;
        private Label LoggedInUserPhoneNumber;
        private Panel LoggedInUserNameEntry;
        private Label LoggedInUserNameEntryText;
        private Button SaveSettingsButton;
        private Panel LoggedInUserEmailEntry;
        private Label LoggedInUserEmailEntryText;
        private Panel LoggedInUserPhoneNumberEntry;
        private TextBox LoggedInUserPhoneNumberEntryText;
        private Panel LoggedInUserPhoneNumberEntryFooter;
        private Panel LoggedInUserPasswordEntry;
        private TextBox LoggedInUserPasswordEntryText;
        private Panel LoggedInUserPasswordEntryFooter;
    }
}
