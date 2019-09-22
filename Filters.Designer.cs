namespace CRM
{
    partial class Filters
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
            this.tc_main = new System.Windows.Forms.TabControl();
            this.ts_tab = new System.Windows.Forms.TabPage();
            this.lv_tabs = new System.Windows.Forms.ListView();
            this.c_tab_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_tab_fixed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_tab_del = new System.Windows.Forms.Button();
            this.btn_tab_edit = new System.Windows.Forms.Button();
            this.btn_add_tab = new System.Windows.Forms.Button();
            this.ts_categories = new System.Windows.Forms.TabPage();
            this.lv_categories_sub = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_categories_sub_del = new System.Windows.Forms.Button();
            this.btn_categories_sub_edit = new System.Windows.Forms.Button();
            this.btn_categories_sub_add = new System.Windows.Forms.Button();
            this.lv_categories = new System.Windows.Forms.ListView();
            this.column_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_tab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_show_on_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_cat_delete = new System.Windows.Forms.Button();
            this.btn_cat_edit = new System.Windows.Forms.Button();
            this.btn_cat_add = new System.Windows.Forms.Button();
            this.ts_filters = new System.Windows.Forms.TabPage();
            this.lv_filters = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_filters_delete = new System.Windows.Forms.Button();
            this.btn_filters_edit = new System.Windows.Forms.Button();
            this.btn_filters_add = new System.Windows.Forms.Button();
            this.tc_main.SuspendLayout();
            this.ts_tab.SuspendLayout();
            this.ts_categories.SuspendLayout();
            this.ts_filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.ts_tab);
            this.tc_main.Controls.Add(this.ts_categories);
            this.tc_main.Controls.Add(this.ts_filters);
            this.tc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_main.Location = new System.Drawing.Point(10, 10);
            this.tc_main.Margin = new System.Windows.Forms.Padding(10);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(879, 599);
            this.tc_main.TabIndex = 0;
            // 
            // ts_tab
            // 
            this.ts_tab.Controls.Add(this.lv_tabs);
            this.ts_tab.Controls.Add(this.btn_tab_del);
            this.ts_tab.Controls.Add(this.btn_tab_edit);
            this.ts_tab.Controls.Add(this.btn_add_tab);
            this.ts_tab.Location = new System.Drawing.Point(4, 22);
            this.ts_tab.Name = "ts_tab";
            this.ts_tab.Padding = new System.Windows.Forms.Padding(3);
            this.ts_tab.Size = new System.Drawing.Size(871, 573);
            this.ts_tab.TabIndex = 2;
            this.ts_tab.Text = "Tab";
            this.ts_tab.UseVisualStyleBackColor = true;
            // 
            // lv_tabs
            // 
            this.lv_tabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_tabs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_tab_name,
            this.c_tab_fixed});
            this.lv_tabs.FullRowSelect = true;
            this.lv_tabs.HideSelection = false;
            this.lv_tabs.Location = new System.Drawing.Point(17, 45);
            this.lv_tabs.Name = "lv_tabs";
            this.lv_tabs.Size = new System.Drawing.Size(341, 485);
            this.lv_tabs.TabIndex = 3;
            this.lv_tabs.UseCompatibleStateImageBehavior = false;
            this.lv_tabs.View = System.Windows.Forms.View.Details;
            // 
            // c_tab_name
            // 
            this.c_tab_name.Text = "Name";
            this.c_tab_name.Width = 300;
            // 
            // c_tab_fixed
            // 
            this.c_tab_fixed.Text = "Fixed";
            // 
            // btn_tab_del
            // 
            this.btn_tab_del.Location = new System.Drawing.Point(127, 16);
            this.btn_tab_del.Name = "btn_tab_del";
            this.btn_tab_del.Size = new System.Drawing.Size(49, 23);
            this.btn_tab_del.TabIndex = 2;
            this.btn_tab_del.Text = "Delete";
            this.btn_tab_del.UseVisualStyleBackColor = true;
            this.btn_tab_del.Click += new System.EventHandler(this.Btn_tab_del_Click);
            // 
            // btn_tab_edit
            // 
            this.btn_tab_edit.Location = new System.Drawing.Point(72, 16);
            this.btn_tab_edit.Name = "btn_tab_edit";
            this.btn_tab_edit.Size = new System.Drawing.Size(49, 23);
            this.btn_tab_edit.TabIndex = 1;
            this.btn_tab_edit.Text = "Edit";
            this.btn_tab_edit.UseVisualStyleBackColor = true;
            this.btn_tab_edit.Click += new System.EventHandler(this.Btn_tab_edit_Click);
            // 
            // btn_add_tab
            // 
            this.btn_add_tab.Location = new System.Drawing.Point(17, 16);
            this.btn_add_tab.Name = "btn_add_tab";
            this.btn_add_tab.Size = new System.Drawing.Size(49, 23);
            this.btn_add_tab.TabIndex = 0;
            this.btn_add_tab.Text = "Add";
            this.btn_add_tab.UseVisualStyleBackColor = true;
            this.btn_add_tab.Click += new System.EventHandler(this.Btn_add_tab_Click);
            // 
            // ts_categories
            // 
            this.ts_categories.BackColor = System.Drawing.Color.Transparent;
            this.ts_categories.Controls.Add(this.lv_categories_sub);
            this.ts_categories.Controls.Add(this.btn_categories_sub_del);
            this.ts_categories.Controls.Add(this.btn_categories_sub_edit);
            this.ts_categories.Controls.Add(this.btn_categories_sub_add);
            this.ts_categories.Controls.Add(this.lv_categories);
            this.ts_categories.Controls.Add(this.btn_cat_delete);
            this.ts_categories.Controls.Add(this.btn_cat_edit);
            this.ts_categories.Controls.Add(this.btn_cat_add);
            this.ts_categories.Location = new System.Drawing.Point(4, 22);
            this.ts_categories.Name = "ts_categories";
            this.ts_categories.Padding = new System.Windows.Forms.Padding(3);
            this.ts_categories.Size = new System.Drawing.Size(871, 573);
            this.ts_categories.TabIndex = 0;
            this.ts_categories.Text = "Categories";
            // 
            // lv_categories_sub
            // 
            this.lv_categories_sub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_categories_sub.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_categories_sub.FullRowSelect = true;
            this.lv_categories_sub.GridLines = true;
            this.lv_categories_sub.HideSelection = false;
            this.lv_categories_sub.Location = new System.Drawing.Point(399, 45);
            this.lv_categories_sub.MultiSelect = false;
            this.lv_categories_sub.Name = "lv_categories_sub";
            this.lv_categories_sub.Size = new System.Drawing.Size(365, 485);
            this.lv_categories_sub.TabIndex = 11;
            this.lv_categories_sub.UseCompatibleStateImageBehavior = false;
            this.lv_categories_sub.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 173;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tab";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Show On List";
            // 
            // btn_categories_sub_del
            // 
            this.btn_categories_sub_del.Location = new System.Drawing.Point(509, 16);
            this.btn_categories_sub_del.Name = "btn_categories_sub_del";
            this.btn_categories_sub_del.Size = new System.Drawing.Size(49, 23);
            this.btn_categories_sub_del.TabIndex = 10;
            this.btn_categories_sub_del.Text = "Delete";
            this.btn_categories_sub_del.UseVisualStyleBackColor = true;
            this.btn_categories_sub_del.Click += new System.EventHandler(this.Btn_categories_sub_del_Click);
            // 
            // btn_categories_sub_edit
            // 
            this.btn_categories_sub_edit.Location = new System.Drawing.Point(454, 16);
            this.btn_categories_sub_edit.Name = "btn_categories_sub_edit";
            this.btn_categories_sub_edit.Size = new System.Drawing.Size(49, 23);
            this.btn_categories_sub_edit.TabIndex = 9;
            this.btn_categories_sub_edit.Text = "Edit";
            this.btn_categories_sub_edit.UseVisualStyleBackColor = true;
            this.btn_categories_sub_edit.Click += new System.EventHandler(this.Btn_categories_sub_edit_Click);
            // 
            // btn_categories_sub_add
            // 
            this.btn_categories_sub_add.Location = new System.Drawing.Point(399, 16);
            this.btn_categories_sub_add.Name = "btn_categories_sub_add";
            this.btn_categories_sub_add.Size = new System.Drawing.Size(49, 23);
            this.btn_categories_sub_add.TabIndex = 8;
            this.btn_categories_sub_add.Text = "Add";
            this.btn_categories_sub_add.UseVisualStyleBackColor = true;
            this.btn_categories_sub_add.Click += new System.EventHandler(this.Btn_categories_sub_add_Click);
            // 
            // lv_categories
            // 
            this.lv_categories.AllowColumnReorder = true;
            this.lv_categories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_categories.BackColor = System.Drawing.SystemColors.Window;
            this.lv_categories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_name,
            this.column_tab,
            this.column_type,
            this.column_show_on_list});
            this.lv_categories.FullRowSelect = true;
            this.lv_categories.GridLines = true;
            this.lv_categories.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_categories.HideSelection = false;
            this.lv_categories.HoverSelection = true;
            this.lv_categories.Location = new System.Drawing.Point(17, 45);
            this.lv_categories.MultiSelect = false;
            this.lv_categories.Name = "lv_categories";
            this.lv_categories.Size = new System.Drawing.Size(365, 485);
            this.lv_categories.TabIndex = 7;
            this.lv_categories.UseCompatibleStateImageBehavior = false;
            this.lv_categories.View = System.Windows.Forms.View.Details;
            this.lv_categories.Click += new System.EventHandler(this.Lv_categories_Click);
            this.lv_categories.DoubleClick += new System.EventHandler(this.Lv_categories_DoubleClick);
            // 
            // column_name
            // 
            this.column_name.Text = "Name";
            this.column_name.Width = 173;
            // 
            // column_tab
            // 
            this.column_tab.Text = "Tab";
            this.column_tab.Width = 134;
            // 
            // column_type
            // 
            this.column_type.Text = "Type";
            this.column_type.Width = 123;
            // 
            // column_show_on_list
            // 
            this.column_show_on_list.Text = "Show On List";
            // 
            // btn_cat_delete
            // 
            this.btn_cat_delete.Location = new System.Drawing.Point(127, 16);
            this.btn_cat_delete.Name = "btn_cat_delete";
            this.btn_cat_delete.Size = new System.Drawing.Size(49, 23);
            this.btn_cat_delete.TabIndex = 6;
            this.btn_cat_delete.Text = "Delete";
            this.btn_cat_delete.UseVisualStyleBackColor = true;
            this.btn_cat_delete.Click += new System.EventHandler(this.Btn_cat_delete_Click);
            // 
            // btn_cat_edit
            // 
            this.btn_cat_edit.Location = new System.Drawing.Point(72, 16);
            this.btn_cat_edit.Name = "btn_cat_edit";
            this.btn_cat_edit.Size = new System.Drawing.Size(49, 23);
            this.btn_cat_edit.TabIndex = 5;
            this.btn_cat_edit.Text = "Edit";
            this.btn_cat_edit.UseVisualStyleBackColor = true;
            this.btn_cat_edit.Click += new System.EventHandler(this.Btn_cat_edit_Click);
            // 
            // btn_cat_add
            // 
            this.btn_cat_add.Location = new System.Drawing.Point(17, 16);
            this.btn_cat_add.Name = "btn_cat_add";
            this.btn_cat_add.Size = new System.Drawing.Size(49, 23);
            this.btn_cat_add.TabIndex = 4;
            this.btn_cat_add.Text = "Add";
            this.btn_cat_add.UseVisualStyleBackColor = true;
            this.btn_cat_add.Click += new System.EventHandler(this.Btn_cat_add_click);
            // 
            // ts_filters
            // 
            this.ts_filters.Controls.Add(this.lv_filters);
            this.ts_filters.Controls.Add(this.btn_filters_delete);
            this.ts_filters.Controls.Add(this.btn_filters_edit);
            this.ts_filters.Controls.Add(this.btn_filters_add);
            this.ts_filters.Location = new System.Drawing.Point(4, 22);
            this.ts_filters.Name = "ts_filters";
            this.ts_filters.Padding = new System.Windows.Forms.Padding(3);
            this.ts_filters.Size = new System.Drawing.Size(871, 573);
            this.ts_filters.TabIndex = 1;
            this.ts_filters.Text = "Filters";
            this.ts_filters.UseVisualStyleBackColor = true;
            // 
            // lv_filters
            // 
            this.lv_filters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_filters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lv_filters.FullRowSelect = true;
            this.lv_filters.GridLines = true;
            this.lv_filters.HideSelection = false;
            this.lv_filters.Location = new System.Drawing.Point(18, 45);
            this.lv_filters.MultiSelect = false;
            this.lv_filters.Name = "lv_filters";
            this.lv_filters.Size = new System.Drawing.Size(365, 485);
            this.lv_filters.TabIndex = 11;
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
            this.columnHeader6.Text = "Tab";
            this.columnHeader6.Width = 134;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Type";
            this.columnHeader7.Width = 123;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Show On List";
            // 
            // btn_filters_delete
            // 
            this.btn_filters_delete.Location = new System.Drawing.Point(128, 16);
            this.btn_filters_delete.Name = "btn_filters_delete";
            this.btn_filters_delete.Size = new System.Drawing.Size(49, 23);
            this.btn_filters_delete.TabIndex = 10;
            this.btn_filters_delete.Text = "Delete";
            this.btn_filters_delete.UseVisualStyleBackColor = true;
            // 
            // btn_filters_edit
            // 
            this.btn_filters_edit.Location = new System.Drawing.Point(73, 16);
            this.btn_filters_edit.Name = "btn_filters_edit";
            this.btn_filters_edit.Size = new System.Drawing.Size(49, 23);
            this.btn_filters_edit.TabIndex = 9;
            this.btn_filters_edit.Text = "Edit";
            this.btn_filters_edit.UseVisualStyleBackColor = true;
            this.btn_filters_edit.Click += new System.EventHandler(this.Btn_filters_edit_Click);
            // 
            // btn_filters_add
            // 
            this.btn_filters_add.Location = new System.Drawing.Point(18, 16);
            this.btn_filters_add.Name = "btn_filters_add";
            this.btn_filters_add.Size = new System.Drawing.Size(49, 23);
            this.btn_filters_add.TabIndex = 8;
            this.btn_filters_add.Text = "Add";
            this.btn_filters_add.UseVisualStyleBackColor = true;
            this.btn_filters_add.Click += new System.EventHandler(this.Btn_filters_add_Click);
            // 
            // Filters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 619);
            this.Controls.Add(this.tc_main);
            this.Name = "Filters";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Filters";
            this.tc_main.ResumeLayout(false);
            this.ts_tab.ResumeLayout(false);
            this.ts_categories.ResumeLayout(false);
            this.ts_filters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_main;
        private System.Windows.Forms.TabPage ts_categories;
        private System.Windows.Forms.TabPage ts_filters;
        private System.Windows.Forms.TabPage ts_tab;
        private System.Windows.Forms.ListView lv_tabs;
        private System.Windows.Forms.Button btn_tab_del;
        private System.Windows.Forms.Button btn_tab_edit;
        private System.Windows.Forms.Button btn_add_tab;
        private System.Windows.Forms.Button btn_cat_delete;
        private System.Windows.Forms.Button btn_cat_edit;
        private System.Windows.Forms.Button btn_cat_add;
        private System.Windows.Forms.ColumnHeader column_name;
        private System.Windows.Forms.ColumnHeader column_type;
        private System.Windows.Forms.ColumnHeader column_show_on_list;
        private System.Windows.Forms.ColumnHeader c_tab_name;
        private System.Windows.Forms.ColumnHeader c_tab_fixed;
        private System.Windows.Forms.ColumnHeader column_tab;
        private System.Windows.Forms.ListView lv_categories_sub;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_categories_sub_del;
        private System.Windows.Forms.Button btn_categories_sub_edit;
        private System.Windows.Forms.Button btn_categories_sub_add;
        private System.Windows.Forms.ListView lv_filters;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btn_filters_delete;
        private System.Windows.Forms.Button btn_filters_edit;
        private System.Windows.Forms.Button btn_filters_add;
        private System.Windows.Forms.ListView lv_categories;
    }
}