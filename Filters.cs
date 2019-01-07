namespace CRM
{
    using System;
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
        }

        /// <summary>
        /// The btn_add_tab_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btn_add_tab_Click(object sender, EventArgs e)
        {
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
        }
    }
}
