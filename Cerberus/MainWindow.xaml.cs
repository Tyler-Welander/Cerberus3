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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.NavigationService.Navigate(new Home());
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Inmate Profiles
             Main.Content = new SearchInmate();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Medical Report
            Main.Content = new SearchMedicalReports();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Schedule
            Main.Content = new ScheduleSearch();
        }
    }
}
