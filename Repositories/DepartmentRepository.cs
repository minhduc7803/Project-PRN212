using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DepartmentDAO _departmentDAO;
        public DepartmentRepository()
        {
            _departmentDAO = new DepartmentDAO();
        }
        public void CreateDepartment(Department department) => _departmentDAO.CreateDepartment(department);


        public List<Department> GetDepartment() => _departmentDAO.GetDepartment();

        public void UpdateDepartment(Department department) => _departmentDAO.UpdateDepartment(department);

        public Department? GetDepartmentByCode(string Code) => _departmentDAO.GetDepartmentByCode(Code);
    }
}