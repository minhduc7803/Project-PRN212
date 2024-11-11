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

namespace CourseManagement.SemeterManagement
{
    /// <summary>
    /// Interaction logic for EditSemester.xaml
    /// </summary>
    public partial class EditSemester : Window
    {
        public Semester _newSemester { get; private set; }
        private readonly ISemesterSevice _isemester;
        public EditSemester(Semester semester)
        {
            InitializeComponent();
            _isemester = new SemesterSevice();
            _newSemester = semester;
            
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _newSemester.Id = int.Parse(txtId.Text);
            DateTime? selectStartDate = txtStartDate.SelectedDate;
            DateTime? selectEndDate = txtEndDate.SelectedDate;

             int year = -1;
            try
            {
                if (txtCode.Text != null)
                {
                    _newSemester.Code = txtCode.Text;
                }
                else
                {
                    throw new Exception("Code need to insert");
                }
                if (txtYear.Text != null && int.TryParse(txtYear.Text.ToString(), out year)) ;
                if (year != -1)
                {
                    _newSemester.Year = int.Parse(txtYear.Text);
                }
                else
                {
                    throw new Exception("Year need to insert");
                }

                if (selectStartDate.HasValue)
                {
                    _newSemester.BeginDate = DateOnly.FromDateTime(selectStartDate.Value);
                }
                else
                {
                    throw new Exception("Begin Date need to insert");
                }
                if (selectEndDate.HasValue)
                {
                    _newSemester.EndDate = DateOnly.FromDateTime(selectEndDate.Value);
                }
                else
                {
                    throw new Exception("End Date need to insert");
                }
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtId.Text = _newSemester.Id.ToString();
            txtCode.Text = _newSemester.Code;
            DateOnly? startDate = _newSemester.BeginDate;
            DateOnly? endDate = _newSemester.EndDate;
            txtStartDate.SelectedDate = startDate.Value.ToDateTime(TimeOnly.MinValue);
            txtEndDate.SelectedDate = endDate.Value.ToDateTime(TimeOnly.MinValue);
            txtYear.Text = _newSemester.Year.ToString();
        }

        private void txtYear_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string input = txtYear.Text;

            if (int.TryParse(input, out int number) && number > 0)
            {
                txtYear.Background = System.Windows.Media.Brushes.White;
            }
            else
            {
                txtYear.Background = System.Windows.Media.Brushes.LightPink;
            }
        }

        private void txtStartDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtEndDate.SelectedDate.HasValue)
            {
                txtStartDate.DisplayDateEnd = txtEndDate.SelectedDate.Value;
            }
        }

        private void txtEndDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtStartDate.SelectedDate.HasValue)
            {
                txtEndDate.DisplayDateStart = txtStartDate.SelectedDate.Value;
            }
        }

        private void txtCode_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (txtCode.Text != null)
            {
                bool? isSemesterExist = _isemester.GetSemesterByCode(txtCode.Text);
                txtCode.Background = isSemesterExist == false ? System.Windows.Media.Brushes.White : System.Windows.Media.Brushes.LightPink;
            }
        }
    }
}
