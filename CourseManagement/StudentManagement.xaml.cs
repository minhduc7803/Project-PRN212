using BusinessObjects;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class StudentManagement : Window
    {
        public StudentManagement()
        {
            InitializeComponent();
            applyFilter();
            loadGender();
            loadCountry();
            loadDepartment();


        }

        public void loadGender()
        {
            var listGender = new List<string>
                {
                    "Male",
                    "Female"
                };
            cboGender.ItemsSource = listGender;
        }

        public void loadCountry()
        {
            CourseManagementDbContext db = new CourseManagementDbContext();
            cboCountry.ItemsSource = null;
            var listCountry = db.Students.Select(x => x.Country).ToList();
            cboCountry.ItemsSource = listCountry;
        }

        public void loadDepartment()
        {
            CourseManagementDbContext db = new CourseManagementDbContext();
            cboDepartment.ItemsSource = null;
            var listDepartment = db.Departments.Select(x => x.Name).ToList();
            cboDepartment.ItemsSource = listDepartment;
        }

        public void txtSearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            applyFilter();
        }

        public void filter(object sender, SelectionChangedEventArgs e)
        {
            applyFilter();

        }

        public void loadData()
        {
            dgData.ItemsSource = null;
        }

        public void applyFilter()
        {
            string searchName = txtSearchName.Text.ToLower();
            string gender = cboGender.SelectedItem?.ToString();
            string country = cboCountry.SelectedItem?.ToString();
            string department = cboDepartment.SelectedItem?.ToString();
            StudentDAO dao = new StudentDAO();
            var students = dao.GetStudent();
            var filteredData = students.Where(item =>
                (string.IsNullOrEmpty(searchName) || item.Name.ToLower().Contains(searchName)) &&
                (string.IsNullOrEmpty(gender) || item.Gender == gender) &&
                (string.IsNullOrEmpty(department) || item.Department == department) &&
                (string.IsNullOrEmpty(country) || item.Country == country)
            ).ToList();

            dgData.ItemsSource = filteredData;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtSearchName.Text = string.Empty;
            cboGender.SelectedIndex = -1;
            cboDepartment.SelectedIndex = -1;
            cboCountry.SelectedIndex = -1;
            applyFilter();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
            this.Hide();
        }
    }
}
