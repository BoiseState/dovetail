using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dovetail.Displays.Installs
{
    public partial class InstallMainControl : UserControl
    {
        public InstallMainControl()
        {
            InitializeComponent();
        }

        private void HideAllDisplays()
        {
            installOverviewControl1.Hide();
            installHistoryControl1.Hide();
        }

        private void overviewButton_Click(object sender, EventArgs e)
        {
            HideAllDisplays();
            installOverviewControl1.Show();
        }

        private void dailyStatsButton_Click(object sender, EventArgs e)
        {
            HideAllDisplays();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            HideAllDisplays();
            installHistoryControl1.Show();
        }
    }
}
