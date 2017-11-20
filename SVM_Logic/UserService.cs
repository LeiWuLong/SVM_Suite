using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Contracts;
using SVM_Processor.Models;
using SVM_Processor.DTO;

namespace SVM_Logic
{
    public class UserService : IUserService, IUserAccessService
    {

        SVMContext svmContext = new SVMContext();



        public int SaveUser(string firstName, string middleName, string lastName, 
              string mobileNo, string email, byte[] image, int createdBy, DateTime? createdDate, DateTime? lastModifiedDate,
              int? lastModifiedBy, string imagePath)
        {
            tbluser tblUser = new tbluser();
           // tblUser.EmployeeNo = userId;
            tblUser.FirstName = firstName;
            tblUser.MiddleName = middleName;
            tblUser.LastName = lastName;
            //tblUser.Suffix = suffix;
            tblUser.MobileNo = mobileNo;
            tblUser.Email = email;
            tblUser.Photo = image;
            tblUser.CreatedBy = createdBy;
            tblUser.CreatedDate = createdDate;
            tblUser.LastModifiedDate = lastModifiedDate;
            tblUser.Path = imagePath;
            svmContext.tbluser.Add(tblUser);
            svmContext.SaveChanges();

            return tblUser.UserId;
        }

        public void UpdateUser(string employeeNo, string firstName, string middleName, string lastName, 
             string mobileNo, string email, byte[] image, int? createdBy, DateTime? createdDate, DateTime? lastModifiedDate,
             int? lastModifiedBy,int userId,string imagePath)
        {
            tbluser tblUser = GetEmployee(userId);
            tblUser.EmployeeNo = employeeNo;
            tblUser.FirstName = firstName;
            tblUser.MiddleName = middleName;
            tblUser.LastName = lastName;
           // tblUser.Suffix = suffix;
            tblUser.MobileNo = mobileNo;
            tblUser.Email = email;
            tblUser.Photo = image;
            tblUser.CreatedBy = createdBy;
            tblUser.CreatedDate = createdDate;
            tblUser.LastModifiedDate = lastModifiedDate;
            tblUser.Path = imagePath;

            svmContext.SaveChanges();

           

        }

        public void DeleteUser(int userId)
        {
            tbluser employeeDetails = (from p in svmContext.tbluser
                                       where p.UserId == userId && p.isDeleted == false
                                       select p).FirstOrDefault();
            employeeDetails.isDeleted = true;
            svmContext.SaveChanges();
        }

        public int GetSelectedUser(int userId)
        {
            int empNo = (from p in svmContext.tbluser
                         where p.UserId == userId && p.isDeleted == false
                         select p.UserId).FirstOrDefault();
            return empNo;
        }

        public tbluser GetEmployee(int userId)
        {
            tbluser employeeDetails = (from p in svmContext.tbluser
                                       where p.UserId == userId && p.isDeleted == false
                                       select p).FirstOrDefault();

            return employeeDetails;
        }

        public List<tbluser> LoadUsers()
        {
            List<tbluser> employees = (from p in svmContext.tbluser
                                       where p.isDeleted == false
                                       select p).ToList();

            return employees;
        }

        public string GetUsername(string userName)
        {
            string uName = (from p in svmContext.tbluseraccess
                            where p.UserName == userName
                            select p.UserName).FirstOrDefault();

            return uName;

        }

        public void SaveUserAccess(int accessId,int userId, string userName, string password, int attempts,
            bool isLocked, bool isActive, DateTime createdDate, int createdBy, int? lastModifiedBy, bool isDeleted)
        {

            tbluseraccess tblUserAccess = new tbluseraccess();
            tblUserAccess.AccessId = accessId;
            
            tblUserAccess.UserId = userId;
            tblUserAccess.UserName = userName.Trim();
            tblUserAccess.Password = "password";
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

        public List<tblaccess> LoadAccess()
        {
            return null;

        }

        public List<tbluseraccess> LoadUserAccess()
        {
            return null;
        }

        public tbluseraccess GetAccess(int userId)
        {
            return null;
        }

        //public string GetUsername(string userName)
        //{

        //    string uName = (from p in svmContext.tbluseraccess
        //                    where p.UserName == userName
        //                    select p.UserName).FirstOrDefault();

        //    return uName;
        //}

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

        public List<UserListingDTO> LoadUsersByName(string empName)
        {
            List<UserListingDTO> lstEmployee = svmContext.tbluser
                                            .Where(p => p.isDeleted == false && p.FirstName.Contains(empName))
                                            .ToList()
                                            .Select(p => new UserListingDTO()
                                            {
                                                UserId = p.UserId,
                                                //  StudentNo = p.StudentId.ToString().PadLeft(4, '0') + " - " + p.YearEnrolled.ToString(),
                                                EmployeeNo= p.EmployeeNo,
                                                FirstName = p.FirstName,
                                                MiddleName = p.MiddleName,
                                                LastName = p.LastName
                                            }).ToList();
            return lstEmployee;
        }

        public List<UserListingDTO> LoadUsersByEmpNo(string empNo)
        {
            List<UserListingDTO> lstUser = svmContext.tbluser
                                            .Where(p => p.isDeleted == false && p.EmployeeNo.Contains(empNo))
                                            .ToList()
                                            .Select(p => new UserListingDTO()
                                            {
                                                UserId = p.UserId,
                                                //EmployeeNo = p.EmployeeNo.ToString().PadLeft(4, '0'), // + " - " + p.YearEnrolled.ToString(),
                                                EmployeeNo = p.EmployeeNo.ToString(),
                                                FirstName = p.FirstName,
                                                MiddleName = p.MiddleName,
                                                LastName = p.LastName
                                            }).ToList();
            return lstUser;
        }

        public List<UserListingDTO> LoadUserListing()
        {
            List<UserListingDTO> lstUser = svmContext.tbluser
                                            .Where(p => p.isDeleted == false)
                                            .ToList()
                                            .Select(p => new UserListingDTO()
                                            {
                                                UserId = p.UserId,
                                                // EmployeeNo = p.EmployeeNo.ToString().PadLeft(4, '0'), // + " - " + p.YearEnrolled.ToString(),
                                                EmployeeNo = p.EmployeeNo.ToString(),
                                                FirstName = p.FirstName,
                                                MiddleName = p.MiddleName,
                                                LastName = p.LastName
                                            }).ToList();
            return lstUser;
        }
    }
}
