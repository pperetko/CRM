namespace CRM
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="FormCategoriesSubAdd" />
    /// </summary>
    public partial class FormCategoriesSubAdd : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormCategoriesSubAdd"/> class.
        /// </summary>
        public FormCategoriesSubAdd()
        {
            InitializeComponent();
            id = -1;
        }

        /// <summary>
        /// Defines the change
        /// </summary>
        private bool change = false;

        /// <summary>
        /// Defines the id
        /// </summary>
        public int id;

        /// <summary>
        /// Gets or sets the id_category
        /// </summary>
        public int id_category;
        

        /// <summary>
        /// The ValidateFields
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        private bool ValidateFields()
        {
            bool res = true;

            if (tb_cat_sub_name.Text == @"")
            {
                res = false;
                CRMHelper.Information(@"Error", @"This field cant be empty!");
            }

            return res;
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
                DataClassesFiltersDataContext dc = new DataClassesFiltersDataContext();
                if ((change == true) && (id != -1))
                {
                    var cat = dc.category_subs.FirstOrDefault(d => d.id_category == id);
                    if (cat != null)
                    {
                        cat.name = tb_cat_sub_name.Text;
                        cat.show_on_list = cbx_cat_sub_show_on_list.Checked;
                    }
                    dc.SubmitChanges();
                }

                else if (id == -1)
                {
                    category_sub cat = new category_sub();
                    cat.name = tb_cat_sub_name.Text;
                    cat.id_category = id_category;
                    cat.show_on_list = cbx_cat_sub_show_on_list.Checked;
                    dc.category_subs.InsertOnSubmit(cat);
                    dc.SubmitChanges();
                    id = Convert.ToInt32( cat.id_category);

                }
            }
        }

        /// <summary>
        /// The SetCatSubValues
        /// </summary>
        private void SetCatSubValues()
        {
            DataClassesFiltersDataContext db = new DataClassesFiltersDataContext();
            var data = from p in db.category_subs
                       where p.id_category_sub == id
                       orderby p.name
                       select p;

            if (data != null)
            {
                foreach (var item in data)
                {

                    tb_cat_sub_name.Text = item.name;
                    if (item.show_on_list == true)
                    {
                        cbx_cat_sub_show_on_list.Checked = true;
                    }
                    else
                    {
                        cbx_cat_sub_show_on_list.Checked = false;
                    }
                }
            }
        }

        private void FormCategoriesSubAdd_Load(object sender, EventArgs e)
        {
            if (id != -1) {
                SetCatSubValues();
            }
        }
    }
}
