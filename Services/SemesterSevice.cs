using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Repositories;
namespace Services
{
    public class SemesterSevice : ISemesterSevice
    {
        private readonly ISemesterRepository _irepository;
        public SemesterSevice()
        {
            _irepository = new SemesterRepository();
        }

        public void Add_Semester(Semester semester)
        {
            ValidateDate(semester.BeginDate, semester.EndDate);
            _irepository.Add_Semester(semester);
        }
        public int GetLastId() => _irepository.GetLastId();


        public DateOnly? GetMaxDate(int year) => _irepository.GetMaxDate(year);


        public DateOnly? GetMixDate(int year) => _irepository.GetMinDate(year);

        public bool GetSemesterByCode(string code)
        {
            return _irepository.GetSemesterByCode(code);
        }

        public Semester? GetSemesterById(int semesterId) => _irepository.GetSemesterById(semesterId);

        public List<Semester> GetSemesters()
        {
            return _irepository.GetSemesters();
        }

        public List<Semester> Load_Semester(int year, DateOnly? startDate, DateOnly? endDate)
        {
            ValidateDate(startDate, endDate);
            return _irepository.Load_Semester(year, startDate, endDate);

        }

        public List<int?> Load_Year() => _irepository.Load_Year();


        public void Update_Semester(Semester semester)
        {
            ValidateDate(semester.BeginDate, semester.EndDate);
            _irepository.Update_Semester(semester);
        }


        public void ValidateDate(DateOnly? startDate, DateOnly? endDate)
        {
            if (startDate > endDate)
            {
                throw new Exception("Begin date is not more than End Date");
            }
        }
    }
}
