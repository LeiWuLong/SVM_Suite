using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;
using SVM_Processor.DTO;

namespace SVM_Contracts
{
    public interface IStudentService
    {
        tblstudent GetStudentDetails(int studentId);

        tblstudenthealthrecord GetStudentHealthRecord(int studentId);

        List<tblstudent> GetStudents();

        List<tblrelationship> GetRelationship();

        List<tbldimeducationlevel> GetEducationLevel();

        List<tblstudent> GetAllStudents();
        
        List<tblhealthconcern> GetHealthConcerns();

        List<tblgender> GetGender();

        List<tbldimhonor> GetHonors();

        List<tbldimreferrals> GetReferrals();

        List<tbldimsiblings> GetSiblings();

        int SaveStudent(string firstName, string middleName, string lastName, string dateOfBirth, string placeOfBirth,
           int genderId, string religion, string citizenship, string postalCode, string permanentAddress, string imagePath);


        

        void SaveFamilyBackground(int studentId, int relationshipId, string citizenship, string religion, string address,
            string telNo, string mobileNo, string eMail, string occupation, string employerBizAddress,
            string lastSchoolAttended, string yearGraduated, string educationalAttainment, string Name);


        void SaveEducationalBackground(int levelId, string schoolName, string schoolYear, string awardsReceived,int studentId);

        void SaveHealthBackground(int studentId, string childsDoctor, string doctorsContactNo,
            string doctorsBusinessNameAndAddress,bool immunization, int healthConcernId, string allergies, string conditionHindrance, string specialCare);

        //void SaveFamilyBackground();
        // List<tblgender> GetGender();

        tblstudent GetStudent(int studentId);
        List<tblstudenteducationalbackground> GetEducationalBackground(int studentId);
        List<tblstudentfamily> GetStudentFamily(int studentId); 


        tblstudenteducationalbackground GetEducLevelUpdate(int levelId);
        tblstudentfamily GetStudFamilyUpdate(int familyId);
        tblstudenthealthrecord GetStudHealthRecord(int studentHealthRecordId);
        //######################    update part ################################
        void UpdateStudent(int studentId, string firstName, string middleName, string lastName, string dateOfBirth, string placeOfBirth,
          int genderId, string religion, string citizenship, string postalCode, string permanentAddress, string imagePath);


        void UpdateFamilyBackground(int famId, int relationshipId, string citizenship, string religion, string address,
        string telNo, string mobileNo, string eMail, string occupation, string employerBizAddress,
        string lastSchoolAttended, string yearGraduated, string educationalAttainment, string name);

        void UpdateEducationalBackground(int educId,int levelId, string schoolName, string schoolYear, string awardsReceived);

        void UpdateHealthBackground(int studentId, string childsDoctor, string doctorsContactNo,
           string doctorsBusinessNameAndAddress, bool immunization, int healthConcernId, string allergies, string conditionHindrance, string specialCare);

        List<StudentListingDTO> LoadStudents();

        List<StudentListingDTO> LoadStudentsByName(string studName);

        List<StudentListingDTO> LoadStudentsByNumber(string studNo);

    }
}
