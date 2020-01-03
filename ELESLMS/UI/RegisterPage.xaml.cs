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

namespace ELESLMS.UI
{
    /// <summary>
    /// RegisterPage.xaml etkileşim mantığı
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password==txtConfirmPassword.Password)
            {
                UserService userService = new UserService();
                userService.Register(cbPosition.SelectedIndex, txtName.Text, txtSurname.Text, txtUserName.Text, txtEMail.Text, txtStudentNumberAndProfession.Text, txtPassword.Password);
                NavigationService.Navigate(new LoginPage());
            }
            else
            {
                MessageBox.Show("Passwords aren't match");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            GridLength gridLength = new GridLength(1,GridUnitType.Star);
            rowSix.Height = gridLength;
            txtBlock.Text = "Student Number:";
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            GridLength gridLength = new GridLength(1, GridUnitType.Star);
            rowSix.Height = gridLength;
            txtBlock.Text = "Profession:";
        }
    }
}
