using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibraryCRM
{
    public partial class CRMComboBox: ComboBox
    {
        public CRMComboBox()
        {
            InitializeComponent();
            idList = new List<long>();
            Width = 150;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        IList<long> idList;



        public void AddItem(object item,long id) {
            base.Items.Add(item);
            idList.Add(id);
        }

        private int getIndex(long id) {

            int pos = -1;
            foreach (long element in idList)
            {
                pos = +1;
                if (element == id)
                    break;

            }
            return pos;
        }


        //Function back item for id
        public object GetItemWithId(long id) {
            int pos = getIndex(id);
            if (pos != -1) {
                return this.Items[pos];
            }
            else {
                return null;
            }
            
             
        }

        //Function back current id for ItemIndex
        public long GetID() {
            if (this.SelectedItem != null)
            {
                return Convert.ToInt64(idList[this.SelectedIndex]);
            }
            else {
                return -1;
            }
        }


        public bool delete(long id) {
            int pos = getIndex(id);
            if (pos != -1)
            {
                this.Items.RemoveAt(pos);
                idList.RemoveAt(pos);
                return true;
            }
            else {
                return false;

            }

        }



        public void clearItems() {
            this.Items.Clear();
            idList.Clear();

        }
       
    }
}
