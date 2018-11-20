namespace CRM
{
    partial class FrmSettings
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
            this.fl_panel_status = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.edt_status = new System.Windows.Forms.MaskedTextBox();
            this.btn_add_status = new System.Windows.Forms.Button();
            this.btn_edit_status = new System.Windows.Forms.Button();
            this.btn_delete_status = new System.Windows.Forms.Button();
            this.fl_panel_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // fl_panel_status
            // 
            this.fl_panel_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fl_panel_status.Controls.Add(this.lbl_status);
            this.fl_panel_status.Controls.Add(this.cb_status);
            this.fl_panel_status.Controls.Add(this.edt_status);
            this.fl_panel_status.Controls.Add(this.btn_add_status);
            this.fl_panel_status.Controls.Add(this.btn_edit_status);
            this.fl_panel_status.Controls.Add(this.btn_delete_status);
            this.fl_panel_status.Location = new System.Drawing.Point(12, 12);
            this.fl_panel_status.Name = "fl_panel_status";
            this.fl_panel_status.Padding = new System.Windows.Forms.Padding(5);
            this.fl_panel_status.Size = new System.Drawing.Size(273, 94);
            this.fl_panel_status.TabIndex = 0;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(8, 13);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(51, 8);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(191, 21);
            this.cb_status.TabIndex = 1;
            // 
            // edt_status
            // 
            this.edt_status.Location = new System.Drawing.Point(51, 35);
            this.edt_status.Margin = new System.Windows.Forms.Padding(46, 3, 3, 3);
            this.edt_status.Name = "edt_status";
            this.edt_status.Size = new System.Drawing.Size(191, 20);
            this.edt_status.TabIndex = 3;
            this.edt_status.Text = "status";
            // 
            // btn_add_status
            // 
            this.btn_add_status.Location = new System.Drawing.Point(60, 61);
            this.btn_add_status.Margin = new System.Windows.Forms.Padding(55, 3, 3, 3);
            this.btn_add_status.Name = "btn_add_status";
            this.btn_add_status.Size = new System.Drawing.Size(52, 23);
            this.btn_add_status.TabIndex = 4;
            this.btn_add_status.Text = "Add";
            this.btn_add_status.UseVisualStyleBackColor = true;
            this.btn_add_status.Click += new System.EventHandler(this.btn_add_status_Click);
            // 
            // btn_edit_status
            // 
            this.btn_edit_status.Location = new System.Drawing.Point(118, 61);
            this.btn_edit_status.Name = "btn_edit_status";
            this.btn_edit_status.Size = new System.Drawing.Size(52, 23);
            this.btn_edit_status.TabIndex = 5;
            this.btn_edit_status.Text = "Edit";
            this.btn_edit_status.UseVisualStyleBackColor = true;
            this.btn_edit_status.Click += new System.EventHandler(this.btn_edit_status_Click);
            // 
            // btn_delete_status
            // 
            this.btn_delete_status.Location = new System.Drawing.Point(176, 61);
            this.btn_delete_status.Name = "btn_delete_status";
            this.btn_delete_status.Size = new System.Drawing.Size(52, 23);
            this.btn_delete_status.TabIndex = 6;
            this.btn_delete_status.Text = "Delete";
            this.btn_delete_status.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fl_panel_status);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.fl_panel_status.ResumeLayout(false);
            this.fl_panel_status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fl_panel_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.MaskedTextBox edt_status;
        private System.Windows.Forms.Button btn_add_status;
        private System.Windows.Forms.Button btn_edit_status;
        private System.Windows.Forms.Button btn_delete_status;
    }
}