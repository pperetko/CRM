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
                DataClassesFiltersDataContext dc = new DataClassesFiltersDataContext();
                if ((change == true) && (id != -1))
                {
                    var tab = dc.tab_filters.FirstOrDefault(d => d.id_tab_filters == id);
                    if (tab != null)
                    {
                        tab.name = tb_cat_name.Text;
                        tab.fix = cb_tab_fixed.Checked;
                    }
                    dc.SubmitChanges();
                }

                else if (id == -1)
                {
                    tab_filter tab = new tab_filter();
                    tab.name = tb_cat_name.Text;
                    tab.fix = cb_tab_fixed.Checked;
                    dc.tab_filters.InsertOnSubmit(tab);
                    dc.SubmitChanges();
                    id = tab.id_tab_filters;

                }
            }



        }

        private void FormTabAdd_Load_1(object sender, EventArgs e)
        {
            if (id != -1)
            {
                DataClassesFiltersDataContext dc = new DataClassesFiltersDataContext();
                var tab = dc.tab_filters.FirstOrDefault(d => d.id_tab_filters == id);
                tb_cat_name.Text = CRMHelper.NullToString(tab.name);
                cb_tab_fixed.Checked = tab.fix.Value;

            }

        }
    }
}
