using System.Net.Sockets;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.IdentityModel.Tokens;
using SocietySync.User_Controls;
using SocietySyncLibrary;

namespace SocietySync;

public partial class MainForm : Form
{
    Dictionary<string, Control> screens = new Dictionary<string, Control>();
    string activeScreen = "LogIn";
    //string activeScreen = "Home";

    User? loggedInUser = null;
    Society? selectedSociety = null;
    bool? selectedSocietyJoined = null;
    dynamic? selectedEvent = null;

    public MainForm()
    {
        InitializeComponent();

        //SocietyController.SeedSocieties();
    }

    private void MainForm_Loaded(object sender, EventArgs e)
    {
        foreach (Control control in Controls)
        {
            control.Visible = false;
            screens.Add(control.Name, control);
        }
        screens[activeScreen].Visible = true;
    }

    private void ApplicationPostLogIn()
    {
        if (loggedInUser == null)
        {
            SelectScreen("LogIn");
            return;
        }

        PopulateHomeAnnouncements();
        PopulateSocieties();
        PopulateEvents();

        SettingsNameLabel.Text = $"{loggedInUser.FirstName} {loggedInUser.LastName} (unchangeable)";
        SettingsEmailLabel.Text = $"{loggedInUser.Email} (unchangeable)";

        SelectScreen("Home");
    }

    private void SelectScreen(string screen)
    {
        screens[activeScreen].Visible = false;
        screens[screen].Visible = true;
        activeScreen = screen;
    }

    private void SelectScreen(object sender, EventArgs e)
    {
        string screen = GetTagValue((Control)sender, "screen");

        screens[activeScreen].Visible = false;
        screens[screen].Visible = true;
        activeScreen = screen;
    }

    private string GetTagValue(Control control, string tag)
    {
        try
        {
            string[] tags = control.Tag != null ? control.Tag.ToString()!.Split(' ', StringSplitOptions.RemoveEmptyEntries) : new string[0];

            return tags.Contains(tag) ? tags[Array.IndexOf(tags, tag) + 1] : string.Empty;
        }
        catch
        {
            return string.Empty;
        }
    }

    private string ValidateInput(string input, string name = "", bool emptyCheck = true, bool numericCheck = false, bool emailCheck = false)
    {
        if (emptyCheck && input.IsNullOrEmpty()) return $"{name} must not be empty";
        if (numericCheck && !Regex.IsMatch(input, @"^\d*$")) return $"{name} must only contain numbers";
        if (emailCheck && !Regex.IsMatch(input, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")) return $"{name} must be a valid email address";

        return string.Empty;
    }

    private void SignUpUser(object sender, EventArgs e)
    {
        List<string> errors = new List<string>
        {
            ValidateInput(SignUpFirstNameInput.Text, "First name", true, false, false),
            ValidateInput(SignUpLastNameInput.Text, "Last name", true, false, false),
            ValidateInput(SignUpEmailInput.Text, "Email", true, false, true),
            ValidateInput(SignUpPasswordInput.Text, "Password", true, false, false),
            ValidateInput(SignUpPhoneNumberInput.Text, "Phone number", false, true, false),
        };

        foreach (string error in errors)
        {
            if (error.IsNullOrEmpty()) continue;

            SignUpError.Text = error;
            SignUpError.Visible = true;
            return;
        }

        User user = new User();
        user.Email = SignUpEmailInput.Text;
        user.PasswordHash = SignUpPasswordInput.Text;
        user.FirstName = SignUpFirstNameInput.Text;
        user.LastName = SignUpLastNameInput.Text;
        user.PhoneNumber = SignUpPhoneNumberInput.Text.IsNullOrEmpty() ? null : SignUpPhoneNumberInput.Text;

        if (!UserController.Save(user))
        {
            SignUpError.Text = "Something went wrong";
            SignUpError.Visible = true;
            return;
        }

        loggedInUser = user;
        ApplicationPostLogIn();
    }

    private void LogInUser(object sender, EventArgs e)
    {
        List<string> errors = new List<string>
        {
            ValidateInput(LogInEmailInput.Text, "Email", true, false, true),
            ValidateInput(LogInPasswordInput.Text, "Password", true, false, false),
        };

        foreach (string error in errors)
        {
            if (error.IsNullOrEmpty()) continue;

            LogInError.Text = error;
            LogInError.Visible = true;
            return;
        }

        User? user = UserController.FindByEmail(LogInEmailInput.Text);

        if (user == null || !UserController.VerifyPassword(LogInPasswordInput.Text, user.PasswordHash!))
        {
            LogInError.Text = "Invalid credentials";
            LogInError.Visible = true;
            return;
        }

        loggedInUser = user;
        ApplicationPostLogIn();
    }

    private void SaveUser(object sender, EventArgs e)
    {
        if (SettingsPhoneNumberInput.Text.IsNullOrEmpty() && SettingsPasswordInput.Text.IsNullOrEmpty())
        {
            SettingsError.Text = "No data entered";
            SettingsError.Visible = true;
            return;
        }

        List<string> errors = new List<string>
        {
            ValidateInput(SettingsPhoneNumberInput.Text, "Phone number", false, true, false),
        };

        foreach (string error in errors)
        {
            if (error.IsNullOrEmpty()) continue;

            SettingsError.Text = error;
            SettingsError.Visible = true;
            return;
        }

        User user = loggedInUser!;
        user.PhoneNumber = SettingsPhoneNumberInput.Text.IsNullOrEmpty() ? user.PhoneNumber : SettingsPhoneNumberInput.Text;
        user.PasswordHash = SettingsPasswordInput.Text.IsNullOrEmpty() ? user.PasswordHash : SettingsPasswordInput.Text;

        if (!UserController.Update(user, !SettingsPasswordInput.Text.IsNullOrEmpty()))
        {
            SettingsError.Text = "Something went wrong";
            SettingsError.Visible = true;
            return;
        }

        loggedInUser = UserController.FindByEmail(user.Email!);
        SettingsError.Visible = false;
    }

    private void ToggleBackground(object sender, EventArgs e)
    {
        Control control = (Control)sender;
        control.BackgroundImage = control.BackgroundImage == null ? Properties.Resources.selection : null;
    }

    private string TruncateString(string str, int max)
    {
        if (str.Length > max) return str.Substring(0, max - 3) + "...";
        else return str;
    }

    // Form Events

    private void OpenNewSocietyForm(object sender, EventArgs e)
    {
        CRUDForm newSocietyForm = new CRUDForm();
        newSocietyForm.SocietyForm.Tag = "";

        List<OptionItem> dataSource = new List<OptionItem>
            {
                new OptionItem($"{loggedInUser!.FirstName} {loggedInUser.LastName}", loggedInUser.UserID)
            };

        newSocietyForm.SocietyFormPresidentInput.DataSource = dataSource;
        newSocietyForm.SocietyFormPresidentInput.SelectedIndex = 0;
        newSocietyForm.SocietyFormRemoveButton.Enabled = false;

        newSocietyForm.FormClosed += (sender, e) =>
        {
            PopulateSocieties();
        };

        newSocietyForm.activeScreen = "SocietyForm";
        newSocietyForm.ShowDialog();
    }

    private void OpenSocietyApplicationForm(object sender, EventArgs e)
    {
        CRUDForm societyApplicationForm = new CRUDForm();
        societyApplicationForm.SocietyApplication.Tag = $"{selectedSociety!.SocietyID} {loggedInUser?.UserID}";

        societyApplicationForm.SocietyApplicationSocietyInput.Text = selectedSociety.Name;

        societyApplicationForm.FormClosed += (sender, e) =>
        {
            PopulateSocieties();
            SelectScreen("Societies");
        };

        societyApplicationForm.activeScreen = "SocietyApplication";
        societyApplicationForm.ShowDialog();
    }

    private void OpenNewEventForm(object sender, EventArgs e)
    {
        CRUDForm newEventForm = new CRUDForm();
        newEventForm.EventForm.Tag = $"{selectedSociety!.SocietyID} {loggedInUser!.UserID}";

        newEventForm.EventFormRemoveButton.Enabled = false;

        newEventForm.FormClosed += (sender, e) =>
        {
            PopulateEvents();
        };

        newEventForm.activeScreen = "EventForm";
        newEventForm.ShowDialog();
    }

    private void OpenNewAnnouncementForm(object sender, EventArgs e)
    {
        CRUDForm newAnnouncementForm = new CRUDForm();
        newAnnouncementForm.AnnouncementForm.Tag = $"{loggedInUser!.UserID} {selectedSociety!.SocietyID}";

        newAnnouncementForm.AnnouncementFormRemoveButton.Enabled = false;

        newAnnouncementForm.FormClosed += (sender, e) =>
        {
            PopulateHomeAnnouncements();
            PopulateSelectedSociety();
        };

        newAnnouncementForm.activeScreen = "AnnouncementForm";
        newAnnouncementForm.ShowDialog();
    }

    // Populants

    private void PopulateHomeAnnouncements()
    {
        foreach (Control control in HomePanel.Controls.OfType<TemplateAnnouncement>())
        {
            HomePanel.Controls.Remove(control);
        }

        IEnumerable<dynamic> announcements = GeneralController.GetAnnouncementsForUser(loggedInUser!.UserID);

        if (announcements.IsNullOrEmpty())
        {
            HomeAnnouncementsLabel.Visible = false;
            HomeNoAnnouncementsLabel.Visible = true;
            return;
        } else
        {
            HomeAnnouncementsLabel.Visible = true;
            HomeNoAnnouncementsLabel.Visible = false;
        }

        int idx = 0;
        foreach (dynamic announcement in announcements)
        {
            TemplateAnnouncement templateAnnouncement = new TemplateAnnouncement();
            templateAnnouncement.AnnouncementName = $"{announcement.first_name} {announcement.last_name}";
            templateAnnouncement.AnnouncementSociety = announcement.name;
            templateAnnouncement.AnnouncementText = announcement.text;
            templateAnnouncement.AnnouncementDate = announcement.created_at.ToString("D");
            templateAnnouncement.Location = new Point(63, 246 + (idx * 175));
            HomePanel.Controls.Add(templateAnnouncement);
            ++idx;
        }
    }

    private void PopulateSocieties()
    {
        foreach (Control control in SocietiesPanel.Controls.OfType<TemplateSociety>())
        {
            SocietiesPanel.Controls.Remove(control);
        }

        IEnumerable<Society> societies = GeneralController.GetJoinedSocietiesForUser(loggedInUser!.UserID);

        Point discoverLocation = new Point(85, 271);

        if (!societies.IsNullOrEmpty())
        {
            int idx = 0;
            foreach (Society society in societies)
            {
                TemplateSociety templateSociety = new TemplateSociety();
                templateSociety.SocietyName = society.Name == null ? string.Empty : society.Name;

                templateSociety.TemplateSocietyClicked += (sender, e) =>
                {
                    selectedSociety = society;
                    selectedSocietyJoined = true;
                    PopulateSelectedSociety();
                    SelectScreen("Society");
                };

                if (society.President == loggedInUser.UserID)
                {
                    templateSociety.TemplateSocietySettingsClicked += (sender, e) =>
                    {
                        IEnumerable<dynamic> members = GeneralController.GetMembersBySocietyId(society.SocietyID);
                        
                        CRUDForm updateSocietyForm = new CRUDForm();
                        updateSocietyForm.SocietyForm.Tag = society.SocietyID;
                        
                        List<OptionItem> dataSource = new List<OptionItem>();
                        int idx = 0;
                        int count = 0;
                        foreach (dynamic member in members)
                        {
                            if (member.user_id.Equals(society.President)) idx = count;
                            dataSource.Add(new OptionItem($"{member.first_name} {member.last_name}", member.user_id));
                            count++;
                        }

                        updateSocietyForm.SocietyFormNameInput.Text = society.Name;
                        updateSocietyForm.SocietyFormDescriptionInput.Text = society.Description;
                        updateSocietyForm.SocietyFormPresidentInput.DataSource = dataSource;
                        updateSocietyForm.SocietyFormPresidentInput.SelectedIndex = idx;

                        updateSocietyForm.FormClosed += (sender, e) =>
                        {
                            PopulateSocieties();
                        };

                        updateSocietyForm.activeScreen = "SocietyForm";
                        updateSocietyForm.ShowDialog();
                    };
                } else
                {
                    templateSociety.hideSettings = true;
                }

                templateSociety.UpdateFunctions();
                templateSociety.Location = new Point(idx % 2 == 0 ? 63 : 373, 246 + ((idx / 2) * 241));
                discoverLocation = new Point(85, 537 + ((idx / 2) * 241));
                SocietiesPanel.Controls.Add(templateSociety);
                ++idx;
            }

            SocietiesJoinedLabel.Visible = true;
            SocietiesNoJoinedLabel.Visible = false;
        } else
        {
            SocietiesJoinedLabel.Visible = false;
            SocietiesNoJoinedLabel.Visible = true;
        }

        SocietiesDiscoverLabel.Location = discoverLocation;
        SocietiesNoDiscoverLabel.Location = discoverLocation;

        societies = GeneralController.GetDiscoverableSocietiesForUser(loggedInUser!.UserID);

        if (!societies.IsNullOrEmpty())
        {
            int idx = 0;
            foreach (Society society in societies)
            {
                TemplateSociety templateSociety = new TemplateSociety();
                templateSociety.SocietyName = society.Name == null ? string.Empty : society.Name;

                templateSociety.TemplateSocietyClicked += (sender, e) =>
                {
                    selectedSociety = society;
                    selectedSocietyJoined = false;
                    PopulateSelectedSociety();
                    SelectScreen("Society");
                };

                templateSociety.hideSettings = true;
                templateSociety.UpdateFunctions();
                templateSociety.Location = new Point(idx % 2 == 0 ? 63 : 373, discoverLocation.Y + 86 + ((idx / 2) * 241));
                SocietiesPanel.Controls.Add(templateSociety);
                ++idx;
            }

            SocietiesDiscoverLabel.Visible = true;
            SocietiesNoDiscoverLabel.Visible = false;
        }
        else
        {
            SocietiesDiscoverLabel.Visible = false;
            SocietiesNoDiscoverLabel.Visible = true;
        }
    }

    private void PopulateEvents()
    {
        foreach (Control control in EventsPanel.Controls.OfType<TemplateEvent>())
        {
            EventsPanel.Controls.Remove(control);
        }

        IEnumerable<dynamic> events = GeneralController.GetParticipatingEventsForUser(loggedInUser!.UserID);

        Point otherLocation = new Point(85, 271);

        if (!events.IsNullOrEmpty())
        {
            int idx = 0;
            foreach (dynamic ev in events)
            {
                TemplateEvent templateEvent = new TemplateEvent();
                templateEvent.TemplateEventClicked += (sender, e) =>
                {
                    selectedEvent = e;
                    //selectedEventJoined = true;
                    //PopulateSelectedEvent();
                    SelectScreen("Event");
                };

                templateEvent.EventName = ev.title ?? string.Empty;
                templateEvent.EventText = $"\"{ev.description}\"" ?? string.Empty;
                templateEvent.EventSociety = $"- {ev.society_name}" ?? string.Empty;

                if (ev.created_by == loggedInUser.UserID)
                {
                    templateEvent.TemplateEventSettingsClicked += (sender, e) =>
                    {
                        Event ev_ = EventController.Find(ev.event_id)!;

                        //CRUDForm updateSocietyForm = new CRUDForm();
                        //updateSocietyForm.SocietyForm.Tag = society.SocietyID;

                        //List<OptionItem> dataSource = new List<OptionItem>();
                        //int idx = 0;
                        //int count = 0;
                        //foreach (dynamic member in members)
                        //{
                        //    if (member.user_id.Equals(society.President)) idx = count;
                        //    dataSource.Add(new OptionItem($"{member.first_name} {member.last_name}", member.user_id));
                        //    count++;
                        //}

                        //updateSocietyForm.SocietyFormNameInput.Text = society.Name;
                        //updateSocietyForm.SocietyFormDescriptionInput.Text = society.Description;
                        //updateSocietyForm.SocietyFormPresidentInput.DataSource = dataSource;
                        //updateSocietyForm.SocietyFormPresidentInput.SelectedIndex = idx;

                        //updateSocietyForm.FormClosed += (sender, e) =>
                        //{
                        //    PopulateSocieties();
                        //};

                        //updateSocietyForm.activeScreen = "SocietyForm";
                        //updateSocietyForm.ShowDialog();
                    };
                } else
                {
                    templateEvent.hideSettings = true;
                }

                templateEvent.UpdateFunctions();
                templateEvent.Location = new Point(63, 246 + (idx * 181));
                otherLocation = new Point(85, 477 + (idx * 181));
                EventsPanel.Controls.Add(templateEvent);
                ++idx;
            }

            EventsParticipating.Visible = true;
            EventsNoParticipating.Visible = false;
        }
        else
        {
            EventsParticipating.Visible = false;
            EventsNoParticipating.Visible = true;
        }

        EventsOther.Location = otherLocation;
        EventsNoOther.Location = otherLocation;

        events = GeneralController.GetOtherEventsForUser(loggedInUser!.UserID);

        if (!events.IsNullOrEmpty())
        {
            int idx = 0;
            foreach (dynamic ev in events)
            {
                TemplateEvent templateEvent = new TemplateEvent();
                templateEvent.EventName = ev.title ?? string.Empty;
                templateEvent.EventText = $"\"{ev.description}\"" ?? string.Empty;
                templateEvent.EventSociety = $"- {ev.society_name}" ?? string.Empty;
                //todo
                templateEvent.UpdateFunctions();
                templateEvent.Location = new Point(63, otherLocation.Y + 86 + (idx * 181));
                EventsPanel.Controls.Add(templateEvent);
                ++idx;
            }

            EventsOther.Visible = true;
            EventsNoOther.Visible = false;
        }
        else
        {
            EventsOther.Visible = false;
            EventsNoOther.Visible = true;
        }
    }

    private void PopulateSelectedSociety()
    {
        if (selectedSociety == null) return;

        SocietyName.Text = $"| {selectedSociety.Name}";
        SocietyDescriptionText.Text = $"\"{selectedSociety.Description}\"" ;

        foreach (Control control in SocietyPanel.Controls.OfType<TemplateAnnouncement>())
        {
            SocietyPanel.Controls.Remove(control);
        }

        UserRole? role = GeneralController.GetUserRoleInSociety(loggedInUser!.UserID, selectedSociety.SocietyID);

        if (selectedSocietyJoined == null || selectedSocietyJoined == false || role == null || role.Name!.Equals("Pending"))
        {
            SocietyNewAnnouncementButton.Visible = false;
            SocietyUserListButton.Enabled = false;
            SocietyUserListButton.BackColor = Color.White;

            if (role == null)
            {
                SocietyApplicationButton.Enabled = true;
                SocietyApplicationButton.BackColor = Color.Transparent;
            } else
            {
                SocietyApplicationButton.Enabled = false;
                SocietyApplicationButton.BackColor = Color.White;
            }
        } else
        {
            SocietyNewAnnouncementButton.Visible = true;
            SocietyUserListButton.Enabled = true;
            SocietyUserListButton.BackColor = Color.Transparent;
            SocietyApplicationButton.Enabled = false;
            SocietyApplicationButton.BackColor = Color.White;

            PopulateSelectedSocietyUserList();
        }

        IEnumerable<dynamic> announcements = GeneralController.GetAnnouncementsBySocietyId(selectedSociety.SocietyID);

        if (announcements.IsNullOrEmpty())
        {
            SocietyAnnouncementsLabel.Visible = false;
            SocietyNoAnnouncementsLabel.Visible = true;
            SocietyNewAnnouncementButton.Location = new Point(SocietyNoAnnouncementsLabel.Location.X + SocietyNoAnnouncementsLabel.Size.Width + 25, SocietyNoAnnouncementsLabel.Location.Y + 8);
        } else
        {
            SocietyAnnouncementsLabel.Visible = true;
            SocietyNoAnnouncementsLabel.Visible = false;
        }

        int idx = 0;
        foreach (dynamic announcement in announcements)
        {
            TemplateAnnouncement templateAnnouncement = new TemplateAnnouncement();
            templateAnnouncement.AnnouncementName = $"{announcement.first_name} {announcement.last_name}";
            templateAnnouncement.AnnouncementSociety = string.Empty;
            templateAnnouncement.AnnouncementText = announcement.text;
            templateAnnouncement.AnnouncementDate = announcement.created_at.ToString("D");
            templateAnnouncement.Location = new Point(63, 457 + (idx * 175));
            SocietyPanel.Controls.Add(templateAnnouncement);
            ++idx;
        }

        User? president = GeneralController.GetPresidentBySocietyId(selectedSociety.SocietyID);

        if (president != null)
        {
            SocietyPresdientText.Text = $"{president.FirstName} {president.LastName}";

            if (president.UserID != loggedInUser?.UserID)
            {
                SocietyNewEventButton.Visible = false;
            } else
            {
                SocietyNewEventButton.Visible = true;
            }
        } else
        {
            SocietyNewEventButton.Visible = false;
        }
    }

    private void PopulateSelectedSocietyUserList()
    {
        if (selectedSociety == null) return;

        SocietyUserListSocietyName.Text = $"| {selectedSociety.Name}";

        foreach (Control control in SocietyUserListPanel.Controls.OfType<TemplateListedUser>())
        {
            SocietyUserListPanel.Controls.Remove(control);
        }

        UserRole role = GeneralController.GetUserRoleInSociety(loggedInUser!.UserID, selectedSociety.SocietyID)!;

        IEnumerable<dynamic> members = GeneralController.GetMembersBySocietyId(selectedSociety.SocietyID);

        int idx = 0;
        foreach (dynamic member in members)
        {
            TemplateListedUser templateListedUser = new TemplateListedUser();
            templateListedUser.ListedUserId = member.membership_id.ToString().PadLeft(6, '0');
            templateListedUser.ListedUserName = TruncateString($"{member.first_name} {member.last_name}", 15);
            templateListedUser.ListedUserEmail = TruncateString(member.email!, 15);
            templateListedUser.ListedUserPhoneNumber = TruncateString(member.PhoneNumber ?? "-", 15);
            templateListedUser.ListedUserRole = member.role_name;
            templateListedUser.ListedUserJoinedAt = member.joined_at.ToString("D");

            if (role.Name!.Equals("President") || role.Name!.Equals("Executive"))
            {
                if (member.role_name.Equals("President"))
                {
                    templateListedUser.UpdateFunctions();
                    templateListedUser.Location = new Point(85, 239 + (idx * 64));
                    SocietyUserListPanel.Controls.Add(templateListedUser);
                    ++idx;
                    continue;
                }

                if (member.role_name.Equals("Executive"))
                {
                    if (role.Name!.Equals("Executive"))
                    {
                        templateListedUser.UpdateFunctions();
                        templateListedUser.Location = new Point(85, 239 + (idx * 64));
                        SocietyUserListPanel.Controls.Add(templateListedUser);
                        ++idx;
                        continue;
                    }
                }

                templateListedUser.TemplateListedUserClicked += (sender, e) =>
                {
                    IEnumerable<UserRole> roles = UserRoleController.FindAll().Where(role => !role.Name!.Equals("Head") && !role.Name!.Equals("President"));

                    CRUDForm updateListedUserForm = new CRUDForm();
                    updateListedUserForm.SocietyMemberForm.Tag = member.membership_id;

                    List<OptionItem> dataSource = new List<OptionItem>();
                    int idx_i = 0;
                    int count = 0;
                    foreach (UserRole role in roles)
                    {
                        if (role.Name!.Equals(member.role_name)) idx_i = count;
                        dataSource.Add(new OptionItem(role.Name, role.RoleID));
                        count++;
                    }

                    updateListedUserForm.SocietyMemberFormRoleInput.DataSource = dataSource;
                    updateListedUserForm.SocietyMemberFormRoleInput.SelectedIndex = idx_i;

                    updateListedUserForm.FormClosed += (sender, e) =>
                    {
                        PopulateSelectedSociety();
                        SelectScreen("Society");
                    };

                    updateListedUserForm.activeScreen = "SocietyMemberForm";
                    updateListedUserForm.ShowDialog();
                };
            }

            templateListedUser.UpdateFunctions();
            templateListedUser.Location = new Point(85, 239 + (idx * 64));
            SocietyUserListPanel.Controls.Add(templateListedUser);
            ++idx;
        }
    }
}
