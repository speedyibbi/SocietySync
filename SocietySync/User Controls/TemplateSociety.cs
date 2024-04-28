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
    public partial class TemplateSociety : UserControl
    {
        private string _societyName = "";

        [Browsable(true)]
        public string SocietyName
        {
            get { return _societyName; }
            set
            {
                _societyName = value;
                if (TemplateSocietyLabel != null)
                {
                    TemplateSocietyLabel.Text = value;
                }
            }
        }

        public event EventHandler? TemplateSocietyClicked;
        public event EventHandler? TemplateSocietySettingsClicked;
        public bool hideSettings = false;

        public TemplateSociety()
        {
            InitializeComponent();

            Size = new Size(310, 241);

            Random random = new Random();
            TemplateSocietyPicture.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        }

        public void UpdateFunctions()
        {
            Click += (sender, e) => TemplateSocietyClicked?.Invoke(this, EventArgs.Empty);
            TemplateSocietyLabel.Click += (sender, e) => TemplateSocietyClicked?.Invoke(this, EventArgs.Empty);
            TemplateSocietyPicture.Click += (sender, e) => TemplateSocietyClicked?.Invoke(this, EventArgs.Empty);

            if (!hideSettings)
            {
                TemplateSocietySettingsButton.Visible = true;
                TemplateSocietySettingsButton.Click += (sender, e) => TemplateSocietySettingsClicked?.Invoke(this, EventArgs.Empty);
            } else
            {
                TemplateSocietySettingsButton.Visible = false;
            }
        }
    }
}
