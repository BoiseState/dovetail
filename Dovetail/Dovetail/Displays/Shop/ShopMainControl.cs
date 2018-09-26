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

        private void hideAllDisplays()
        {
            shopOverViewControl1.Hide();
        }
        private void overviewButton_Click(object sender, EventArgs e)
        {
            hideAllDisplays();

            shopOverViewControl1.Show();
        }
    }
}
