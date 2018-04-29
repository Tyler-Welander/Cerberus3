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
    /// Interaction logic for InmateSchedule.xaml
    /// </summary>
    public partial class InmateSchedule : Page
    {
        public InmateSchedule(String fname)
        {
            InitializeComponent();
            lblFirstName.Content = fname;
        }

        private void ReturntoSearch_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void UpdateInmateSchedule_Click(object sender, RoutedEventArgs e)
        {
            //Save schedule to database
        }

        private void Calendar_OnSelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            String day = "";
            if (calSchedule.SelectedDate.HasValue)
            {
                day = calSchedule.SelectedDate.Value.ToString("D").Split(',')[0];
            }
            if (day != "")
            {
                if (day.Equals("Sunday") || day.Equals("Saturday"))
                {
                    txtSchedule.Text = "No work today";
                }
                else
                {
                    txtSchedule.Text = "Go to work today";
                }
            }
        }
    }
}
