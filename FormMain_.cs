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
            DataClassesCRMDataContext db=new DataClassesCRMDataContext();
            var data = from p in db.menus
                where p.parent_id =="-1" && p.activie==true
                       orderby p.orders
                       select p ;
            foreach (var item in data)
            {
                TreeNode node = tr_menu.Nodes.Add(item.menu1);
                node.Tag = item.id_menu.ToString();

                var Subdata = from a in db.menus
                              where a.parent_id == item.id_menu.ToString() && a.parent_id != "-1"
                              select a;
                foreach (var subitem in Subdata)
                {
                    TreeNode sub_node = node.Nodes.Add(subitem.menu1);
                    sub_node.Tag = subitem.id_menu.ToString();

                }
                node.ExpandAll();

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
            if (checkTabExist(e.Node.Tag.ToString()) == false)
            {
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
                        myTabPage.Tag = e.Node.Tag.ToString();
                        pc_main.SelectedTab = myTabPage;
                        break;
                    case 2:
                        myform = new Filters();
                        myTabPage = new TabPage("Filters");
                        pc_main.TabPages.Add(myTabPage);
                        myform.Visible = true;
                        myform.TopLevel = false;
                        myform.FormBorderStyle = FormBorderStyle.None;
                        myform.Dock = DockStyle.Fill;
                        myTabPage.Controls.Add(myform);
                        myTabPage.Name = "tb_filters";
                        myTabPage.Tag = e.Node.Tag.ToString();
                        pc_main.SelectedTab = myTabPage;
                        break;
                    default:

                        break;
                }
            }
            else {
                myTabPage = GetTabPageActive(e.Node.Tag.ToString());
                if (myTabPage != null) {
                    pc_main.SelectedTab = myTabPage;
                }
            }
        }

        private void pc_main_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();                                                       //15                        //4                                   
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right-20, e.Bounds.Top + 4);
            e.Graphics.DrawString(pc_main.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
            
        }

        private void pc_main_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < pc_main.TabPages.Count; i++)
            {
                Rectangle r = pc_main.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 25, r.Top + 10, 19, 7);
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



        private bool checkTabExist(string id) {
            for (int i = 0; i < pc_main.TabPages.Count; i++)
            {
                if (pc_main.TabPages[i].Tag.ToString() == id)
                {
                    return true;
                }
            }
            return false;

        }


        private TabPage GetTabPageActive(string id)
        {
            for (int i = 0; i < pc_main.TabPages.Count; i++)
            {
                if (pc_main.TabPages[i].Tag.ToString() == id)
                {
                    return pc_main.TabPages[i];
                }
            }
            return null;
        }

        private void tr_menu_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
