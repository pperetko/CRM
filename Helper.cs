namespace CRM
{
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="CRMHelper" />
    /// </summary>
    public partial class CRMHelper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CRMHelper"/> class.
        /// </summary>
        public CRMHelper()
        {
        }

        /// <summary>
        /// The NullToString
        /// </summary>
        /// <param name="Value">The Value<see cref="object"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string NullToString(object Value)
        {
            if (Value == null)
            {
                return string.Empty;
            }
            return Value.ToString();
        }

        /// <summary>
        /// The Information
        /// </summary>
        /// <param name="header">The header<see cref="string"/></param>
        /// <param name="body">The body<see cref="string"/></param>
        public static void Information(string header, string body)
        {
            MessageBox.Show(body, header);
        }

        /// <summary>
        /// The Question
        /// </summary>
        /// <param name="header">The header<see cref="string"/></param>
        /// <param name="body">The body<see cref="string"/></param>
        /// <returns>The <see cref="DialogResult"/></returns>
        public static DialogResult Question(string header, string body)
        {
            return MessageBox.Show(body, header, MessageBoxButtons.OKCancel);
        }
    }
}
