using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ELESLMS.Service;
using ELESLMS.Data;

namespace ELESLMS.UI
{
    /// <summary>
    /// LoginPage.xaml etkileşim mantığı
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        UserService UserService;

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            UserService = new UserService();
            var loginUser = UserService.Login(txtUserName.Text, txtPassword.Password);
            if (loginUser==null)
            {
                MessageBox.Show("Enter a username and password.");
            }
            else if (loginUser.IsDeleted == false)
            {
                MainWindow mainWindow = new MainWindow(loginUser);
                mainWindow.Show();
                Application.Current.MainWindow.Close();
            }
            else
            {
                MessageBox.Show("This account is not found");
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            NavigationService.Navigate(registerPage);
        }
    }
}
