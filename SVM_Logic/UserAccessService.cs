using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;
using SVM_Contracts;

namespace SVM_Logic
{
    public class UserAccessService:IUserAccessService
    {
        SVMContext svmContext = new SVMContext();
      public  List<tbluseraccess> LoadUserAccess()
        {
           

            List<tbluseraccess> lstUserAccess = new List<tbluseraccess>();
            lstUserAccess= (from p in svmContext.tbluseraccess
                        select p).ToList();

            return lstUserAccess;
        }



       public List<tblaccess> LoadAccess()
        {
            SVMContext svmContext = new SVMContext();

            List<tblaccess> lstAccess = new List<tblaccess>();
            lstAccess = (from p in svmContext.tblaccess
                         select p).ToList();

            return lstAccess;
        }

       

        public void SaveUserAccess(int accessId, int userId, string userName, string password, int attempts,
            bool isLocked, bool isActive, DateTime createdDate, int createdBy, int? lastModifiedBy, bool isDeleted
           )
        {
           

            tbluseraccess tblUserAccess = new tbluseraccess();
            tblUserAccess.AccessId = accessId;

            tblUserAccess.UserId = userId;
            tblUserAccess.UserName = userName.Trim();
            tblUserAccess.Password = password.Trim();
            
            tblUserAccess.Attempts = attempts;
            tblUserAccess.IsLocked = isLocked;
            tblUserAccess.IsActive = isActive;
            tblUserAccess.CreatedDate = DateTime.Now;
            tblUserAccess.CreatedBy = createdBy;
            tblUserAccess.LastModifiedBy = lastModifiedBy;
            tblUserAccess.isDeleted = isDeleted;

            svmContext.tbluseraccess.Add(tblUserAccess);
            svmContext.SaveChanges();
        }

        public int GetSelectedUser(int userId)
        {
            int empNo = (from p in svmContext.tbluser
                         where p.UserId == userId
                         select p.UserId).FirstOrDefault();
            return empNo;
        }

        public tbluseraccess GetAccess(int userId)
        {
            tbluseraccess userAccess = (from p in svmContext.tbluseraccess
                                        where p.UserId == userId
                                        select p).FirstOrDefault();

            return userAccess;
            
        }

        public List<tbluser> LoadUsers()
        {
            List<tbluser> employees = (from p in svmContext.tbluser
                                       select p).ToList();

            return employees;
        }

        public void UpdateUserAccess(int accessId, int userId, string userName, string password, int attempts,
           bool isLocked, bool isActive, DateTime? createdDate, int? createdBy, int? lastModifiedBy, bool isDeleted)
        {
           

            tbluseraccess tblUserAccess = GetAccess(userId);
            tblUserAccess.AccessId = accessId;

            tblUserAccess.UserId = userId;
            tblUserAccess.UserName = userName.Trim();
            tblUserAccess.Password = password.Trim();
            tblUserAccess.Attempts = attempts;
            tblUserAccess.IsLocked = isLocked;
            tblUserAccess.IsActive = isActive;
            tblUserAccess.CreatedDate = DateTime.Now;
            tblUserAccess.CreatedBy = createdBy;
            tblUserAccess.LastModifiedBy = lastModifiedBy;
            tblUserAccess.isDeleted = isDeleted;


           
            svmContext.SaveChanges();
        }

        public void UpdatePassword(int userId, string password)
        {
            tbluseraccess tblUserAccess = GetAccess(userId);
            tblUserAccess.Password = password.Trim();

            svmContext.SaveChanges();
        }


    }
}
