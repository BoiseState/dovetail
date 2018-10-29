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
    public partial class ShopMainControl : UserControl
    {
        public ShopMainControl()
        {
            InitializeComponent();
        }

        private void HideAllDisplays()
        {
            shopOverViewControl1.Hide();
            shopHistoryControl1.Hide();
        }
        private void overviewButton_Click(object sender, EventArgs e)
        {
            HideAllDisplays();

            shopOverViewControl1.Show();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            HideAllDisplays();
            shopHistoryControl1.Show();
        }
    }
}
