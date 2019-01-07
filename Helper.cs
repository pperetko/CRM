using System;
using System.Windows.Forms;


namespace CRM
{

    public partial class CRMHelper
    {
        public CRMHelper()
        {
        }

        

        public static string NullToString(object Value)
        {
            if (Value == null) {
                return string.Empty;
            }
            return Value.ToString();
        }


        public static void Information(string header, string body){
            MessageBox.Show(body,header);
        } 



    }
}
