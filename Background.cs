using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace WorkScreenSaver
{
    public partial class Background : Form
    {
        #region Win32 API functions

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        #endregion

        public Background()
        {
            InitializeComponent();
        }

        private Point mouseLocation;
        private bool previewMode = false;
        private Random rand = new Random();
        private string currLocation;

        public Background(Rectangle Bounds, string location)
        {
            InitializeComponent();
            this.Bounds = Bounds;
            currLocation = location;
        }

        public Background(IntPtr PreviewWndHandle)
        {
            InitializeComponent();

            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // Make this a child window so it will close when the parent dialog closes
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            // Make text smaller
            lblLocation.Font = new System.Drawing.Font("Arial", 6);

            previewMode = true;
        }

        private void Background_Load(object sender, EventArgs e)
        {            
            LoadSettings();

            Cursor.Hide();            
            TopMost = true;

            moveTimer.Interval = 2500;
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            // Move text to new location
            lblLocation.Left = rand.Next(Math.Max(1, Bounds.Width - lblLocation.Width));
            lblLocation.Top = rand.Next(Math.Max(1, Bounds.Height - lblLocation.Height));            
        }

        private void LoadSettings()
        {
            if (currLocation == null)
                lblLocation.Text = "C# Screen Saver";
            else
                lblLocation.Text = currLocation;
        }

        private void Background_MouseMove(object sender, MouseEventArgs e)
        {
            if (!previewMode)
            {
                if (!mouseLocation.IsEmpty)
                {
                    // Terminate if mouse is moved a significant distance
                    if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                        Math.Abs(mouseLocation.Y - e.Y) > 5)
                    {
                        Cursor.Show();
                        foreach (Screen screen in Screen.AllScreens)
                        {
                            this.Close();
                        }
                    }
                }

                // Update current mouse location
                mouseLocation = e.Location;
            }
        }

        private void Background_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!previewMode)
                Cursor.Show();
            foreach (Screen screen in Screen.AllScreens)
            {
                this.Close();
            }
        }

        private void Background_MouseClick(object sender, MouseEventArgs e)
        {
            if (!previewMode)
                Cursor.Show();
            foreach (Screen screen in Screen.AllScreens)
            {
                this.Close();
            }
        }
    }
}
