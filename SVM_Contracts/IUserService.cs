using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;
using SVM_Processor.DTO;

namespace SVM_Contracts
{
    public interface IUserService
    {
        int SaveUser(string firstName, string middleName, string lastName,
            string mobileNo, string email, byte[] image, int createdBy, DateTime? createdDate, DateTime? lastModifiedDate,
            int? lastModifiedBy,string imagePath);

        void UpdateUser(string userId, string firstName, string middleName, string lastName, 
           string mobileNo, string email, byte[] image, int? createdBy, DateTime? createdDate, DateTime? lastModifiedDate,
           int? lastModifiedBy,int user_id,string imagePath);
            
        void DeleteUser(int employeeNo);

        int GetSelectedUser(int userId);
         tbluser GetEmployee(int userId);

        List<tbluser> LoadUsers();


        string GetUsername(string userName);

       // List<UserListingDTO> LoadUserByEmpNo(string userNo);

        List<UserListingDTO> LoadUserListing();

        List<UserListingDTO> LoadUsersByName(string empName);

        List<UserListingDTO> LoadUsersByEmpNo(string empNo);
    }
        
}
