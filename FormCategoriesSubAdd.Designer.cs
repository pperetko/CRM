namespace CRM
{
    partial class FormCategoriesSubAdd
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
            this.tb_cat_sub_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.cbx_cat_sub_show_on_list = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_cat_sub_name
            // 
            this.tb_cat_sub_name.Location = new System.Drawing.Point(68, 25);
            this.tb_cat_sub_name.MaxLength = 100;
            this.tb_cat_sub_name.Name = "tb_cat_sub_name";
            this.tb_cat_sub_name.Size = new System.Drawing.Size(318, 20);
            this.tb_cat_sub_name.TabIndex = 3;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(27, 28);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(311, 149);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(230, 149);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // cbx_cat_sub_show_on_list
            // 
            this.cbx_cat_sub_show_on_list.AutoSize = true;
            this.cbx_cat_sub_show_on_list.Location = new System.Drawing.Point(68, 63);
            this.cbx_cat_sub_show_on_list.Name = "cbx_cat_sub_show_on_list";
            this.cbx_cat_sub_show_on_list.Size = new System.Drawing.Size(83, 17);
            this.cbx_cat_sub_show_on_list.TabIndex = 7;
            this.cbx_cat_sub_show_on_list.Text = "Show on list";
            this.cbx_cat_sub_show_on_list.UseVisualStyleBackColor = true;
            // 
            // FormCategoriesSubAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(442, 184);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cbx_cat_sub_show_on_list);
            this.Controls.Add(this.tb_cat_sub_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "FormCategoriesSubAdd";
            this.ShowIcon = false;
            this.Text = "Categories Sub Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cat_sub_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox cbx_cat_sub_show_on_list;
    }
}