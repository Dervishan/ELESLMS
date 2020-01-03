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
using ELESLMS.Data;
using ELESLMS.Service;

namespace ELESLMS.UI
{
    /// <summary>
    /// MainPage.xaml etkileşim mantığı
    /// </summary>
    public partial class MainPage : Page
    {
        User user;
        StudentCourse studentCourse;
        Course course;
        public MainPage(User user, StudentCourse studentCourse,Course course)
        {
            this.user = user;
            this.studentCourse = studentCourse;
            this.course = course;
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void tabPeople_GotFocus(object sender, RoutedEventArgs e)
        {
            CourseService courseService = new CourseService();
            dbPeople.ItemsSource = courseService.ClassList(course);

        }
    }
}
