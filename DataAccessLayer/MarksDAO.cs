using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MarksDAO
    {
        public static void addMark(Mark mark)
        {
            CourseManagementDbContext dbContext = new CourseManagementDbContext();            
            dbContext.Marks.Add(mark);
            dbContext.SaveChanges();
        }

        public static void updateMark(Mark mark)
        {
            CourseManagementDbContext db = new CourseManagementDbContext();
            db.Marks.Update(mark);
            db.SaveChanges();
        }

        public static List<Mark>? getMark(int enrollmentId)
        {
            CourseManagementDbContext db = new CourseManagementDbContext();
            var marks = db.Marks
                .Include(m => m.Assessment)
                .Include(m => m.Enrollment)
                .Where(m => m.EnrollmentId == enrollmentId)
                .ToList();
            return marks;
        }
    }
}
