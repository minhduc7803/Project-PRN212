using BusinessObjects;
using CourseManagement.SemeterManagement;
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

namespace CourseManagement
{
    /// <summary>
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Window
    {        
        
        public admin()
        {
            InitializeComponent();
        }

        public admin(AccountMember accountMembers)
        {
            InitializeComponent();
            if (accountMembers.Role == 2)
            {
                btnSemester.Visibility = Visibility.Collapsed;
                btnCourse.Visibility = Visibility.Collapsed;
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
    }
}
