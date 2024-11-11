using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SemesterRepository : ISemesterRepository
    {
        private readonly SemestersDAO _dbcontext;
        public SemesterRepository()
        {
            _dbcontext = new SemestersDAO();
        }

        public void Add_Semester(Semester semester) => _dbcontext.Add_Semester(semester);

        public int GetLastId() => _dbcontext.GetLastId();
       

        public DateOnly? GetMaxDate(int year) => _dbcontext.GetMaxDate(year);
       

        public DateOnly? GetMinDate(int year) => _dbcontext.GetMinDate(year);

        public bool GetSemesterByCode(string code) => SemestersDAO.GetSemesterByCode(code);        

        public Semester? GetSemesterById(int id) => _dbcontext.GetSemesterById(id);

        public List<Semester> GetSemesters() => SemestersDAO.GetSemesters();

        public List<Semester> Load_Semester(int year, DateOnly? startDate, DateOnly? endDate)
        {
            return _dbcontext.Load_Semester( year, startDate, endDate);
        }

        public List<int?> Load_Year() => _dbcontext.Load_Year();
       

        public void Update_Semester(Semester semester) => _dbcontext.Update_Semester(semester);


   
    }
}
