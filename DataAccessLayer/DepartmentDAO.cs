using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DepartmentDAO
    {
        public List<Department> GetDepartment()
        {
            List<Department> departments = new List<Department>();
            CourseManagementDbContext db = new CourseManagementDbContext();
            departments = db.Departments.ToList();
            return departments;
        }
        public void UpdateDepartment(Department department)
        {
            CourseManagementDbContext db = new CourseManagementDbContext();
            db.Departments.Update(department);
            db.SaveChanges();
        }

        public void CreateDepartment(Department department)
        {

            CourseManagementDbContext db = new CourseManagementDbContext();
            db.Departments.Add(department);
            db.SaveChanges();
        }
        public Department? GetDepartmentByCode(string Code)
        {
            Department? department = new Department();
            CourseManagementDbContext db = new CourseManagementDbContext();
            department = db.Departments.Find(Code);
            return department;
        }
    }
}