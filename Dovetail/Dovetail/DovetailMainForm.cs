using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dovetail
{
    public partial class DovetailMainForm: Form
    {
        public DovetailMainForm()
        {
            InitializeComponent();

            setScreenDimensions();
        }
        /// <summary>
        /// This block of code is responsible for setting the screen size. 
        /// </summary>
        private void setScreenDimensions()
        {
            Screen screen = Screen.FromControl(this);
            int x = screen.WorkingArea.X - screen.Bounds.X;
            int y = screen.WorkingArea.Y - screen.Bounds.Y;
            this.MaximizedBounds = new Rectangle(x, y, screen.WorkingArea.Width, screen.WorkingArea.Height);
            this.MaximumSize = screen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            this.Left = Top = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }
        
        /// <summary>
        /// This method is responsible for closing the form. 
        /// The reas 
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Hide all of the user controls. 
        /// </summary>
        private void hideAllControls()
        {
            shopMainControl1.Hide();
            sprayBoothMainControl1.Hide();
            doveImageBox.Hide();
        }

        private void doveButton_Click(object sender, EventArgs e)
        {
            hideAllControls();

            //Show home splash. 
            doveImageBox.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            navbuttonClick(btn);

            hideAllControls();

        }
        private void shopButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            navbuttonClick(btn);

            hideAllControls();

            shopMainControl1.Show();
        }

        private void sprayBoothButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            navbuttonClick(btn);

            hideAllControls();

            sprayBoothMainControl1.Show();
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            navbuttonClick(btn);

            hideAllControls();
        }
        private void officeButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            navbuttonClick(btn);

            hideAllControls();
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            navbuttonClick(btn);

            hideAllControls();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            //If this window is maximized
            if (this.WindowState == FormWindowState.Maximized)      
            {
                maximizeButton.Text = "☐";
                //Set the normal state of this form. 
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                //Maximize the window. 
                this.WindowState = FormWindowState.Maximized;
                this.ShowInTaskbar = true;

                maximizeButton.Text = "❒";
            }
           
        }
        /// <summary>
        /// On click, this method will minimize the window. 
        /// </summary>
        private void resizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}
