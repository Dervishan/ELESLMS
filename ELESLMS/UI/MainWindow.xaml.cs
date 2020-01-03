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
using System.Windows.Shapes;
using ELESLMS.Data;

namespace ELESLMS.UI
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        User user;
        public MainWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            MainFrame.Navigate(new CoursesPage(user));
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PasswordChangePage(user));
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ManageAccountPage(user));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

    }
}
