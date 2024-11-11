using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AssessmentsDAO
    {

        public List<Assessment> GetAssessments()
        {
            using (var db = new CourseManagementDbContext())
            {
                return db.Assessments.ToList();
            }
        }

        public Assessment GetAssessmentById(int id)
        {
            using (var db = new CourseManagementDbContext())
            {
                return db.Assessments.Find(id);
            }
        }

        public void CreateAssessment(Assessment assessment)
        {
            assessment.Id = GetNextAssessmentId();
            using (var db = new CourseManagementDbContext())
            {
                db.Assessments.Add(assessment);
                db.SaveChanges();
            }
        }

        public void UpdateAssessment(Assessment assessment)
        {
            using (var db = new CourseManagementDbContext())
            {
                db.Assessments.Update(assessment);
                db.SaveChanges();
            }
        }


        public void DeleteAssessment(Assessment assessment)
        {
            using (var db = new CourseManagementDbContext())
            {
                db.Assessments.Remove(assessment);
                db.SaveChanges();
            }
        }

        private int GetNextAssessmentId()
        {
            using (var db = new CourseManagementDbContext())
            {
                return db.Assessments.Any() ? db.Assessments.Max(c => c.Id) + 1 : 1;
            }
        }
        public double GetTotalPercent()
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            var totalPercent = _context.Assessments.Sum(a => a.Percent);
            return (double)totalPercent;
        }

    }
}
