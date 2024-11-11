using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class AssessmentDAO
    {
        private static List<Assessment> GetAssessments()
        {
            List<Assessment> assessments = new List<Assessment>();
            CourseManagementDbContext db = new CourseManagementDbContext();
            assessments = db.Assessments.ToList();
            return assessments;
        }

        private static void CreateAssessment(Assessment assessment)
        {
            CourseManagementDbContext db = new CourseManagementDbContext();
            db.Assessments.Add(assessment);
        }
        
    }
}
