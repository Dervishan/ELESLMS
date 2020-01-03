using System;
using System.Collections.Generic;
using System.Linq;
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
    /// CoursesPage.xaml etkileşim mantığı
    /// </summary>
    public partial class CoursesPage : Page
    {
        User user;
        public CoursesPage(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        CourseService courseService;
        private void btnAddCourse_Click(object sender, RoutedEventArgs e)
        {
            if (user.RoleId==2)
            {
                CourseListWindow courseListWindow = new CourseListWindow(user);
                courseListWindow.ShowDialog();
            }
            else if (user.RoleId==3 || user.RoleId==1)
            {
                CreateCourseWindow createCourseWindow = new CreateCourseWindow(user);
                createCourseWindow.ShowDialog();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            courseService = new CourseService();
            dgAddedCourses.ItemsSource = null;
            dgAddedCourses.ItemsSource = courseService.studentCourses(user);
        }

        private void dgCoursesAdded_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            courseService = new CourseService();
            var f = (StudentCourse)dgAddedCourses.SelectedItem;
            NavigationService.Navigate(new MainPage(user, f, f.Course));
        }
    }
}
