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
    public partial class InstallHistoryControl : UserControl
    {
        private _dovetail_dbDataSet.Business_InstallDataTable dataTable;
        private int numBoxesInstalled { get; set; }
        private double totalHoursInstall { get; set; }

        public InstallHistoryControl()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{

        //    displayOnDate();

        //}

        //private void displayOnDate()
        //{
        //    DateTime selected = this.dateTimePicker1.Value;
        //    dataTable = business_BoothTableAdapter1.GetDataByDate(selected.Date.ToString());
        //    ResetStats();

        //    foreach (_dovetail_dbDataSet.Business_BoothRow row in dataTable)
        //    {
        //        NumPartsFinished += row.numPartsFinished;
        //        TotalHoursFinish += row.totalHoursFinish;
        //    }
        //    SetStats();
        //}
        //private void ResetStats()
        //{
        //    NumPartsFinished = 0;
        //    TotalHoursFinish = 0;
        //}
        //private void SetStats()
        //{
        //    label5.Text = NumPartsFinished.ToString();
        //    label6.Text = TotalHoursFinish.ToString();
        //}
