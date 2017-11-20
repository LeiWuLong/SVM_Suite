using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;

namespace SVM_Contracts
{
    
    public interface IUserAccessService
    {
        void SaveUserAccess(int accessId, int userId, string userName, string password,int attempts,
            bool isLocked, bool isActive, DateTime createdDate, int createdBy, int? lastModifiedBy, bool isDeleted);

        List<tblaccess> LoadAccess();
        List<tbluseraccess> LoadUserAccess();

         int GetSelectedUser(int userId);

        tbluseraccess GetAccess(int userId);

        List<tbluser> LoadUsers();

        void UpdateUserAccess(int accessId, int userId, string userName, string password, int attempts,
           bool isLocked, bool isActive, DateTime? createdDate, int? createdBy, int? lastModifiedBy, bool isDeleted);

        void UpdatePassword(int userId, string password);
    }
}
