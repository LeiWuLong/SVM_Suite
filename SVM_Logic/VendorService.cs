using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;
using SVM_Contracts;
namespace SVM_Logic
{
    public class VendorService:IVendorService
    {
        SVMContext svmContext = new SVMContext();

        public List<tblvendor> GetVendors()
        {
            List<tblvendor> lstVendors = (from p in svmContext.tblvendor
                                          where p.IsDeleted == false
                                          select p).ToList();

            return lstVendors;
        }

        public tblvendor GetVendorById(int vendorId)
        {
            tblvendor lstVendors = (from p in svmContext.tblvendor
                                    where p.IsDeleted == false && p.VendorId == vendorId
                                    select p).FirstOrDefault();

            return lstVendors;
        }

        public void SaveVendor(string vendorName, string vendorCode, string vendorDesc)
        {
            tblvendor tblVendor = new tblvendor();
            tblVendor.VendorName = vendorName;
            tblVendor.VendorCode = vendorCode;
            tblVendor.VendorDescription = vendorDesc;
            svmContext.tblvendor.Add(tblVendor);
            svmContext.SaveChanges();
        }

        public List<tblvendor> GetVendorsByName(string vendorName)
        {
            List<tblvendor> lstVendors = (from p in svmContext.tblvendor
                                          where p.IsDeleted == false &&  p.VendorName.Contains(vendorName)
                                          select p).ToList();

            return lstVendors;
        }

        public List<tblvendor> GetVendorsByCode(string vendorCode)
        {
            List<tblvendor> lstVendors = (from p in svmContext.tblvendor
                                          where p.IsDeleted == false && p.VendorCode.Contains(vendorCode)
                                          select p).ToList();

            return lstVendors;
        }

        public void Delete_Vendor(int vendorId)
        {
            tblvendor vendor = (from p in svmContext.tblvendor
                                where p.VendorId == vendorId
                                && p.IsDeleted == false
                                select p).FirstOrDefault();
            svmContext.SaveChanges();
        }

        public void UpdateVendor(int vendorId,string vendorCode,string vendorName, string vendorDesc)
        {
            tblvendor vendor = (from p in svmContext.tblvendor
                                where p.VendorId == vendorId
                                && p.IsDeleted == false
                                select p).FirstOrDefault();

            vendor.VendorCode = vendorCode;
            vendor.VendorName = vendorName;
            vendor.VendorDescription = vendorDesc;
            svmContext.SaveChanges();
        }
    }
}
