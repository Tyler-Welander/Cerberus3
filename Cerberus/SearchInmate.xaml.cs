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
    /// Interaction logic for SearchInmate.xaml
    /// </summary>
    public partial class SearchInmate : Page
    {
        public SearchInmate()
        {
            InitializeComponent();
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", ID = 42, Profile  = new InmateProfile()});
            items.Add(new User() { Name = "Jane Doe", ID = 39, Profile = new InmateProfile() });
            items.Add(new User() { Name = "Sammy Doe", ID = 7, Profile = new InmateProfile() });
            SearchResults.ItemsSource = items;
        }

        public class User
        {
            public string Name { get; set; }

            public int ID { get; set; }

            public InmateProfile Profile { get; set; }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
