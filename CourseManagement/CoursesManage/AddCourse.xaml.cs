using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CourseManagement.CoursesManage
{
    /// <summary>
    /// Interaction logic for AddCourse.xaml
    /// </summary>
    public partial class AddCourse : Window
    {
        private readonly CourseManagementDbContext _context;

        public Course NewCourse { get; private set; }

        public AddCourse()
        {
            InitializeComponent();
            _context = new CourseManagementDbContext();
            NewCourse = new Course();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string code = txtCourseCode.Text;
            string title = txtCourseTitle.Text;
            string creditsText = txtCredits.Text;

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(creditsText))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (code.Trim().Length == 0 || title.Trim().Length == 0)
            {
                MessageBox.Show("Fields cannot be empty or contain only white spaces.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            if (!IsValidCodeOrTitle(code) || !IsValidCodeOrTitle(title))
            {
                MessageBox.Show("Code and Title cannot contain special characters.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            if (!byte.TryParse(creditsText, out byte credits))
            {
                MessageBox.Show("Credits must be a valid number.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (_context.Courses.Any(c => c.Code == code))
            {
                MessageBox.Show("The course code already exists in the database.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            NewCourse.Code = code;
            NewCourse.Title = title;
            NewCourse.Credits = credits;


            MessageBox.Show("Course added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            DialogResult = true;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private bool IsValidCodeOrTitle(string input)
        {

            Regex regex = new Regex(@"^[a-zA-Z0-9 ]+$");
            return regex.IsMatch(input);
        }
    }
}
