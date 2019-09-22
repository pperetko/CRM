namespace CRM
{
    partial class FormTabAdd
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tb_cat_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.cb_tab_fixed = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(275, 149);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(194, 149);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tb_cat_name
            // 
            this.tb_cat_name.Location = new System.Drawing.Point(75, 32);
            this.tb_cat_name.MaxLength = 100;
            this.tb_cat_name.Name = "tb_cat_name";
            this.tb_cat_name.Size = new System.Drawing.Size(318, 20);
            this.tb_cat_name.TabIndex = 10;
            this.tb_cat_name.TextChanged += new System.EventHandler(this.tb_cat_name_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(34, 35);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name";
            // 
            // cb_tab_fixed
            // 
            this.cb_tab_fixed.AutoSize = true;
            this.cb_tab_fixed.Location = new System.Drawing.Point(75, 71);
            this.cb_tab_fixed.Name = "cb_tab_fixed";
            this.cb_tab_fixed.Size = new System.Drawing.Size(51, 17);
            this.cb_tab_fixed.TabIndex = 11;
            this.cb_tab_fixed.Text = "Fixed";
            this.cb_tab_fixed.UseVisualStyleBackColor = true;
            // 
            // FormTabAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 184);
            this.ControlBox = false;
            this.Controls.Add(this.cb_tab_fixed);
            this.Controls.Add(this.tb_cat_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTabAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Tab";
            this.Load += new System.EventHandler(this.FormTabAdd_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox tb_cat_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.CheckBox cb_tab_fixed;
    }
}