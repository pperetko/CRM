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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            id = -1;
            FillStatusList();
            tb_avatar_path.Text = @"";
        }

        private int id;

        private void btn_add_status_Click(object sender, EventArgs e)
        {
            if (btn_add_status.Text == @"Add")
            {
                btn_add_status.Text = @"Accept";
                btn_edit_status.Text = @"Cancel";
                btn_edit_status.Tag = 1;
                edt_status.Text = @"";
                edt_status.Enabled = true;
                if (edt_status.CanFocus)
                {
                    edt_status.Select();
                }
            }
            else
            {
                if (btn_edit_status.Tag.ToString() == @"1")
                { //INSERT
                    if (check_status() == true)
                    {
                        btn_add_status.Text = @"Add";
                        edt_status.Enabled = false;
                        DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
                        status stat = new status();
                        stat.name = edt_status.Text;
                        dc.status.InsertOnSubmit(stat);
                        dc.SubmitChanges();
                        id = stat.id_status;
                    }
                }
                if (btn_edit_status.Tag.ToString() == @"2") //Update
                {
                    btn_add_status.Text = @"Add";


                }
            }

        }

        private bool check_status()
        {
            bool res = true;
            if (edt_status.Text.Length == 0)
            {
                res = false;
                CRMHelper.Information(@"Information", @"Fill name field!");
                if (edt_status.CanFocus)
                {
                    edt_status.Select();
                }
            }
            return res;

        }

        private void btn_edit_status_Click(object sender, EventArgs e)
        {
            if (btn_edit_status.Text == @"Cancel")
            {
                btn_add_status.Text = @"Add";
                btn_edit_status.Text = @"Edit";
                edt_status.Enabled = false;
            }
            if (btn_edit_status.Text == @"Edit")
            {
                btn_add_status.Text = @"Accept";
                btn_edit_status.Text = @"Cancel";
                btn_edit_status.Tag = 2;
                edt_status.Text = @"";
                edt_status.Enabled = true;
                if (edt_status.CanFocus)
                {
                    edt_status.Select();
                }
            }

        }


        private void FillStatusList()
        {


            DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
            var data = from p in dc.status
                       orderby p.name
                       select p;
            foreach (var item in data)
            {
                cb_status.Items.Add(item.name);

            }

        }

     

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
            var set = dc.settings.FirstOrDefault(d => d.id == 1);
            if (set != null)
            {
                tb_avatar_path.Text =  set.avatar_path;
            }
            
        }

     

        private void FrmSettings_Leave(object sender, EventArgs e)
        {
            DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
            var set = dc.settings.FirstOrDefault(d => d.id == 1);
            if (set != null)
            {
                string path = tb_avatar_path.Text;
                char[] charsToTrim1 = { '\\' };
                path.TrimEnd(charsToTrim1);
                set.avatar_path = path + "\\";
            }
            dc.SubmitChanges();
        }

        private void btn_avatar_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tb_avatar_path.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
