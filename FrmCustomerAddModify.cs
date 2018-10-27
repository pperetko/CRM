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
         //++   RefreshGridTasks();
        }

        public int id_customer;
        public int id_task;

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
                if (id_customer == -1)
                {

                    string query_insert = "Insert into dbo.Customers(Name, Prename, Nationality, State , City, Street, No, dob, StateCode, phone1,phone2,email) values(@0, @1,@2, @3,@4,@5,@6,@7,@8,@9,@10,@11)";
                    Database db = new Database();
                    db.execute(query_insert, new[] { tb_name.Text, tb_surname.Text,cb_nationality.Text, cb_state.Text, tb_city.Text, tb_street.Text,
                        tb_no.Text, dt_dob.Value.Date.ToString(), tb_code.Text, tb_phone1.Text,tb_phone2.Text,tb_email.Text });
                }
                else
                {
                string query_update = "Update dbo.Customers set name=@0, prename=@1, Nationality=@2, State=@3, City=@4, Street=@5, No=@6, Dob=@7,StateCode=@8, phone1=@9, phone2=@10, email=@11 where id_customers=@12";
                Database db = new Database();
                db.execute(query_update, new[] { tb_name.Text, tb_surname.Text, cb_nationality.Text, cb_state.Text, tb_city.Text, tb_street.Text,
                        tb_no.Text, dt_dob.Value.Date.ToString(), tb_code.Text,tb_phone1.Text, tb_phone2.Text, tb_email.Text, id_customer.ToString() });

            }

            

        }



        public void setid(int id) {
            this.id_customer = id;

        }


        public void setEditingData()
        {
            if (id_customer != -1)
            {
                Database db = new Database();
                DataSet ds;
                ds = db.invoke("select * from dbo.customers where id_customers=@0;", new[] { id_customer.ToString() });
                DataTableReader rd = ds.CreateDataReader();
                while (rd.Read())
                {
                    tb_name.Text = rd["name"].ToString();
                    tb_surname.Text = rd["prename"].ToString();
                    tb_city.Text = rd["city"].ToString();
                    tb_code.Text = rd["StateCode"].ToString();
                    tb_no.Text = rd["no"].ToString();
                    tb_street.Text = rd["Street"].ToString();
                    dt_dob.Text= rd["dob"].ToString();
                }
                pl_task_button.Visible = true;
            }
        }

        private void FrmCustomerAddModify_Activated(object sender, EventArgs e)
        {
            setStateCombo();
            setNationalityCombo();
            setEditingData();
        }



        private void setStateCombo() {
            Database db = new Database();
            DataSet ds;
            ds = db.invoke_sql("select * from dbo.country order by name;");
            DataTableReader rd = ds.CreateDataReader();
           

            while (rd.Read())
            {
                cb_state.Items.Add(rd["name"]);
            }

       }



        private void setNationalityCombo() {
            Database db = new Database();
            DataSet ds;
            ds = db.invoke_sql("select * from dbo.country order by name;");
            DataTableReader rd = ds.CreateDataReader();


            while (rd.Read())
            {
                cb_nationality.Items.Add(rd["aplha_3"]);
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
            string query = "Select dbo.Tasks  order by title ";
            Database db = new Database();

            DataSet ds = db.invoke_member(query, null, "tasks");
            dataGridView_tasks.Columns.Add("title", "Title");
            dataGridView_tasks.DataSource = ds;
            dataGridView_tasks.DataMember = "tasks";



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
