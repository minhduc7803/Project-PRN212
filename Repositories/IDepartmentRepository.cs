using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IDepartmentRepository
    {
        public List<Department> GetDepartment();
        public void UpdateDepartment(Department department);
        public void CreateDepartment(Department department);
        public Department? GetDepartmentByCode(string Code);
    }
}