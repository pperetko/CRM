namespace Encode
{
    partial class Form1
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
            this.lbl_string = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_string = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.tb_encrypt = new System.Windows.Forms.TextBox();
            this.lb_decrypt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_string
            // 
            this.lbl_string.AutoSize = true;
            this.lbl_string.Location = new System.Drawing.Point(12, 9);
            this.lbl_string.Name = "lbl_string";
            this.lbl_string.Size = new System.Drawing.Size(34, 13);
            this.lbl_string.TabIndex = 0;
            this.lbl_string.Text = "String";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 36);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            // 
            // tb_string
            // 
            this.tb_string.Location = new System.Drawing.Point(65, 6);
            this.tb_string.Name = "tb_string";
            this.tb_string.Size = new System.Drawing.Size(247, 20);
            this.tb_string.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(65, 36);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(247, 20);
            this.tb_password.TabIndex = 3;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(65, 62);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypt.TabIndex = 4;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(146, 62);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_decrypt.TabIndex = 5;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // tb_encrypt
            // 
            this.tb_encrypt.Location = new System.Drawing.Point(65, 91);
            this.tb_encrypt.Name = "tb_encrypt";
            this.tb_encrypt.Size = new System.Drawing.Size(290, 20);
            this.tb_encrypt.TabIndex = 6;
            // 
            // lb_decrypt
            // 
            this.lb_decrypt.AutoSize = true;
            this.lb_decrypt.Location = new System.Drawing.Point(62, 131);
            this.lb_decrypt.Name = "lb_decrypt";
            this.lb_decrypt.Size = new System.Drawing.Size(31, 13);
            this.lb_decrypt.TabIndex = 7;
            this.lb_decrypt.Text = "........";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 162);
            this.Controls.Add(this.lb_decrypt);
            this.Controls.Add(this.tb_encrypt);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_string);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_string);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_string;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_string;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.TextBox tb_encrypt;
        private System.Windows.Forms.Label lb_decrypt;
    }
}

