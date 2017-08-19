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
            this.components = new System.ComponentModel.Container();
            this.pl_filter = new System.Windows.Forms.Panel();
            this.pl_button = new System.Windows.Forms.Panel();
            this.dg_customers = new System.Windows.Forms.DataGridView();
            this.cRMDataSet_customers = new CRM.CRMDataSet_customers();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new CRM.CRMDataSet_customersTableAdapters.CustomersTableAdapter();
            this.idcustomersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
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
            this.pl_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_button.Location = new System.Drawing.Point(0, 49);
            this.pl_button.Name = "pl_button";
            this.pl_button.Size = new System.Drawing.Size(782, 43);
            this.pl_button.TabIndex = 1;
            // 
            // dg_customers
            // 
            this.dg_customers.AutoGenerateColumns = false;
            this.dg_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcustomersDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.prenameDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn});
            this.dg_customers.DataSource = this.customersBindingSource;
            this.dg_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_customers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_customers.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dg_customers.Location = new System.Drawing.Point(0, 92);
            this.dg_customers.Name = "dg_customers";
            this.dg_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_customers.Size = new System.Drawing.Size(782, 404);
            this.dg_customers.TabIndex = 2;
            this.dg_customers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_customers_CellContentClick);
            // 
            // cRMDataSet_customers
            // 
            this.cRMDataSet_customers.DataSetName = "CRMDataSet_customers";
            this.cRMDataSet_customers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.cRMDataSet_customers;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // idcustomersDataGridViewTextBoxColumn
            // 
            this.idcustomersDataGridViewTextBoxColumn.DataPropertyName = "id_customers";
            this.idcustomersDataGridViewTextBoxColumn.HeaderText = "id_customers";
            this.idcustomersDataGridViewTextBoxColumn.Name = "idcustomersDataGridViewTextBoxColumn";
            this.idcustomersDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcustomersDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // prenameDataGridViewTextBoxColumn
            // 
            this.prenameDataGridViewTextBoxColumn.DataPropertyName = "Prename";
            this.prenameDataGridViewTextBoxColumn.HeaderText = "Prename";
            this.prenameDataGridViewTextBoxColumn.Name = "prenameDataGridViewTextBoxColumn";
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 496);
            this.Controls.Add(this.dg_customers);
            this.Controls.Add(this.pl_button);
            this.Controls.Add(this.pl_filter);
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_filter;
        private System.Windows.Forms.Panel pl_button;
        private System.Windows.Forms.DataGridView dg_customers;
        private CRMDataSet_customers cRMDataSet_customers;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CRMDataSet_customersTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
    }
}