using ELESLMS.Data;
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
using ELESLMS.Service;

namespace ELESLMS.UI
{
    /// <summary>
    /// CreateCourseWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class CreateCourseWindow : Window
    {
        User user;
        public CreateCourseWindow(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            CourseService courseService = new CourseService();
            courseService.CreateCourse(txtName.Text, txtDefinition.Text, user);
            this.Close();
        }
    }
}
