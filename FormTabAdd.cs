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
    public partial class FormTabAdd : Form
    {

        public int id;

        
        private bool change;

        public FormTabAdd()
        {
            InitializeComponent();
            id = -1;
            change = false;
        }

        private void FormTabAdd_Load(object sender, EventArgs e)
        {
            
            if (id != -1)
            {
                DataClassesFiltersDataContext dc = new DataClassesFiltersDataContext();
                var tab = dc.tab_filters.FirstOrDefault(d => d.id_tabs_filters == id);
                tb_cat_name.Text = CRMHelper.NullToString(tab.name);
                cb_tab_fixed.Checked = tab.fix.Value;

            }
        }


        private bool ValidateFields()
        {
            bool res = true;
            if (tb_cat_name.Text.ToString() == @"")
            {
                CRMHelper.Information(@"Error!", @"This field cant be empty!");
                res = false;
            }
            return res;
        }

        private void tb_cat_name_TextChanged(object sender, EventArgs e)
        {
            change = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            if (ValidateFields() == true)
            {

            }



        }
    }
}
