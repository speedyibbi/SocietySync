namespace SocietySync
{
    partial class CRUDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDForm));
            SocietyForm = new Panel();
            SocietyFormNameLabel = new Label();
            SocietyFormNameInput = new TextBox();
            SocietyFormDescriptionLabel = new Label();
            SocietyFormDescriptionInput = new TextBox();
            SocietyFormPresidentLabel = new Label();
            SocietyFormPresidentInput = new ComboBox();
            SocietyFormRemoveButton = new Label();
            SocietyFormCancelButton = new Label();
            SocietyFormSaveButton = new Label();
            SocietyApplication = new Panel();
            SocietyApplicationSocietyLabel = new Label();
            SocietyApplicationSocietyInput = new TextBox();
            SocietyApplicationAdditionalNoteLabel = new Label();
            SocietyApplicationAdditionalNoteInput = new TextBox();
            SocietyApplicationCancelButton = new Label();
            SocietyApplicationApplyButton = new Label();
            EventForm = new Panel();
            EventFormTitleLabel = new Label();
            EventFormTitleInput = new TextBox();
            EventFormDescriptionLabel = new Label();
            EventFormDescriptionInput = new TextBox();
            EventFormStartDateLabel = new Label();
            EventFormStartDateInput = new TextBox();
            EventFormEndDateLabel = new Label();
            EventFormEndDateInput = new TextBox();
            EventFormLocationLabel = new Label();
            EventFormLocationInput = new TextBox();
            EventFormRemoveButton = new Label();
            EventFormCancelButton = new Label();
            EventFormSaveButton = new Label();
            TeamForm = new Panel();
            TeamFormNameLabel = new Label();
            TeamFormNameInput = new TextBox();
            TeamFormDescriptionLabel = new Label();
            TeamFormDescriptionInput = new TextBox();
            TeamFormHeadLabel = new Label();
            TeamFormHeadInput = new ComboBox();
            TeamFormRemoveButton = new Label();
            TeamFormCancelButton = new Label();
            TeamFormSaveButton = new Label();
            TaskForm = new Panel();
            TaskFormTitleLabel = new Label();
            TaskFormTitleInput = new TextBox();
            TaskFormDescriptionLabel = new Label();
            TaskFormDescriptionInput = new TextBox();
            TaskFormAssigneeLabel = new Label();
            TaskFormAssigneeInput = new ComboBox();
            TaskFormRemoveButton = new Label();
            TaskFormCancelButton = new Label();
            TaskFormSaveButton = new Label();
            TaskFormCompletedLabel = new Label();
            TaskFormCompletedInput = new ComboBox();
            SocietyMemberForm = new Panel();
            SocietyMemberFormRoleInput = new ComboBox();
            SocietyMemberFormRemoveButton = new Label();
            SocietyMemberFormCancelButton = new Label();
            SocietyMemberFormSaveButton = new Label();
            SocietyMemberFormRoleLabel = new Label();
            TeamMemberForm = new Panel();
            TeamMemberFormRoleLabel = new Label();
            TeamMemberFormRoleInput = new ComboBox();
            TeamMemberFormRemoveButton = new Label();
            TeamMemberFormCancelButton = new Label();
            TeamMemberFormSaveButton = new Label();
            AnnouncementForm = new Panel();
            AnnouncementFormTextLabel = new Label();
            AnnouncementFormTextInput = new TextBox();
            AnnouncementFormRemoveButton = new Label();
            AnnouncementFormCancelButton = new Label();
            AnnouncementFormSaveButton = new Label();
            SocietyForm.SuspendLayout();
            SocietyApplication.SuspendLayout();
            EventForm.SuspendLayout();
            TeamForm.SuspendLayout();
            TaskForm.SuspendLayout();
            SocietyMemberForm.SuspendLayout();
            TeamMemberForm.SuspendLayout();
            AnnouncementForm.SuspendLayout();
            SuspendLayout();
            // 
            // SocietyForm
            // 
            SocietyForm.BackgroundImage = (Image)resources.GetObject("SocietyForm.BackgroundImage");
            SocietyForm.BackgroundImageLayout = ImageLayout.Stretch;
            SocietyForm.Controls.Add(SocietyFormNameLabel);
            SocietyForm.Controls.Add(SocietyFormNameInput);
            SocietyForm.Controls.Add(SocietyFormDescriptionLabel);
            SocietyForm.Controls.Add(SocietyFormDescriptionInput);
            SocietyForm.Controls.Add(SocietyFormPresidentLabel);
            SocietyForm.Controls.Add(SocietyFormPresidentInput);
            SocietyForm.Controls.Add(SocietyFormRemoveButton);
            SocietyForm.Controls.Add(SocietyFormCancelButton);
            SocietyForm.Controls.Add(SocietyFormSaveButton);
            SocietyForm.Dock = DockStyle.Fill;
            SocietyForm.Location = new Point(0, 0);
            SocietyForm.Name = "SocietyForm";
            SocietyForm.Size = new Size(462, 673);
            SocietyForm.TabIndex = 0;
            SocietyForm.Visible = false;
            // 
            // SocietyFormNameLabel
            // 
            SocietyFormNameLabel.AutoSize = true;
            SocietyFormNameLabel.ForeColor = Color.Gray;
            SocietyFormNameLabel.Location = new Point(52, 215);
            SocietyFormNameLabel.Name = "SocietyFormNameLabel";
            SocietyFormNameLabel.Size = new Size(43, 16);
            SocietyFormNameLabel.TabIndex = 11;
            SocietyFormNameLabel.Text = "Name";
            // 
            // SocietyFormNameInput
            // 
            SocietyFormNameInput.BorderStyle = BorderStyle.None;
            SocietyFormNameInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            SocietyFormNameInput.ForeColor = Color.Black;
            SocietyFormNameInput.Location = new Point(52, 233);
            SocietyFormNameInput.Margin = new Padding(3, 2, 3, 2);
            SocietyFormNameInput.Name = "SocietyFormNameInput";
            SocietyFormNameInput.Size = new Size(360, 21);
            SocietyFormNameInput.TabIndex = 10;
            // 
            // SocietyFormDescriptionLabel
            // 
            SocietyFormDescriptionLabel.AutoSize = true;
            SocietyFormDescriptionLabel.ForeColor = Color.Gray;
            SocietyFormDescriptionLabel.Location = new Point(52, 286);
            SocietyFormDescriptionLabel.Name = "SocietyFormDescriptionLabel";
            SocietyFormDescriptionLabel.Size = new Size(78, 16);
            SocietyFormDescriptionLabel.TabIndex = 13;
            SocietyFormDescriptionLabel.Text = "Description";
            // 
            // SocietyFormDescriptionInput
            // 
            SocietyFormDescriptionInput.BorderStyle = BorderStyle.None;
            SocietyFormDescriptionInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            SocietyFormDescriptionInput.ForeColor = Color.Black;
            SocietyFormDescriptionInput.Location = new Point(52, 304);
            SocietyFormDescriptionInput.Margin = new Padding(3, 2, 3, 2);
            SocietyFormDescriptionInput.Name = "SocietyFormDescriptionInput";
            SocietyFormDescriptionInput.Size = new Size(360, 21);
            SocietyFormDescriptionInput.TabIndex = 12;
            // 
            // SocietyFormPresidentLabel
            // 
            SocietyFormPresidentLabel.AutoSize = true;
            SocietyFormPresidentLabel.ForeColor = Color.Gray;
            SocietyFormPresidentLabel.Location = new Point(52, 357);
            SocietyFormPresidentLabel.Name = "SocietyFormPresidentLabel";
            SocietyFormPresidentLabel.Size = new Size(67, 16);
            SocietyFormPresidentLabel.TabIndex = 15;
            SocietyFormPresidentLabel.Text = "President";
            // 
            // SocietyFormPresidentInput
            // 
            SocietyFormPresidentInput.BackColor = Color.White;
            SocietyFormPresidentInput.FlatStyle = FlatStyle.Flat;
            SocietyFormPresidentInput.ForeColor = Color.Black;
            SocietyFormPresidentInput.FormattingEnabled = true;
            SocietyFormPresidentInput.Location = new Point(52, 375);
            SocietyFormPresidentInput.Name = "SocietyFormPresidentInput";
            SocietyFormPresidentInput.Size = new Size(360, 24);
            SocietyFormPresidentInput.TabIndex = 16;
            // 
            // SocietyFormRemoveButton
            // 
            SocietyFormRemoveButton.BackColor = Color.Transparent;
            SocietyFormRemoveButton.Cursor = Cursors.Hand;
            SocietyFormRemoveButton.Location = new Point(52, 521);
            SocietyFormRemoveButton.Name = "SocietyFormRemoveButton";
            SocietyFormRemoveButton.Size = new Size(360, 37);
            SocietyFormRemoveButton.TabIndex = 17;
            // 
            // SocietyFormCancelButton
            // 
            SocietyFormCancelButton.BackColor = Color.Transparent;
            SocietyFormCancelButton.Cursor = Cursors.Hand;
            SocietyFormCancelButton.Location = new Point(52, 589);
            SocietyFormCancelButton.Name = "SocietyFormCancelButton";
            SocietyFormCancelButton.Size = new Size(164, 37);
            SocietyFormCancelButton.TabIndex = 18;
            // 
            // SocietyFormSaveButton
            // 
            SocietyFormSaveButton.BackColor = Color.Transparent;
            SocietyFormSaveButton.Cursor = Cursors.Hand;
            SocietyFormSaveButton.Location = new Point(248, 589);
            SocietyFormSaveButton.Name = "SocietyFormSaveButton";
            SocietyFormSaveButton.Size = new Size(164, 37);
            SocietyFormSaveButton.TabIndex = 19;
            // 
            // SocietyApplication
            // 
            SocietyApplication.BackgroundImage = (Image)resources.GetObject("SocietyApplication.BackgroundImage");
            SocietyApplication.BackgroundImageLayout = ImageLayout.Stretch;
            SocietyApplication.Controls.Add(SocietyApplicationSocietyLabel);
            SocietyApplication.Controls.Add(SocietyApplicationSocietyInput);
            SocietyApplication.Controls.Add(SocietyApplicationAdditionalNoteLabel);
            SocietyApplication.Controls.Add(SocietyApplicationAdditionalNoteInput);
            SocietyApplication.Controls.Add(SocietyApplicationCancelButton);
            SocietyApplication.Controls.Add(SocietyApplicationApplyButton);
            SocietyApplication.Dock = DockStyle.Fill;
            SocietyApplication.Location = new Point(0, 0);
            SocietyApplication.Name = "SocietyApplication";
            SocietyApplication.Size = new Size(462, 673);
            SocietyApplication.TabIndex = 1;
            SocietyApplication.Visible = false;
            // 
            // SocietyApplicationSocietyLabel
            // 
            SocietyApplicationSocietyLabel.AutoSize = true;
            SocietyApplicationSocietyLabel.ForeColor = Color.Gray;
            SocietyApplicationSocietyLabel.Location = new Point(52, 215);
            SocietyApplicationSocietyLabel.Name = "SocietyApplicationSocietyLabel";
            SocietyApplicationSocietyLabel.Size = new Size(53, 16);
            SocietyApplicationSocietyLabel.TabIndex = 11;
            SocietyApplicationSocietyLabel.Text = "Society";
            // 
            // SocietyApplicationSocietyInput
            // 
            SocietyApplicationSocietyInput.BorderStyle = BorderStyle.None;
            SocietyApplicationSocietyInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            SocietyApplicationSocietyInput.ForeColor = Color.Black;
            SocietyApplicationSocietyInput.Location = new Point(52, 233);
            SocietyApplicationSocietyInput.Margin = new Padding(3, 2, 3, 2);
            SocietyApplicationSocietyInput.Name = "SocietyApplicationSocietyInput";
            SocietyApplicationSocietyInput.Size = new Size(360, 21);
            SocietyApplicationSocietyInput.TabIndex = 10;
            // 
            // SocietyApplicationAdditionalNoteLabel
            // 
            SocietyApplicationAdditionalNoteLabel.AutoSize = true;
            SocietyApplicationAdditionalNoteLabel.ForeColor = Color.Gray;
            SocietyApplicationAdditionalNoteLabel.Location = new Point(52, 286);
            SocietyApplicationAdditionalNoteLabel.Name = "SocietyApplicationAdditionalNoteLabel";
            SocietyApplicationAdditionalNoteLabel.Size = new Size(104, 16);
            SocietyApplicationAdditionalNoteLabel.TabIndex = 13;
            SocietyApplicationAdditionalNoteLabel.Text = "Additional Note";
            // 
            // SocietyApplicationAdditionalNoteInput
            // 
            SocietyApplicationAdditionalNoteInput.BorderStyle = BorderStyle.None;
            SocietyApplicationAdditionalNoteInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            SocietyApplicationAdditionalNoteInput.ForeColor = Color.Black;
            SocietyApplicationAdditionalNoteInput.Location = new Point(52, 304);
            SocietyApplicationAdditionalNoteInput.Margin = new Padding(3, 2, 3, 2);
            SocietyApplicationAdditionalNoteInput.Name = "SocietyApplicationAdditionalNoteInput";
            SocietyApplicationAdditionalNoteInput.Size = new Size(360, 21);
            SocietyApplicationAdditionalNoteInput.TabIndex = 12;
            // 
            // SocietyApplicationCancelButton
            // 
            SocietyApplicationCancelButton.BackColor = Color.Transparent;
            SocietyApplicationCancelButton.Cursor = Cursors.Hand;
            SocietyApplicationCancelButton.Location = new Point(52, 589);
            SocietyApplicationCancelButton.Name = "SocietyApplicationCancelButton";
            SocietyApplicationCancelButton.Size = new Size(164, 37);
            SocietyApplicationCancelButton.TabIndex = 18;
            // 
            // SocietyApplicationApplyButton
            // 
            SocietyApplicationApplyButton.BackColor = Color.Transparent;
            SocietyApplicationApplyButton.Cursor = Cursors.Hand;
            SocietyApplicationApplyButton.Location = new Point(248, 589);
            SocietyApplicationApplyButton.Name = "SocietyApplicationApplyButton";
            SocietyApplicationApplyButton.Size = new Size(164, 37);
            SocietyApplicationApplyButton.TabIndex = 19;
            // 
            // EventForm
            // 
            EventForm.BackgroundImage = (Image)resources.GetObject("EventForm.BackgroundImage");
            EventForm.BackgroundImageLayout = ImageLayout.Stretch;
            EventForm.Controls.Add(EventFormTitleLabel);
            EventForm.Controls.Add(EventFormTitleInput);
            EventForm.Controls.Add(EventFormDescriptionLabel);
            EventForm.Controls.Add(EventFormDescriptionInput);
            EventForm.Controls.Add(EventFormStartDateLabel);
            EventForm.Controls.Add(EventFormStartDateInput);
            EventForm.Controls.Add(EventFormEndDateLabel);
            EventForm.Controls.Add(EventFormEndDateInput);
            EventForm.Controls.Add(EventFormLocationLabel);
            EventForm.Controls.Add(EventFormLocationInput);
            EventForm.Controls.Add(EventFormRemoveButton);
            EventForm.Controls.Add(EventFormCancelButton);
            EventForm.Controls.Add(EventFormSaveButton);
            EventForm.Dock = DockStyle.Fill;
            EventForm.Location = new Point(0, 0);
            EventForm.Name = "EventForm";
            EventForm.Size = new Size(462, 673);
            EventForm.TabIndex = 2;
            EventForm.Visible = false;
            // 
            // EventFormTitleLabel
            // 
            EventFormTitleLabel.AutoSize = true;
            EventFormTitleLabel.ForeColor = Color.Gray;
            EventFormTitleLabel.Location = new Point(52, 215);
            EventFormTitleLabel.Name = "EventFormTitleLabel";
            EventFormTitleLabel.Size = new Size(34, 16);
            EventFormTitleLabel.TabIndex = 11;
            EventFormTitleLabel.Text = "Title";
            // 
            // EventFormTitleInput
            // 
            EventFormTitleInput.BorderStyle = BorderStyle.None;
            EventFormTitleInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            EventFormTitleInput.ForeColor = Color.Black;
            EventFormTitleInput.Location = new Point(52, 233);
            EventFormTitleInput.Margin = new Padding(3, 2, 3, 2);
            EventFormTitleInput.Name = "EventFormTitleInput";
            EventFormTitleInput.Size = new Size(360, 21);
            EventFormTitleInput.TabIndex = 10;
            // 
            // EventFormDescriptionLabel
            // 
            EventFormDescriptionLabel.AutoSize = true;
            EventFormDescriptionLabel.ForeColor = Color.Gray;
            EventFormDescriptionLabel.Location = new Point(52, 286);
            EventFormDescriptionLabel.Name = "EventFormDescriptionLabel";
            EventFormDescriptionLabel.Size = new Size(78, 16);
            EventFormDescriptionLabel.TabIndex = 13;
            EventFormDescriptionLabel.Text = "Description";
            // 
            // EventFormDescriptionInput
            // 
            EventFormDescriptionInput.BorderStyle = BorderStyle.None;
            EventFormDescriptionInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            EventFormDescriptionInput.ForeColor = Color.Black;
            EventFormDescriptionInput.Location = new Point(52, 304);
            EventFormDescriptionInput.Margin = new Padding(3, 2, 3, 2);
            EventFormDescriptionInput.Name = "EventFormDescriptionInput";
            EventFormDescriptionInput.Size = new Size(360, 21);
            EventFormDescriptionInput.TabIndex = 12;
            // 
            // EventFormStartDateLabel
            // 
            EventFormStartDateLabel.AutoSize = true;
            EventFormStartDateLabel.ForeColor = Color.Gray;
            EventFormStartDateLabel.Location = new Point(52, 356);
            EventFormStartDateLabel.Name = "EventFormStartDateLabel";
            EventFormStartDateLabel.Size = new Size(70, 16);
            EventFormStartDateLabel.TabIndex = 24;
            EventFormStartDateLabel.Text = "Start Date";
            // 
            // EventFormStartDateInput
            // 
            EventFormStartDateInput.BorderStyle = BorderStyle.None;
            EventFormStartDateInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            EventFormStartDateInput.ForeColor = Color.Black;
            EventFormStartDateInput.Location = new Point(52, 374);
            EventFormStartDateInput.Margin = new Padding(3, 2, 3, 2);
            EventFormStartDateInput.Name = "EventFormStartDateInput";
            EventFormStartDateInput.Size = new Size(160, 21);
            EventFormStartDateInput.TabIndex = 21;
            // 
            // EventFormEndDateLabel
            // 
            EventFormEndDateLabel.AutoSize = true;
            EventFormEndDateLabel.ForeColor = Color.Gray;
            EventFormEndDateLabel.Location = new Point(249, 356);
            EventFormEndDateLabel.Name = "EventFormEndDateLabel";
            EventFormEndDateLabel.Size = new Size(64, 16);
            EventFormEndDateLabel.TabIndex = 25;
            EventFormEndDateLabel.Text = "End Date";
            // 
            // EventFormEndDateInput
            // 
            EventFormEndDateInput.BorderStyle = BorderStyle.None;
            EventFormEndDateInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            EventFormEndDateInput.ForeColor = Color.Black;
            EventFormEndDateInput.Location = new Point(249, 374);
            EventFormEndDateInput.Margin = new Padding(3, 2, 3, 2);
            EventFormEndDateInput.Name = "EventFormEndDateInput";
            EventFormEndDateInput.Size = new Size(160, 21);
            EventFormEndDateInput.TabIndex = 22;
            // 
            // EventFormLocationLabel
            // 
            EventFormLocationLabel.AutoSize = true;
            EventFormLocationLabel.ForeColor = Color.Gray;
            EventFormLocationLabel.Location = new Point(52, 424);
            EventFormLocationLabel.Name = "EventFormLocationLabel";
            EventFormLocationLabel.Size = new Size(60, 16);
            EventFormLocationLabel.TabIndex = 26;
            EventFormLocationLabel.Text = "Location";
            // 
            // EventFormLocationInput
            // 
            EventFormLocationInput.BorderStyle = BorderStyle.None;
            EventFormLocationInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            EventFormLocationInput.ForeColor = Color.Black;
            EventFormLocationInput.Location = new Point(52, 442);
            EventFormLocationInput.Margin = new Padding(3, 2, 3, 2);
            EventFormLocationInput.Name = "EventFormLocationInput";
            EventFormLocationInput.Size = new Size(360, 21);
            EventFormLocationInput.TabIndex = 23;
            // 
            // EventFormRemoveButton
            // 
            EventFormRemoveButton.BackColor = Color.Transparent;
            EventFormRemoveButton.Cursor = Cursors.Hand;
            EventFormRemoveButton.Location = new Point(52, 521);
            EventFormRemoveButton.Name = "EventFormRemoveButton";
            EventFormRemoveButton.Size = new Size(360, 37);
            EventFormRemoveButton.TabIndex = 20;
            // 
            // EventFormCancelButton
            // 
            EventFormCancelButton.BackColor = Color.Transparent;
            EventFormCancelButton.Cursor = Cursors.Hand;
            EventFormCancelButton.Location = new Point(52, 589);
            EventFormCancelButton.Name = "EventFormCancelButton";
            EventFormCancelButton.Size = new Size(164, 37);
            EventFormCancelButton.TabIndex = 18;
            // 
            // EventFormSaveButton
            // 
            EventFormSaveButton.BackColor = Color.Transparent;
            EventFormSaveButton.Cursor = Cursors.Hand;
            EventFormSaveButton.Location = new Point(248, 589);
            EventFormSaveButton.Name = "EventFormSaveButton";
            EventFormSaveButton.Size = new Size(164, 37);
            EventFormSaveButton.TabIndex = 19;
            // 
            // TeamForm
            // 
            TeamForm.BackgroundImage = (Image)resources.GetObject("TeamForm.BackgroundImage");
            TeamForm.BackgroundImageLayout = ImageLayout.Stretch;
            TeamForm.Controls.Add(TeamFormNameLabel);
            TeamForm.Controls.Add(TeamFormNameInput);
            TeamForm.Controls.Add(TeamFormDescriptionLabel);
            TeamForm.Controls.Add(TeamFormDescriptionInput);
            TeamForm.Controls.Add(TeamFormHeadLabel);
            TeamForm.Controls.Add(TeamFormHeadInput);
            TeamForm.Controls.Add(TeamFormRemoveButton);
            TeamForm.Controls.Add(TeamFormCancelButton);
            TeamForm.Controls.Add(TeamFormSaveButton);
            TeamForm.Dock = DockStyle.Fill;
            TeamForm.Location = new Point(0, 0);
            TeamForm.Name = "TeamForm";
            TeamForm.Size = new Size(462, 673);
            TeamForm.TabIndex = 3;
            TeamForm.Visible = false;
            // 
            // TeamFormNameLabel
            // 
            TeamFormNameLabel.AutoSize = true;
            TeamFormNameLabel.ForeColor = Color.Gray;
            TeamFormNameLabel.Location = new Point(52, 215);
            TeamFormNameLabel.Name = "TeamFormNameLabel";
            TeamFormNameLabel.Size = new Size(43, 16);
            TeamFormNameLabel.TabIndex = 11;
            TeamFormNameLabel.Text = "Name";
            // 
            // TeamFormNameInput
            // 
            TeamFormNameInput.BorderStyle = BorderStyle.None;
            TeamFormNameInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            TeamFormNameInput.ForeColor = Color.Black;
            TeamFormNameInput.Location = new Point(52, 233);
            TeamFormNameInput.Margin = new Padding(3, 2, 3, 2);
            TeamFormNameInput.Name = "TeamFormNameInput";
            TeamFormNameInput.Size = new Size(360, 21);
            TeamFormNameInput.TabIndex = 10;
            // 
            // TeamFormDescriptionLabel
            // 
            TeamFormDescriptionLabel.AutoSize = true;
            TeamFormDescriptionLabel.ForeColor = Color.Gray;
            TeamFormDescriptionLabel.Location = new Point(52, 286);
            TeamFormDescriptionLabel.Name = "TeamFormDescriptionLabel";
            TeamFormDescriptionLabel.Size = new Size(78, 16);
            TeamFormDescriptionLabel.TabIndex = 13;
            TeamFormDescriptionLabel.Text = "Description";
            // 
            // TeamFormDescriptionInput
            // 
            TeamFormDescriptionInput.BorderStyle = BorderStyle.None;
            TeamFormDescriptionInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            TeamFormDescriptionInput.ForeColor = Color.Black;
            TeamFormDescriptionInput.Location = new Point(52, 304);
            TeamFormDescriptionInput.Margin = new Padding(3, 2, 3, 2);
            TeamFormDescriptionInput.Name = "TeamFormDescriptionInput";
            TeamFormDescriptionInput.Size = new Size(360, 21);
            TeamFormDescriptionInput.TabIndex = 12;
            // 
            // TeamFormHeadLabel
            // 
            TeamFormHeadLabel.AutoSize = true;
            TeamFormHeadLabel.ForeColor = Color.Gray;
            TeamFormHeadLabel.Location = new Point(52, 357);
            TeamFormHeadLabel.Name = "TeamFormHeadLabel";
            TeamFormHeadLabel.Size = new Size(40, 16);
            TeamFormHeadLabel.TabIndex = 15;
            TeamFormHeadLabel.Text = "Head";
            // 
            // TeamFormHeadInput
            // 
            TeamFormHeadInput.BackColor = Color.White;
            TeamFormHeadInput.FlatStyle = FlatStyle.Flat;
            TeamFormHeadInput.ForeColor = Color.Black;
            TeamFormHeadInput.FormattingEnabled = true;
            TeamFormHeadInput.Location = new Point(52, 375);
            TeamFormHeadInput.Name = "TeamFormHeadInput";
            TeamFormHeadInput.Size = new Size(360, 24);
            TeamFormHeadInput.TabIndex = 16;
            // 
            // TeamFormRemoveButton
            // 
            TeamFormRemoveButton.BackColor = Color.Transparent;
            TeamFormRemoveButton.Cursor = Cursors.Hand;
            TeamFormRemoveButton.Location = new Point(52, 521);
            TeamFormRemoveButton.Name = "TeamFormRemoveButton";
            TeamFormRemoveButton.Size = new Size(360, 37);
            TeamFormRemoveButton.TabIndex = 17;
            // 
            // TeamFormCancelButton
            // 
            TeamFormCancelButton.BackColor = Color.Transparent;
            TeamFormCancelButton.Cursor = Cursors.Hand;
            TeamFormCancelButton.Location = new Point(52, 589);
            TeamFormCancelButton.Name = "TeamFormCancelButton";
            TeamFormCancelButton.Size = new Size(164, 37);
            TeamFormCancelButton.TabIndex = 18;
            // 
            // TeamFormSaveButton
            // 
            TeamFormSaveButton.BackColor = Color.Transparent;
            TeamFormSaveButton.Cursor = Cursors.Hand;
            TeamFormSaveButton.Location = new Point(248, 589);
            TeamFormSaveButton.Name = "TeamFormSaveButton";
            TeamFormSaveButton.Size = new Size(164, 37);
            TeamFormSaveButton.TabIndex = 19;
            // 
            // TaskForm
            // 
            TaskForm.BackgroundImage = (Image)resources.GetObject("TaskForm.BackgroundImage");
            TaskForm.BackgroundImageLayout = ImageLayout.Stretch;
            TaskForm.Controls.Add(TaskFormTitleLabel);
            TaskForm.Controls.Add(TaskFormTitleInput);
            TaskForm.Controls.Add(TaskFormDescriptionLabel);
            TaskForm.Controls.Add(TaskFormDescriptionInput);
            TaskForm.Controls.Add(TaskFormAssigneeLabel);
            TaskForm.Controls.Add(TaskFormAssigneeInput);
            TaskForm.Controls.Add(TaskFormCompletedLabel);
            TaskForm.Controls.Add(TaskFormCompletedInput);
            TaskForm.Controls.Add(TaskFormRemoveButton);
            TaskForm.Controls.Add(TaskFormCancelButton);
            TaskForm.Controls.Add(TaskFormSaveButton);
            TaskForm.Dock = DockStyle.Fill;
            TaskForm.Location = new Point(0, 0);
            TaskForm.Name = "TaskForm";
            TaskForm.Size = new Size(462, 673);
            TaskForm.TabIndex = 4;
            TaskForm.Visible = false;
            // 
            // TaskFormTitleLabel
            // 
            TaskFormTitleLabel.AutoSize = true;
            TaskFormTitleLabel.ForeColor = Color.Gray;
            TaskFormTitleLabel.Location = new Point(52, 215);
            TaskFormTitleLabel.Name = "TaskFormTitleLabel";
            TaskFormTitleLabel.Size = new Size(34, 16);
            TaskFormTitleLabel.TabIndex = 11;
            TaskFormTitleLabel.Text = "Title";
            // 
            // TaskFormTitleInput
            // 
            TaskFormTitleInput.BorderStyle = BorderStyle.None;
            TaskFormTitleInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            TaskFormTitleInput.ForeColor = Color.Black;
            TaskFormTitleInput.Location = new Point(52, 233);
            TaskFormTitleInput.Margin = new Padding(3, 2, 3, 2);
            TaskFormTitleInput.Name = "TaskFormTitleInput";
            TaskFormTitleInput.Size = new Size(360, 21);
            TaskFormTitleInput.TabIndex = 10;
            // 
            // TaskFormDescriptionLabel
            // 
            TaskFormDescriptionLabel.AutoSize = true;
            TaskFormDescriptionLabel.ForeColor = Color.Gray;
            TaskFormDescriptionLabel.Location = new Point(52, 286);
            TaskFormDescriptionLabel.Name = "TaskFormDescriptionLabel";
            TaskFormDescriptionLabel.Size = new Size(78, 16);
            TaskFormDescriptionLabel.TabIndex = 13;
            TaskFormDescriptionLabel.Text = "Description";
            // 
            // TaskFormDescriptionInput
            // 
            TaskFormDescriptionInput.BorderStyle = BorderStyle.None;
            TaskFormDescriptionInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            TaskFormDescriptionInput.ForeColor = Color.Black;
            TaskFormDescriptionInput.Location = new Point(52, 304);
            TaskFormDescriptionInput.Margin = new Padding(3, 2, 3, 2);
            TaskFormDescriptionInput.Name = "TaskFormDescriptionInput";
            TaskFormDescriptionInput.Size = new Size(360, 21);
            TaskFormDescriptionInput.TabIndex = 12;
            // 
            // TaskFormAssigneeLabel
            // 
            TaskFormAssigneeLabel.AutoSize = true;
            TaskFormAssigneeLabel.ForeColor = Color.Gray;
            TaskFormAssigneeLabel.Location = new Point(52, 357);
            TaskFormAssigneeLabel.Name = "TaskFormAssigneeLabel";
            TaskFormAssigneeLabel.Size = new Size(65, 16);
            TaskFormAssigneeLabel.TabIndex = 15;
            TaskFormAssigneeLabel.Text = "Assignee";
            // 
            // TaskFormAssigneeInput
            // 
            TaskFormAssigneeInput.BackColor = Color.White;
            TaskFormAssigneeInput.FlatStyle = FlatStyle.Flat;
            TaskFormAssigneeInput.ForeColor = Color.Black;
            TaskFormAssigneeInput.FormattingEnabled = true;
            TaskFormAssigneeInput.Location = new Point(52, 375);
            TaskFormAssigneeInput.Name = "TaskFormAssigneeInput";
            TaskFormAssigneeInput.Size = new Size(360, 24);
            TaskFormAssigneeInput.TabIndex = 16;
            // 
            // TaskFormRemoveButton
            // 
            TaskFormRemoveButton.BackColor = Color.Transparent;
            TaskFormRemoveButton.Cursor = Cursors.Hand;
            TaskFormRemoveButton.Location = new Point(52, 521);
            TaskFormRemoveButton.Name = "TaskFormRemoveButton";
            TaskFormRemoveButton.Size = new Size(360, 37);
            TaskFormRemoveButton.TabIndex = 17;
            // 
            // TaskFormCancelButton
            // 
            TaskFormCancelButton.BackColor = Color.Transparent;
            TaskFormCancelButton.Cursor = Cursors.Hand;
            TaskFormCancelButton.Location = new Point(52, 589);
            TaskFormCancelButton.Name = "TaskFormCancelButton";
            TaskFormCancelButton.Size = new Size(164, 37);
            TaskFormCancelButton.TabIndex = 18;
            // 
            // TaskFormSaveButton
            // 
            TaskFormSaveButton.BackColor = Color.Transparent;
            TaskFormSaveButton.Cursor = Cursors.Hand;
            TaskFormSaveButton.Location = new Point(248, 589);
            TaskFormSaveButton.Name = "TaskFormSaveButton";
            TaskFormSaveButton.Size = new Size(164, 37);
            TaskFormSaveButton.TabIndex = 19;
            // 
            // TaskFormCompletedLabel
            // 
            TaskFormCompletedLabel.AutoSize = true;
            TaskFormCompletedLabel.ForeColor = Color.Gray;
            TaskFormCompletedLabel.Location = new Point(52, 425);
            TaskFormCompletedLabel.Name = "TaskFormCompletedLabel";
            TaskFormCompletedLabel.Size = new Size(75, 16);
            TaskFormCompletedLabel.TabIndex = 20;
            TaskFormCompletedLabel.Text = "Completed";
            // 
            // TaskFormCompletedInput
            // 
            TaskFormCompletedInput.BackColor = Color.White;
            TaskFormCompletedInput.FlatStyle = FlatStyle.Flat;
            TaskFormCompletedInput.ForeColor = Color.Black;
            TaskFormCompletedInput.FormattingEnabled = true;
            TaskFormCompletedInput.Location = new Point(52, 443);
            TaskFormCompletedInput.Name = "TaskFormCompletedInput";
            TaskFormCompletedInput.Size = new Size(360, 24);
            TaskFormCompletedInput.TabIndex = 21;
            // 
            // SocietyMemberForm
            // 
            SocietyMemberForm.BackgroundImage = (Image)resources.GetObject("SocietyMemberForm.BackgroundImage");
            SocietyMemberForm.BackgroundImageLayout = ImageLayout.Stretch;
            SocietyMemberForm.Controls.Add(SocietyMemberFormRoleLabel);
            SocietyMemberForm.Controls.Add(SocietyMemberFormRoleInput);
            SocietyMemberForm.Controls.Add(SocietyMemberFormRemoveButton);
            SocietyMemberForm.Controls.Add(SocietyMemberFormCancelButton);
            SocietyMemberForm.Controls.Add(SocietyMemberFormSaveButton);
            SocietyMemberForm.Dock = DockStyle.Fill;
            SocietyMemberForm.Location = new Point(0, 0);
            SocietyMemberForm.Name = "SocietyMemberForm";
            SocietyMemberForm.Size = new Size(462, 673);
            SocietyMemberForm.TabIndex = 5;
            SocietyMemberForm.Visible = false;
            // 
            // SocietyMemberFormRoleInput
            // 
            SocietyMemberFormRoleInput.BackColor = Color.White;
            SocietyMemberFormRoleInput.FlatStyle = FlatStyle.Flat;
            SocietyMemberFormRoleInput.ForeColor = Color.Black;
            SocietyMemberFormRoleInput.FormattingEnabled = true;
            SocietyMemberFormRoleInput.Location = new Point(52, 234);
            SocietyMemberFormRoleInput.Name = "SocietyMemberFormRoleInput";
            SocietyMemberFormRoleInput.Size = new Size(360, 24);
            SocietyMemberFormRoleInput.TabIndex = 16;
            // 
            // SocietyMemberFormRemoveButton
            // 
            SocietyMemberFormRemoveButton.BackColor = Color.Transparent;
            SocietyMemberFormRemoveButton.Cursor = Cursors.Hand;
            SocietyMemberFormRemoveButton.Location = new Point(52, 521);
            SocietyMemberFormRemoveButton.Name = "SocietyMemberFormRemoveButton";
            SocietyMemberFormRemoveButton.Size = new Size(360, 37);
            SocietyMemberFormRemoveButton.TabIndex = 17;
            // 
            // SocietyMemberFormCancelButton
            // 
            SocietyMemberFormCancelButton.BackColor = Color.Transparent;
            SocietyMemberFormCancelButton.Cursor = Cursors.Hand;
            SocietyMemberFormCancelButton.Location = new Point(52, 589);
            SocietyMemberFormCancelButton.Name = "SocietyMemberFormCancelButton";
            SocietyMemberFormCancelButton.Size = new Size(164, 37);
            SocietyMemberFormCancelButton.TabIndex = 18;
            // 
            // SocietyMemberFormSaveButton
            // 
            SocietyMemberFormSaveButton.BackColor = Color.Transparent;
            SocietyMemberFormSaveButton.Cursor = Cursors.Hand;
            SocietyMemberFormSaveButton.Location = new Point(248, 589);
            SocietyMemberFormSaveButton.Name = "SocietyMemberFormSaveButton";
            SocietyMemberFormSaveButton.Size = new Size(164, 37);
            SocietyMemberFormSaveButton.TabIndex = 19;
            // 
            // SocietyMemberFormRoleLabel
            // 
            SocietyMemberFormRoleLabel.AutoSize = true;
            SocietyMemberFormRoleLabel.ForeColor = Color.Gray;
            SocietyMemberFormRoleLabel.Location = new Point(52, 216);
            SocietyMemberFormRoleLabel.Name = "SocietyMemberFormRoleLabel";
            SocietyMemberFormRoleLabel.Size = new Size(34, 16);
            SocietyMemberFormRoleLabel.TabIndex = 15;
            SocietyMemberFormRoleLabel.Text = "Role";
            // 
            // TeamMemberForm
            // 
            TeamMemberForm.BackgroundImage = (Image)resources.GetObject("TeamMemberForm.BackgroundImage");
            TeamMemberForm.BackgroundImageLayout = ImageLayout.Stretch;
            TeamMemberForm.Controls.Add(TeamMemberFormRoleLabel);
            TeamMemberForm.Controls.Add(TeamMemberFormRoleInput);
            TeamMemberForm.Controls.Add(TeamMemberFormRemoveButton);
            TeamMemberForm.Controls.Add(TeamMemberFormCancelButton);
            TeamMemberForm.Controls.Add(TeamMemberFormSaveButton);
            TeamMemberForm.Dock = DockStyle.Fill;
            TeamMemberForm.Location = new Point(0, 0);
            TeamMemberForm.Name = "TeamMemberForm";
            TeamMemberForm.Size = new Size(462, 673);
            TeamMemberForm.TabIndex = 6;
            TeamMemberForm.Visible = false;
            // 
            // TeamMemberFormRoleLabel
            // 
            TeamMemberFormRoleLabel.AutoSize = true;
            TeamMemberFormRoleLabel.ForeColor = Color.Gray;
            TeamMemberFormRoleLabel.Location = new Point(52, 216);
            TeamMemberFormRoleLabel.Name = "TeamMemberFormRoleLabel";
            TeamMemberFormRoleLabel.Size = new Size(34, 16);
            TeamMemberFormRoleLabel.TabIndex = 15;
            TeamMemberFormRoleLabel.Text = "Role";
            // 
            // TeamMemberFormRoleInput
            // 
            TeamMemberFormRoleInput.BackColor = Color.White;
            TeamMemberFormRoleInput.FlatStyle = FlatStyle.Flat;
            TeamMemberFormRoleInput.ForeColor = Color.Black;
            TeamMemberFormRoleInput.FormattingEnabled = true;
            TeamMemberFormRoleInput.Location = new Point(52, 234);
            TeamMemberFormRoleInput.Name = "TeamMemberFormRoleInput";
            TeamMemberFormRoleInput.Size = new Size(360, 24);
            TeamMemberFormRoleInput.TabIndex = 16;
            // 
            // TeamMemberFormRemoveButton
            // 
            TeamMemberFormRemoveButton.BackColor = Color.Transparent;
            TeamMemberFormRemoveButton.Cursor = Cursors.Hand;
            TeamMemberFormRemoveButton.Location = new Point(52, 521);
            TeamMemberFormRemoveButton.Name = "TeamMemberFormRemoveButton";
            TeamMemberFormRemoveButton.Size = new Size(360, 37);
            TeamMemberFormRemoveButton.TabIndex = 17;
            // 
            // TeamMemberFormCancelButton
            // 
            TeamMemberFormCancelButton.BackColor = Color.Transparent;
            TeamMemberFormCancelButton.Cursor = Cursors.Hand;
            TeamMemberFormCancelButton.Location = new Point(52, 589);
            TeamMemberFormCancelButton.Name = "TeamMemberFormCancelButton";
            TeamMemberFormCancelButton.Size = new Size(164, 37);
            TeamMemberFormCancelButton.TabIndex = 18;
            // 
            // TeamMemberFormSaveButton
            // 
            TeamMemberFormSaveButton.BackColor = Color.Transparent;
            TeamMemberFormSaveButton.Cursor = Cursors.Hand;
            TeamMemberFormSaveButton.Location = new Point(248, 589);
            TeamMemberFormSaveButton.Name = "TeamMemberFormSaveButton";
            TeamMemberFormSaveButton.Size = new Size(164, 37);
            TeamMemberFormSaveButton.TabIndex = 19;
            // 
            // AnnouncementForm
            // 
            AnnouncementForm.BackgroundImage = (Image)resources.GetObject("AnnouncementForm.BackgroundImage");
            AnnouncementForm.BackgroundImageLayout = ImageLayout.Stretch;
            AnnouncementForm.Controls.Add(AnnouncementFormTextLabel);
            AnnouncementForm.Controls.Add(AnnouncementFormTextInput);
            AnnouncementForm.Controls.Add(AnnouncementFormRemoveButton);
            AnnouncementForm.Controls.Add(AnnouncementFormCancelButton);
            AnnouncementForm.Controls.Add(AnnouncementFormSaveButton);
            AnnouncementForm.Dock = DockStyle.Fill;
            AnnouncementForm.Location = new Point(0, 0);
            AnnouncementForm.Name = "AnnouncementForm";
            AnnouncementForm.Size = new Size(462, 673);
            AnnouncementForm.TabIndex = 7;
            AnnouncementForm.Visible = false;
            // 
            // AnnouncementFormTextLabel
            // 
            AnnouncementFormTextLabel.AutoSize = true;
            AnnouncementFormTextLabel.ForeColor = Color.Gray;
            AnnouncementFormTextLabel.Location = new Point(52, 215);
            AnnouncementFormTextLabel.Name = "AnnouncementFormTextLabel";
            AnnouncementFormTextLabel.Size = new Size(34, 16);
            AnnouncementFormTextLabel.TabIndex = 11;
            AnnouncementFormTextLabel.Text = "Text";
            // 
            // AnnouncementFormTextInput
            // 
            AnnouncementFormTextInput.BorderStyle = BorderStyle.None;
            AnnouncementFormTextInput.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            AnnouncementFormTextInput.ForeColor = Color.Black;
            AnnouncementFormTextInput.Location = new Point(52, 233);
            AnnouncementFormTextInput.Margin = new Padding(3, 2, 3, 2);
            AnnouncementFormTextInput.Name = "AnnouncementFormTextInput";
            AnnouncementFormTextInput.Size = new Size(360, 21);
            AnnouncementFormTextInput.TabIndex = 10;
            // 
            // AnnouncementFormRemoveButton
            // 
            AnnouncementFormRemoveButton.BackColor = Color.Transparent;
            AnnouncementFormRemoveButton.Cursor = Cursors.Hand;
            AnnouncementFormRemoveButton.Location = new Point(52, 521);
            AnnouncementFormRemoveButton.Name = "AnnouncementFormRemoveButton";
            AnnouncementFormRemoveButton.Size = new Size(360, 37);
            AnnouncementFormRemoveButton.TabIndex = 17;
            // 
            // AnnouncementFormCancelButton
            // 
            AnnouncementFormCancelButton.BackColor = Color.Transparent;
            AnnouncementFormCancelButton.Cursor = Cursors.Hand;
            AnnouncementFormCancelButton.Location = new Point(52, 589);
            AnnouncementFormCancelButton.Name = "AnnouncementFormCancelButton";
            AnnouncementFormCancelButton.Size = new Size(164, 37);
            AnnouncementFormCancelButton.TabIndex = 18;
            // 
            // AnnouncementFormSaveButton
            // 
            AnnouncementFormSaveButton.BackColor = Color.Transparent;
            AnnouncementFormSaveButton.Cursor = Cursors.Hand;
            AnnouncementFormSaveButton.Location = new Point(248, 589);
            AnnouncementFormSaveButton.Name = "AnnouncementFormSaveButton";
            AnnouncementFormSaveButton.Size = new Size(164, 37);
            AnnouncementFormSaveButton.TabIndex = 19;
            // 
            // CRUDForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(462, 673);
            Controls.Add(SocietyForm);
            Controls.Add(SocietyApplication);
            Controls.Add(EventForm);
            Controls.Add(TeamForm);
            Controls.Add(TaskForm);
            Controls.Add(SocietyMemberForm);
            Controls.Add(TeamMemberForm);
            Controls.Add(AnnouncementForm);
            DoubleBuffered = true;
            Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "CRUDForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SocietySync Form";
            TopMost = true;
            SocietyForm.ResumeLayout(false);
            SocietyForm.PerformLayout();
            SocietyApplication.ResumeLayout(false);
            SocietyApplication.PerformLayout();
            EventForm.ResumeLayout(false);
            EventForm.PerformLayout();
            TeamForm.ResumeLayout(false);
            TeamForm.PerformLayout();
            TaskForm.ResumeLayout(false);
            TaskForm.PerformLayout();
            SocietyMemberForm.ResumeLayout(false);
            SocietyMemberForm.PerformLayout();
            TeamMemberForm.ResumeLayout(false);
            TeamMemberForm.PerformLayout();
            AnnouncementForm.ResumeLayout(false);
            AnnouncementForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SocietyForm;
        private Label SocietyFormNameLabel;
        private TextBox SocietyFormNameInput;
        private Label SocietyFormDescriptionLabel;
        private TextBox SocietyFormDescriptionInput;
        private Label SocietyFormPresidentLabel;
        private ComboBox SocietyFormPresidentInput;
        private Label SocietyFormRemoveButton;
        private Label SocietyFormCancelButton;
        private Label SocietyFormSaveButton;
        private Panel SocietyApplication;
        private Label SocietyApplicationSocietyLabel;
        private TextBox SocietyApplicationSocietyInput;
        private Label SocietyApplicationAdditionalNoteLabel;
        private TextBox SocietyApplicationAdditionalNoteInput;
        private Label SocietyApplicationCancelButton;
        private Label SocietyApplicationApplyButton;
        private Panel EventForm;
        private Label EventFormTitleLabel;
        private TextBox EventFormTitleInput;
        private Label EventFormDescriptionLabel;
        private TextBox EventFormDescriptionInput;
        private Label EventFormCancelButton;
        private Label EventFormSaveButton;
        private TextBox EventFormStartDateInput;
        private TextBox EventFormEndDateInput;
        private Label EventFormRemoveButton;
        private Label EventFormStartDateLabel;
        private Label EventFormEndDateLabel;
        private Label EventFormLocationLabel;
        private TextBox EventFormLocationInput;
        private Panel TeamForm;
        private Label TeamFormNameLabel;
        private TextBox TeamFormNameInput;
        private Label TeamFormDescriptionLabel;
        private TextBox TeamFormDescriptionInput;
        private Label TeamFormHeadLabel;
        private ComboBox TeamFormHeadInput;
        private Label TeamFormRemoveButton;
        private Label TeamFormCancelButton;
        private Label TeamFormSaveButton;
        private Panel TaskForm;
        private Label TaskFormTitleLabel;
        private TextBox TaskFormTitleInput;
        private Label TaskFormDescriptionLabel;
        private TextBox TaskFormDescriptionInput;
        private Label TaskFormAssigneeLabel;
        private ComboBox TaskFormAssigneeInput;
        private Label TaskFormRemoveButton;
        private Label TaskFormCancelButton;
        private Label TaskFormSaveButton;
        private Label TaskFormCompletedLabel;
        private ComboBox TaskFormCompletedInput;
        private Panel SocietyMemberForm;
        private Label SocietyMemberFormRoleLabel;
        private ComboBox SocietyMemberFormRoleInput;
        private Label SocietyMemberFormRemoveButton;
        private Label SocietyMemberFormCancelButton;
        private Label SocietyMemberFormSaveButton;
        private Panel TeamMemberForm;
        private Label TeamMemberFormRoleLabel;
        private ComboBox TeamMemberFormRoleInput;
        private Label TeamMemberFormRemoveButton;
        private Label TeamMemberFormCancelButton;
        private Label TeamMemberFormSaveButton;
        private Panel AnnouncementForm;
        private Label AnnouncementFormTextLabel;
        private TextBox AnnouncementFormTextInput;
        private Label AnnouncementFormRemoveButton;
        private Label AnnouncementFormCancelButton;
        private Label AnnouncementFormSaveButton;
    }
}