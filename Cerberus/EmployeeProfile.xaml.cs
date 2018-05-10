using Cerberus.CerberusDatabaseDataSetTableAdapters;
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
    /// Interaction logic for EmployeeProfile.xaml
    /// </summary>
    public partial class EmployeeProfile : Page
    {
        private CerberusDatabaseDataSet CerberusDataSet;
        private EmployeesTableAdapter employeesTableAdapter;
        private Int32 ID;

        public EmployeeProfile(String ID)
        {
            InitializeComponent();

            // Construct the dataset
            CerberusDataSet = new CerberusDatabaseDataSet();

            // Parsing id from a string to integer
            this.ID = Int32.Parse(ID);

            // Use a table adapter to populate the Inmates table
            employeesTableAdapter = new EmployeesTableAdapter();
            employeesTableAdapter.EmployeeInfo(CerberusDataSet.Employees, this.ID);

            txtName.DataContext = CerberusDataSet.Employees.DefaultView;
            txtIDNumber.DataContext = CerberusDataSet.Employees.DefaultView;
            txtHealthInfo.DataContext = CerberusDataSet.Employees.DefaultView;
            txtEmergencyContactInfo.DataContext = CerberusDataSet.Employees.DefaultView;
            txtEmergencyContactName.DataContext = CerberusDataSet.Employees.DefaultView;
            txtEmergencyContactRelation.DataContext = CerberusDataSet.Employees.DefaultView;
            chbBackgroundCheck.DataContext = CerberusDataSet.Employees.DefaultView;
        }

        private void UpdateEmployeeProfile_Click(object sender, RoutedEventArgs e)
        {
            //update database
        }

        private void ReturntoSearch_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
