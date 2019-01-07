﻿namespace CRM
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="FormCategoriesAdd" />
    /// </summary>
    public partial class FormCategoriesAdd : Form
    {
        /// <summary>
        /// Defines the id
        /// </summary>
        public int id;

        /// <summary>
        /// Defines the change
        /// </summary>
        private bool change;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormCategoriesAdd"/> class.
        /// </summary>
        public FormCategoriesAdd()
        {
            InitializeComponent();
            id = -1;
            change = false;
        }

        /// <summary>
        /// The FormCategoriesAdd_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void FormCategoriesAdd_Load(object sender, EventArgs e)
        {
            SetCategoriesValues();
            if (id != -1)
            {
                DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
                var cat = dc.categories.FirstOrDefault(d => d.id_categories == id);
                tb_cat_name.Text = CRMHelper.NullToString(cat.name);
                cb_cat_type.SetID(Convert.ToInt64(cat.id_field));
                cbx_cat_show_on_list.Checked = cat.show_on_list;

            }
        }

        /// <summary>
        /// The SetCategoriesValues
        /// </summary>
        private void SetCategoriesValues()
        {
            DataClassesCRMDataContext db = new DataClassesCRMDataContext();
            var data = from p in db.categories_types
                       where p.show_on_list == true
                       orderby p.id_categories_types
                       select p;
            foreach (var item in data)
            {

                cb_cat_type.AddItem(item.name, item.id_categories_types);

            }
        }

        /// <summary>
        /// The ValidateFields
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        private bool ValidateFields()
        {
            bool res = true;
            if (tb_cat_name.Text.ToString() == @"")
            {
                CRMHelper.Information(@"Error!", @"This field cant be empty!");
                res = false;
            }

            if (res == true)
            {
                if (cb_cat_type.Text.ToString() == @"")
                {
                    CRMHelper.Information(@"Error!", @"This field cant be empty!");
                    res = false;
                }

            }
            return res;
        }

        /// <summary>
        /// The tb_cat_name_TextChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void tb_cat_name_TextChanged(object sender, EventArgs e)
        {
            change = true;
        }

        /// <summary>
        /// The cb_cat_type_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void cb_cat_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            change = true;
        }

        /// <summary>
        /// The cbx_cat_show_on_list_CheckedChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void cbx_cat_show_on_list_CheckedChanged(object sender, EventArgs e)
        {
            change = true;
        }

        /// <summary>
        /// The btn_ok_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (ValidateFields() == true)
            {
                DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
                if ((change == true) && (id != -1))
                {
                    var cat = dc.categories.FirstOrDefault(d => d.id_categories == id);
                    if (cat != null)
                    {
                        cat.name = tb_cat_name.Text;
                        if (cb_cat_type.SelectedIndex != -1)
                        {
                            cat.id_field = Convert.ToInt32(cb_cat_type.GetID());
                        }
                        cat.show_on_list = cbx_cat_show_on_list.Checked;
                    }
                    dc.SubmitChanges();

                }

                else if (id == -1)
                {
                    category cat = new category();
                    cat.name = tb_cat_name.Text;
                    if (cb_cat_type.SelectedIndex != -1)
                    {
                        cat.id_field = Convert.ToInt32(cb_cat_type.GetID());
                    }
                    cat.show_on_list = cbx_cat_show_on_list.Checked;
                    dc.categories.InsertOnSubmit(cat);
                    dc.SubmitChanges();
                    id = cat.id_categories;

                }
            }
        }
    }
}
