using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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
                  cust.phone = tb_phone1.Text;
                  cust.phone2 = tb_phone2.Text;
                  cust.email = tb_email.Text;
                  dc.customers.InsertOnSubmit(cust);
                  dc.SubmitChanges();
                  id_customer = cust.id_customers;
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
                    cust.phone = tb_phone1.Text;
                    cust.phone2 = tb_phone2.Text;
                    cust.email = tb_email.Text;
                }
                    dc.SubmitChanges();              

                }
            SaveAvatars(id_customer);



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
                tb_name.Text = CRMHelper.NullToString(cust.last_name);
                cb_nationality.Text = CRMHelper.NullToString(cust.nationality);

                cb_state.Text = CRMHelper.NullToString(cust.state);
                tb_city.Text = CRMHelper.NullToString(cust.city);
                tb_street.Text = CRMHelper.NullToString(cust.street);
                tb_no.Text = CRMHelper.NullToString(cust.No);
                dt_dob.Value = cust.dob.Value;
                tb_phone1.Text = CRMHelper.NullToString(cust.phone);
                tb_phone2.Text = CRMHelper.NullToString(cust.phone2);
                tb_email.Text = CRMHelper.NullToString(cust.email);

                imglist.Images.Clear();

                if (File.Exists(@"g:\firma\projekty\img\Avatar1_" + id_customer.ToString() + ".jpg"))
                {
                    var image = Image.FromFile(@"g:\firma\projekty\img\" + "Avatar1_" + id_customer.ToString() + ".jpg");
                    imglist.Images.Add("Avatar1", image);
                    pb_avatar.Image = imglist.Images["Avatar1"];
                    image.Dispose();
                }
                if (File.Exists(@"g:\firma\projekty\img\Avatar2_" + id_customer.ToString() + ".jpg"))
                {
                    var image = Image.FromFile(@"g:\firma\projekty\img\" + "Avatar2_" + id_customer.ToString() + ".jpg");
                    imglist.Images.Add("Avatar2", image);
                    image.Dispose();
                }
                if (File.Exists(@"g:\firma\projekty\img\Avatar3_" + id_customer.ToString() + ".jpg"))
                {
                    var image = Image.FromFile(@"g:\firma\projekty\img\" + "Avatar3_" + id_customer.ToString() + ".jpg");
                    imglist.Images.Add("Avatar3", image);
                    image.Dispose();
                }
            }
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
        {  


        }



          private void ll_avatar1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (imglist.Images["Avatar1"] != null)
            {
                pb_avatar.Image = imglist.Images["Avatar1"];
            }
           
        }

        private void Lb_avatar1_plus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog_Awatar1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse IMG Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Jpg files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog_Awatar1.ShowDialog() == DialogResult.OK)
            {
                imglist.Images.RemoveByKey("Avatar1");
                imglist.Images.Add("Avatar1", Image.FromFile(openFileDialog_Awatar1.FileName));
                pb_avatar.Image = null;
                pb_avatar.Image = imglist.Images["Avatar1"];
               
            }

        }

        private void Lb_avatar2_plus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog_Awatar2 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse IMG Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Jpg files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog_Awatar2.ShowDialog() == DialogResult.OK)
            {


                imglist.Images.RemoveByKey("Avatar2");
                imglist.Images.Add("Avatar2", Image.FromFile(openFileDialog_Awatar2.FileName));
                pb_avatar.Image = imglist.Images["Avatar2"];
            }

        }

        private void ll_avatar2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (imglist.Images["Avatar2"] != null)
            {
                pb_avatar.Image = imglist.Images["Avatar2"];
            }
        }

        private void Lb_avatar3_plus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog_Awatar3 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse IMG Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Jpg files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog_Awatar3.ShowDialog() == DialogResult.OK)
            {


                imglist.Images.RemoveByKey("Avatar3");
                imglist.Images.Add("Avatar3", Image.FromFile(openFileDialog_Awatar3.FileName));
                pb_avatar.Image = imglist.Images["Avatar3"];
               
            }
        }

        private void ll_avatar3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (imglist.Images["Avatar3"] != null)
            {
                pb_avatar.Image = imglist.Images["Avatar3"];
            }

        }


        private void SaveAvatars(int id)
        {


            if (imglist.Images["Avatar1"] != null)
            {
                imglist.Images["Avatar1"].Save(@"g:\firma\projekty\img\Avatar1_1" + id.ToString() + ".jpg");
            }
            if (imglist.Images["Avatar2"] != null)
            {
                imglist.Images["Avatar2"].Save(@"g:\firma\projekty\img\Avatar1_2" + id.ToString() + ".jpg");
            }
            if (imglist.Images["Avatar3"] != null)
            {
                imglist.Images["Avatar3"].Save(@"g:\firma\projekty\img\Avatar1_3" + id.ToString() + ".jpg");
            }
            pb_avatar.Image = null;
            imglist.Images.Clear();
            
            if (File.Exists(@"g:\firma\projekty\img\Avatar1_" + id.ToString() + ".jpg"))
            {
                File.Delete(@"g:\firma\projekty\img\Avatar1_" + id.ToString() + ".jpg");
            }
            if (File.Exists(@"g:\firma\projekty\img\Avatar2_" + id.ToString() + ".jpg"))
            {
                File.Delete(@"g:\firma\projekty\img\Avatar2_" + id.ToString() + ".jpg");
            }
            if (File.Exists(@"g:\firma\projekty\img\Avatar3_" + id.ToString() + ".jpg"))
            {
                File.Delete(@"g:\firma\projekty\img\Avatar3_" + id.ToString() + ".jpg");
            }
            if (File.Exists(@"g:\firma\projekty\img\Avatar1_1" + id.ToString() + ".jpg"))
            {
                File.Move(@"g:\firma\projekty\img\Avatar1_1" + id.ToString() + ".jpg", @"g:\firma\projekty\img\Avatar1_" + id.ToString() + ".jpg");
                File.Delete(@"g:\firma\projekty\img\Avatar1_1" + id.ToString() + ".jpg");
            }
            if (File.Exists(@"g:\firma\projekty\img\Avatar1_2" + id.ToString() + ".jpg"))
            {
                File.Move(@"g:\firma\projekty\img\Avatar1_2" + id.ToString() + ".jpg", @"g:\firma\projekty\img\Avatar2_" + id.ToString() + ".jpg");
                File.Delete(@"g:\firma\projekty\img\Avatar1_2" + id.ToString() + ".jpg");
            }
            if (File.Exists(@"g:\firma\projekty\img\Avatar1_3" + id.ToString() + ".jpg"))
            {
                File.Move(@"g:\firma\projekty\img\Avatar1_3" + id.ToString() + ".jpg", @"g:\firma\projekty\img\Avatar3_" + id.ToString() + ".jpg");
                File.Delete(@"g:\firma\projekty\img\Avatar1_3" + id.ToString() + ".jpg");
            }

        }

        private void FrmCustomerAddModify_Shown(object sender, EventArgs e)
        {
            setStateCombo();
            setNationalityCombo();
            setEditingData();
            setStatusCombo();
        }


        private void setStatusCombo() {
            DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
            var data = from p in dc.status
                       orderby p.name
                       select p;
            foreach (var item in data)
            {
                if (item.name != null)
                {
                    cb_status.AddItem(item.name, item.id_status);
                }
            }




        }


    }
}
