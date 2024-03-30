using SocietySyncLibrary;

namespace SocietySync
{
    public partial class MainForm : Form
    {
        User? loggedInUser;
        int activePanel = 0;

        public MainForm()
        {
            InitializeComponent();

            // temporary seed societies table
            //SocietyController.SeedSocieties();

            // temporary code prior to auth implementation
            IEnumerable<User> users = UserController.FindAll();
            if (users.Count() > 0)
            {
                loggedInUser = users.First();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SelectPanel(activePanel, true);

            /*
             * Navigation Button Click Assignments
             */
            HomeButtonBG.Click += (sender, e) => SelectPanel(0);
            HomeIcon.Click += (sender, e) => SelectPanel(0);
            HomeLabel.Click += (sender, e) => SelectPanel(0);

            SocietiesButtonBG.Click += (sender, e) => SelectPanel(1);
            SocietiesIcon.Click += (sender, e) => SelectPanel(1);
            SocietiesLabel.Click += (sender, e) => SelectPanel(1);

            SettingsButtonBG.Click += (sender, e) => SelectPanel(2);
            SettingsIcon.Click += (sender, e) => SelectPanel(2);
            SettingsLabel.Click += (sender, e) => SelectPanel(2);

            /*
             * Home Panel Setup
             */
            if (loggedInUser != null)
            {
                HomePanelLabel.Text = $"{HomePanelLabel.Text} {loggedInUser.FirstName}!";
            }
            else
            {
                HomePanelLabel.Text = "No user available";
            }

            /*
             * Society Panel Setup
             */
            IEnumerable<Society> societies = SocietyController.FindAll();
            int societiesCount = societies.Count();
            if (societiesCount > 0)
            {
                GroupBox[] societyGroup = new GroupBox[societiesCount];
                Label[] societyTitleLabel = new Label[societiesCount];
                Label[] societyDescriptionLabel = new Label[societiesCount];
                Panel[] societyGroupPanel = new Panel[societiesCount];

                for (int i = 0; i < societiesCount; i++)
                {
                    societyGroup[i] = new GroupBox();
                    societyGroup[i].Location = new Point(100, 225 + (i * 105));
                    societyGroup[i].Size = new Size(500, 100);
                    societyGroup[i].BackColor = Color.FromArgb(242, 242, 242);

                    societyTitleLabel[i] = new Label();
                    societyTitleLabel[i].Location = new Point(0, 0);
                    societyTitleLabel[i].Text = $"{societies.ElementAt(i).Name}";
                    societyTitleLabel[i].Font = new Font(societyTitleLabel[i].Font.FontFamily, 14, FontStyle.Bold);
                    societyTitleLabel[i].AutoSize = true;

                    societyDescriptionLabel[i] = new Label();
                    societyDescriptionLabel[i].Location = new Point(0, 35);
                    societyDescriptionLabel[i].Text = $"{societies.ElementAt(i).Description}";
                    societyDescriptionLabel[i].AutoSize = true;

                    societyGroupPanel[i] = new Panel();
                    societyGroupPanel[i].Location = new Point(0, 0);
                    societyGroupPanel[i].Size = new Size(500, 100);
                    societyGroupPanel[i].BackColor = Color.FromArgb(242, 242, 242);

                    societyGroup[i].Controls.Add(societyTitleLabel[i]);
                    societyGroup[i].Controls.Add(societyDescriptionLabel[i]);
                    societyGroup[i].Controls.Add(societyGroupPanel[i]);

                    SocietiesPanel.Controls.Add(societyGroup[i]);
                }
            }
            else
            {
                SocietiesPanelLabel.Text = "No societies available";
            }

            /*
             * Society Search
             */
            SocietySearchbarText.TextChanged += (sender, e) =>
            {
                string searchTerm = SocietySearchbarText.Text.ToLower();

                foreach (Control control in SocietiesPanel.Controls)
                {
                    if (control is GroupBox society)
                    {
                        string societyTitle = (society.Controls[0] as Label)?.Text.ToLower() ?? "";

                        if (societyTitle.Contains(searchTerm))
                        {
                            society.Visible = true;
                        }
                        else
                        {
                            society.Visible = false;
                        }
                    }
                }
            };

            /*
             * Settings Panel Setup
             */
            if (loggedInUser != null)
            {
                LoggedInUserNameEntryText.Text = $"{loggedInUser.FirstName} {loggedInUser.LastName}";
                LoggedInUserEmailEntryText.Text = loggedInUser.Email;
                LoggedInUserPhoneNumberEntryText.Text = loggedInUser.PhoneNumber;

                SaveSettingsButton.Click += (sender, e) =>
                {
                    bool rehash = LoggedInUserPasswordEntryText.Text.Length > 0;

                    loggedInUser.PhoneNumber = LoggedInUserPhoneNumberEntryText.Text ?? null;
                    loggedInUser.PasswordHash = rehash ? LoggedInUserPasswordEntryText.Text : loggedInUser.PasswordHash;

                    UserController.Update(loggedInUser, rehash);
                };
            }
        }

        private void SelectPanel(int idx, bool reset = false)
        {
            if (reset)
            {
                for (int i = 0; i < NavigationPanels.Controls.Count; i++)
                {
                    NavigationPanels.Controls[i].Visible = false;
                }

                NavigationPanels.Controls[idx].Visible = true;
            }
            else
            {
                NavigationPanels.Controls[activePanel].Visible = false;
                NavigationPanels.Controls[idx].Visible = true;

                activePanel = idx;
            }
        }

        
    }
}
