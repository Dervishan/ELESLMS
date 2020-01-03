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
    /// PasswordResetPage.xaml etkileşim mantığı
    /// </summary>
    public partial class PasswordResetPage : Page
    {
        public PasswordResetPage()
        {
            InitializeComponent();
        }
        UserService userService = new UserService();
        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text!="")
            {
                if (userService.UserExists(txtUserName.Text))
                {
                    GridLength gridLengthEmpty = new GridLength(0);
                    GridLength gridLengthFull = new GridLength(60);
                    rowTwo.Height = gridLengthEmpty;
                    rowThree.Height = gridLengthEmpty;
                    rowFour.Height = gridLengthFull;
                    rowFive.Height = gridLengthFull;
                    rowSix.Height = gridLengthFull;
                }
                else
                {
                    MessageBox.Show("User is not found");
                }
            }
            else
            {
                MessageBox.Show("Enter username");
            }
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {

        }

        private void btnContinue2_Click(object sender, RoutedEventArgs e)
        {
            if (userService.UserExists(txtUserName.Text))
            {
                if (userService.SecretQuestionCheck(txtUserName.Text,cbSecretQuestions.SelectedIndex,txtSecretAnswer.Text))
                {
                    GridLength gridLengthEmpty = new GridLength(0);
                    GridLength gridLengthFull = new GridLength(60);
                    rowFour.Height = gridLengthEmpty;
                    rowFive.Height = gridLengthEmpty;
                    rowSix.Height = gridLengthEmpty;
                    rowSeven.Height = gridLengthFull;
                    rowEight.Height = gridLengthFull;
                    rowNine.Height = gridLengthFull;
                }
                else
                {
                    MessageBox.Show("Incorrect secret question");
                }
            }
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (txtNewPassword.Password==txtConfirmPassword.Password)
            {
                userService.ChangePassword(txtUserName.Text, txtNewPassword.Password);
                LoginPage loginPage = new LoginPage();
                NavigationService.Navigate(loginPage);
            }
            else
            {
                MessageBox.Show("Passwords aren't match");
            }
        }
    }
}
