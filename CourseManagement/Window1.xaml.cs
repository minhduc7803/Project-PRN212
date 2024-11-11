
using BusinessObjects;
using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private readonly DepartmentDAO _departmentDAO;
        public Window1()
        {
            InitializeComponent();
            _departmentDAO = new DepartmentDAO();
            LoadDepartment();
        }

        public void LoadDepartment()
        {

            dgDepartment.ItemsSource = null;
            dgDepartment.ItemsSource = _departmentDAO.GetDepartment();
        }
        private Department departmentSelected = null;
        private void MyDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgDepartment.SelectedItem != null)
            {
                Department department = dgDepartment.SelectedItem as Department;
                if (department != null)
                {
                    txtCode.IsEnabled = false;
                    txtCode.Text = department.Code;
                    txtName.Text = department.Name;
                    departmentSelected = department;
                }
            }
        }



        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (departmentSelected != null)
            {

                Department department = new Department();

                if (string.IsNullOrWhiteSpace(txtCode.Text) || txtCode.Text.Length < 2 || txtCode.Text.Length > 20)
                {
                    MessageBox.Show("Code is required, must be between 2 and 20 characters, and cannot contain special characters or numbers");
                    return;
                }

                if (!Regex.IsMatch(txtCode.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Code can only contain letters");
                    return;
                }

                if (txtCode.Text.StartsWith(" ") || txtCode.Text.Contains("  ") || txtCode.Text.EndsWith(" "))
                {
                    MessageBox.Show("Code cannot start or end with a space, and cannot contain multiple spaces in a row");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length < 2 || txtName.Text.Length > 20)
                {
                    MessageBox.Show("Name is required, must be between 2 and 20 characters, and cannot contain special characters or numbers");
                    return;
                }

                if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Name can only contain letters");
                    return;
                }

                if (txtName.Text.StartsWith(" ") || txtName.Text.Contains("  ") || txtName.Text.EndsWith(" "))
                {
                    MessageBox.Show("Name cannot start or end with a space, and cannot contain multiple spaces in a row");
                    return;
                }

                department.Code = txtCode.Text.Trim(); // Remove leading and trailing spaces
                department.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text.ToLower().Trim()); // Convert to title case and remove leading and trailing spaces

                _departmentDAO.UpdateDepartment(department);
                LoadDepartment();
                MessageBox.Show("Department updated successfully!");
            }
            else
            {
                Department department = new Department();

                if (string.IsNullOrWhiteSpace(txtCode.Text) || txtCode.Text.Length < 2 || txtCode.Text.Length > 20)
                {
                    MessageBox.Show("Code is required, must be between 2 and 20 characters, and cannot contain special characters or numbers");
                    return;
                }

                if (!Regex.IsMatch(txtCode.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Code can only contain letters");
                    return;
                }

                if (txtCode.Text.StartsWith(" ") || txtCode.Text.Contains("  ") || txtCode.Text.EndsWith(" "))
                {
                    MessageBox.Show("Code cannot start or end with a space, and cannot contain multiple spaces in a row");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length < 2 || txtName.Text.Length > 20)
                {
                    MessageBox.Show("Name is required, must be between 2 and 20 characters, and cannot contain special characters or numbers");
                    return;
                }

                if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Name can only contain letters");
                    return;
                }

                if (txtName.Text.StartsWith(" ") || txtName.Text.Contains("  ") || txtName.Text.EndsWith(" "))
                {
                    MessageBox.Show("Name cannot start or end with a space, and cannot contain multiple spaces in a row");
                    return;
                }
                if (_departmentDAO.GetDepartmentByCode(txtCode.Text) != null)
                {
                    MessageBox.Show("Department Code Exists!");
                    return;
                }

                department.Code = txtCode.Text.ToUpper().Trim(); // Remove leading and trailing spaces
                department.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text.ToLower().Trim()); // Convert to title case and remove leading and trailing spaces

                _departmentDAO.CreateDepartment(department);
                LoadDepartment();
                MessageBox.Show("Department Add successfully!");
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtCode.IsEnabled = true;
            departmentSelected = null;
            txtCode.Text = null;
            txtName.Text = null;
        }

        private void btnbacktomain_Click(object sender, RoutedEventArgs e)
        {            
            this.Close();
        }
    }

}
