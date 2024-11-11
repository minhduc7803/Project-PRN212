using BusinessObjects;
using Services;
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
    /// Interaction logic for AddEnrollment.xaml
    /// </summary>
    public partial class AddEnrollment : Window
    {
        private readonly IEnrollmentService enrollmentService;
        private readonly ICourseService courseService;
        private readonly ISemesterSevice semesterService;
        public AddEnrollment()
        {
            InitializeComponent();
            enrollmentService = new EnrollmentService();
            courseService = new CourseService();
            semesterService = new SemesterSevice();
            loadStudent();
            loadCourse();
            loadSemester();
        }
        public void loadStudent()
        {
            CourseManagementDbContext db = new CourseManagementDbContext();
            cboStudent.ItemsSource = null;
            var students = db.Students.ToList();
            cboStudent.ItemsSource = students;
            cboStudent.DisplayMemberPath = "Name";
            cboStudent.SelectedValuePath = "Id";
        }
        public void loadCourse()
        {
            cboCourse.ItemsSource = null;
            var course = courseService.GetCourses();
            cboCourse.ItemsSource = course;
            cboCourse.SelectedValuePath = "Id";
            cboCourse.DisplayMemberPath = "Code";
        }

        public void loadSemester()
        {
            cboSemester.ItemsSource = null;
            var semester = semesterService.GetSemesters();
            cboSemester.ItemsSource = semester;
            cboSemester.SelectedValuePath = "Id";
            cboSemester.DisplayMemberPath = "Code";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cboStudent.SelectedValue == null || cboSemester.SelectedValue == null || cboCourse.SelectedValue == null)
            {
                MessageBox.Show("Invalid Field!");
                return;
            }
            int studentId = Int32.Parse(cboStudent.SelectedValue.ToString());
            int semesterId = Int32.Parse(cboSemester.SelectedValue.ToString());
            int courseId = Int32.Parse(cboCourse.SelectedValue.ToString());
            var enrollments = enrollmentService.getEnrollment();
            foreach ( var enrollment in enrollments )
            {
                if (enrollment.StudentId == studentId && enrollment.CourseId == courseId)
                {
                    MessageBox.Show("Student have already enrolled this course!");
                    return;
                }
            }
            enrollmentService.addEnrollment(studentId, courseId, semesterId);
            MessageBox.Show("Enrollment added successful!");
            this.Close();
        }
    }    
}
