namespace CRM
{
    partial class FormFiltersAdd
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
            this.lbl_filter_name = new System.Windows.Forms.Label();
            this.tb_filters_name = new System.Windows.Forms.TextBox();
            this.lv_filters = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tc_categories = new System.Windows.Forms.TabControl();
            this.tp_aviable_categories = new System.Windows.Forms.TabPage();
            this.lv_aviable_categories = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_filters_left = new System.Windows.Forms.Button();
            this.btn_filters_right = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_filters_categories = new System.Windows.Forms.Label();
            this.tc_categories.SuspendLayout();
            this.tp_aviable_categories.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_filter_name
            // 
            this.lbl_filter_name.AutoSize = true;
            this.lbl_filter_name.Location = new System.Drawing.Point(11, 25);
            this.lbl_filter_name.Name = "lbl_filter_name";
            this.lbl_filter_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_filter_name.TabIndex = 0;
            this.lbl_filter_name.Text = "Name";
            // 
            // tb_filters_name
            // 
            this.tb_filters_name.Location = new System.Drawing.Point(52, 22);
            this.tb_filters_name.Name = "tb_filters_name";
            this.tb_filters_name.Size = new System.Drawing.Size(325, 20);
            this.tb_filters_name.TabIndex = 1;
            // 
            // lv_filters
            // 
            this.lv_filters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_filters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_filters.FullRowSelect = true;
            this.lv_filters.GridLines = true;
            this.lv_filters.HideSelection = false;
            this.lv_filters.Location = new System.Drawing.Point(12, 75);
            this.lv_filters.MultiSelect = false;
            this.lv_filters.Name = "lv_filters";
            this.lv_filters.Size = new System.Drawing.Size(386, 574);
            this.lv_filters.TabIndex = 12;
            this.lv_filters.UseCompatibleStateImageBehavior = false;
            this.lv_filters.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 173;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 134;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Show on list";
            this.columnHeader7.Width = 123;
            // 
            // tc_categories
            // 
            this.tc_categories.Controls.Add(this.tp_aviable_categories);
            this.tc_categories.Location = new System.Drawing.Point(467, 75);
            this.tc_categories.Name = "tc_categories";
            this.tc_categories.SelectedIndex = 0;
            this.tc_categories.Size = new System.Drawing.Size(445, 574);
            this.tc_categories.TabIndex = 13;
            // 
            // tp_aviable_categories
            // 
            this.tp_aviable_categories.Controls.Add(this.lv_aviable_categories);
            this.tp_aviable_categories.Location = new System.Drawing.Point(4, 22);
            this.tp_aviable_categories.Name = "tp_aviable_categories";
            this.tp_aviable_categories.Padding = new System.Windows.Forms.Padding(3);
            this.tp_aviable_categories.Size = new System.Drawing.Size(437, 548);
            this.tp_aviable_categories.TabIndex = 0;
            this.tp_aviable_categories.Text = "Aviable categories";
            this.tp_aviable_categories.UseVisualStyleBackColor = true;
            // 
            // lv_aviable_categories
            // 
            this.lv_aviable_categories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_aviable_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_aviable_categories.FullRowSelect = true;
            this.lv_aviable_categories.GridLines = true;
            this.lv_aviable_categories.HideSelection = false;
            this.lv_aviable_categories.Location = new System.Drawing.Point(3, 3);
            this.lv_aviable_categories.MultiSelect = false;
            this.lv_aviable_categories.Name = "lv_aviable_categories";
            this.lv_aviable_categories.Size = new System.Drawing.Size(431, 542);
            this.lv_aviable_categories.TabIndex = 13;
            this.lv_aviable_categories.UseCompatibleStateImageBehavior = false;
            this.lv_aviable_categories.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 173;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Show on list";
            this.columnHeader3.Width = 123;
            // 
            // btn_filters_left
            // 
            this.btn_filters_left.Location = new System.Drawing.Point(417, 76);
            this.btn_filters_left.Name = "btn_filters_left";
            this.btn_filters_left.Size = new System.Drawing.Size(34, 47);
            this.btn_filters_left.TabIndex = 14;
            this.btn_filters_left.Text = "<<";
            this.btn_filters_left.UseVisualStyleBackColor = true;
            this.btn_filters_left.Click += new System.EventHandler(this.Btn_filters_left_Click);
            // 
            // btn_filters_right
            // 
            this.btn_filters_right.Location = new System.Drawing.Point(417, 129);
            this.btn_filters_right.Name = "btn_filters_right";
            this.btn_filters_right.Size = new System.Drawing.Size(34, 47);
            this.btn_filters_right.TabIndex = 15;
            this.btn_filters_right.Text = ">>";
            this.btn_filters_right.UseVisualStyleBackColor = true;
            this.btn_filters_right.Click += new System.EventHandler(this.Btn_filters_right_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(756, 661);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 16;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(837, 661);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_filters_categories
            // 
            this.lbl_filters_categories.AutoSize = true;
            this.lbl_filters_categories.Location = new System.Drawing.Point(12, 59);
            this.lbl_filters_categories.Name = "lbl_filters_categories";
            this.lbl_filters_categories.Size = new System.Drawing.Size(57, 13);
            this.lbl_filters_categories.TabIndex = 18;
            this.lbl_filters_categories.Text = "Categories";
            // 
            // FormFiltersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 696);
            this.Controls.Add(this.lbl_filters_categories);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_filters_right);
            this.Controls.Add(this.btn_filters_left);
            this.Controls.Add(this.tc_categories);
            this.Controls.Add(this.lv_filters);
            this.Controls.Add(this.tb_filters_name);
            this.Controls.Add(this.lbl_filter_name);
            this.Name = "FormFiltersAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filter Definition";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFiltersAdd_FormClosed);
            this.Load += new System.EventHandler(this.FormFiltersAdd_Load);
            this.tc_categories.ResumeLayout(false);
            this.tp_aviable_categories.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_filter_name;
        private System.Windows.Forms.TextBox tb_filters_name;
        private System.Windows.Forms.ListView lv_filters;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabControl tc_categories;
        private System.Windows.Forms.TabPage tp_aviable_categories;
        private System.Windows.Forms.Button btn_filters_left;
        private System.Windows.Forms.Button btn_filters_right;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_filters_categories;
        private System.Windows.Forms.ListView lv_aviable_categories;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}