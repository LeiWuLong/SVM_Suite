using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Suite
{
    public static class Global
    { 
       public static int loggedUserId { get; set; }
      
        public static int loggedUserAccess { get; set; }

        public static int lastInsertedUserId { get; set; }

        public static int selectedStudent { get; set; }

        public static bool isStudentEdit { get; set; }

        public static bool isUserEdit { get; set; }

        public static int selectedUser { get; set; }

        public static string formToOpen { get; set; }

        //making generic  variables below

        public static int selectedId { get; set; }

        public static bool isEdit { get; set; }
        
    }
}
