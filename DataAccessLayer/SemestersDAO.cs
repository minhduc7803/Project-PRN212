using BusinessObjects;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessLayer
{
    public class SemestersDAO
    {
        public int GetLastId()
        {
            int id = -1;
            using (var _dbcontext = new CourseManagementDbContext())
            {
                return _dbcontext.Semesters.Max(s => s.Id) + 1;
            }
        }
        public List<int?> Load_Year()
        {
            using (var _dbcontext = new CourseManagementDbContext())
            {
                return _dbcontext.Semesters
                    .Select(x => x.Year)
                    .Distinct()
                    .ToList();
            }
        }
        public DateOnly? GetMinDate(int year)
        {
            using (var _dbcontext = new CourseManagementDbContext())
            {
                IQueryable<Semester> query = _dbcontext.Semesters;
                if(year != -1)
                {
                  query =  query.Where(s => s.Year == year);
                }
                return  query.Min(s => s.BeginDate);
            }
        }
        public DateOnly? GetMaxDate(int year)
        {
            using (var _dbcontext = new CourseManagementDbContext())
            {
                IQueryable<Semester> query = _dbcontext.Semesters;
                if (year != -1)
                {
                   query = query.Where(s => s.Year == year);
                }
                return query.Max(s => s.EndDate);
            }
        }
        

        public List<Semester> Load_Semester(int year, DateOnly? startDate, DateOnly? endDate)
        {
            List<Semester> semesters = new List<Semester>();
            try
            {
                using (var _dbcontext = new CourseManagementDbContext())
                {
                    IQueryable<Semester> query = _dbcontext.Semesters;
                    if (year != -1) { query = query.Where(s => s.Year == year); }
                    if (startDate.HasValue && endDate.HasValue)
                    {
                        query = query.Where(s => s.BeginDate >= startDate.Value && s.EndDate <= endDate.Value);
                    }
                    semesters = query.ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return semesters;
        }
        public void Add_Semester(Semester semester)
        {
            try
            {
                using (var _dbcontext = new CourseManagementDbContext())
                {
                    _dbcontext.Semesters.Add(semester);
                    _dbcontext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while adding semester: " + ex.Message);
            }
        }

        public void Update_Semester(Semester semester)
        {
            try
            {
                using (var _dbcontext = new CourseManagementDbContext())
                {
                    _dbcontext.Update(semester);
                    _dbcontext.SaveChanges();
                }
            }
            catch (Exception ex) { }
        }
        public Semester? GetSemesterById(int id)
        {
            Semester semester = null;
            try
            {
                using (var _dbcontext = new CourseManagementDbContext())
                {
                    semester = _dbcontext.Find<Semester>(id);
                }
            }
            catch (Exception ex)
            {

            }
            return semester;
        }
        public static bool GetSemesterByCode(string code)
        {
            using (var _dbcontext = new CourseManagementDbContext())
            {
                return _dbcontext.Semesters.Any(s => s.Code == code);
            }
        }

        public static List<Semester> GetSemesters()
        {
            List<Semester> semesters = new List<Semester>();
            CourseManagementDbContext context = new CourseManagementDbContext();
            semesters = context.Semesters.ToList();
            return semesters;
        }
    }
}
