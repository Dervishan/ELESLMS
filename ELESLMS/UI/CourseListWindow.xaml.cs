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
using System.Windows.Shapes;

namespace ELESLMS.UI
{
    /// <summary>
    /// CourseListWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class CourseListWindow : Window
    {
        User user;
        public CourseListWindow(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        CourseService courseService = new CourseService();

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            courseService.JoinCourse(user, (Course)dgCourseList.SelectedItem);
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgCourseList.ItemsSource = null;
            dgCourseList.ItemsSource = courseService.courses();
        }
    }
}
