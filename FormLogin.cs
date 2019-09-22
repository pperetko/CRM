using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{

    


    public partial class FormLogin : Form
    {

        private bool log_to_app=false;

        public bool Login
        {
            get
            {
                return log_to_app;
            }
        }

   
        public FormLogin()
        {
            InitializeComponent();
        }


        private void LoginToApp() {
              string pass = "qulaola";

               DataClassesCRMDataContext db = new DataClassesCRMDataContext();
               var data = from p in db.logins
                          where p.login1 == tb_login.Text.ToString() &&
                                p.pass == Encrypting.EncryptString(tb_password.Text.ToString(), pass) &&
                                p.bloced == false
                          select p;


               if (data.Count() > 0)
               {
                   log_to_app = true;
               }
               
               Close();

        }


        private void Btn_ok_Click(object sender, EventArgs e)
        {
            LoginToApp();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void Tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginToApp();
            }
        }
    }



    public static class Logins
    {

        public static bool Login_to()
        {

            FormLogin form = new FormLogin();
            form.ShowDialog();
            return form.Login; 
        }
    }


}
