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
        private List<Inmate> items = new List<Inmate>();
        
        public SearchInmate()
        {
            InitializeComponent();
            //List<TodoItem> items = new List<TodoItem>();
            items.Add(new Inmate() { Name = "Jay Peterson", ID = "00000001", Profile = new InmateProfile("Jay") });
            items.Add(new Inmate() { Name = "Tyler Welander", ID = "00000002", Profile = new InmateProfile("Tyler") });
            items.Add(new Inmate() { Name = "Michelle Keller", ID = "00000003", Profile = new InmateProfile("Michelle") });

            
        }

        public class Inmate
        {
            public string Name { get; set; }

            public string ID { get; set; }

            public InmateProfile Profile { get; set; }

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
                Inmate selected = (Inmate)SearchResults.SelectedItem;
                
                //txtSearch.Text = SearchResults.SelectedItem.ToString();
                NavigationService.Navigate(selected.Profile);
            }
        }

        private void SearchResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NewInmateProfile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InmateProfile(""));
        }
    }
}
