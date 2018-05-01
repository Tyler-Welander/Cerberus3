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

namespace Cerberus
{
    /// <summary>
    /// Interaction logic for BehaviorReports.xaml
    /// </summary>
    public partial class BehaviorReports : Page
    {
        private List<ReportItem> items = new List<ReportItem>();
        private String firstName;

        public BehaviorReports(String fname)
        {
            InitializeComponent();
            firstName = fname;
            items.Add(new ReportItem() { Name = firstName, ID = "00000001", Report = new Report(firstName) });

        }

        public class ReportItem
        {
            public string Name { get; set; }

            public string ID { get; set; }

            public Report Report { get; set; }

            public override String ToString()
            {
                return Name + " - " + ID;
            }
        }

        private void ReturntoSearch_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void NewReport_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Report(firstName));
        }

        private void lbReports_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbReports.SelectedItem != null)
            {
                ReportItem selected = (ReportItem)lbReports.SelectedItem;

                //txtSearch.Text = SearchResults.SelectedItem.ToString();
                NavigationService.Navigate(selected.Report);
            }
        }

        private void LoadReports_Click(object sender, RoutedEventArgs e)
        {
            lbReports.ItemsSource = items;
        }
    }
}
