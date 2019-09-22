namespace CRM
{
    partial class FormCategoriesAdd
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_cat_name = new System.Windows.Forms.TextBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.cb_cat_type = new WindowsFormsControlLibraryCRM.CRMComboBox();
            this.cbx_cat_show_on_list = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_tabs = new System.Windows.Forms.Label();
            this.cb_cat_tabs = new WindowsFormsControlLibraryCRM.CRMComboBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(23, 31);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // tb_cat_name
            // 
            this.tb_cat_name.Location = new System.Drawing.Point(64, 28);
            this.tb_cat_name.MaxLength = 100;
            this.tb_cat_name.Name = "tb_cat_name";
            this.tb_cat_name.Size = new System.Drawing.Size(318, 20);
            this.tb_cat_name.TabIndex = 1;
            this.tb_cat_name.TextChanged += new System.EventHandler(this.Tb_cat_name_TextChanged);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(23, 83);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(31, 13);
            this.lbl_type.TabIndex = 2;
            this.lbl_type.Text = "Type";
            // 
            // cb_cat_type
            // 
            this.cb_cat_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cat_type.FormattingEnabled = true;
            this.cb_cat_type.Location = new System.Drawing.Point(64, 80);
            this.cb_cat_type.Name = "cb_cat_type";
            this.cb_cat_type.Size = new System.Drawing.Size(318, 21);
            this.cb_cat_type.TabIndex = 3;
            this.cb_cat_type.SelectedIndexChanged += new System.EventHandler(this.Cb_cat_type_SelectedIndexChanged);
            // 
            // cbx_cat_show_on_list
            // 
            this.cbx_cat_show_on_list.AutoSize = true;
            this.cbx_cat_show_on_list.Location = new System.Drawing.Point(64, 107);
            this.cbx_cat_show_on_list.Name = "cbx_cat_show_on_list";
            this.cbx_cat_show_on_list.Size = new System.Drawing.Size(83, 17);
            this.cbx_cat_show_on_list.TabIndex = 4;
            this.cbx_cat_show_on_list.Text = "Show on list";
            this.cbx_cat_show_on_list.UseVisualStyleBackColor = true;
            this.cbx_cat_show_on_list.CheckedChanged += new System.EventHandler(this.Cbx_cat_show_on_list_CheckedChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(155, 149);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(236, 149);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_tabs
            // 
            this.lbl_tabs.AutoSize = true;
            this.lbl_tabs.Location = new System.Drawing.Point(3, 57);
            this.lbl_tabs.Name = "lbl_tabs";
            this.lbl_tabs.Size = new System.Drawing.Size(55, 13);
            this.lbl_tabs.TabIndex = 7;
            this.lbl_tabs.Text = "Tab name";
            // 
            // cb_cat_tabs
            // 
            this.cb_cat_tabs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cat_tabs.FormattingEnabled = true;
            this.cb_cat_tabs.Location = new System.Drawing.Point(64, 53);
            this.cb_cat_tabs.Name = "cb_cat_tabs";
            this.cb_cat_tabs.Size = new System.Drawing.Size(318, 21);
            this.cb_cat_tabs.TabIndex = 2;
            // 
            // FormCategoriesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 184);
            this.ControlBox = false;
            this.Controls.Add(this.cb_cat_tabs);
            this.Controls.Add(this.lbl_tabs);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cbx_cat_show_on_list);
            this.Controls.Add(this.cb_cat_type);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.tb_cat_name);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormCategoriesAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Category Add";
            this.Load += new System.EventHandler(this.FormCategoriesAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_cat_name;
        private System.Windows.Forms.Label lbl_type;
        private WindowsFormsControlLibraryCRM.CRMComboBox cb_cat_type;
        private System.Windows.Forms.CheckBox cbx_cat_show_on_list;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_tabs;
        private WindowsFormsControlLibraryCRM.CRMComboBox cb_cat_tabs;
    }
}