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
    public partial class TemplateEvent : UserControl
    {
        private string _eventName = "";
        private string _eventText = "";
        private string _eventSociety = "";

        [Browsable(true)]
        public string EventName
        {
            get { return _eventName; }
            set
            {
                _eventName = value;
                if (TemplateEventName != null)
                {
                    TemplateEventName.Text = value;
                }
            }
        }

        [Browsable(true)]
        public string EventText
        {
            get { return _eventText; }
            set
            {
                _eventText = value;
                if (TemplateEventText != null)
                {
                    TemplateEventText.Text = value;
                }
            }
        }

        [Browsable(true)]
        public string EventSociety
        {
            get { return _eventSociety; }
            set
            {
                _eventSociety = value;
                if (TemplateEventSociety != null)
                {
                    TemplateEventSociety.Text = value;
                }
            }
        }

        public event EventHandler? TemplateEventClicked;
        public event EventHandler? TemplateEventSettingsClicked;
        public bool hideSettings = false;

        public TemplateEvent()
        {
            InitializeComponent();

            Size = new Size(685, 181);

            Click += (sender, e) => TemplateEventClicked?.Invoke(this, EventArgs.Empty);
            TemplateEventName.Click += (sender, e) => TemplateEventClicked?.Invoke(this, EventArgs.Empty);
            TemplateEventText.Click += (sender, e) => TemplateEventClicked?.Invoke(this, EventArgs.Empty);
            TemplateEventSociety.Click += (sender, e) => TemplateEventClicked?.Invoke(this, EventArgs.Empty);
            
            if (!hideSettings)
            {
                TemplateEventSettingsButton.Click += (sender, e) => TemplateEventSettingsClicked?.Invoke(this, EventArgs.Empty);
            } else
            {
                TemplateEventSettingsButton.Visible = false;
            }
        }
    }
}
