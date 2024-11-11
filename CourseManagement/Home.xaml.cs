using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessObjects;
using CourseManagement.CoursesManage;
using CourseManagement.SemeterManagement;

namespace CourseManagement
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }
        public Home(AccountMember accountMember)
        {
            InitializeComponent();
            if (accountMember.Role == 2)
            {
                btnSemester.Visibility = Visibility.Collapsed;
                btnCourse.Visibility = Visibility.Collapsed;
                btnDepartment.Visibility = Visibility.Collapsed;
            }
        }
        private void btnEnroll_Click(object sender, RoutedEventArgs e)
        {
            EnrollmentManagement enrollmentManagement = new EnrollmentManagement();
            enrollmentManagement.ShowDialog();

        }

        private void btnCourse_Click(object sender, RoutedEventArgs e)
        {
            CoursesManage.CoursesManage coursesManage = new CoursesManage.CoursesManage();
            coursesManage.ShowDialog();
        }

        private void btnSemester_Click(object sender, RoutedEventArgs e)
        {
            SemesterManagement semesterManagement = new SemesterManagement();
            semesterManagement.ShowDialog();
        }

        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentManagement studentManagement = new StudentManagement();
            studentManagement.ShowDialog();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Login n = new Login();
            this.Close();
            n.Show();
        }

        private void btnDepartment_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
        }
    }
}
