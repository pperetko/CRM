namespace CRM
{
    partial class FilterPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_main = new System.Windows.Forms.Panel();
            this.ll_add_month = new System.Windows.Forms.LinkLabel();
            this.ll_plus_day = new System.Windows.Forms.LinkLabel();
            this.ll_minus_day = new System.Windows.Forms.LinkLabel();
            this.ll_minus_month = new System.Windows.Forms.LinkLabel();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.dt_time_to = new System.Windows.Forms.DateTimePicker();
            this.lb_to = new System.Windows.Forms.Label();
            this.dt_timefrom = new System.Windows.Forms.DateTimePicker();
            this.lb_from = new System.Windows.Forms.Label();
            this.pl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_main
            // 
            this.pl_main.Controls.Add(this.ll_add_month);
            this.pl_main.Controls.Add(this.ll_plus_day);
            this.pl_main.Controls.Add(this.ll_minus_day);
            this.pl_main.Controls.Add(this.ll_minus_month);
            this.pl_main.Controls.Add(this.bt_refresh);
            this.pl_main.Controls.Add(this.dt_time_to);
            this.pl_main.Controls.Add(this.lb_to);
            this.pl_main.Controls.Add(this.dt_timefrom);
            this.pl_main.Controls.Add(this.lb_from);
            this.pl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_main.Location = new System.Drawing.Point(0, 0);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(651, 47);
            this.pl_main.TabIndex = 0;
            // 
            // ll_add_month
            // 
            this.ll_add_month.AutoSize = true;
            this.ll_add_month.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ll_add_month.Location = new System.Drawing.Point(573, 14);
            this.ll_add_month.Name = "ll_add_month";
            this.ll_add_month.Size = new System.Drawing.Size(26, 16);
            this.ll_add_month.TabIndex = 8;
            this.ll_add_month.TabStop = true;
            this.ll_add_month.Text = ">>";
            // 
            // ll_plus_day
            // 
            this.ll_plus_day.AutoSize = true;
            this.ll_plus_day.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ll_plus_day.Location = new System.Drawing.Point(550, 14);
            this.ll_plus_day.Name = "ll_plus_day";
            this.ll_plus_day.Size = new System.Drawing.Size(17, 16);
            this.ll_plus_day.TabIndex = 7;
            this.ll_plus_day.TabStop = true;
            this.ll_plus_day.Text = ">";
            // 
            // ll_minus_day
            // 
            this.ll_minus_day.AutoSize = true;
            this.ll_minus_day.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ll_minus_day.Location = new System.Drawing.Point(527, 14);
            this.ll_minus_day.Name = "ll_minus_day";
            this.ll_minus_day.Size = new System.Drawing.Size(17, 16);
            this.ll_minus_day.TabIndex = 6;
            this.ll_minus_day.TabStop = true;
            this.ll_minus_day.Text = "<";
            // 
            // ll_minus_month
            // 
            this.ll_minus_month.AutoSize = true;
            this.ll_minus_month.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ll_minus_month.Location = new System.Drawing.Point(495, 14);
            this.ll_minus_month.Name = "ll_minus_month";
            this.ll_minus_month.Size = new System.Drawing.Size(26, 16);
            this.ll_minus_month.TabIndex = 5;
            this.ll_minus_month.TabStop = true;
            this.ll_minus_month.Text = "<<";
            // 
            // bt_refresh
            // 
            this.bt_refresh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_refresh.Location = new System.Drawing.Point(418, 9);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(72, 26);
            this.bt_refresh.TabIndex = 4;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            // 
            // dt_time_to
            // 
            this.dt_time_to.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dt_time_to.Location = new System.Drawing.Point(262, 10);
            this.dt_time_to.Name = "dt_time_to";
            this.dt_time_to.Size = new System.Drawing.Size(152, 24);
            this.dt_time_to.TabIndex = 3;
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_to.Location = new System.Drawing.Point(235, 14);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(21, 17);
            this.lb_to.TabIndex = 2;
            this.lb_to.Text = "to";
            // 
            // dt_timefrom
            // 
            this.dt_timefrom.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dt_timefrom.Location = new System.Drawing.Point(79, 10);
            this.dt_timefrom.Name = "dt_timefrom";
            this.dt_timefrom.Size = new System.Drawing.Size(152, 24);
            this.dt_timefrom.TabIndex = 1;
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_from.Location = new System.Drawing.Point(7, 14);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(70, 17);
            this.lb_from.TabIndex = 0;
            this.lb_from.Text = "Time from";
            // 
            // FilterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_main);
            this.Name = "FilterPanel";
            this.Size = new System.Drawing.Size(651, 47);
            this.pl_main.ResumeLayout(false);
            this.pl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_main;
        public System.Windows.Forms.DateTimePicker dt_time_to;
        private System.Windows.Forms.Label lb_to;
        public System.Windows.Forms.DateTimePicker dt_timefrom;
        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.LinkLabel ll_add_month;
        private System.Windows.Forms.LinkLabel ll_plus_day;
        private System.Windows.Forms.LinkLabel ll_minus_day;
        private System.Windows.Forms.LinkLabel ll_minus_month;
        public System.Windows.Forms.Button bt_refresh;
    }
}
