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
    /// Interaction logic for SearchEmployeeProfiles.xaml
    /// </summary>
    public partial class SearchEmployeeProfiles : Page
    {
        private List<Employee> items = new List<Employee>();

        public SearchEmployeeProfiles()
        {
            InitializeComponent();
            //List<TodoItem> items = new List<TodoItem>();
            items.Add(new Employee() { Name = "Jay Peterson", ID = "00000001", Profile = new EmployeeProfile("Jay") });
            items.Add(new Employee() { Name = "Tyler Welander", ID = "00000002", Profile = new EmployeeProfile("Tyler") });
            items.Add(new Employee() { Name = "Michelle Keller", ID = "00000003", Profile = new EmployeeProfile("Michelle") });
        }

        public class Employee
        {
            public string Name { get; set; }

            public string ID { get; set; }

            public EmployeeProfile Profile { get; set; }

            public override String ToString()
            {
                return Name + " - " + ID;
            }
        }

        private void SearchResults_Click(object sender, MouseButtonEventArgs e)
        {
            //var item = ItemsControl.ContainerFromElement(SearchResults, e.OriginalSource as DependencyObject) as ListBoxItem;
            //txtSearch.Text = "Hello World!";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //loads list into listbox
            SearchResults.ItemsSource = items;
        }

        public void ViewItem_Click(object sender, RoutedEventArgs e)
        {
            if (SearchResults.SelectedItem != null)
            {
                Employee selected = (Employee)SearchResults.SelectedItem;

                //txtSearch.Text = SearchResults.SelectedItem.ToString();
                NavigationService.Navigate(selected.Profile);
            }
        }

        private void SearchResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
