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
    public partial class FrmCustomerAddModify : Form
    {
        public FrmCustomerAddModify()
        {
            InitializeComponent();
         
            id_task = -1;
            pl_task_button.Visible = false;
         
        }

        public int id_customer;
        public int id_task;

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
            DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
                if (id_customer == -1)
                {
                  customer cust = new customer();
                  cust.first_name = tb_surname.Text;
                  cust.last_name = tb_name.Text;
                  cust.nationality = cb_nationality.Text;
                  cust.state = cb_state.Text;
                  cust.city = tb_city.Text;
                  cust.street = tb_street.Text;
                  cust.No = tb_no.Text;
                  cust.dob = dt_dob.Value;
                  dc.customers.InsertOnSubmit(cust);
                  dc.SubmitChanges(); 
               
                }
                else
                {
                
               
                var cust = dc.customers.FirstOrDefault(d => d.id_customers == id_customer);
                if (cust != null)
                {
                    cust.first_name = tb_surname.Text;
                    cust.last_name = tb_name.Text;
                    cust.nationality = cb_nationality.Text;
                    cust.state = cb_state.Text;
                    cust.city = tb_city.Text;
                    cust.street = tb_street.Text;
                    cust.No = tb_no.Text;
                    cust.dob = dt_dob.Value;

                }
                    dc.SubmitChanges();              

                }

            

        }



        public void setid(int id) {
            this.id_customer = id;

        }


        public void setEditingData()
        {
            if (id_customer != -1)
            {
                DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
                var cust = dc.customers.FirstOrDefault(d => d.id_customers == id_customer);

              

                tb_surname.Text = CRMHelper.NullToString(cust.first_name);
                tb_name.Text= CRMHelper.NullToString(cust.last_name);
                cb_nationality.Text= CRMHelper.NullToString(cust.nationality);

                cb_state.Text = CRMHelper.NullToString(cust.state);
                tb_city.Text = CRMHelper.NullToString(cust.city);
                tb_street.Text = CRMHelper.NullToString(cust.street);
                tb_no.Text = CRMHelper.NullToString(cust.No);
                dt_dob.Value = cust.dob.Value;


            }
        }

        private void FrmCustomerAddModify_Activated(object sender, EventArgs e)
        {
            setStateCombo();
            setNationalityCombo();
            setEditingData();
        }



        private void setStateCombo()
        {
          
            DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
            var data = from p in dc.countries
                       orderby p.name
                       select p;
            foreach (var item in data)
            {
                cb_state.Items.Add(item.name);

            }
        }



        private void setNationalityCombo() {
            DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
            var data = from p in dc.countries
                       orderby p.name
                       select p;
            foreach (var item in data)
            {   if (item.aplha_3 != null)
                {
                    cb_state.Items.Add(item.aplha_3);
                }
            }


        }

        private void fp_tasks_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Task_Click(object sender, EventArgs e)
        {
            FormAddEditTask form = new FormAddEditTask();
            form.id_customer = this.id_customer;
            form.ShowDialog(this);
            RefreshGridTasks();
        }

        private void btn_Edit_Task_Click(object sender, EventArgs e)
        {
            FormAddEditTask form = new FormAddEditTask();
            form.id_customer= this.id_customer;

            foreach (DataGridViewRow row in dg_tasks.SelectedRows)
            {
                id_task = int.Parse(row.Cells[0].Value.ToString());
                
            }

            form.id = id_task;
            form.ShowDialog(this);
            RefreshGridTasks();
        }



        private void RefreshGridTasks()
        {  //where id_customers=@0
           //new[] { id_customer.ToString() }
            //string query = "Select dbo.Tasks  order by title ";
            //Database db = new Database();

            //DataSet ds = db.invoke_member(query, null, "tasks");
            //dataGridView_tasks.Columns.Add("title", "Title");
            //dataGridView_tasks.DataSource = ds;
            //dataGridView_tasks.DataMember = "tasks";



        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
        

        }

        private void FrmCustomerAddModify_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'cRMDS_customers.customers' . Możesz go przenieść lub usunąć.
           // this.customersTableAdapter.Fill(this.cRMDS_customers.customers);
          

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            //this.Validate();
            //this.customersBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.cRMDS_customers);

        }
    }
}
