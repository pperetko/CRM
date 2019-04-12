using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Form Defintion of alarm
/// </summary>
namespace CRM
{
    public partial class FormFiltersAdd : Form
    {
        public FormFiltersAdd()
        {
            InitializeComponent();
        }

        public int id;
       // private bool change = false;

       

        /// <summary>
        /// Function checks field. If empty then shows message.
        /// </summary>

        private bool ValidateFields() {
            
            bool res = true;

            if (tb_filters_name.Text.Length == 0) {
                CRMHelper.Information(@"Information",@"The field name cant be empty");
                res = false;

            }

            return res;

        }

        /// <summary>
        /// This function load connected category to  left list view.
        /// </summary>

        private void loadCategoryToFilterEdit()
        {
            DataClassesFiltersDataContext dc = new DataClassesFiltersDataContext();
            var data = from p in dc.filters
                       from a in dc.category_filters
                       from c in dc.categories
                       from t in dc.categories_types
                       where p.id_filters == a.id_filter && 
                             p.id_filters == id &&
                             a.id_category == c.id_category && 
                             c.id_categories_types == t.id_categories_types
                       orderby a.id_category
                       select new { cat_name = c.name, cat_type = t.name, c.show_on_list, c.id_category };
            lv_filters.Items.Clear();
            lv_filters.BeginUpdate();
            if (data != null)
            {
                foreach (var item in data)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.cat_name;
                    lvi.SubItems.Add(item.cat_type);
                    lvi.SubItems.Add(item.show_on_list.ToString());
                    lvi.Tag = item.id_category.ToString();

                    lv_filters.Items.Add(lvi);

                }
            }
            lv_filters.EndUpdate();
        }

        /// <summary>
        /// Set data filter on edit mode
        /// </summary>
        private void setDataFilterEdit()
        {

            DataClassesFiltersDataContext dc = new DataClassesFiltersDataContext();
            var data = from p in dc.filters
                       where p.id_filters == id
                       select p;
            if (data != null)
            {
                foreach (var item in data)
                {
                    tb_filters_name.Text = item.name; 
                }
            }
        }


        //var noServiceCalls =
         //   from a in _context.Apartments
         //   where !_context.ServiceCalls.Any(s => s.ApartmentID == a.ID)
        //select a; przykład na not exists in linq

        private void loadAviableCategory() {
            DataClassesFiltersDataContext dc = new DataClassesFiltersDataContext();
            var data =
                      from c in dc.categories
                      from t in dc.categories_types
                      where !dc.category_filters.Any(s => s.id_filter == id && s.id_category==c.id_category) &&
                            c.id_categories_types == t.id_categories_types
                      select new { cat_name = c.name,cat_type =t.name, c.show_on_list,  c.id_category };

            lv_filters.Items.Clear();
            if (data != null)
            {
                foreach (var item in data)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.cat_name;
                    lvi.SubItems.Add(item.cat_type);
                    lvi.SubItems.Add(item.show_on_list.ToString());
                    lvi.Tag = item.id_category.ToString();
                    lv_aviable_categories.Items.Add(lvi);

                }
            }
        }
        /// <summary>
        /// 
        /// </summary>

        private void loadFixedCategory() {




        }
        

        /// <summary>
        ///  operation of the left button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_filters_left_Click(object sender, EventArgs e)
        {

            if (lv_aviable_categories.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lv_aviable_categories.SelectedItems[0];
                ListViewItem lvi_category = new ListViewItem();
                lvi_category.Text = lvi.Text;
                lvi_category.SubItems.Add(lvi.SubItems[1].Text);
                lvi_category.SubItems.Add(lvi.SubItems[2].Text);
                lvi_category.Tag = Convert.ToInt32(lvi.Tag);
                lv_filters.Items.Add(lvi_category);
                lv_aviable_categories.Items.Remove(lvi);
            }
            else {
                CRMHelper.Information(@"Information",@"Please selected aviable category");
            }
         }

        /// <summary>
        /// operation of the right button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_filters_right_Click(object sender, EventArgs e)
        {
            if (lv_filters.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lv_filters.SelectedItems[0];
                ListViewItem lvi_category = new ListViewItem();
                lvi_category.Text = lvi.Text;
                lvi_category.SubItems.Add(lvi.SubItems[1].Text);
                lvi_category.SubItems.Add(lvi.SubItems[2].Text);
                lvi_category.Tag = Convert.ToInt32(lvi.Tag);
                lv_aviable_categories.Items.Add(lvi_category);
                lv_filters.Items.Remove(lvi);

            }
            else {
                CRMHelper.Information(@"Information", @"Please selected aviable category");
            }
        }

        private void FormFiltersAdd_Load(object sender, EventArgs e)
        {
            loadAviableCategory();
            loadFixedCategory();
            loadCategoryToFilterEdit();
            setDataFilterEdit();
        }

        

        private void FormFiltersAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((this.DialogResult == DialogResult.OK))
            {
                DataClassesFiltersDataContext dc = new DataClassesFiltersDataContext();
                if (id != -1)
                {
                    var filter = dc.filters.FirstOrDefault(d => d.id_filters == id);
                    if (filter != null)
                    {
                        filter.name = tb_filters_name.Text;



                        var data = dc.category_filters.FirstOrDefault(x => x.id_filter == id);
                        if (data != null)
                        {
                            dc.category_filters.DeleteOnSubmit(data);
                            dc.SubmitChanges();
                        }

                        for (int i = 0; i <= lv_filters.Items.Count - 1; i++)
                        {
                            ListViewItem lvi = lv_filters.Items[i];
                            category_filter cat = new category_filter();
                            cat.id_category = Convert.ToInt32(lvi.Tag);
                            cat.id_filter = id; 
                            dc.category_filters.InsertOnSubmit(cat);
                            dc.SubmitChanges();
                        }
                    }


                }
                else
                {
                    filter filtr = new filter();
                    filtr.name = tb_filters_name.Text;
                    dc.filters.InsertOnSubmit(filtr);
                    dc.SubmitChanges();
                    id = Convert.ToInt32(filtr.id_filters);
                    for (int i = 0; i <= lv_filters.Items.Count - 1; i++)
                    {
                        ListViewItem lvi = lv_filters.Items[i];
                        category_filter cat = new category_filter();
                        cat.id_category = Convert.ToInt32(lvi.Tag);
                        cat.id_filter = id;
                        dc.category_filters.InsertOnSubmit(cat);
                        dc.SubmitChanges();
                    }

                }
            }

        }
    }
}
