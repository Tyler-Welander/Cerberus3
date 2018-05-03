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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private SolidColorBrush error = new SolidColorBrush(Colors.Crimson);
        private SolidColorBrush normal = new SolidColorBrush(Colors.Black);

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text.Equals("") && txtPassword.Password.Equals(""))
            {
                lblInstructions.Foreground = error;
                lblInstructions.Content = "Please enter a username and password.";
            }
            else if (txtUsername.Text.Equals(""))
            {
                lblInstructions.Foreground = error;
                lblInstructions.Content = "Please enter a username.";
            }
            else if (txtPassword.Password.Equals(""))
            {
                lblInstructions.Foreground = error;
                lblInstructions.Content = "Please enter a password.";
            }
            else if (!txtUsername.Text.Equals("admin") && !txtPassword.Password.Equals("password"))
            {
                lblInstructions.Foreground = error;
                lblInstructions.Content = "Invalid credentials.";
            }
            else if (txtUsername.Text.Equals("admin") && txtPassword.Password.Equals("password"))
            {
                lblInstructions.Foreground = normal;
                lblInstructions.Content = "Enter credentials to continue.";
                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.setLogin();
                NavigationService.Navigate(new Home());
            }
        }
    }
}
