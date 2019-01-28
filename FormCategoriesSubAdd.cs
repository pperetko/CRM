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
    public partial class FormCategoriesSubAdd : Form
    {
        public FormCategoriesSubAdd()
        {
            InitializeComponent();
            id = -1;
        }


        public int id;


        private bool ValidateFields() {
            bool res = true;

            if (tb_cat_sub_name.Text == @"") {
                res = false;
                CRMHelper.Information(@"Error", @"This field cant be empty!");
            }

            return res;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {



        }



    }




}
