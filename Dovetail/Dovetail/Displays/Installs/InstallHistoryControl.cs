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
    }
}
