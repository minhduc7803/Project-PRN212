using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SemesterDAO
    {
        private static List<Semester> GetSemesters()
        {
            List<Semester> semesters = new List<Semester>();
            CourseManagementDbContext context = new CourseManagementDbContext();
            semesters = context.Semesters.ToList();
            return semesters;
        }
    }
}
