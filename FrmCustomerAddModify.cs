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
            id = -1;
        }

        public int id;

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
                if (id == -1)
                {

                    string query_insert = "Insert into dbo.Customers(Name, Prename, Nationality, State , City, Street, No, dob, StateCode) values(@0, @1,@2, @3,@4,@5,@6,@7,@8)";
                    Database db = new Database();
                    db.execute(query_insert, new[] { tb_name.Text, tb_surname.Text, "", cb_state.Text, tb_city.Text, tb_street.Text,
                        tb_no.Text, dt_dob.Value.Date.ToString(), tb_code.Text });
                }
                else
                {
                string query_update = "Update dbo.Customers set name=@0, prename=@1, Nationality=@2, State=@3, City=@4, Street=@5, No=@6, Dob=@7,StateCode=@8 where id_customers=@9";
                Database db = new Database();
                db.execute(query_update, new[] { tb_name.Text, tb_surname.Text, "", cb_state.Text, tb_city.Text, tb_street.Text,
                        tb_no.Text, dt_dob.Value.Date.ToString(), tb_code.Text, id.ToString() });

            }

            

        }



        public void setid(int id) {
            this.id = id;
        }


        public void setEditingData()
        {
            if (id != -1)
            {
                Database db = new Database();
                DataSet ds;
                ds = db.invoke("select * from dbo.Customers where id_customers=@0;", new[] { id.ToString() });
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
            }
        }

        private void FrmCustomerAddModify_Activated(object sender, EventArgs e)
        {
            setEditingData();
        }
    }
}
