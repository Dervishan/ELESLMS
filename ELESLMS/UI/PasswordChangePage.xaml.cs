using ELESLMS.Data;
using ELESLMS.Service;
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

namespace ELESLMS.UI
{
    /// <summary>
    /// PasswordChangePage.xaml etkileşim mantığı
    /// </summary>
    public partial class PasswordChangePage : Page
    {
        User user;
        public PasswordChangePage(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            UserService userService = new UserService();
            if (userService.hashPassword(txtOldPassword.Password) == user.Password)
            {
                if (txtNewPassword.Password==txtConfirmPassword.Password)
                {
                    userService.ChangePassword(user, txtNewPassword.Password);
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.Show();
                    Application.Current.MainWindow.Close();
                }
                else
                {
                    MessageBox.Show("Passwords aren't match");
                }
            }
            else
            {
                MessageBox.Show("Password is incorrect");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CoursesPage(user));
        }
    }
}
