using System;



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


    }
}
