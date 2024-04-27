using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocietySync
{
    public partial class TemplateAnnouncement : UserControl
    {
        private string _announcementName = "";
        private string _announcementSociety = "";
        private string _announcementText = "";
        private string _announcementDate = "";

        [Browsable(true)]
        public string AnnouncementName
        {
            get { return _announcementName; }
            set
            {
                _announcementName = value;
                if (TemplateAnnouncementName != null)
                {
                    TemplateAnnouncementName.Text = value;
                    TemplateAnnouncementSociety.Location = new Point(TemplateAnnouncementName.Location.X + TemplateAnnouncementName.Size.Width, TemplateAnnouncementSociety.Location.Y);
                }
            }
        }

        [Browsable(true)]
        public string AnnouncementSociety
        {
            get { return _announcementSociety; }
            set
            {
                _announcementSociety = value;
                if (TemplateAnnouncementSociety != null)
                {
                    TemplateAnnouncementSociety.Text = $"| {value}";
                }
            }
        }

        [Browsable(true)]
        public string AnnouncementText
        {
            get { return _announcementText; }
            set
            {
                _announcementText = value;
                if (TemplateAnnouncementText != null)
                {
                    TemplateAnnouncementText.Text = $"\"{value}\"";
                    TemplateAnnouncementText.Size = new Size(Size.Width - 50, 51);
                }
            }
        }

        [Browsable(true)]
        public string AnnouncementDate
        {
            get { return _announcementDate; }
            set
            {
                _announcementDate = value;
                if (TemplateAnnouncementDate != null)
                {
                    TemplateAnnouncementDate.Text = $"- {value}";
                }
            }
        }

        public TemplateAnnouncement()
        {
            InitializeComponent();

            TemplateAnnouncementText.Size = new Size(635, 51);
        }
    }
}
