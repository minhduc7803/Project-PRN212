using BusinessObjects;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for EnrollmentManagement.xaml
    /// </summary>
    public partial class EnrollmentManagement : Window
    {

        private readonly IEnrollmentService enrollmentService;
        private readonly ICourseService courseService;
        private readonly ISemesterSevice semesterService;
        public EnrollmentManagement()
        {
            InitializeComponent();
            enrollmentService = new EnrollmentService();
            courseService = new CourseService();
            semesterService = new SemesterSevice();
            loadWindow();
            loadCourse();
            loadSemester();
        }

        public void loadWindow()
        {
            CourseManagementDbContext db = new CourseManagementDbContext();
            var enrollments = enrollmentService.getEnrollment();
            List<dynamic> dynamics = new List<dynamic>();
            foreach (var enrollment in enrollments)
            {                
                dynamics.Add(new { EnrollmentId = enrollment.EnrollmentId, Name = enrollment.Student.Name, CourseCode = enrollment.Course.Code, SemesterCode = enrollment.Semester.Code });
            }
            dgData.ItemsSource = dynamics;
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

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (!txtEnrollmentID.Text.Equals(""))
            {
                EditMark editMark = new EditMark(Int32.Parse(txtEnrollmentID.Text));
                editMark.Show();
            } else
            {
                MessageBox.Show("Enrollment not Selected!");
            }
        }

        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            if (dataGrid.ItemsSource != null)
            {
                DataGridRow row = dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex) as DataGridRow;
                DataGridCell cell = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;

                string id = ((TextBlock)cell.Content).Text;
                if (!id.Equals(""))
                {
                    CourseManagementDbContext db = new CourseManagementDbContext();
                    var enrollments = enrollmentService.getEnrollment();
                    foreach (Enrollment enrollment in enrollments)
                    {
                        if (enrollment.EnrollmentId == Int32.Parse(id))
                        {
                            txtEnrollmentID.Text = enrollment.EnrollmentId.ToString();
                            txtCourseName.Text = enrollment.Course.Code;
                            txtStudentName.Text = enrollment.Student.Name;
                            txtSemester.Text = enrollment.Semester.Code;
                        }
                    }                    
                }
            }
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string course = "";
            string semester = "";
            if (cboCourse.SelectedValue != null)
            {
                course = cboCourse.SelectedValue.ToString();
            }
            
            if (cboSemester.SelectedValue != null)
            {
                semester = cboSemester.SelectedValue.ToString();
            }
            CourseManagementDbContext db = new CourseManagementDbContext();
            var enrollments = enrollmentService.getEnrollment();
            List<dynamic> dynamics = new List<dynamic>();
            foreach (var enrollment in enrollments)                
            {
                if (!course.Equals("") && enrollment.CourseId != Int32.Parse(course))
                {
                    continue;
                }
                if (!semester.Equals("") && enrollment.SemesterId != Int32.Parse(semester))
                {
                    continue;
                }
                if (enrollment.Student.Name.Contains(name))
                {                    
                    dynamics.Add(new { EnrollmentId = enrollment.EnrollmentId, Name = enrollment.Student.Name, CourseCode = enrollment.Course.Code, SemesterCode = enrollment.Semester.Code });                    
                }                

            }
            dgData.ItemsSource = dynamics;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            loadCourse();
            loadSemester();
            txtName.Text = "";
            loadWindow();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEnrollment addEnrollment = new AddEnrollment();
            addEnrollment.ShowDialog();
            loadWindow();
        }
    }
}
