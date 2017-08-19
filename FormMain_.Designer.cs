namespace CRM
{
    partial class FormMain
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sp_main = new System.Windows.Forms.SplitContainer();
            this.tr_menu = new System.Windows.Forms.TreeView();
            this.pc_main = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.sp_main)).BeginInit();
            this.sp_main.Panel1.SuspendLayout();
            this.sp_main.Panel2.SuspendLayout();
            this.sp_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // sp_main
            // 
            this.sp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_main.Location = new System.Drawing.Point(3, 3);
            this.sp_main.Name = "sp_main";
            // 
            // sp_main.Panel1
            // 
            this.sp_main.Panel1.Controls.Add(this.tr_menu);
            // 
            // sp_main.Panel2
            // 
            this.sp_main.Panel2.Controls.Add(this.pc_main);
            this.sp_main.Size = new System.Drawing.Size(778, 555);
            this.sp_main.SplitterDistance = 178;
            this.sp_main.SplitterWidth = 2;
            this.sp_main.TabIndex = 2;
            // 
            // tr_menu
            // 
            this.tr_menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tr_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tr_menu.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tr_menu.FullRowSelect = true;
            this.tr_menu.Location = new System.Drawing.Point(0, 0);
            this.tr_menu.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tr_menu.Name = "tr_menu";
            this.tr_menu.ShowLines = false;
            this.tr_menu.ShowNodeToolTips = true;
            this.tr_menu.ShowPlusMinus = false;
            this.tr_menu.ShowRootLines = false;
            this.tr_menu.Size = new System.Drawing.Size(178, 555);
            this.tr_menu.TabIndex = 1;
            this.tr_menu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tr_menu_NodeMouseClick_1);
            // 
            // pc_main
            // 
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pc_main.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.pc_main.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pc_main.ItemSize = new System.Drawing.Size(200, 22);
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.SelectedIndex = 0;
            this.pc_main.Size = new System.Drawing.Size(598, 555);
            this.pc_main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.pc_main.TabIndex = 2;
            this.pc_main.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.pc_main_DrawItem);
            this.pc_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pc_main_MouseDown);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.sp_main);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.sp_main.Panel1.ResumeLayout(false);
            this.sp_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_main)).EndInit();
            this.sp_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer sp_main;
        private System.Windows.Forms.TreeView tr_menu;
        public System.Windows.Forms.TabControl pc_main;
    }
}

