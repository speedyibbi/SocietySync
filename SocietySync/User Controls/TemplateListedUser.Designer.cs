namespace SocietySync.User_Controls
{
    partial class TemplateListedUser
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
            TemplateListedUserId = new Label();
            TemplateListedUserName = new Label();
            TemplateListedUserPhoneNumber = new Label();
            TemplateListedUserRole = new Label();
            TemplateListedUserJoinedAt = new Label();
            TemplateListedUserUnderline = new Panel();
            TemplateListedUserEmail = new Label();
            SuspendLayout();
            // 
            // TemplateListedUserId
            // 
            TemplateListedUserId.AutoSize = true;
            TemplateListedUserId.Cursor = Cursors.Hand;
            TemplateListedUserId.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateListedUserId.ForeColor = Color.Black;
            TemplateListedUserId.Location = new Point(0, 0);
            TemplateListedUserId.Name = "TemplateListedUserId";
            TemplateListedUserId.Size = new Size(84, 24);
            TemplateListedUserId.TabIndex = 9;
            TemplateListedUserId.Text = "000001";
            // 
            // TemplateListedUserName
            // 
            TemplateListedUserName.AutoSize = true;
            TemplateListedUserName.Cursor = Cursors.Hand;
            TemplateListedUserName.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateListedUserName.ForeColor = Color.Black;
            TemplateListedUserName.Location = new Point(114, 0);
            TemplateListedUserName.Name = "TemplateListedUserName";
            TemplateListedUserName.Size = new Size(133, 24);
            TemplateListedUserName.TabIndex = 10;
            TemplateListedUserName.Text = "Ibrahim Khan";
            // 
            // TemplateListedUserPhoneNumber
            // 
            TemplateListedUserPhoneNumber.AutoSize = true;
            TemplateListedUserPhoneNumber.Cursor = Cursors.Hand;
            TemplateListedUserPhoneNumber.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateListedUserPhoneNumber.ForeColor = Color.Black;
            TemplateListedUserPhoneNumber.Location = new Point(491, 0);
            TemplateListedUserPhoneNumber.Name = "TemplateListedUserPhoneNumber";
            TemplateListedUserPhoneNumber.Size = new Size(19, 24);
            TemplateListedUserPhoneNumber.TabIndex = 12;
            TemplateListedUserPhoneNumber.Text = "-";
            // 
            // TemplateListedUserRole
            // 
            TemplateListedUserRole.AutoSize = true;
            TemplateListedUserRole.Cursor = Cursors.Hand;
            TemplateListedUserRole.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateListedUserRole.ForeColor = Color.Black;
            TemplateListedUserRole.Location = new Point(697, 0);
            TemplateListedUserRole.Name = "TemplateListedUserRole";
            TemplateListedUserRole.Size = new Size(88, 24);
            TemplateListedUserRole.TabIndex = 13;
            TemplateListedUserRole.Text = "Member";
            // 
            // TemplateListedUserJoinedAt
            // 
            TemplateListedUserJoinedAt.AutoSize = true;
            TemplateListedUserJoinedAt.Cursor = Cursors.Hand;
            TemplateListedUserJoinedAt.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateListedUserJoinedAt.ForeColor = Color.Black;
            TemplateListedUserJoinedAt.Location = new Point(849, 0);
            TemplateListedUserJoinedAt.Name = "TemplateListedUserJoinedAt";
            TemplateListedUserJoinedAt.Size = new Size(125, 24);
            TemplateListedUserJoinedAt.TabIndex = 14;
            TemplateListedUserJoinedAt.Text = "10-04-2024";
            // 
            // TemplateListedUserUnderline
            // 
            TemplateListedUserUnderline.BackColor = Color.LightGray;
            TemplateListedUserUnderline.Cursor = Cursors.Hand;
            TemplateListedUserUnderline.Location = new Point(0, 43);
            TemplateListedUserUnderline.Name = "TemplateListedUserUnderline";
            TemplateListedUserUnderline.Size = new Size(1100, 1);
            TemplateListedUserUnderline.TabIndex = 16;
            // 
            // TemplateListedUserEmail
            // 
            TemplateListedUserEmail.AutoSize = true;
            TemplateListedUserEmail.Cursor = Cursors.Hand;
            TemplateListedUserEmail.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TemplateListedUserEmail.ForeColor = Color.Black;
            TemplateListedUserEmail.Location = new Point(280, 0);
            TemplateListedUserEmail.Name = "TemplateListedUserEmail";
            TemplateListedUserEmail.Size = new Size(186, 24);
            TemplateListedUserEmail.TabIndex = 11;
            TemplateListedUserEmail.Text = "i210601@nu.edu...";
            // 
            // TemplateListedUser
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TemplateListedUserId);
            Controls.Add(TemplateListedUserName);
            Controls.Add(TemplateListedUserEmail);
            Controls.Add(TemplateListedUserPhoneNumber);
            Controls.Add(TemplateListedUserRole);
            Controls.Add(TemplateListedUserJoinedAt);
            Controls.Add(TemplateListedUserUnderline);
            Cursor = Cursors.Hand;
            Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TemplateListedUser";
            Size = new Size(1100, 44);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TemplateListedUserId;
        private Label TemplateListedUserName;
        private Label TemplateListedUserPhoneNumber;
        private Label TemplateListedUserRole;
        private Label TemplateListedUserJoinedAt;
        private Panel TemplateListedUserUnderline;
        private Label TemplateListedUserEmail;
    }
}
