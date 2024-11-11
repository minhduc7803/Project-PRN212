using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CourseDAO
    {
        public static List<Course> GetCourses()
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            return _context.Courses.ToList();
        }

        public static void DeleteCourse(Course course)
        {

            CourseManagementDbContext _context = new CourseManagementDbContext();
            var existingCourse = _context.Courses.Find(course.Id);
            if (existingCourse != null)
            {
                _context.Courses.Remove(existingCourse);
                _context.SaveChanges();
            }
        }

        public static void UpdateCourse(Course course)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            _context.Courses.Update(course);
            _context.SaveChanges(); 
        }


        public static void CreateCourse(Course NewCourse)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            NewCourse.Id = GetNextCourseId();
            _context.Courses.Add(NewCourse);
            _context.SaveChanges();
        }
        public static List<int> GetCredits()
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT DISTINCT Credits FROM Courses";
                _context.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    var credits = new List<int>();
                    while (result.Read())
                    {
                        credits.Add(Convert.ToInt32(result.GetValue(0)));
                    }
                    return credits;
                }
            }
        }
        public static Course GetCourseById(int id)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            return _context.Courses.Find(id);
        }
        private static int GetNextCourseId()
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            return _context.Courses.Any() ? _context.Courses.Max(c => c.Id) + 1 : 1;
        }
    }
}
