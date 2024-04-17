using System.Text.RegularExpressions;
using Microsoft.IdentityModel.Tokens;
using SocietySyncLibrary;

namespace SocietySync;

public partial class MainForm : Form
{
    Dictionary<string, Control> screens = new Dictionary<string, Control>();
    //string activeScreen = "LogIn";
    string activeScreen = "Home";

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

        UserController.loggedInUser = user;
        SelectScreen("Home");
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

        UserController.loggedInUser = user;
        SelectScreen("Home");
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

        User user = UserController.loggedInUser!;
        user.PhoneNumber = SettingsPhoneNumberInput.Text.IsNullOrEmpty() ? user.PhoneNumber : SettingsPhoneNumberInput.Text;
        user.PasswordHash = SettingsPasswordInput.Text.IsNullOrEmpty() ? user.PasswordHash : SettingsPasswordInput.Text;

        if (!UserController.Update(user, !SettingsPasswordInput.Text.IsNullOrEmpty()))
        {
            SettingsError.Text = "Something went wrong";
            SettingsError.Visible = true;
            return;
        }

        UserController.loggedInUser = UserController.FindByEmail(user.Email!);
        SettingsError.Visible = false;
    }

    private void ToggleBackground(object sender, EventArgs e)
    {
        Control control = (Control)sender;
        control.BackgroundImage = control.BackgroundImage == null ? Properties.Resources.selection : null;
    }
}
