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
        _dovetail_dbDataSet.Business_ShopRow TodayShopStats;

        public ShopOverViewControl()
        {
            InitializeComponent();

            LoadToday();
        }

        private void LoadToday()
        {
            try
            {
                todaysDateLabel.Text = DateTime.Today.Date.ToShortDateString();
                _dovetail_dbDataSet.Business_ShopDataTable shopTable = business_ShopTableAdapter1.GetDataByDateInShop(DateTime.Today.Date.ToString());

                TodayShopStats = shopTable.NewBusiness_ShopRow();

                if(shopTable.Count > 0)
                {
                    foreach(_dovetail_dbDataSet.Business_ShopRow row in shopTable)
                    {
                        TodayShopStats = row;
                    }

                    SetStats();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetStats()
        {
            finishedPartsLabel.Text = TodayShopStats.numFinishedParts.ToString();
            sheetsCutLabel.Text = TodayShopStats.numSheetsCut.ToString();
            boxesBuiltLabel.Text = TodayShopStats.numBoxesBuilt.ToString();
            edgeBardedPartsLabel.Text = TodayShopStats.numPartsEdgeBarded.ToString();
            drawersBuiltLabel.Text = TodayShopStats.numDrawersBuilt.ToString();
            doorsCutLabel.Text = TodayShopStats.numDoorsCut.ToString();

            boxHoursLabel.Text = TodayShopStats.totalHoursBoxes.ToString();
            cuttingHoursLabel.Text = TodayShopStats.totalHoursCutting.ToString();
            drawerHoursLabel.Text = TodayShopStats.totalHoursDrawers.ToString();
            edgeBandingHours.Text = TodayShopStats.totalHoursEdgeBanding.ToString();

            totalHoursLabel.Text = (TodayShopStats.totalHoursBoxes + TodayShopStats.totalHoursCutting + TodayShopStats.totalHoursDrawers + TodayShopStats.totalHoursEdgeBanding).ToString();

        }
    }
}
