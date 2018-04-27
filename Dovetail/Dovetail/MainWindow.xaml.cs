using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dovetail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int BoxesPerDay { get; set; } = 10;
        public double TimePerBox { get; set; } = 43.5;
        public decimal CostPerBox { get; set; } = 150.0m;
        public double SheetsCutPerDay { get; set; } = 5;

        public int InstallPerDay { get; set; } = 10;
        public double TimePerInstall { get; set; } = 43.5;
        public decimal CostPerInstall { get; set; } = 150.0m;
        public double InstallPerWeek { get; set; } = 5;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DateRange_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked Date Range");
        }

        private void Trend_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked Trend");
        }
    }
}
