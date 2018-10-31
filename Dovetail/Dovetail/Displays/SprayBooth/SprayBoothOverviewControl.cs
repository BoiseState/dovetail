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
        private int NumPartsFinished { get; set; }
        private double TotalHoursFinish { get; set; }

        public SprayBoothOverviewControl()
        {
            InitializeComponent();
            getTodayStats();
        }

        private void currentJobsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectedJobLabel.Text = currentJobsListBox.SelectedItem.ToString();
        }
        //get today's stats method
        private void getTodayStats()
        {
            _dovetail_dbDataSet.Business_BoothDataTable dataTable = business_BoothTableAdapter1.GetDataByDate(DateTime.Now.Date.ToString());
            ResetStats();
            foreach(_dovetail_dbDataSet.Business_BoothRow row in dataTable) {
                NumPartsFinished += row.numPartsFinished;
                TotalHoursFinish += row.totalHoursFinish;  
            }
            SetStats();
        }
        private void ResetStats()
        {
            NumPartsFinished = 0;
            TotalHoursFinish = 0;
        }
        private void SetStats()
        {
            jobsInProgressLabel.Text = DateTime.Now.Date.ToString();
            label2.Text = NumPartsFinished.ToString();
            totalPartsLabel.Text = TotalHoursFinish.ToString();
        }

    }
}
