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
    /// Interaction logic for InmateProfile.xaml
    /// </summary>
    public partial class InmateProfile : Page
    {
        private CerberusDatabaseDataSet CerberusDataSet;
        private InmatesTableAdapter inmatesTableAdapter;
        private Int32 ID;

        //private CollectionViewSource inmateViewSource;

        public InmateProfile(String ID)
        {
            InitializeComponent();

            // Construct the dataset
            CerberusDataSet = new CerberusDatabaseDataSet();

            // Parsing id from a string to integer
            this.ID = int.Parse(ID);

            // Use a table adapter to populate the Inmates table
            inmatesTableAdapter = new InmatesTableAdapter();
            inmatesTableAdapter.PrisonerInfo(CerberusDataSet.Inmates, Int32.Parse(ID));

            // Use the Inmates talbe as the DataContext for this window
            //grid.DataContext = CerberusDataSet.Inmates.DefaultView;
            //inmateViewSource = (CollectionViewSource)(FindResource("inmatesViewSource"));
            txtFirstName.DataContext = CerberusDataSet.Inmates.DefaultView;
            txtID.DataContext = CerberusDataSet.Inmates.DefaultView;
            txtDateOfBirth.DataContext = CerberusDataSet.Inmates.DefaultView;
            txtSSN.DataContext = CerberusDataSet.Inmates.DefaultView;
            txtSentence.DataContext = CerberusDataSet.Inmates.DefaultView;
            txtLawyerName.DataContext = CerberusDataSet.Inmates.DefaultView;
            txtEmergencyContactName.DataContext = CerberusDataSet.Inmates.DefaultView;
            txtCellAssignment.DataContext = CerberusDataSet.Inmates.DefaultView;
            txtJobAssignment.DataContext = CerberusDataSet.Inmates.DefaultView;
        }

        private void ReturntoSearch_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void UpdateInmateProfile_Click(object sender, RoutedEventArgs e)
        {
            //Save fields in database
            inmatesTableAdapter.UpdateInfo(txtFirstName.Text,
                                           Int32.Parse(txtID.Text),
                                           DateTime.Parse(txtDateOfBirth.Text),
                                           Int32.Parse(txtSSN.Text),
                                           txtSentence.Text,
                                           txtLawyerName.Text,
                                           txtJobAssignment.Text,
                                           txtCellAssignment.Text,
                                           txtEmergencyContactName.Text,
                                           ID);
            inmatesTableAdapter.Update(CerberusDataSet);
        }
    }
}
