namespace CRM
{
    partial class FrmCustomerAddModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerAddModify));
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_main = new System.Windows.Forms.TabControl();
            this.tp_main = new System.Windows.Forms.TabPage();
            this.gb_operational_data = new System.Windows.Forms.GroupBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.ll_avatar3 = new System.Windows.Forms.LinkLabel();
            this.ll_avatar2 = new System.Windows.Forms.LinkLabel();
            this.ll_avatar1 = new System.Windows.Forms.LinkLabel();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.gb_ContactData = new System.Windows.Forms.GroupBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tb_phone2 = new System.Windows.Forms.TextBox();
            this.lbTel2 = new System.Windows.Forms.Label();
            this.tb_phone1 = new System.Windows.Forms.TextBox();
            this.lbTel1 = new System.Windows.Forms.Label();
            this.dt_dob = new System.Windows.Forms.DateTimePicker();
            this.lb_dob = new System.Windows.Forms.Label();
            this.gb_address = new System.Windows.Forms.GroupBox();
            this.cb_nationality = new System.Windows.Forms.ComboBox();
            this.lb_nationality = new System.Windows.Forms.Label();
            this.tb_no = new System.Windows.Forms.TextBox();
            this.lb_no = new System.Windows.Forms.Label();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.lb_city = new System.Windows.Forms.Label();
            this.tb_street = new System.Windows.Forms.TextBox();
            this.lb_street = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.lb_code = new System.Windows.Forms.Label();
            this.cb_state = new System.Windows.Forms.ComboBox();
            this.lb_state = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.lb_surname = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.tp_tasks = new System.Windows.Forms.TabPage();
            this.dataGridView_tasks = new System.Windows.Forms.DataGridView();
            this.pl_task_button = new System.Windows.Forms.Panel();
            this.btn_Edit_Task = new System.Windows.Forms.Button();
            this.btn_Add_Task = new System.Windows.Forms.Button();
            this.dg_tasks = new System.Windows.Forms.DataGridView();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.Lb_avatar1_plus = new System.Windows.Forms.LinkLabel();
            this.Lb_avatar2_plus = new System.Windows.Forms.LinkLabel();
            this.filterPanel1 = new CRM.FilterPanel();
            this.Lb_avatar3_plus = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.tb_main.SuspendLayout();
            this.tp_main.SuspendLayout();
            this.gb_operational_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.gb_ContactData.SuspendLayout();
            this.gb_address.SuspendLayout();
            this.tp_tasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tasks)).BeginInit();
            this.pl_task_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            resources.ApplyResources(this.btn_ok, "btn_ok");
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_ok);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tb_main
            // 
            this.tb_main.Controls.Add(this.tp_main);
            this.tb_main.Controls.Add(this.tp_tasks);
            resources.ApplyResources(this.tb_main, "tb_main");
            this.tb_main.Name = "tb_main";
            this.tb_main.SelectedIndex = 0;
            // 
            // tp_main
            // 
            this.tp_main.Controls.Add(this.Lb_avatar3_plus);
            this.tp_main.Controls.Add(this.Lb_avatar2_plus);
            this.tp_main.Controls.Add(this.Lb_avatar1_plus);
            this.tp_main.Controls.Add(this.gb_operational_data);
            this.tp_main.Controls.Add(this.ll_avatar3);
            this.tp_main.Controls.Add(this.ll_avatar2);
            this.tp_main.Controls.Add(this.ll_avatar1);
            this.tp_main.Controls.Add(this.pb_avatar);
            this.tp_main.Controls.Add(this.gb_ContactData);
            this.tp_main.Controls.Add(this.dt_dob);
            this.tp_main.Controls.Add(this.lb_dob);
            this.tp_main.Controls.Add(this.gb_address);
            this.tp_main.Controls.Add(this.tb_surname);
            this.tp_main.Controls.Add(this.lb_surname);
            this.tp_main.Controls.Add(this.tb_name);
            this.tp_main.Controls.Add(this.lb_name);
            resources.ApplyResources(this.tp_main, "tp_main");
            this.tp_main.Name = "tp_main";
            this.tp_main.UseVisualStyleBackColor = true;
            
            // 
            // gb_operational_data
            // 
            this.gb_operational_data.Controls.Add(this.cb_status);
            this.gb_operational_data.Controls.Add(this.lbl_status);
            resources.ApplyResources(this.gb_operational_data, "gb_operational_data");
            this.gb_operational_data.Name = "gb_operational_data";
            this.gb_operational_data.TabStop = false;
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            resources.ApplyResources(this.cb_status, "cb_status");
            this.cb_status.Name = "cb_status";
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            // 
            // ll_avatar3
            // 
            resources.ApplyResources(this.ll_avatar3, "ll_avatar3");
            this.ll_avatar3.Name = "ll_avatar3";
            this.ll_avatar3.TabStop = true;
            this.ll_avatar3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_avatar3_LinkClicked);
            // 
            // ll_avatar2
            // 
            resources.ApplyResources(this.ll_avatar2, "ll_avatar2");
            this.ll_avatar2.Name = "ll_avatar2";
            this.ll_avatar2.TabStop = true;
            this.ll_avatar2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_avatar2_LinkClicked);
            // 
            // ll_avatar1
            // 
            resources.ApplyResources(this.ll_avatar1, "ll_avatar1");
            this.ll_avatar1.Name = "ll_avatar1";
            this.ll_avatar1.TabStop = true;
            this.ll_avatar1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_avatar1_LinkClicked);
            // 
            // pb_avatar
            // 
            this.pb_avatar.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.pb_avatar, "pb_avatar");
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.TabStop = false;
            // 
            // gb_ContactData
            // 
            this.gb_ContactData.Controls.Add(this.tb_email);
            this.gb_ContactData.Controls.Add(this.lbEmail);
            this.gb_ContactData.Controls.Add(this.tb_phone2);
            this.gb_ContactData.Controls.Add(this.lbTel2);
            this.gb_ContactData.Controls.Add(this.tb_phone1);
            this.gb_ContactData.Controls.Add(this.lbTel1);
            resources.ApplyResources(this.gb_ContactData, "gb_ContactData");
            this.gb_ContactData.Name = "gb_ContactData";
            this.gb_ContactData.TabStop = false;
            // 
            // tb_email
            // 
            resources.ApplyResources(this.tb_email, "tb_email");
            this.tb_email.Name = "tb_email";
            // 
            // lbEmail
            // 
            resources.ApplyResources(this.lbEmail, "lbEmail");
            this.lbEmail.Name = "lbEmail";
            // 
            // tb_phone2
            // 
            resources.ApplyResources(this.tb_phone2, "tb_phone2");
            this.tb_phone2.Name = "tb_phone2";
            // 
            // lbTel2
            // 
            resources.ApplyResources(this.lbTel2, "lbTel2");
            this.lbTel2.Name = "lbTel2";
            // 
            // tb_phone1
            // 
            resources.ApplyResources(this.tb_phone1, "tb_phone1");
            this.tb_phone1.Name = "tb_phone1";
            // 
            // lbTel1
            // 
            resources.ApplyResources(this.lbTel1, "lbTel1");
            this.lbTel1.Name = "lbTel1";
            // 
            // dt_dob
            // 
            resources.ApplyResources(this.dt_dob, "dt_dob");
            this.dt_dob.Name = "dt_dob";
            // 
            // lb_dob
            // 
            resources.ApplyResources(this.lb_dob, "lb_dob");
            this.lb_dob.Name = "lb_dob";
            // 
            // gb_address
            // 
            this.gb_address.Controls.Add(this.cb_nationality);
            this.gb_address.Controls.Add(this.lb_nationality);
            this.gb_address.Controls.Add(this.tb_no);
            this.gb_address.Controls.Add(this.lb_no);
            this.gb_address.Controls.Add(this.tb_city);
            this.gb_address.Controls.Add(this.lb_city);
            this.gb_address.Controls.Add(this.tb_street);
            this.gb_address.Controls.Add(this.lb_street);
            this.gb_address.Controls.Add(this.tb_code);
            this.gb_address.Controls.Add(this.lb_code);
            this.gb_address.Controls.Add(this.cb_state);
            this.gb_address.Controls.Add(this.lb_state);
            resources.ApplyResources(this.gb_address, "gb_address");
            this.gb_address.Name = "gb_address";
            this.gb_address.TabStop = false;
            // 
            // cb_nationality
            // 
            this.cb_nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nationality.FormattingEnabled = true;
            resources.ApplyResources(this.cb_nationality, "cb_nationality");
            this.cb_nationality.Name = "cb_nationality";
            // 
            // lb_nationality
            // 
            resources.ApplyResources(this.lb_nationality, "lb_nationality");
            this.lb_nationality.Name = "lb_nationality";
            // 
            // tb_no
            // 
            resources.ApplyResources(this.tb_no, "tb_no");
            this.tb_no.Name = "tb_no";
            // 
            // lb_no
            // 
            resources.ApplyResources(this.lb_no, "lb_no");
            this.lb_no.Name = "lb_no";
            // 
            // tb_city
            // 
            resources.ApplyResources(this.tb_city, "tb_city");
            this.tb_city.Name = "tb_city";
            // 
            // lb_city
            // 
            resources.ApplyResources(this.lb_city, "lb_city");
            this.lb_city.Name = "lb_city";
            // 
            // tb_street
            // 
            resources.ApplyResources(this.tb_street, "tb_street");
            this.tb_street.Name = "tb_street";
            // 
            // lb_street
            // 
            resources.ApplyResources(this.lb_street, "lb_street");
            this.lb_street.Name = "lb_street";
            // 
            // tb_code
            // 
            resources.ApplyResources(this.tb_code, "tb_code");
            this.tb_code.Name = "tb_code";
            // 
            // lb_code
            // 
            resources.ApplyResources(this.lb_code, "lb_code");
            this.lb_code.Name = "lb_code";
            // 
            // cb_state
            // 
            this.cb_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_state.FormattingEnabled = true;
            resources.ApplyResources(this.cb_state, "cb_state");
            this.cb_state.Name = "cb_state";
            // 
            // lb_state
            // 
            resources.ApplyResources(this.lb_state, "lb_state");
            this.lb_state.Name = "lb_state";
            // 
            // tb_surname
            // 
            resources.ApplyResources(this.tb_surname, "tb_surname");
            this.tb_surname.Name = "tb_surname";
            // 
            // lb_surname
            // 
            resources.ApplyResources(this.lb_surname, "lb_surname");
            this.lb_surname.Name = "lb_surname";
            // 
            // tb_name
            // 
            resources.ApplyResources(this.tb_name, "tb_name");
            this.tb_name.Name = "tb_name";
            // 
            // lb_name
            // 
            resources.ApplyResources(this.lb_name, "lb_name");
            this.lb_name.Name = "lb_name";
            // 
            // tp_tasks
            // 
            this.tp_tasks.Controls.Add(this.dataGridView_tasks);
            this.tp_tasks.Controls.Add(this.pl_task_button);
            this.tp_tasks.Controls.Add(this.dg_tasks);
            this.tp_tasks.Controls.Add(this.filterPanel1);
            resources.ApplyResources(this.tp_tasks, "tp_tasks");
            this.tp_tasks.Name = "tp_tasks";
            this.tp_tasks.UseVisualStyleBackColor = true;
            // 
            // dataGridView_tasks
            // 
            this.dataGridView_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView_tasks, "dataGridView_tasks");
            this.dataGridView_tasks.Name = "dataGridView_tasks";
            // 
            // pl_task_button
            // 
            this.pl_task_button.Controls.Add(this.btn_Edit_Task);
            this.pl_task_button.Controls.Add(this.btn_Add_Task);
            resources.ApplyResources(this.pl_task_button, "pl_task_button");
            this.pl_task_button.Name = "pl_task_button";
            // 
            // btn_Edit_Task
            // 
            resources.ApplyResources(this.btn_Edit_Task, "btn_Edit_Task");
            this.btn_Edit_Task.Name = "btn_Edit_Task";
            this.btn_Edit_Task.UseVisualStyleBackColor = true;
            this.btn_Edit_Task.Click += new System.EventHandler(this.btn_Edit_Task_Click);
            // 
            // btn_Add_Task
            // 
            resources.ApplyResources(this.btn_Add_Task, "btn_Add_Task");
            this.btn_Add_Task.Name = "btn_Add_Task";
            this.btn_Add_Task.UseVisualStyleBackColor = true;
            this.btn_Add_Task.Click += new System.EventHandler(this.btn_Add_Task_Click);
            // 
            // dg_tasks
            // 
            this.dg_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dg_tasks, "dg_tasks");
            this.dg_tasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_tasks.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dg_tasks.MultiSelect = false;
            this.dg_tasks.Name = "dg_tasks";
            this.dg_tasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // imglist
            // 
            this.imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.imglist, "imglist");
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Lb_avatar1_plus
            // 
            resources.ApplyResources(this.Lb_avatar1_plus, "Lb_avatar1_plus");
            this.Lb_avatar1_plus.LinkColor = System.Drawing.Color.Red;
            this.Lb_avatar1_plus.Name = "Lb_avatar1_plus";
            this.Lb_avatar1_plus.TabStop = true;
            this.Lb_avatar1_plus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lb_avatar1_plus_LinkClicked);
            // 
            // Lb_avatar2_plus
            // 
            this.Lb_avatar2_plus.ActiveLinkColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.Lb_avatar2_plus, "Lb_avatar2_plus");
            this.Lb_avatar2_plus.LinkColor = System.Drawing.Color.Red;
            this.Lb_avatar2_plus.Name = "Lb_avatar2_plus";
            this.Lb_avatar2_plus.TabStop = true;
            this.Lb_avatar2_plus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lb_avatar2_plus_LinkClicked);
            // 
            // filterPanel1
            // 
            resources.ApplyResources(this.filterPanel1, "filterPanel1");
            this.filterPanel1.Name = "filterPanel1";
            // 
            // Lb_avatar3_plus
            // 
            resources.ApplyResources(this.Lb_avatar3_plus, "Lb_avatar3_plus");
            this.Lb_avatar3_plus.LinkColor = System.Drawing.Color.Red;
            this.Lb_avatar3_plus.Name = "Lb_avatar3_plus";
            this.Lb_avatar3_plus.TabStop = true;
            this.Lb_avatar3_plus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lb_avatar3_plus_LinkClicked);
            // 
            // FrmCustomerAddModify
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_main);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCustomerAddModify";
            this.Activated += new System.EventHandler(this.FrmCustomerAddModify_Activated);
            
            this.panel1.ResumeLayout(false);
            this.tb_main.ResumeLayout(false);
            this.tp_main.ResumeLayout(false);
            this.tp_main.PerformLayout();
            this.gb_operational_data.ResumeLayout(false);
            this.gb_operational_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.gb_ContactData.ResumeLayout(false);
            this.gb_ContactData.PerformLayout();
            this.gb_address.ResumeLayout(false);
            this.gb_address.PerformLayout();
            this.tp_tasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tasks)).EndInit();
            this.pl_task_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tb_main;
        private System.Windows.Forms.TabPage tp_main;
        private System.Windows.Forms.GroupBox gb_ContactData;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tb_phone2;
        private System.Windows.Forms.Label lbTel2;
        private System.Windows.Forms.TextBox tb_phone1;
        private System.Windows.Forms.Label lbTel1;
        private System.Windows.Forms.DateTimePicker dt_dob;
        private System.Windows.Forms.Label lb_dob;
        private System.Windows.Forms.GroupBox gb_address;
        private System.Windows.Forms.ComboBox cb_nationality;
        private System.Windows.Forms.Label lb_nationality;
        private System.Windows.Forms.TextBox tb_no;
        private System.Windows.Forms.Label lb_no;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.Label lb_city;
        private System.Windows.Forms.TextBox tb_street;
        private System.Windows.Forms.Label lb_street;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label lb_code;
        private System.Windows.Forms.ComboBox cb_state;
        private System.Windows.Forms.Label lb_state;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label lb_surname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TabPage tp_tasks;
        private System.Windows.Forms.Panel pl_task_button;
        private System.Windows.Forms.Button btn_Add_Task;
        private FilterPanel filterPanel1;
        private System.Windows.Forms.DataGridView dg_tasks;
        private System.Windows.Forms.Button btn_Edit_Task;
        private System.Windows.Forms.DataGridView dataGridView_tasks;
        private System.Windows.Forms.LinkLabel ll_avatar2;
        private System.Windows.Forms.LinkLabel ll_avatar1;
        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.GroupBox gb_operational_data;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.LinkLabel ll_avatar3;
        private System.Windows.Forms.ImageList imglist;
        private System.Windows.Forms.LinkLabel Lb_avatar1_plus;
        private System.Windows.Forms.LinkLabel Lb_avatar2_plus;
        private System.Windows.Forms.LinkLabel Lb_avatar3_plus;
    }
}