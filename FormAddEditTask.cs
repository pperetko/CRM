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
    public partial class FormAddEditTask : Form
    {

        public int id;
        public int id_customer;
        public FormAddEditTask()
        {
            InitializeComponent();
            this.Text = "Add task";
            this.id = -1;
        }



        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (id == -1)
            {

                string query_insert = "Insert into dbo.Tasks(title, descryption,id_customers,status) values(@0, @1,@2, @3)";
                Database db = new Database();
                db.execute(query_insert, new[] { tb_task_name.Text,tb_description.Text, id_customer.ToString(), "N" });
            }
            else
            {
                string query_update = "Update dbo.Tasks set title=@0, descryption=@1 where id_tasks=@2";
                Database db = new Database();
                db.execute(query_update, new[] { tb_task_name.Text, tb_description.Text, id.ToString() });

            }
        }
    }
}
