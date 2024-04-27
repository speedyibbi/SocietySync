using System.Net.Sockets;
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

        AdminChecks();

        PopulateHomeAnnouncements();
        PopulateSocieties();
        PopulateEvents();

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

    private void AdminChecks()
    {
        if (!loggedInUser!.Admin)
        {
            SocietiesNewSocietyButton.BackColor = Color.White;
            SocietiesNewSocietyButton.Enabled = false;
            
            return;
        }

        SocietiesNewSocietyButton.Click += (sender, e) =>
        {
            CRUDForm newSocietyForm = new CRUDForm();
        };
    }

    // Populants

    private void PopulateHomeAnnouncements()
    {
        IEnumerable<dynamic> announcements = GeneralController.GetAnnouncementsForUser(loggedInUser!.UserID);

        if (announcements.IsNullOrEmpty())
        {
            HomeAnnouncementsLabel.Visible = false;
            HomeNoAnnouncementsLabel.Visible = true;
            return;
        }

        int idx = 0;
        foreach (dynamic announcement in announcements)
        {
            TemplateAnnouncement templateAnnouncement = new TemplateAnnouncement();
            templateAnnouncement.AnnouncementName = $"{announcement.first_name} {announcement.last_name}";
            templateAnnouncement.AnnouncementSociety = announcement.name;
            templateAnnouncement.AnnouncementText = announcement.text;
            templateAnnouncement.AnnouncementDate = announcement.created_at;
            templateAnnouncement.Location = new Point(63, 246 + (idx * 175));
            HomePanel.Controls.Add(templateAnnouncement);
            ++idx;
        }
    }

    private void PopulateSocieties()
    {
        IEnumerable<Society> societies = GeneralController.GetJoinedSocietiesForUser(loggedInUser!.UserID);

        Point discoverLocation = new Point(85, 271);

        if (!societies.IsNullOrEmpty())
        {
            int idx = 0;
            foreach (Society society in societies)
            {
                TemplateSociety templateSociety = new TemplateSociety();
                templateSociety.SocietyName = society.Name == null ? string.Empty : society.Name;
                // todo: click event for settings
                templateSociety.Location = new Point(idx % 2 == 0 ? 63 : 373, 246 + ((idx / 2) * 241));
                discoverLocation = new Point(85, 537 + ((idx / 2) * 241));
                SocietiesPanel.Controls.Add(templateSociety);
                ++idx;
            }
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
                // todo: click event for settings
                templateSociety.Location = new Point(idx % 2 == 0 ? 63 : 373, discoverLocation.Y + 86 + ((idx / 2) * 241));
                SocietiesPanel.Controls.Add(templateSociety);
                ++idx;
            }
        }
        else
        {
            SocietiesDiscoverLabel.Visible = false;
            SocietiesNoDiscoverLabel.Visible = true;
        }
    }

    private void PopulateEvents()
    {
        IEnumerable<dynamic> events = GeneralController.GetParticipatingEventsForUser(loggedInUser!.UserID);

        Point otherLocation = new Point(85, 271);

        if (!events.IsNullOrEmpty())
        {
            int idx = 0;
            foreach (dynamic e in events)
            {
                TemplateEvent templateEvent = new TemplateEvent();
                templateEvent.EventName = e.Title == null ? string.Empty : e.Title;
                templateEvent.EventText = e.Description == null ? string.Empty : e.Description;
                templateEvent.EventSociety = e.SocietyName == null ? string.Empty : e.SocietyName;
                // todo: click event for settings
                templateEvent.Location = new Point(63, 246 + (idx * 181));
                otherLocation = new Point(85, 477 + (idx * 181));
                EventsPanel.Controls.Add(templateEvent);
                ++idx;
            }
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
            foreach (dynamic e in events)
            {
                TemplateEvent templateEvent = new TemplateEvent();
                templateEvent.EventName = e.Title == null ? string.Empty : e.Title;
                templateEvent.EventText = e.Description == null ? string.Empty : e.Description;
                templateEvent.EventSociety = e.SocietyName == null ? string.Empty : e.SocietyName;
                // todo: click event for settings
                templateEvent.Location = new Point(63, otherLocation.Y + 86 + (idx * 181));
                EventsPanel.Controls.Add(templateEvent);
                ++idx;
            }
        }
        else
        {
            EventsOther.Visible = false;
            EventsNoOther.Visible = true;
        }
    }
}
