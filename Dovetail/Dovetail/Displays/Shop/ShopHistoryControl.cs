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
    public partial class ShopHistoryControl : UserControl
    {
        private _dovetail_dbDataSet.Business_ShopDataTable ShopStats; 
        /// <summary>
        /// These are the properties affecting this control.
        /// </summary>
        private int NumSheetsCut { get; set; }
        private int NumPartsEdgeBarded { get; set; }
        private int NumDoorsCut { get; set; }
        private int NumFinishedParts { get; set; }
        private int NumBoxesBuild { get; set; }
        private int NumDrawersBuilt { get; set; }
        
        private double TotalHoursBoxes { get; set; }
        private double TotalHoursDrawers { get; set; }
        private double TotalHoursEdgeBanding { get; set; }
        private double TotalHoursCutting { get; set; }

        private decimal HourlyWage { get; set; } = 12.5m;

        private decimal TotalHours
        {
            get
            {
               return CalculateTotalHours();
            }
        }

        private decimal Return {
            get
            {
                return CalculateReturn();
            }
        }

        

        private int _startLeft = 0;     // start Width of the panel
        private int _endLeft = 370;      // end width of the panel
        private int _stepSize = 10;     // pixels to move

        public ShopHistoryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is responisble for querying the Database based on the
        /// date picked by the user. 
        /// </summary>
        private void LoadShopOnDate()
        {
            DateTime selectedDate = this.ShopDatePicker.Value;
            try
            {
                this.ShopStats = business_ShopTableAdapter1.GetDataByDateInShop(selectedDate.Date.ToString());

                CalculateStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in shop history: " + ex.Message);
            }

            
        }

        /// <summary>
        /// This method loops through the rows of the ShopStats table calculates the totals.
        /// </summary>
        private void CalculateStats()
        {
            ResetStats();

            foreach(_dovetail_dbDataSet.Business_ShopRow row in ShopStats)
            {
                TotalHoursBoxes += row.totalHoursBoxes;
                TotalHoursCutting += row.totalHoursCutting;
                TotalHoursDrawers += row.totalHoursDrawers;
                TotalHoursEdgeBanding += row.totalHoursEdgeBanding;

                NumBoxesBuild += row.numBoxesBuilt;
                NumDoorsCut += row.numDoorsCut;
                NumDrawersBuilt += row.numDrawersBuilt;
                NumFinishedParts += row.numFinishedParts;
                NumPartsEdgeBarded += row.numPartsEdgeBarded;
                NumSheetsCut += row.numSheetsCut;
            }

            DisplayStats();

            DisplayStatsTable();
        }

        /// <summary>
        /// This method is responsible for placing the ShopsStats into the a 
        /// table for the user to see.
        /// </summary>
        private void DisplayStatsTable()
        {
            try
            {
                jobsDataGridView.DataSource = ShopStats;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// This method is responsible for displaying the stats inside of the totals 
        /// panel. 
        /// </summary>
        private void DisplayStats()
        {
            BoxHoursLabel.Text = TotalHoursBoxes.ToString("#.##");
            DrawerHoursLabel.Text = TotalHoursDrawers.ToString("#.##");
            EdgeBandingHoursLabel.Text = TotalHoursEdgeBanding.ToString("#.##");
            CuttingHoursLabel.Text = TotalHoursCutting.ToString("#.##");
            TotalSheetsLabel.Text = NumSheetsCut.ToString("#.##");
            EdgBardedLabel.Text = NumPartsEdgeBarded.ToString("#.##");
            TotalDrawersLabel.Text = NumDrawersBuilt.ToString("#.##");
            TotalFinishedPartsLabel.Text = NumFinishedParts.ToString("#.##");

            TotalHoursLabel.Text = TotalHours.ToString("#.##");

            if(Return > 0)
            {
                ReturnLabel.ForeColor = Color.LightGreen;
            }
            else
            {
                ReturnLabel.ForeColor = Color.Red;
            }
            ReturnLabel.Text = "$" + Return.ToString("#.##");
        }

        /// <summary>
        /// This method is responsible for resetting the properities of the control. 
        /// </summary>
        private void ResetStats()
        {
            TotalHoursBoxes = 0;
            TotalHoursCutting = 0;
            TotalHoursDrawers = 0;
            TotalHoursEdgeBanding = 0;

            NumBoxesBuild = 0;
            NumDoorsCut = 0;
            NumDrawersBuilt = 0;
            NumFinishedParts = 0;
            NumPartsEdgeBarded = 0;
            NumSheetsCut = 0;
        }

        /// <summary>
        /// This method is called to show the panel for the totals. 
        /// It's not necessary, but it adds some sexy animations. 
        /// </summary>
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            // if just starting, move to start location and make visible
            if (!TotalsPanel.Visible)
            {
                TotalsPanel.Left = _startLeft;
                TotalsPanel.Visible = true;
            }

            // incrementally move
            TotalsPanel.Width += _stepSize;
            // make sure we didn't over shoot
            if (TotalsPanel.Width > _endLeft) TotalsPanel.Width = _endLeft;

            // have we arrived?
            if (TotalsPanel.Width >= _endLeft)
            {
                animationTimer.Enabled = false;
            }
        }

        /// <summary>
        /// This method is responsible for calculating all of the hours 
        /// spent in theshop
        /// </summary>
        /// <returns>A decimal form of the total hours.</returns>
        //
        private decimal CalculateTotalHours()
        {
            decimal total = 0;
            total += decimal.Parse(TotalHoursBoxes.ToString());
            total += decimal.Parse(TotalHoursCutting.ToString());
            total += decimal.Parse(TotalHoursDrawers.ToString());
            total += decimal.Parse(TotalHoursEdgeBanding.ToString());

            return total;
        }

        /// <summary>
        /// This method is responisble for calculating the total return
        /// for the date.
        /// </summary>
        /// <returns></returns>
        private decimal CalculateReturn()
        {
            decimal total = 0; 
            //Multiply these numbers by their constants. 
            total += NumBoxesBuild;
            total += NumDoorsCut;
            total += NumDrawersBuilt;
            total += NumFinishedParts;
            total += NumPartsEdgeBarded;
            total += NumSheetsCut;

            //In this case the universal constant will be 50.
            //Assuming all of their products retail at $50
            total += total * 50;


            //Subtract total by the calculated total hours*rate
            total = total - (TotalHours* HourlyWage);

            return total;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            //Animates that panel when the value is selected. 
            if (!TotalsPanel.Visible)
            {
                animationTimer.Enabled = true;
            }

            LoadShopOnDate();
        }
    }
}
