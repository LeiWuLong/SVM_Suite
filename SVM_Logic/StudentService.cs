using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;
using SVM_Contracts;
using SVM_Processor.DTO;

namespace SVM_Logic
{
    public class StudentService : IStudentService
    {
        SVMContext svmContext = new SVMContext();

        public tblstudent GetStudentDetails(int studentId)
        {
            tblstudent studentDetails = (from p in svmContext.tblstudent
                                         where p.StudentId == studentId
                                         && p.isDeleted == false
                                         select p).FirstOrDefault();

            return studentDetails;


        }

        public tblstudenthealthrecord GetStudentHealthRecord(int studentId)
        {
            tblstudenthealthrecord studentHealthRecord = (from p in svmContext.tblstudenthealthrecord
                                                          where p.StudentId == studentId
                                                          && p.isDeleted == false
                                                          select p).FirstOrDefault();

            return studentHealthRecord;
        }


        public List<tblstudent> GetStudents()
        {
            List<tblstudent> lstStudentDetails = (from p in svmContext.tblstudent
                                                  where p.isDeleted == false
                                                  select p).ToList();

            return lstStudentDetails;
        }

        public List<tblstudent> GetAllStudents()
        {
            List<tblstudent> lstStudentDetails = (from p in svmContext.tblstudent
                                                  where p.isDeleted == false
                                                  select p).ToList();

            return lstStudentDetails;
        }

        public List<tblrelationship> GetRelationship()
        {

            List<tblrelationship> relationships = (from p in svmContext.tblrelationship
                                                   select p).ToList();

            return relationships;
        }


        public List<tbldimeducationlevel> GetEducationLevel()
        {
            List<tbldimeducationlevel> educationLevel = (from p in svmContext.tbldimeducationlevel
                                                         select p).ToList();

            return educationLevel;

        }

        public List<tblhealthconcern> GetHealthConcerns()
        {
            List<tblhealthconcern> healthConcern = (from p in svmContext.tblhealthconcern
                                                    select p).ToList();

            return healthConcern;

        }

        public List<tblgender> GetGender()
        {
            List<tblgender> gender = (from p in svmContext.tblgender
                                      select p).ToList();

            return gender;

        }

        public int SaveStudent(string firstName, string middleName, string lastName, string dateOfBirth, string placeOfBirth,
           int genderId, string religion, string citizenship, string postalCode, string permanentAddress, string imagePath)
        {


            tblstudent tblStudent = new tblstudent();


            tblStudent.FirstName = firstName;
            tblStudent.MiddleName = middleName;

            tblStudent.LastName = lastName;
            tblStudent.DateOfBirth = Convert.ToDateTime(dateOfBirth);
            tblStudent.PlaceOfBirth = placeOfBirth;

            tblStudent.GenderId = genderId;
            tblStudent.Religion = religion;
            tblStudent.Citizenship = citizenship;
            tblStudent.PostalCode = postalCode;
            tblStudent.PermanentAddress = permanentAddress;
            tblStudent.isDeleted = false;
            tblStudent.path = imagePath;
            tblStudent.AY = Convert.ToInt32(DateTime.Now.Year);

            //apply academic year
            tblStudent.AY = GetAcademicyearId();

            svmContext.tblstudent.Add(tblStudent);

            svmContext.SaveChanges();

            return tblStudent.StudentId;
        }


        public void SaveFamilyBackground(int studentId, int relationshipId, string citizenship, string religion, string address,
        string telNo, string mobileNo, string eMail, string occupation, string employerBizAddress,
        string lastSchoolAttended, string yearGraduated, string educationalAttainment, string name)
        {
            tblstudentfamily tblStudentFamily = new tblstudentfamily();
            tblStudentFamily.StudentId = studentId;
            tblStudentFamily.RelationshipId = relationshipId;
            tblStudentFamily.Citizenship = citizenship;
            tblStudentFamily.Religion = religion;
            tblStudentFamily.Address = address;
            tblStudentFamily.TelNo = telNo;
            tblStudentFamily.MobileNo = mobileNo;
            tblStudentFamily.eMail = eMail;
            tblStudentFamily.Occupation = occupation;
            tblStudentFamily.EmployerBizAddress = employerBizAddress;
            tblStudentFamily.LastSchoolAttended = lastSchoolAttended;
            tblStudentFamily.YearGraduated = yearGraduated;
            tblStudentFamily.EducationalAttainment = educationalAttainment;
            tblStudentFamily.Name = name;

            svmContext.tblstudentfamily.Add(tblStudentFamily);
            svmContext.SaveChanges();

        }

        public void SaveEducationalBackground(int levelId, string schoolName, string schoolYear, string awardsReceived, int studentId)
        {
            tblstudenteducationalbackground tblStudentEducationalBackground = new tblstudenteducationalbackground();

            tblStudentEducationalBackground.EducLevelId = levelId;
            tblStudentEducationalBackground.SchoolName = schoolName;
            tblStudentEducationalBackground.SchoolYear = schoolYear;
            tblStudentEducationalBackground.AwardsReceived = awardsReceived;
            tblStudentEducationalBackground.StudentId = studentId;
            svmContext.tblstudenteducationalbackground.Add(tblStudentEducationalBackground);
            svmContext.SaveChanges();
            //svmContext.tblstuden.Add(tblStudentEducationalBackground);
        }


        public void SaveHealthBackground(int studentId, string childsDoctor, string doctorsContactNo,
            string doctorsBusinessNameAndAddress, bool immunization, int healthConcernId, string allergies, string conditionHindrance, string specialCare)
        {
            tblstudenthealthrecord tblStudentHealthRecord = new tblstudenthealthrecord();
            tblStudentHealthRecord.StudentId = studentId;
            tblStudentHealthRecord.ChildsDoctor = childsDoctor;
            tblStudentHealthRecord.DoctorsContactNo = doctorsContactNo;
            tblStudentHealthRecord.DoctorsBusinessNameAndAddress = doctorsBusinessNameAndAddress;
            tblStudentHealthRecord.Immunization = immunization;
            tblStudentHealthRecord.HealthConcernId = healthConcernId;
            tblStudentHealthRecord.Allergies = allergies;
            tblStudentHealthRecord.ConditionHindrance = conditionHindrance;
            tblStudentHealthRecord.SpecialCare = specialCare;

            svmContext.tblstudenthealthrecord.Add(tblStudentHealthRecord);
            svmContext.SaveChanges();
        }
        //public List<tblgender> GetGender()
        //{
        //    List<tblgender> lstGender = (from p in svmContext.tblge
        //                                 select p).ToList();

        //    return lstGender;
        //}

        public tblstudent GetStudent(int studentId)
        {
            tblstudent student = (from p in svmContext.tblstudent
                                  where studentId == p.StudentId && p.isDeleted == false
                                  select p).FirstOrDefault();

            return student;
        }

        public List<tblstudenteducationalbackground> GetEducationalBackground(int studentId)
        {
            List<tblstudenteducationalbackground> educBackground = (from p in svmContext.tblstudenteducationalbackground
                                                                    where studentId == p.StudentId
                                                                    select p).ToList();

            return educBackground;
        }

        public List<tblstudentfamily> GetStudentFamily(int studentId)
        {
            List<tblstudentfamily> studentFamily = (from p in svmContext.tblstudentfamily
                                                    where studentId == p.StudentId && p.IsDeleted == false
                                                    select p).ToList();

            return studentFamily;
        }

        public tblstudenteducationalbackground GetEducLevelUpdate(int levelId)
        {
            tblstudenteducationalbackground studentEducationLevel = (from p in svmContext.tblstudenteducationalbackground
                                                                     where p.IsDeleted == false && p.LevelId == levelId
                                                                     select p).FirstOrDefault();

            return studentEducationLevel;
        }


        public tblstudentfamily GetStudFamilyUpdate(int familyId)
        {
            tblstudentfamily studentFamily = (from p in svmContext.tblstudentfamily
                                              where p.IsDeleted == false && p.StudentFamilyId == familyId
                                              select p).FirstOrDefault();
            return studentFamily;
        }

        public tblstudenthealthrecord GetStudHealthRecord(int studentHealthRecordId)
        {
            tblstudenthealthrecord studentHealthRecord = (from p in svmContext.tblstudenthealthrecord
                                                          where p.isDeleted == false && p.StudentHealthRecordId == studentHealthRecordId
                                                          select p).FirstOrDefault();

            return studentHealthRecord;
        }
        //update part----------------------------------------------------------


        public void UpdateStudent(int studentId, string firstName, string middleName, string lastName, string dateOfBirth, string placeOfBirth,
          int genderId, string religion, string citizenship, string postalCode, string permanentAddress, string imagePath)
        {


            tblstudent tblStudent = GetStudent(studentId);


            tblStudent.FirstName = firstName;
            tblStudent.MiddleName = middleName;

            tblStudent.LastName = lastName;
            tblStudent.DateOfBirth = Convert.ToDateTime(dateOfBirth);
            tblStudent.PlaceOfBirth = placeOfBirth;

            tblStudent.GenderId = genderId;
            tblStudent.Religion = religion;
            tblStudent.Citizenship = citizenship;
            tblStudent.PostalCode = postalCode;
            tblStudent.PermanentAddress = permanentAddress;
            tblStudent.isDeleted = false;
            tblStudent.path = imagePath;



            svmContext.SaveChanges();


        }


        public void UpdateFamilyBackground(int familyId, int relationshipId, string citizenship, string religion, string address,
        string telNo, string mobileNo, string eMail, string occupation, string employerBizAddress,
        string lastSchoolAttended, string yearGraduated, string educationalAttainment, string name)
        {
            tblstudentfamily tblStudentFamily = GetStudFamilyUpdate(familyId);

            tblStudentFamily.RelationshipId = relationshipId;
            tblStudentFamily.Citizenship = citizenship;
            tblStudentFamily.Religion = religion;
            tblStudentFamily.Address = address;
            tblStudentFamily.TelNo = telNo;
            tblStudentFamily.MobileNo = mobileNo;
            tblStudentFamily.eMail = eMail;
            tblStudentFamily.Occupation = occupation;
            tblStudentFamily.EmployerBizAddress = employerBizAddress;
            tblStudentFamily.LastSchoolAttended = lastSchoolAttended;
            tblStudentFamily.YearGraduated = yearGraduated;
            tblStudentFamily.EducationalAttainment = educationalAttainment;
            tblStudentFamily.Name = name;


            svmContext.SaveChanges();

        }

        public void UpdateEducationalBackground(int educId, int levelId, string schoolName, string schoolYear, string awardsReceived)
        {
            tblstudenteducationalbackground tblStudentEducationalBackground = GetEducLevelUpdate(educId);

            tblStudentEducationalBackground.LevelId = tblStudentEducationalBackground.LevelId;
            tblStudentEducationalBackground.SchoolName = schoolName;
            tblStudentEducationalBackground.SchoolYear = schoolYear;
            tblStudentEducationalBackground.AwardsReceived = awardsReceived;

            svmContext.tblstudenteducationalbackground.Add(tblStudentEducationalBackground);
            svmContext.SaveChanges();
            //svmContext.tblstuden.Add(tblStudentEducationalBackground);
        }


        public void UpdateHealthBackground(int studentId, string childsDoctor, string doctorsContactNo,
            string doctorsBusinessNameAndAddress, bool immunization, int healthConcernId, string allergies, string conditionHindrance, string specialCare)
        {
            tblstudenthealthrecord tblStudentHealthRecord = new tblstudenthealthrecord();
            tblStudentHealthRecord.ChildsDoctor = childsDoctor;
            tblStudentHealthRecord.DoctorsContactNo = doctorsBusinessNameAndAddress;
            tblStudentHealthRecord.DoctorsBusinessNameAndAddress = doctorsBusinessNameAndAddress;
            tblStudentHealthRecord.Immunization = immunization;
            tblStudentHealthRecord.HealthConcernId = healthConcernId;
            tblStudentHealthRecord.Allergies = allergies;
            tblStudentHealthRecord.ConditionHindrance = conditionHindrance;
            tblStudentHealthRecord.SpecialCare = specialCare;
        }

        public List<StudentListingDTO> LoadStudents()
        {
            List<StudentListingDTO> lstStudent = svmContext.tblstudent
                                            .Where(p => p.isDeleted == false)
                                            .ToList()
                                            .Select(p => new StudentListingDTO()
                                            {
                                                StudentId = p.StudentId,
                                                StudentNo = p.StudentId.ToString().PadLeft(4, '0') + " - " + p.AY.ToString(),
                                                FirstName = p.FirstName,
                                                MiddleName = p.MiddleName,
                                                LastName = p.LastName
                                            }).ToList();
            return lstStudent;
        }

        public List<StudentListingDTO> LoadStudentsByName(string studName)
        {
            List<StudentListingDTO> lstStudent = svmContext.tblstudent
                                            .Where(p => p.isDeleted == false && p.FirstName.Contains(studName))
                                            .ToList()
                                            .Select(p => new StudentListingDTO()
                                            {
                                                StudentId = p.StudentId,
                                                StudentNo = p.StudentId.ToString().PadLeft(4, '0') + " - " + p.AY.ToString(),
                                                FirstName = p.FirstName,
                                                MiddleName = p.MiddleName,
                                                LastName = p.LastName
                                            }).ToList();
            return lstStudent;
        }

        public List<StudentListingDTO> LoadStudentsByNumber(string studNo)
        {
            List<StudentListingDTO> lstStudent = svmContext.tblstudent
                                            .Where(p => p.isDeleted == false && p.StudentNo.Contains(studNo))
                                            .ToList()
                                            .Select(p => new StudentListingDTO()
                                            {
                                                StudentId = p.StudentId,
                                                StudentNo = p.StudentId.ToString().PadLeft(4, '0') + " - " + p.AY.ToString(),
                                                FirstName = p.FirstName,
                                                MiddleName = p.MiddleName,
                                                LastName = p.LastName
                                            }).ToList();
            return lstStudent;
        }

        public List<tbldimhonor> GetHonors()
        {
            List<tbldimhonor> lstHonors = (from p in svmContext.tbldimhonor
                                           select p).ToList();

            return lstHonors;
        }

        public List<tbldimreferrals> GetReferrals()
        {
            List<tbldimreferrals> lstReferrals = (from p in svmContext.tbldimreferrals
                                           select p).ToList();

            return lstReferrals;
        }

        public List<tbldimsiblings> GetSiblings()
        {
            List<tbldimsiblings> lstSiblings = (from p in svmContext.tbldimsiblings
                                           select p).ToList();

            return lstSiblings;
        }

        public int GetAcademicyearId()
        {
            int ay = (from p in svmContext.tblacademicyear
                                  where p.isCurrent == true
                                  select p.AcademicYearId).FirstOrDefault();

            return ay;
        }
    }
}




