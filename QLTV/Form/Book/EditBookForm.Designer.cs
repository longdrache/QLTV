namespace QLTV
{
    partial class EditBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookForm));
            this.label6 = new System.Windows.Forms.Label();
            this.rtxt_desc = new System.Windows.Forms.RichTextBox();
            this.header = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.cb_author = new System.Windows.Forms.ComboBox();
            this.cb_edition = new System.Windows.Forms.ComboBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_bookName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(88, 536);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 39);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mô tả";
            // 
            // rtxt_desc
            // 
            this.rtxt_desc.Location = new System.Drawing.Point(228, 501);
            this.rtxt_desc.Name = "rtxt_desc";
            this.rtxt_desc.Size = new System.Drawing.Size(423, 149);
            this.rtxt_desc.TabIndex = 25;
            this.rtxt_desc.Text = "";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.header.Location = new System.Drawing.Point(376, 37);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(251, 63);
            this.header.TabIndex = 24;
            this.header.Text = "Sửa sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(409, 684);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(199, 75);
            this.btn_edit.TabIndex = 22;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // cb_author
            // 
            this.cb_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_author.FormattingEnabled = true;
            this.cb_author.Location = new System.Drawing.Point(228, 428);
            this.cb_author.Margin = new System.Windows.Forms.Padding(5);
            this.cb_author.Name = "cb_author";
            this.cb_author.Size = new System.Drawing.Size(370, 47);
            this.cb_author.TabIndex = 21;
            // 
            // cb_edition
            // 
            this.cb_edition.AllowDrop = true;
            this.cb_edition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_edition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_edition.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cb_edition.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cb_edition.Location = new System.Drawing.Point(228, 313);
            this.cb_edition.Margin = new System.Windows.Forms.Padding(5);
            this.cb_edition.Name = "cb_edition";
            this.cb_edition.Size = new System.Drawing.Size(199, 47);
            this.cb_edition.TabIndex = 20;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_isbn.Location = new System.Drawing.Point(360, 236);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(5);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(278, 47);
            this.txt_isbn.TabIndex = 19;
            // 
            // txt_bookName
            // 
            this.txt_bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_bookName.Location = new System.Drawing.Point(261, 141);
            this.txt_bookName.Margin = new System.Windows.Forms.Padding(5);
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.Size = new System.Drawing.Size(419, 47);
            this.txt_bookName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(78, 428);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 39);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(78, 316);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tái bản ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(78, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(78, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên sách";
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 788);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxt_desc);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.cb_author);
            this.Controls.Add(this.cb_edition);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật sách";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxt_desc;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox cb_author;
        private System.Windows.Forms.ComboBox cb_edition;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_bookName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}