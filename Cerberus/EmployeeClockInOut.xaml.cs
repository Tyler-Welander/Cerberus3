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
using System.Windows.Threading;

namespace Cerberus
{
    /// <summary>
    /// Interaction logic for EmployeeClockInOut.xaml
    /// </summary>
    public partial class EmployeeClockInOut : Page
    {
        public EmployeeClockInOut()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void PunchTimeSheet_Click(object sender, RoutedEventArgs e)
        {
            if (cmbClockInOut.SelectedIndex == 0)
            {
                //Clock In
                txtTimesheet.Text += "\nClock In:\n\t" + lblTime.Content;
            }
            else if (cmbClockInOut.SelectedIndex == 1)
            {
                //Clock Out
                txtTimesheet.Text += "\nClock Out:\n\t" + lblTime.Content;
            }
            
        }

        


        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = System.DateTime.Now;
        }
    }
}
