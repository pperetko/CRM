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
            shows_categories_subitems(-1);
            ShowFilters(-1);
            set_enabled_sub_buttons(false);
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
                       from tbs in db.tab_filters
                       where p.id_categories_types == t.id_categories_types && p.id_tab_filters == tbs.id_tab_filters
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
            if (lv_categories.Items.Count > 0)
            {
                if (lv_categories.SelectedItems.Count > 0) { 
                  ListViewItem lvi = lv_categories.SelectedItems[0];
                  frm.id = Convert.ToInt32(lvi.Tag.ToString());
                  frm.ShowDialog();
                  if (frm.DialogResult == DialogResult.OK)
                   {
                        show_category(frm.id);
                   }
                }
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
                if (lv_categories.Items.Count > 0)
                {
                    ListViewItem lvi = lv_categories.SelectedItems[0];
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
            lv_tabs.BeginUpdate();
            lv_tabs.Items.Clear();
            DataClassesFiltersDataContext db = new DataClassesFiltersDataContext();
            var data = from p in db.tab_filters
                       orderby p.name
                       select new { u1 = p.name, u2 = p.fix, id = p.id_tab_filters };
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
            lv_tabs.EndUpdate();
            if (index != -1)
            {
                lv_tabs.Items[index].Selected = true;
                lv_tabs.Select();

            }
        }

        /// <summary>
        /// The btn_tab_edit_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btn_tab_edit_Click(object sender, EventArgs e)
        {

            FormTabAdd frm = new FormTabAdd();
            if (lv_tabs.Items.Count > 0)
            {
                if (lv_tabs.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = lv_tabs.SelectedItems[0];
                    frm.id = Convert.ToInt32(lvi.Tag.ToString());
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        show_tabs(frm.id);
                    }
                }
            }
            
        }

        /// <summary>
        /// The btn_tab_del_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btn_tab_del_Click(object sender, EventArgs e)
        {
            int id = -1;

            if (lv_tabs.Items.Count == 0)
            {
                return;
            }

            if (CRMHelper.Question(@"Question", @"Delete selected items ?") == DialogResult.OK)
            {
                if (lv_tabs.Items.Count > 0)
                {
                    ListViewItem lvi = lv_tabs.SelectedItems[0];
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

        /// <summary>
        /// The set_enabled_sub_buttons
        /// </summary>
        /// <param name="enabled">The enabled<see cref="bool"/></param>
        private void set_enabled_sub_buttons(bool enabled)
        {
            btn_categories_sub_add.Enabled = enabled;
            btn_categories_sub_del.Enabled = enabled;
            btn_categories_sub_edit.Enabled = enabled;
        }

        /// <summary>
        /// The lv_categories_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void lv_categories_Click(object sender, EventArgs e)
        {
            set_enabled_sub_buttons(false);
            if (lv_categories.Items.Count > 0)
            {
                ListViewItem lvi = lv_categories.SelectedItems[0];
                if (lvi != null)
                {
                    if ((lvi.SubItems[2].Text == @"Combo Box") || (lvi.SubItems[2].Text == @"List Check Box"))
                    {
                        set_enabled_sub_buttons(true);
                    }
                }
            }
        }

        //-------------------Categories subitems
        /// <summary>
        /// The btn_categories_sub_add_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btn_categories_sub_add_Click(object sender, EventArgs e)
        {
            FormCategoriesSubAdd frm = new FormCategoriesSubAdd();
            frm.id = -1;
            if (lv_categories.Items.Count > 0)
            {
                ListViewItem lvi = lv_categories.SelectedItems[0];
                frm.id_category = Convert.ToInt32(lvi.Tag.ToString());
            }

            frm.ShowDialog();

            if (lv_categories.Items.Count > 0)
            {
                ListViewItem lvi = lv_categories.SelectedItems[0];
                shows_categories_subitems(Convert.ToInt32(lvi.Tag.ToString()));
            }
        }

        /// <summary>
        /// The btn_categories_sub_edit_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btn_categories_sub_edit_Click(object sender, EventArgs e)
        {
            FormCategoriesSubAdd frm = new FormCategoriesSubAdd();
            if (lv_categories_sub.Items.Count > 0)
            {
                ListViewItem lvi = lv_categories_sub.SelectedItems[0];
                frm.id = Convert.ToInt32(lvi.Tag.ToString());
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                shows_categories_subitems(frm.id);
            }
            if (lv_categories.Items.Count > 0)
            {
                ListViewItem lvi = lv_categories.SelectedItems[0];
                shows_categories_subitems(Convert.ToInt32(lvi.Tag.ToString()));
            }

        }

        /// <summary>
        /// The shows_categories_subitems
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        private void shows_categories_subitems(int id)
        {
            int index = -1;
            lv_categories_sub.BeginUpdate();
            lv_categories_sub.Items.Clear();
            DataClassesFiltersDataContext db = new DataClassesFiltersDataContext();
            var data = from p in db.category_subs
                       where p.id_category==id
                       orderby p.name
                       select new { u1 = p.name, u2 = p.show_on_list, id = p.id_category_sub };
            foreach (var item in data)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.u1;
                lvi.SubItems.Add(item.u2.ToString());

                lvi.Tag = item.id;
                lv_categories_sub.Items.Add(lvi);
                if (id == item.id)
                {
                    index = lvi.Index;

                }
            }
            lv_categories_sub.EndUpdate();
            if (index != -1)
            {
                lv_categories_sub.Items[index].Selected = true;
                lv_categories_sub.Select();

            }
        }

        /// <summary>
        /// The btn_categories_sub_del_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btn_categories_sub_del_Click(object sender, EventArgs e)
        {

            int id = -1;

            if (lv_tabs.Items.Count == 0)
            {
                return;
            }

            if (CRMHelper.Question(@"Question", @"Delete selected items ?") == DialogResult.OK)
            {
                if (lv_categories_sub.Items.Count > 0)
                {
                    ListViewItem lvi = lv_categories_sub.SelectedItems[0];
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
                    var cat = db.category_subs.FirstOrDefault(d => d.id_category_sub == id);
                    if (cat != null)
                    {
                        db.category_subs.DeleteOnSubmit(cat);
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

        private void lv_categories_DoubleClick(object sender, EventArgs e)
        {
            if (lv_categories.Items.Count > 0) {
                ListViewItem lvi = lv_categories.SelectedItems[0];
                shows_categories_subitems(Convert.ToInt32(lvi.Tag.ToString()));
            }
        }

        //FILTERS  Definition --------------------------------------------------------------------------------------
        //BTN ADD
        private void btn_filters_add_Click(object sender, EventArgs e)
        {
            FormFiltersAdd form = new FormFiltersAdd();
            form.id= -1;
            form.ShowDialog();
            ShowFilters(form.id);

        }


        /// <summary>
        /// Function shows filters on list
        /// </summary>
        /// <param name="id"></param>

        private void ShowFilters(int id)
        {
            int index = -1;
            lv_filters.BeginUpdate();
            lv_filters.Items.Clear();
            DataClassesFiltersDataContext db = new DataClassesFiltersDataContext();
            var data = from p in db.filters
                       
                       
                       orderby p.name
                       select new { u1 = p.name, u2 = p.index, u3=p.id_filters};
            foreach (var item in data)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.u1;
                lvi.SubItems.Add(item.u2.ToString());
                lvi.Tag = item.u3;
                lv_filters.Items.Add(lvi);
                if (id == item.u3)
                {
                    index = lvi.Index;

                }
            }
            lv_filters.EndUpdate();
            if (index != -1)
            {
                lv_filters.Items[index].Selected = true;
                lv_filters.Select();

            }



        }

        private void btn_filters_edit_Click(object sender, EventArgs e)
        {

            FormFiltersAdd form = new FormFiltersAdd();
            if (lv_filters.Items.Count > 0) {
                if (lv_filters.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = lv_filters.SelectedItems[0];
                    form.id = Convert.ToInt32(lvi.Tag);
                    form.ShowDialog();
                    ShowFilters(form.id);

                }
            }
            
        }
    }
}
