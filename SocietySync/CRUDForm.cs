using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using SocietySyncLibrary;

namespace SocietySync;

public partial class CRUDForm : Form
{
    Dictionary<string, Control> screens = new Dictionary<string, Control>();
    public string activeScreen = "SocietyForm";

    public CRUDForm()
    {
        InitializeComponent();
    }

    private void CRUDForm_Loaded(object sender, EventArgs e)
    {
        foreach (Control control in Controls)
        {
            control.Visible = false;
            screens.Add(control.Name, control);
        }
        screens[activeScreen].Visible = true;
    }

    public void SelectScreen(string screen)
    {
        screens[activeScreen].Visible = false;
        screens[screen].Visible = true;
        activeScreen = screen;
    }

    private void CloseForm(object sender, EventArgs e)
    {
        Close();
    }

    private void SaveSociety(object sender, EventArgs e)
    {
        string? societyId = SocietyForm.Tag.ToString();

        if (societyId.IsNullOrEmpty())
        {
            Society society = new Society();
            society.Name = SocietyFormNameInput.Text;
            society.Description = SocietyFormDescriptionInput.Text;
            society.President = ((OptionItem)SocietyFormPresidentInput.Items[SocietyFormPresidentInput.SelectedIndex]).Value;

            if (SocietyController.Save(society)) Close();
        } else
        {
            Society? society = SocietyController.Find(int.Parse(societyId!));
            if (society == null) return;

            society.Name = SocietyFormNameInput.Text;
            society.Description = SocietyFormDescriptionInput.Text;
            society.President = ((OptionItem)SocietyFormPresidentInput.Items[SocietyFormPresidentInput.SelectedIndex]).Value;

            if (SocietyController.Update(society)) Close();
        }
    }

    private void RemoveSociety(object sender, EventArgs e)
    {
        string? societyId = SocietyForm.Tag.ToString();

        if (!societyId.IsNullOrEmpty())
        {
            if (SocietyController.Delete(int.Parse(societyId!))) Close();
        }
    }

    private void ApplyToSociety(object sender, EventArgs e)
    {
        string[]? ids = SocietyApplication.Tag.ToString()!.Split(' ');

        if (ids?.Length > 0)
        {
            if (SocietyController.AddUserToSociety(int.Parse(ids[0]), int.Parse(ids[1]))) Close();
        }
    }

    private void SaveAnnouncement(object sender, EventArgs e)
    {
        string[]? ids = AnnouncementForm.Tag.ToString()!.Split(' ');

        if (ids?.Length == 2)
        {
            Announcement announcement = new Announcement();
            announcement.Text = AnnouncementFormTextInput.Text;
            announcement.UserID = int.Parse(ids[0]);
            announcement.SocietyID = int.Parse(ids[1]);

            if (AnnouncementController.Save(announcement)) Close();
        } else if (ids?.Length == 3)
        {
            Announcement announcement = new Announcement();
            announcement.Text = AnnouncementFormTextInput.Text;
            announcement.UserID = int.Parse(ids[0]);
            announcement.SocietyID = int.Parse(ids[1]);
            announcement.EventID = int.Parse(ids[2]);

            if (AnnouncementController.Save(announcement)) Close();
        }
    }

    private void RemoveAnnouncement(object sender, EventArgs e)
    {
        string? announcementId = AnnouncementForm.Tag.ToString();

        if (!announcementId.IsNullOrEmpty())
        {
            if (AnnouncementController.Delete(int.Parse(announcementId!))) Close();
        }
    }

    private void SaveSocietyMember(object sender, EventArgs e)
    {
        string? membershipId = SocietyMemberForm.Tag.ToString();

        if (!membershipId.IsNullOrEmpty())
        {
            Membership? membership = MembershipController.Find(int.Parse(membershipId!));

            if (membership == null) return;

            membership.RoleID = ((OptionItem)SocietyMemberFormRoleInput.Items[SocietyMemberFormRoleInput.SelectedIndex]).Value;

            if (MembershipController.Update(membership)) Close();
        }
    }

    private void RemoveSocietyMember(object sender, EventArgs e)
    {
        string? membershipId = SocietyMemberForm.Tag.ToString();

        if (!membershipId.IsNullOrEmpty())
        {
            if (MembershipController.Delete(int.Parse(membershipId!))) Close();
        }
    }

    private void SaveEvent(object sender, EventArgs e)
    {
        string[]? ids = EventForm.Tag.ToString()!.Split(' ');

        if (ids.Length == 2)
        {
            Event ev = new Event();
            ev.SocietyID = int.Parse(ids[0]);
            ev.Title = EventFormTitleInput.Text;
            ev.Description = EventFormDescriptionInput.Text;
            ev.StartDate = EventFormStartDateInput.Value;
            ev.EndDate = EventFormEndDateInput.Value;
            ev.Location = EventFormLocationInput.Text;
            ev.CreatedBy = int.Parse(ids[1]);

            if (ev.Title.IsNullOrEmpty() || ev.Location.IsNullOrEmpty() || (ev.StartDate > ev.EndDate)) return;
            
            if (EventController.Save(ev)) Close();
        }
        else if (ids.Length == 3)
        {
            Event? ev = EventController.Find(int.Parse(ids[2]));
            if (ev == null) return;

            ev.Title = EventFormTitleInput.Text;
            ev.Description = EventFormDescriptionInput.Text;
            ev.StartDate = EventFormStartDateInput.Value;
            ev.EndDate = EventFormEndDateInput.Value;
            ev.Location = EventFormLocationInput.Text;

            if (ev.Title.IsNullOrEmpty() || ev.Location.IsNullOrEmpty() || (ev.StartDate > ev.EndDate)) return;

            if (EventController.Update(ev)) Close();
        }
    }

    private void RemoveEvent(object sender, EventArgs e)
    {
        string[]? ids = EventForm.Tag.ToString()!.Split(' ');

        if (!ids.IsNullOrEmpty())
        {
            if (SocietyController.Delete(int.Parse(ids[0]))) Close();
        }
    }
}
