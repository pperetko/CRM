namespace CRM
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Filters" />
    /// </summary>
    public partial class Filters : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filters"/> class.
        /// </summary>
        public Filters()
        {
            InitializeComponent();
            show_tabs(-1);
            show_category(-1);
        }

        /// <summary>
        /// The btn_cat_add_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btn_cat_add_Click(object sender, EventArgs e)
        {
            FormCategoriesAdd frm = new FormCategoriesAdd();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                show_category(frm.id);
            }
        }

        /// <summary>
        /// The show_category
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        private void show_category(int id)
        {
            int index = -1;
            lv_categories.BeginUpdate();
            lv_categories.Items.Clear();
            DataClassesFiltersDataContext db = new DataClassesFiltersDataContext();
            var data = from p in db.categories
                       from t in db.categories_types
                       from  tbs in db.tab_filters
                       where p.id_categories_types == t.id_categories_types && p.id_tab_filters== tbs.id_tab_filters
                       orderby p.name
                       select new { u1 = p.name, u2 = t.name, id = p.id_category, shw_on_list = p.show_on_list, u3 = tbs.name };
            foreach (var item in data)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.u1;
                lvi.SubItems.Add(item.u3);
                lvi.SubItems.Add(item.u2);
                lvi.SubItems.Add(item.shw_on_list.ToString());
                lvi.Tag = item.id;
                lv_categories.Items.Add(lvi);
                if (id == item.id)
                {
                    index = lvi.Index;

                }
            }
            lv_categories.EndUpdate();
            if (index != -1)
            {
                lv_categories.Items[index].Selected = true;
                lv_categories.Select();

            }
        }

        /// <summary>
        /// The btn_cat_edit_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btn_cat_edit_Click(object sender, EventArgs e)
        {
            FormCategoriesAdd frm = new FormCategoriesAdd();
            ListViewItem lvi = lv_categories.SelectedItems[0];
            if (lvi != null)
            {
                frm.id = Convert.ToInt32(lvi.Tag.ToString());
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                show_category(frm.id);
            }
        }

        /// <summary>
        /// The btn_cat_delete_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btn_cat_delete_Click(object sender, EventArgs e)
        {
            int id = -1;

            if (CRMHelper.Question(@"Question", @"Delete selected items ?") == DialogResult.OK)
            {

                ListViewItem lvi = lv_categories.SelectedItems[0];
                if (lvi != null)
                {
                    id = Convert.ToInt32(lvi.Tag.ToString());
                }
                else
                {
                    CRMHelper.Information(@"Information", @"Cant delete selected items!");
                    return;
                }
                if (id != -1)
                {
                    DataClassesFiltersDataContext db = new DataClassesFiltersDataContext();
                    var cat = db.categories.FirstOrDefault(d => d.id_category == id);
                    if (cat != null)
                    {
                        db.categories.DeleteOnSubmit(cat);
                        // zapisujemy zmiany
                        db.SubmitChanges();
                        show_category(-1);

                    }
                }
                else
                {
                    CRMHelper.Information(@"Information", @"Cant delete selected items!");
                    return;
                }
            }
        }
        //-----------------------------------------TAB---------------------------------------
        /// <summary>
        /// The btn_add_tab_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btn_add_tab_Click(object sender, EventArgs e)
        {
            FormTabAdd frm = new FormTabAdd();
            if (lv_tabs.Items.Count > 0)
            {
                ListViewItem lvi = lv_tabs.SelectedItems[0];
                if (lvi != null)
                {
                    frm.id = Convert.ToInt32(lvi.Tag.ToString());
                }
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                show_tabs(frm.id);
            }
        }

        /// <summary>
        /// The show_tabs
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        private void show_tabs(int id)
        {
            int index = -1;
            lv_categories.BeginUpdate();
            lv_categories.Items.Clear();
            DataClassesFiltersDataContext db = new DataClassesFiltersDataContext();
            var data = from p in db.tab_filters
                        orderby p.name
                       select new { u1 = p.name, u2 = p.fix,id= p.id_tab_filters};
            foreach (var item in data)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.u1;
                lvi.SubItems.Add(item.u2.ToString());
                
                lvi.Tag = item.id;
                lv_tabs.Items.Add(lvi);
                if (id == item.id)
                {
                    index = lvi.Index;

                }
            }
            lv_categories.EndUpdate();
            if (index != -1)
            {
                lv_tabs.Items[index].Selected = true;
                lv_tabs.Select();

            }

        }

        private void btn_tab_edit_Click(object sender, EventArgs e)
        {

            FormTabAdd frm = new FormTabAdd();
            ListViewItem lvi = lv_tabs.SelectedItems[0];
            if (lvi != null)
            {
                frm.id = Convert.ToInt32(lvi.Tag.ToString());
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                show_tabs(frm.id);
            }

        }

        private void btn_tab_del_Click(object sender, EventArgs e)
        {
            int id = -1;

            if (lv_tabs.Items.Count == 0) {
                return;
            }

            if (CRMHelper.Question(@"Question", @"Delete selected items ?") == DialogResult.OK)
            {

                ListViewItem lvi = lv_tabs.SelectedItems[0];
                if (lvi != null)
                {
                    id = Convert.ToInt32(lvi.Tag.ToString());
                }
                else
                {
                    CRMHelper.Information(@"Information", @"Cant delete selected items!");
                    return;
                }
                if (id != -1)
                {
                    DataClassesFiltersDataContext db = new DataClassesFiltersDataContext();
                    var cat = db.tab_filters.FirstOrDefault(d => d.id_tab_filters == id);
                    if (cat != null)
                    {
                        db.tab_filters.DeleteOnSubmit(cat);
                        // zapisujemy zmiany
                        db.SubmitChanges();
                        show_tabs(-1);

                    }
                }
                else
                {
                    CRMHelper.Information(@"Information", @"Cant delete selected items!");
                    return;
                }
            }

        }
    }
}
