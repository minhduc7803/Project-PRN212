using BusinessObjects;
using DataAccessLayer;
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

namespace CourseManagement
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
            loadGender();
            loadDepartment();
        }

        public void loadDepartment()
        {
            CourseManagementDbContext db = new CourseManagementDbContext();
            cboDepartment.ItemsSource = null;
            var listDepartment = db.Departments.Select(s => s.Name).ToList();   
            cboDepartment.ItemsSource = listDepartment;
        }

        public void loadGender()
        {
            using (CourseManagementDbContext db = new CourseManagementDbContext())
            {
                var listGender = new List<string>
                {
                    "Male",
                    "Female"
                };
                cboGender.ItemsSource = listGender;
            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

      

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateInputs())
            {
                string name = txtName.Text;
                DateOnly? birthDate = txtBirthDate.SelectedDate.HasValue
                    ? DateOnly.FromDateTime(txtBirthDate.SelectedDate.Value)
                    : (DateOnly?)null;
                string gender = cboGender.Text;
                string address = txtAddress.Text;
                string city = txtCity.Text;
                string country = txtCountry.Text;
                string department = cboDepartment.SelectedItem?.ToString();

                 

                CourseManagementDbContext db = new CourseManagementDbContext();
                string departmentCode = db.Departments
                                      .Where(d => d.Name == department)
                                      .Select(d => d.Code)
                                      .FirstOrDefault();                

                var student = db.Students.ToList();
                Student studentss = new Student();                

                studentss.Id = db.Students.Max(std => std.Id) + 1;
                studentss.Name = name;
                studentss.Gender = gender;
                studentss.Address = address;
                studentss.Country = country;
                studentss.Department = departmentCode;
                studentss.City = city;
                studentss.Birthdate = birthDate;
                

                StudentDAO studentDAO = new StudentDAO();
                studentDAO.addStudent(studentss);

                MessageBox.Show("Student added successfully.");
                StudentManagement studentManagement = new StudentManagement();
                studentManagement.Show();
                this.Close();
            }
        }

        public bool ValidateInputs()
        {
            // Regular expression to check for only valid characters (alphanumeric, spaces allowed)
            Regex validCharsRegex = new Regex("^[a-zA-Z0-9 ]*$");

            // Validate Student Name
            if (string.IsNullOrWhiteSpace(txtName.Text) || !validCharsRegex.IsMatch(txtName.Text))
            {
                MessageBox.Show("Student Name is required and cannot contain special characters.");
                txtName.Focus();
                return false;
            }

            // Validate Birthdate
            if (!txtBirthDate.SelectedDate.HasValue)
            {
                MessageBox.Show("Birthdate is required.");
                txtBirthDate.Focus();
                return false;
            }

            // Validate Gender
            if (cboGender.SelectedItem == null || string.IsNullOrWhiteSpace(cboGender.Text) || !validCharsRegex.IsMatch(cboGender.Text))
            {
                MessageBox.Show("Gender is required and cannot contain special characters.");
                cboGender.Focus();
                return false;
            }

            // Validate Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text) || !validCharsRegex.IsMatch(txtAddress.Text))
            {
                MessageBox.Show("Address is required and cannot contain special characters.");
                txtAddress.Focus();
                return false;
            }

            // Validate City
            if (string.IsNullOrWhiteSpace(txtCity.Text) || !validCharsRegex.IsMatch(txtCity.Text))
            {
                MessageBox.Show("City is required and cannot contain special characters.");
                txtCity.Focus();
                return false;
            }

            // Validate Country
            if (string.IsNullOrWhiteSpace(txtCountry.Text) || !validCharsRegex.IsMatch(txtCountry.Text))
            {
                MessageBox.Show("Country is required and cannot contain special characters.");
                txtCountry.Focus();
                return false;
            }

            // Validate Department
            if (cboDepartment.SelectedItem == null || string.IsNullOrWhiteSpace(cboDepartment.Text) || !validCharsRegex.IsMatch(cboDepartment.Text))
            {
                MessageBox.Show("Department is required and cannot contain special characters.");
                cboDepartment.Focus();
                return false;
            }

            // All validations passed
            return true;
        }

        private void dpBirthDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            // Optional: Handle any specific logic when the birthdate is changed
        }
    }
}

