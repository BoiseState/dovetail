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
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void doveButton_Click(object sender, EventArgs e)
        {
           
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
    }
}
