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
    public partial class SprayBoothMainControl : UserControl
    {
        public SprayBoothMainControl()
        {
            InitializeComponent();
            hideAllDisplays();
        }

        private void hideAllDisplays()
        {
            sprayBoothOverviewControl1.Hide();
            sprayHistoryControl1.Hide();
        }
        private void overviewButton_Click(object sender, EventArgs e)
        {
            hideAllDisplays();
            sprayBoothOverviewControl1.Show();
        }

        private void dailyStatsButton_Click(object sender, EventArgs e)
        {
            hideAllDisplays();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            hideAllDisplays();
            sprayHistoryControl1.Show();
        }
    }
}
