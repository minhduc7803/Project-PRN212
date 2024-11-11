using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentDAO
    {
        public List<Student> GetStudent()
        {
            List<Student> students = new List<Student>();
            CourseManagementDbContext context = new CourseManagementDbContext();
            students = context.Students.Include(s => s.DepartmentNavigation)
            .Select(s => new Student
            {
                Id = s.Id,
                Name = s.Name,
                Birthdate = s.Birthdate,
                Gender = s.Gender,
                Address = s.Address,
                City = s.City,
                Country = s.Country,
                Department = s.DepartmentNavigation.Name
            }).ToList();
            return students;
        }

        public void addStudent(Student student)
        {
            CourseManagementDbContext db = new CourseManagementDbContext();
            db.Students.Add(student);
            db.SaveChanges();
        }
    }
}
