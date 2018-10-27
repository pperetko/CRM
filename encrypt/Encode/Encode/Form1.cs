using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Encode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {

            tb_encrypt.Text = Encrypting.EncryptString(tb_string.Text, tb_password.Text);

        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            lb_decrypt.Text = Encrypting.DecryptString(tb_encrypt.Text, tb_password.Text);

        }
    }
}
