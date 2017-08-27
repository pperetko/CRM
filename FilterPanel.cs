using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class FilterPanel :  UserControl
    {


       
      

    public FilterPanel()
        {
            InitializeComponent();
            pl_main.Resize += onResize;
            pl_main.Resize += new System.EventHandler(this.onResize);

        }

        protected   void onResize(object sender, EventArgs e) {


            this.bt_refresh.Top = 7;

        }


   }
}
