using BusinessObjects;
using DataAccessLayer;
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

namespace CourseManagement.CoursesManage
{
    /// <summary>
    /// Interaction logic for AddAssessment.xaml
    /// </summary>
    public partial class AddAssessment : Window
    {
        private int courseId;

        public AddAssessment(int courseId)
        {
            InitializeComponent();
            this.courseId = courseId;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Basic client-side validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Validate special characters in the Name field
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Name cannot contain special characters.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Type is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(txtPercent.Text, out double percent) || percent < 0 || percent > 1)
            {
                MessageBox.Show("Percent must be a number between 0 and 1.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using (var context = new CourseManagementDbContext())
            {
                var totalPercent = context.Assessments
                                          .Where(a => a.CourseId == courseId)
                                          .Sum(a => a.Percent);

                if (totalPercent + percent > 1)
                {
                    MessageBox.Show("The total percentage of assessments for this course exceeds 100%. You cannot add this assessment.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                var assessment = new Assessment
                {
                    Name = txtName.Text,
                    Type = ((ComboBoxItem)cmbType.SelectedItem).Content.ToString(),
                    Percent = percent,
                    CourseId = courseId
                };

                var dao = new AssessmentsDAO();
                dao.CreateAssessment(assessment);
            }

            this.Close();
        }




    }
}
