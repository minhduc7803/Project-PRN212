using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISemesterSevice
    {
        public List<Semester> Load_Semester(int year, DateOnly? startDate, DateOnly? endDate);

        public void Add_Semester(Semester semester);
        public void Update_Semester(Semester semester);
        public Semester? GetSemesterById(int semesterId);

        public List<int?> Load_Year();
        public DateOnly? GetMixDate(int year);
        public DateOnly? GetMaxDate(int year);
        public int GetLastId();
        List<Semester> GetSemesters();
        bool GetSemesterByCode(string code);
    }
}
