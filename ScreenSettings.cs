using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkScreenSaver
{
    public partial class ScreenSettings : Form
    {
        public ScreenSettings()
        {
            InitializeComponent();
        }

        // Add or modify your workplace areas here and the text to show
        private void btnLunch_Click(object sender, EventArgs e)
        {
            string location = "At Lunch";
            setText(location);
        }

        private void btnMeeting_Click(object sender, EventArgs e)
        {
            string location = "In A Meeting";
            setText(location);
        }

        private void btnServerRoom_Click(object sender, EventArgs e)
        {
            string location =  "In Server Room";
            setText(location);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            string location =  "At Service Room";
            setText(location);
        }

        private void btnEngineering_Click(object sender, EventArgs e)
        {
            string location = "At Engineering";
            setText(location);
        }

        private void btnQuality_Click(object sender, EventArgs e)
        {
            string location =  "At QC";
            setText(location);
        }

        private void btnMangement_Click(object sender, EventArgs e)
        {
            string location =  "Near Management";
            setText(location);
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            string location = "At Production Floor";
            setText(location);
        }

        // Calls the background form passing the indicated text
        private void setText(string location)
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                Background screensaver = new Background(screen.Bounds, location);
                screensaver.Show();
            }
        }
    }
}
