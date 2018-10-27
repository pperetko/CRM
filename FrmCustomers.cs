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
    public partial class FrmCustomers : Form
    {

        public int id;

        public FrmCustomers()
        {
            InitializeComponent();
          //  lv_customers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
         
        }

      

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            FrmCustomerAddModify form = new FrmCustomerAddModify();
            form.ShowDialog(this);
            if (form.DialogResult == DialogResult.OK) {
             
            }
        }

        private void tsb_edit_Click(object sender, EventArgs e)
        {
            FrmCustomerAddModify form = new FrmCustomerAddModify();
           
       
            foreach (DataGridViewRow row in dg_customers.SelectedRows)
            {
                id = int.Parse(row.Cells[0].Value.ToString());
                form.setid(id);  
            }


            form.ShowDialog(this);
            if (form.DialogResult == DialogResult.OK)
            {
            
            }
        }

        private void LoadCustomers()
        {
            DataClassesCRMDataContext db = new DataClassesCRMDataContext();
            var data = from p in db.customers

                       orderby p.id_customers
                       select p;
            foreach (var item in data)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.first_name;
                lvi.SubItems.Add(item.last_name);
                lvi.SubItems.Add(item.nationality);
                lvi.SubItems.Add(item.state);
                lvi.SubItems.Add(item.city);
                lvi.SubItems.Add(item.street);
                lvi.SubItems.Add(item.No);
                lvi.SubItems.Add(item.dob.ToString());
                lvi.Tag = item.id_customers;
                lv_customers.Items.Add(lvi);



            }

        }

        private void lv_customers_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            string text = lv_customers.Columns[e.ColumnIndex].Text;
            switch (e.ColumnIndex)
            {
                case 0:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 1:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 2:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 3:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 4:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 5:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 6:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 7:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 8:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
            }
        }

        private void lv_customers_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
           // string text = lv_customers.Columns[e.ItemIndex].Text;
           // e.Graphics.DrawString(text, lv_customers.Font,
            //          Brushes.Aquamarine, e.Bounds);
        }
    }
}
