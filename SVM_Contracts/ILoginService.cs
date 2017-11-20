using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;

namespace SVM_Contracts
{
    public interface ILoginService
    {
        tbluseraccess LoginUser(string userName, string password);
                            
       
        

    }
}
