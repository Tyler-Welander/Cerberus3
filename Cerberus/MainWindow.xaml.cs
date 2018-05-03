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
        private Boolean loggedin = false;
        public Login login = new Login();

        public MainWindow()
        {
            InitializeComponent();
            Main.Content = login;
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }

        public void setLogin()
        {
            loggedin = true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Inmate Profiles
            if (loggedin == true)
            {
                Main.Content = new SearchInmate();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (loggedin == true)
            {
                //Medical Report
                Main.Content = new SearchMedicalReports();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (loggedin == true)
            {
                //Schedule
                Main.Content = new ScheduleSearch();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (loggedin == true)
            {
                Main.Content = new SearchBehaviorReports();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (loggedin == true)
            {
                Main.Content = new EmployeeClockInOut();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (loggedin == true)
            {
                Main.Content = new SearchEmployeeProfiles();
            }
        }
    }
}
