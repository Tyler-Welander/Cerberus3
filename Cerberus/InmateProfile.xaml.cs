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
    /// Interaction logic for InmateProfile.xaml
    /// </summary>
    public partial class InmateProfile : Page
    {
        public InmateProfile(String fname)
        {
            InitializeComponent();
            txtFirstName.Text = fname;
        }

        private void ReturntoSearch_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void UpdateInmateProfile_Click(object sender, RoutedEventArgs e)
        {
            //Save fields in database
        }
    }
}
