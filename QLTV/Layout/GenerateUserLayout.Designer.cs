namespace QLTV
{
    partial class GenerateUserLayout
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_account = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_confirm_pass = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_cpass = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(490, 137);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(407, 63);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Cấp người dùng";
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.Location = new System.Drawing.Point(151, 357);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(168, 39);
            this.lbl_account.TabIndex = 1;
            this.lbl_account.Text = "Tài khoản";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(151, 475);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(159, 39);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Mật khẩu";
            // 
            // lbl_confirm_pass
            // 
            this.lbl_confirm_pass.AutoSize = true;
            this.lbl_confirm_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_pass.Location = new System.Drawing.Point(151, 585);
            this.lbl_confirm_pass.Name = "lbl_confirm_pass";
            this.lbl_confirm_pass.Size = new System.Drawing.Size(314, 39);
            this.lbl_confirm_pass.TabIndex = 3;
            this.lbl_confirm_pass.Text = "Xác nhận mật khẩu";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(700, 357);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(432, 47);
            this.txt_username.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(703, 472);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(413, 47);
            this.txt_pass.TabIndex = 5;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_cpass
            // 
            this.txt_cpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpass.Location = new System.Drawing.Point(700, 585);
            this.txt_cpass.Name = "txt_cpass";
            this.txt_cpass.Size = new System.Drawing.Size(412, 47);
            this.txt_cpass.TabIndex = 6;
            this.txt_cpass.UseSystemPasswordChar = true;
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(784, 687);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_generate.Size = new System.Drawing.Size(254, 116);
            this.btn_generate.TabIndex = 7;
            this.btn_generate.Text = "Tạo";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // GenerateUserLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.txt_cpass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_confirm_pass);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.lbl_title);
            this.Name = "GenerateUserLayout";
            this.Size = new System.Drawing.Size(1735, 1200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_confirm_pass;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_cpass;
        private System.Windows.Forms.Button btn_generate;

         }
}
