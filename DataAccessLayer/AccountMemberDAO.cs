using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class AccountMemberDAO
    {
        public static AccountMember CheckExist(string username,string password)
        {
            CourseManagementDbContext db = new CourseManagementDbContext();
            AccountMember accountMember = db.AccountMembers.FirstOrDefault(u => u.Username == username && u.Password == password);
            return accountMember;
        }
        
       
    }
}
