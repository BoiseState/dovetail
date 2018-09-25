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

            /// <summary>
            /// 
            /// </summary>
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            Screen screen = Screen.FromControl(this);
            int x = screen.WorkingArea.X - screen.Bounds.X;
            int y = screen.WorkingArea.Y - screen.Bounds.Y;
            this.MaximizedBounds = new Rectangle(x, y, screen.WorkingArea.Width, screen.WorkingArea.Height);
            this.MaximumSize = screen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
        }

        
        /// <summary>
        /// This method is responsible for closing the form. 
        /// The reas 
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void doveButton_Click(object sender, EventArgs e)
        {
            _dovetail_dbDataSet.UsersDataTable users = usersTableAdapter1.GetUserByType("Admin");

            //users.Count
            foreach(_dovetail_dbDataSet.UsersRow usr in users)
            {
              //  usr.
            }

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            navbuttonClick(btn);

        }
        private void shopButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            navbuttonClick(btn);
        }

        private void sprayBoothButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            navbuttonClick(btn);
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            navbuttonClick(btn);
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
    }
}
