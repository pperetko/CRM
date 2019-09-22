namespace CRM
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="FrmCustomers" />
    /// </summary>
    public partial class FrmCustomers : Form
    {
        /// <summary>
        /// Defines the id
        /// </summary>
        public int id;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmCustomers"/> class.
        /// </summary>
        public FrmCustomers()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The FrmCustomers_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            CreateFiltersPanels();
            LoadCustomers();
        }

        /// <summary>
        /// The tsb_add_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void tsb_add_Click(object sender, EventArgs e)
        {
            FrmCustomerAddModify form = new FrmCustomerAddModify();
            form.id_customer = -1;
            form.ShowDialog(this);
            if (form.DialogResult == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        /// <summary>
        /// The tsb_edit_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void tsb_edit_Click(object sender, EventArgs e)
        {
            FrmCustomerAddModify form = new FrmCustomerAddModify();
            if (lv_customers.Items.Count > 0)
            {
                ListViewItem lvi = lv_customers.SelectedItems[0];
                if (lvi != null)
                {
                    form.setid(Convert.ToInt32(lvi.Tag.ToString()));
                    form.ShowDialog(this);
                    if (form.DialogResult == DialogResult.OK)
                    {
                        RefreshSelectedRow();
                    }
                }
            }
        }

        /// <summary>
        /// The LoadCustomers
        /// </summary>
        private void LoadCustomers()
        {
            lv_customers.BeginUpdate();
            lv_customers.Items.Clear();
            DataClassesCRMDataContext db = new DataClassesCRMDataContext();
            var data = from p in db.customers

                       orderby p.id_customers
                       select p;
            foreach (var item in data)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.first_name;
                lvi.SubItems.Add(item.last_name);
                lvi.SubItems.Add(item.nationality);
                lvi.SubItems.Add(item.state);
                lvi.SubItems.Add(item.city);
                lvi.SubItems.Add(item.street);
                lvi.SubItems.Add(item.No);
                lvi.SubItems.Add(item.dob.ToString());
                lvi.Tag = item.id_customers;
                lv_customers.Items.Add(lvi);
            }
            lv_customers.EndUpdate();
        }

        /// <summary>
        /// The lv_customers_DrawColumnHeader
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="DrawListViewColumnHeaderEventArgs"/></param>
        private void lv_customers_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            string text = lv_customers.Columns[e.ColumnIndex].Text;
            switch (e.ColumnIndex)
            {
                case 0:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 1:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 2:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 3:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 4:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 5:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 6:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 7:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
                case 8:
                    e.Graphics.DrawString(text, lv_customers.Font,
                        Brushes.Aquamarine, e.Bounds);
                    break;
            }
        }

        /// <summary>
        /// The lv_customers_DrawItem
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="DrawListViewItemEventArgs"/></param>
        private void lv_customers_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
        }

        /// <summary>
        /// The lv_customers_DoubleClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void lv_customers_DoubleClick(object sender, EventArgs e)
        {
            tsb_edit_Click(sender, e);
        }

        /// <summary>
        /// The RefreshSelectedRow
        /// </summary>
        private void RefreshSelectedRow()
        {
            ListViewItem lvi = lv_customers.SelectedItems[0];
            if (lvi != null)
            {
                DataClassesCRMDataContext dc = new DataClassesCRMDataContext();
                var cust = dc.customers.FirstOrDefault(d => d.id_customers == Convert.ToInt32(lvi.Tag.ToString()));
                if (cust != null)
                {
                    lvi.Text = cust.first_name;
                    lvi.SubItems[1].Text = cust.last_name;
                    lvi.SubItems[2].Text = cust.nationality;
                    lvi.SubItems[3].Text = cust.state;
                    lvi.SubItems[4].Text = cust.city;
                    lvi.SubItems[5].Text = cust.street;
                    lvi.SubItems[6].Text = cust.No;
                    lvi.SubItems[7].Text = cust.dob.ToString();
                }
            }
        }

        //------------------------------------------------ Add dynamicaly filters -------------------------------------------------------
        /// <summary>
        /// The CreateComponentsFilters
        /// </summary>
        /// <param name="id">The id<see cref="long"/></param>
        private void CreateComponentsFilters(long id)
        {
            int top_ = 5;
            int left_ = 5;
            DataClassesFiltersDataContext db = new DataClassesFiltersDataContext();
            var data = from p in db.filters
                       from cf in db.category_filters
                       from c in db.categories
                       from tp in db.categories_types
                       where p.id_filters==cf.id_filter &&
                             c.id_category==cf.id_category &&
                             tp.id_categories_types ==c.id_categories_types && 
                             p.active == true && 
                             p.id_filters==id
                             orderby p.index
                       select new { u1 = tp.id_categories_types, u2 = tp.alias , u3 = p.id_filters, u4 = c.name, u5= c.id_category};
            

            foreach (var item in data)
            {
                //text component
                if (item.u2==1) {
                    var lbl = new Label();
                    lbl.Text = item.u4;
                    pl_filter.Controls.Add(lbl);
                    lbl.Left = left_ + 3;
                    lbl.Top = top_;
                    lbl.Width = 70;



                    var text = new MaskedTextBox();
                    pl_filter.Controls.Add(text);
                    text.Top = top_;
                    text.Left = lbl.Width + 10;
                    left_ = text.Left;
                    text.Width = 100;

                    var pl = new Panel();
                    pl_filter.Controls.Add(pl);
                    pl.Top = top_ - 2;
                    pl.Height = pl_filter.Height / 2;
                    pl.Width = 2;
                    pl.BackColor = Color.Red;
                    pl.Left = text.Left + text.Width + 10;
                    left_ = pl.Left;



                }


                //Combo box
                if (item.u2==2 ) {
                    //Create label
                    var lbl = new Label();
                    lbl.Text = item.u4;
                    pl_filter.Controls.Add(lbl);
                    lbl.Left = left_+3;
                    lbl.Top = top_;
                    lbl.Width = 70;

                    var combo = new WindowsFormsControlLibraryCRM.CRMComboBox();
                    pl_filter.Controls.Add(combo);
                    combo.Top = top_;
                    combo.Left = lbl.Width + 10;
                    left_ = combo.Left;
                    combo.Width = 100;
                    ComboBoxAddValues(item.u5, combo);


                    var pl = new Panel();
                    pl_filter.Controls.Add(pl);
                    pl.Top = top_-2;
                    pl.Height = pl_filter.Height /2;
                    pl.Width = 2;
                    pl.BackColor = Color.Red;
                    pl.Left = combo.Left + combo.Width + 10;
                    left_ = pl.Left;


                }



                //Check box
                //Numerical component
                







            }

        }


        private void ComboBoxAddValues(int id_category, object combo) {



        }



        /// <summary>
        /// The CreateFiltersPanels
        /// </summary>
        private void CreateFiltersPanels()
        {
            DataClassesFiltersDataContext db = new DataClassesFiltersDataContext();
            var data = from p in db.filters
                       where p.active == true
                       orderby p.index
                       select new { u1 = p.name, u2 = p.index, u3 = p.id_filters };
            foreach (var item in data)
            {
                CreateComponentsFilters(item.u3);

            }
        }
    }
}
