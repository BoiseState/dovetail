using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dovetail.Displays.SprayBooth
{
    public partial class SprayBoothOverviewControl : UserControl
    {
        public SprayBoothOverviewControl()
        {
            InitializeComponent();
        }

        private void currentJobsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedJobLabel.Text = currentJobsListBox.SelectedItem.ToString();
        }
    }
}
