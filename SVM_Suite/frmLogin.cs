using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVM_Logic;
using SVM_Processor.Models;
using SVM_Contracts;

namespace SVM_Suite
{
    public partial class frmLogin : Form, ILoginService
    {
        readonly ILoginService _loginService;
        tbluseraccess loginAccess;
        public frmLogin()
        {
         

            InitializeComponent();
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            loginAccess = LoginUser(txtLogin.Text, txtPassword.Text);
            //SVMContext dbContext = new SVMContext();
            using (var dbcontext = new SVMContext())
            {
                //var a = (from p in dbcontext.tbluseraccess
                //         where p.UserName == txtLogin.Text
                //         && txtPassword.Text == p.Password
                //         && p.isDeleted != false
                //         select p).FirstOrDefault();

                if (loginAccess != null)
                {
                    

                    this.Hide();
                    var parent = new Parent_SVM();


                    Global.loggedUserId = loginAccess.UserId;
                    Global.loggedUserAccess = loginAccess.AccessId;
                    //Parent_SVM parent = new Parent_SVM();
                    parent.Closed += (s, args) => this.Close();


                    parent.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }

                
            }
        }

        public tbluseraccess LoginUser(string userName, string password)
        {
             ILoginService _loginService = new LoginService();

            return _loginService.LoginUser(userName, password);
           
             
        }

    }
}
