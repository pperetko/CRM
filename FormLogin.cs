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
            log_to_app = true;
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
