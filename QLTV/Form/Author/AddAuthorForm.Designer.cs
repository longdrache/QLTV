namespace QLTV
{
    partial class AddAuthorForm
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
            this.lbl_authorName = new System.Windows.Forms.Label();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_authorName
            // 
            this.lbl_authorName.AutoSize = true;
            this.lbl_authorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_authorName.Location = new System.Drawing.Point(12, 50);
            this.lbl_authorName.Name = "lbl_authorName";
            this.lbl_authorName.Size = new System.Drawing.Size(161, 36);
            this.lbl_authorName.TabIndex = 0;
            this.lbl_authorName.Text = "Tên tác giả";
            // 
            // txt_author
            // 
            this.txt_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_author.Location = new System.Drawing.Point(192, 50);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(193, 47);
            this.txt_author.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_add.Location = new System.Drawing.Point(143, 148);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(131, 63);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 250);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.lbl_authorName);
            this.Name = "AddAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tác giả";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_authorName;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.Button btn_add;
    }
}