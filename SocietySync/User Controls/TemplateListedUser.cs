using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocietySync.User_Controls
{
    public partial class TemplateListedUser : UserControl
    {
        private string _listedUserId = "";
        private string _listedUserName = "";
        private string _listedUserEmail = "";
        private string _listedUserPhoneNumber = "";
        private string _listedUserRole = "";
        private string _listedUserJoinedAt = "";

        [Browsable(true)]
        public string ListedUserId
        {
            get { return _listedUserId; }
            set
            {
                _listedUserId = value;
                if (TemplateListedUserId != null)
                {
                    TemplateListedUserId.Text = value;
                }
            }
        }

        [Browsable(true)]
        public string ListedUserName
        {
            get { return _listedUserName; }
            set
            {
                _listedUserName = value;
                if (TemplateListedUserName != null)
                {
                    TemplateListedUserName.Text = value;
                }
            }
        }

        [Browsable(true)]
        public string ListedUserEmail
        {
            get { return _listedUserEmail; }
            set
            {
                _listedUserEmail = value;
                if (TemplateListedUserEmail != null)
                {
                    TemplateListedUserEmail.Text = value;
                }
            }
        }

        [Browsable(true)]
        public string ListedUserPhoneNumber
        {
            get { return _listedUserPhoneNumber; }
            set
            {
                _listedUserPhoneNumber = value;
                if (TemplateListedUserPhoneNumber != null)
                {
                    TemplateListedUserPhoneNumber.Text = value;
                }
            }
        }

        [Browsable(true)]
        public string ListedUserRole
        {
            get { return _listedUserRole; }
            set
            {
                _listedUserRole = value;
                if (TemplateListedUserRole != null)
                {
                    TemplateListedUserRole.Text = value;
                }
            }
        }

        [Browsable(true)]
        public string ListedUserJoinedAt
        {
            get { return _listedUserJoinedAt; }
            set
            {
                _listedUserJoinedAt = value;
                if (TemplateListedUserJoinedAt != null)
                {
                    TemplateListedUserJoinedAt.Text = value;
                }
            }
        }

        public event EventHandler? TemplateListedUserClicked;

        public TemplateListedUser()
        {
            InitializeComponent();

            Size = new Size(1100, 44);
        }

        public void UpdateFunctions()
        {
            Click += (sender, e) => TemplateListedUserClicked?.Invoke(this, EventArgs.Empty);
            TemplateListedUserId.Click += (sender, e) => TemplateListedUserClicked?.Invoke(this, EventArgs.Empty);
            TemplateListedUserName.Click += (sender, e) => TemplateListedUserClicked?.Invoke(this, EventArgs.Empty);
            TemplateListedUserEmail.Click += (sender, e) => TemplateListedUserClicked?.Invoke(this, EventArgs.Empty);
            TemplateListedUserPhoneNumber.Click += (sender, e) => TemplateListedUserClicked?.Invoke(this, EventArgs.Empty);
            TemplateListedUserRole.Click += (sender, e) => TemplateListedUserClicked?.Invoke(this, EventArgs.Empty);
            TemplateListedUserJoinedAt.Click += (sender, e) => TemplateListedUserClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
