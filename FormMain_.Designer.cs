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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.sp_main = new System.Windows.Forms.SplitContainer();
            this.tr_menu = new System.Windows.Forms.TreeView();
            this.pc_main = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sp_main)).BeginInit();
            this.sp_main.Panel1.SuspendLayout();
            this.sp_main.Panel2.SuspendLayout();
            this.sp_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_main
            // 
            resources.ApplyResources(this.sp_main, "sp_main");
            this.sp_main.Name = "sp_main";
            // 
            // sp_main.Panel1
            // 
            resources.ApplyResources(this.sp_main.Panel1, "sp_main.Panel1");
            this.sp_main.Panel1.Controls.Add(this.tr_menu);
            // 
            // sp_main.Panel2
            // 
            resources.ApplyResources(this.sp_main.Panel2, "sp_main.Panel2");
            this.sp_main.Panel2.Controls.Add(this.pc_main);
            // 
            // tr_menu
            // 
            resources.ApplyResources(this.tr_menu, "tr_menu");
            this.tr_menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tr_menu.FullRowSelect = true;
            this.tr_menu.Name = "tr_menu";
            this.tr_menu.ShowLines = false;
            this.tr_menu.ShowRootLines = false;
            this.tr_menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tr_menu_AfterSelect);
            this.tr_menu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tr_menu_NodeMouseClick_1);
            // 
            // pc_main
            // 
            resources.ApplyResources(this.pc_main, "pc_main");
            this.pc_main.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.pc_main.Name = "pc_main";
            this.pc_main.SelectedIndex = 0;
            this.pc_main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.pc_main.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.pc_main_DrawItem);
            this.pc_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pc_main_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.sp_main);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "FormMain";
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

