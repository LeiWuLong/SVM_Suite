using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Contracts;
using SVM_Processor.Models;

namespace SVM_Logic
{
    public class LoginService :ILoginService
    {
       
        
       

        public tbluseraccess LoginUser(string userName, string password)
        {
            //SVMContext dbContext = new SVMContext();
            using (var dbcontext = new SVMContext())
            {
                var a = (from p in dbcontext.tbluseraccess
                         where p.UserName == userName
                         && password == p.Password
                         && p.isDeleted == false
                         select p).FirstOrDefault();

                return a;
              
            }

        }
    }
}
