namespace CRM
{
    partial class FrmCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.pl_filter = new System.Windows.Forms.Panel();
            this.pl_button = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_edit = new System.Windows.Forms.ToolStripButton();
            this.tsb_view = new System.Windows.Forms.ToolStripButton();
            this.dg_customers = new System.Windows.Forms.DataGridView();
            this.lv_customers = new System.Windows.Forms.ListView();
            this.column_first_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_last_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_nationality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pl_button.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_filter
            // 
            this.pl_filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_filter.Location = new System.Drawing.Point(0, 0);
            this.pl_filter.Name = "pl_filter";
            this.pl_filter.Padding = new System.Windows.Forms.Padding(3);
            this.pl_filter.Size = new System.Drawing.Size(782, 49);
            this.pl_filter.TabIndex = 0;
            // 
            // pl_button
            // 
            this.pl_button.Controls.Add(this.toolStrip1);
            this.pl_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_button.Location = new System.Drawing.Point(0, 49);
            this.pl_button.Name = "pl_button";
            this.pl_button.Size = new System.Drawing.Size(782, 43);
            this.pl_button.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_edit,
            this.tsb_view});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 43);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsb_add
            // 
            this.tsb_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(33, 40);
            this.tsb_add.Text = "Add";
            this.tsb_add.Click += new System.EventHandler(this.tsb_add_Click);
            // 
            // tsb_edit
            // 
            this.tsb_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_edit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_edit.Image")));
            this.tsb_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_edit.Name = "tsb_edit";
            this.tsb_edit.Size = new System.Drawing.Size(31, 40);
            this.tsb_edit.Text = "Edit";
            this.tsb_edit.Click += new System.EventHandler(this.tsb_edit_Click);
            // 
            // tsb_view
            // 
            this.tsb_view.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_view.Image = ((System.Drawing.Image)(resources.GetObject("tsb_view.Image")));
            this.tsb_view.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_view.Name = "tsb_view";
            this.tsb_view.Size = new System.Drawing.Size(36, 40);
            this.tsb_view.Text = "View";
            // 
            // dg_customers
            // 
            this.dg_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_customers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_customers.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dg_customers.Location = new System.Drawing.Point(0, 92);
            this.dg_customers.MultiSelect = false;
            this.dg_customers.Name = "dg_customers";
            this.dg_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_customers.Size = new System.Drawing.Size(782, 404);
            this.dg_customers.TabIndex = 2;
            // 
            // lv_customers
            // 
            this.lv_customers.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_customers.AllowColumnReorder = true;
            this.lv_customers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lv_customers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_first_name,
            this.column_last_name,
            this.column_nationality,
            this.column_state,
            this.column_city,
            this.column_street,
            this.column_no,
            this.column_dob});
            this.lv_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_customers.FullRowSelect = true;
            this.lv_customers.GridLines = true;
            this.lv_customers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_customers.Location = new System.Drawing.Point(0, 92);
            this.lv_customers.Name = "lv_customers";
            this.lv_customers.ShowGroups = false;
            this.lv_customers.Size = new System.Drawing.Size(782, 404);
            this.lv_customers.TabIndex = 3;
            this.lv_customers.UseCompatibleStateImageBehavior = false;
            this.lv_customers.View = System.Windows.Forms.View.Details;
            this.lv_customers.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lv_customers_DrawColumnHeader);
            this.lv_customers.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lv_customers_DrawItem);
            this.lv_customers.DoubleClick += new System.EventHandler(this.lv_customers_DoubleClick);
            // 
            // column_first_name
            // 
            this.column_first_name.Text = "First Name";
            this.column_first_name.Width = 100;
            // 
            // column_last_name
            // 
            this.column_last_name.Text = "Last Name";
            this.column_last_name.Width = 100;
            // 
            // column_nationality
            // 
            this.column_nationality.Text = "Nationality";
            // 
            // column_state
            // 
            this.column_state.Text = "State";
            this.column_state.Width = 100;
            // 
            // column_city
            // 
            this.column_city.Text = "City";
            this.column_city.Width = 100;
            // 
            // column_street
            // 
            this.column_street.Text = "Street";
            this.column_street.Width = 100;
            // 
            // column_no
            // 
            this.column_no.Text = "No";
            // 
            // column_dob
            // 
            this.column_dob.Text = "Date of birth";
            this.column_dob.Width = 100;
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 496);
            this.Controls.Add(this.lv_customers);
            this.Controls.Add(this.dg_customers);
            this.Controls.Add(this.pl_button);
            this.Controls.Add(this.pl_filter);
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.pl_button.ResumeLayout(false);
            this.pl_button.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_filter;
        private System.Windows.Forms.Panel pl_button;
        private System.Windows.Forms.DataGridView dg_customers;
       
       
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.ToolStripButton tsb_edit;
        private System.Windows.Forms.ToolStripButton tsb_view;
        private System.Windows.Forms.ListView lv_customers;
        private System.Windows.Forms.ColumnHeader column_last_name;
        private System.Windows.Forms.ColumnHeader column_nationality;
        private System.Windows.Forms.ColumnHeader column_state;
        private System.Windows.Forms.ColumnHeader column_city;
        private System.Windows.Forms.ColumnHeader column_street;
        private System.Windows.Forms.ColumnHeader column_no;
        private System.Windows.Forms.ColumnHeader column_dob;
        public System.Windows.Forms.ColumnHeader column_first_name;
    }
}