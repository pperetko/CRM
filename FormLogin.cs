﻿using System;
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

        public bool login
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

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string pass= "qulaola";

            DataClassesCRMDataContext db = new DataClassesCRMDataContext();
            var data = from p in db.logins
                       where p.login1 == tb_login.Text.ToString() && 
                             p.pass == Encrypting.EncryptString(tb_password.Text.ToString(),pass) &&
                             p.bloced==false
                       select p;


            if (data.Count() > 0)
            {
                log_to_app = true;
            } 
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }



    public static class Logins
    {

        public static bool login_to()
        {

            FormLogin form = new FormLogin();
            form.ShowDialog();
            return form.login; 
        }
    }


}