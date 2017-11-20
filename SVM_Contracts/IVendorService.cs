using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;

namespace SVM_Contracts
{
    public interface IVendorService
    {
        List<tblvendor> GetVendors();

        void SaveVendor(string vendorName, string vendorCode, string vendorDesc);

        void UpdateVendor(int vendorId, string vendorCode, string vendorName, string vendorDesc);

        void Delete_Vendor(int vendorId);

        List<tblvendor> GetVendorsByCode(string vendorCode);

        List<tblvendor> GetVendorsByName(string vendorName);

        tblvendor GetVendorById(int vendorId);
    }
}
