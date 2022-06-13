namespace QLTV
{
    partial class ChangeNameAuthorForm
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.lbl_authorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_edit.Location = new System.Drawing.Point(187, 175);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(204, 63);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Cập nhật";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_author
            // 
            this.txt_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_author.Location = new System.Drawing.Point(236, 77);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(193, 47);
            this.txt_author.TabIndex = 5;
            // 
            // lbl_authorName
            // 
            this.lbl_authorName.AutoSize = true;
            this.lbl_authorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_authorName.Location = new System.Drawing.Point(56, 77);
            this.lbl_authorName.Name = "lbl_authorName";
            this.lbl_authorName.Size = new System.Drawing.Size(161, 36);
            this.lbl_authorName.TabIndex = 4;
            this.lbl_authorName.Text = "Tên tác giả";
            // 
            // ChangeNameAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 264);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.lbl_authorName);
            this.Name = "ChangeNameAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeNameAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.Label lbl_authorName;
    }
}