using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CRM
{
    public partial class FormMain : Form
    {

        public FormMain()

        {
            InitializeComponent();
            


        }







        private void load_menu()
        {
            Database db = new Database();
            if (db.connected == true)
            {
                DataSet ds;
                ds = db.invoke_sql("select * from dbo.menu where parent_id is null;");
                DataTableReader rd = ds.CreateDataReader();
                while (rd.Read())
                {
                    TreeNode node = tr_menu.Nodes.Add(rd["menu"].ToString());
                    node.Tag = rd["id_menu"].ToString();

                    DataSet sub_ds;
                    sub_ds = db.invoke("Select * from dbo.menu where parent_id=@0", new[] { rd["id_menu"].ToString() });
                    DataTableReader sub_rd = sub_ds.CreateDataReader();

                    while (sub_rd.Read())
                    {
                        TreeNode sub_node = node.Nodes.Add(sub_rd["menu"].ToString());
                        sub_node.Tag = sub_rd["id_menu"].ToString();


                    }

                    node.ExpandAll();

                }


            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            load_menu();


        }

     

        private void tr_menu_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            Form myform;
            TabPage myTabPage;
            int id = int.Parse(e.Node.Tag.ToString());
            switch (id)
            {
                case 1:
                    myform = new FrmCustomers();
                    myTabPage = new TabPage("Customers list");
                

                    pc_main.TabPages.Add(myTabPage);
                    myform.Visible = true;
                    myform.TopLevel = false;
                    myform.FormBorderStyle = FormBorderStyle.None;
                    myform.Dock = DockStyle.Fill;
                    myTabPage.Controls.Add(myform);
                    myTabPage.Name = "tb_customers_list";
                    break;
                case 2:

                    break;
                default:

                    break;
            }
        }

        private void pc_main_DrawItem(object sender, DrawItemEventArgs e)
        {

            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right-15, e.Bounds.Top + 4);
            e.Graphics.DrawString(pc_main.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();

        }

        private void pc_main_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < pc_main.TabPages.Count; i++)
            {
                Rectangle r = pc_main.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 19, 7);
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                System.Drawing.Graphics formGraphics = this.CreateGraphics();
                formGraphics.FillRectangle(myBrush, closeButton);
                myBrush.Dispose();
                formGraphics.Dispose();
                
                if (closeButton.Contains(e.Location))
                {
                   // if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                 //   {
                        pc_main.TabPages.RemoveAt(i);
                        break;
                //    }
                }
            }
        }
    }
}
