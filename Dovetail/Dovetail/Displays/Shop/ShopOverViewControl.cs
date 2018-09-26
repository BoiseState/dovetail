using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dovetail.Displays.Shop
{
    public partial class ShopOverViewControl : UserControl
    {
        public ShopOverViewControl()
        {
            InitializeComponent();

            loadJobs();
        }

        private void currentJobsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(currentJobsListBox.SelectedItem != null)
            {
                selectedJobLabel.Text = currentJobsListBox.SelectedItem.ToString();
            }
        }
        /// <summary>
        /// This method is responsible for loading the current jobs into the list box.
        /// </summary>
        private void loadJobs()
        {
            jobsInProgressLabel.Text = currentJobsListBox.Items.Count.ToString();
        }
    }
}
