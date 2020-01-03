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
    /// ManageAccountPage.xaml etkileşim mantığı
    /// </summary>
    public partial class ManageAccountPage : Page
    {
        User user;
        public ManageAccountPage(User user)
        {
            this.user = user;
            InitializeComponent();
            txtWelcomeMessage.Text = "Welcome " + user.Name + " " + user.Surname;
        }
        UserService userService = new UserService();
        private void btnConfirmAccounDetails_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Changes Saved.");
        }

        private void btnConfirmSecretQuestion_Click(object sender, RoutedEventArgs e)
        {
            userService.SetSecretQuestionAndAnswer(user, cbSecretQuestions.SelectedIndex, txtSecretAnswer.Text);
            MessageBox.Show("Changes Saved.");
        }

        private void btnDeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("It cannot be reversible after complete", "Warning", MessageBoxButton.OKCancel);
            if (result==MessageBoxResult.OK)
            {
                userService.DeleteUser(user);
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
                Application.Current.MainWindow.Close();
            }
            else
            {

            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            txtName.Text = user.Name;
            txtSurname.Text = user.Surname;
            txtEMail.Text = user.EMail;
            txtPhoneNumber.Text = user.PhoneNumber;
            txtAddress.Text = user.Address;
            cbSecretQuestions.SelectedIndex = (int)user.SecretQuestion;
            txtSecretAnswer.Text = user.SecretAnswer;
        }
    }
}
