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
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void dg_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDataSet_customers.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.cRMDataSet_customers.Customers);

        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            FrmCustomerAddModify form = new FrmCustomerAddModify();
            form.ShowDialog(this);
            if (form.DialogResult == DialogResult.OK) {
                this.cRMDataSet_customers.Customers.AcceptChanges();
                this.customersTableAdapter.Fill(this.cRMDataSet_customers.Customers);
            }
        }

        private void tsb_edit_Click(object sender, EventArgs e)
        {
            FrmCustomerAddModify form = new FrmCustomerAddModify();
           
       
            foreach (DataGridViewRow row in dg_customers.SelectedRows)
            {
                form.setid(int.Parse(row.Cells[0].Value.ToString()));  
            }


                form.ShowDialog(this);
            if (form.DialogResult == DialogResult.OK)
            {
                this.cRMDataSet_customers.Customers.AcceptChanges();
                this.customersTableAdapter.Fill(this.cRMDataSet_customers.Customers);
            }
        }




    
}
}
