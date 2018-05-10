﻿using Cerberus.CerberusDatabaseDataSetTableAdapters;
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
        private CerberusDatabaseDataSet CerberusDataSet;
        private EmployeesTableAdapter employeesTableAdapter;

        public SearchEmployeeProfiles()
        {
            InitializeComponent();

            // Construct the dataset
            CerberusDataSet = new CerberusDatabaseDataSet();

            // Use a table adapter to populate the Inmates table
            employeesTableAdapter = new EmployeesTableAdapter();
            employeesTableAdapter.Fill(CerberusDataSet.Employees);

            // Use the Inmates talbe as the DataContext for this window
            grid.DataContext = CerberusDataSet.Employees.DefaultView;
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
            //SearchResults.ItemsSource = items;
        }

        public void ViewItem_Click(object sender, RoutedEventArgs e)
        {
            if (((TextBlock)sender).Tag.ToString() != null)
            {
                //Inmate selected = (Inmate)SearchResults.SelectedItem;
                EmployeeProfile profile = new EmployeeProfile(((TextBlock)sender).Tag.ToString());

                //txtSearch.Text = SearchResults.SelectedItem.ToString();
                NavigationService.Navigate(profile);
            }
        }

        private void SearchResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
