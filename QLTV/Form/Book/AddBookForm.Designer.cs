namespace QLTV
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bookName = new System.Windows.Forms.TextBox();
            this.txt_Isbn = new System.Windows.Forms.TextBox();
            this.txt_edition = new System.Windows.Forms.ComboBox();
            this.cb_author = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Label();
            this.rtxt_desc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(34, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(34, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(34, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tái bản ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 418);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 39);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(34, 432);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tác giả";
            // 
            // txt_bookName
            // 
            this.txt_bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_bookName.Location = new System.Drawing.Point(217, 145);
            this.txt_bookName.Margin = new System.Windows.Forms.Padding(5);
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.Size = new System.Drawing.Size(419, 47);
            this.txt_bookName.TabIndex = 5;
            // 
            // txt_Isbn
            // 
            this.txt_Isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_Isbn.Location = new System.Drawing.Point(184, 243);
            this.txt_Isbn.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Isbn.Name = "txt_Isbn";
            this.txt_Isbn.Size = new System.Drawing.Size(278, 47);
            this.txt_Isbn.TabIndex = 6;
            // 
            // txt_edition
            // 
            this.txt_edition.AllowDrop = true;
            this.txt_edition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_edition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_edition.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_edition.Items.AddRange(new object[] {
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
            this.txt_edition.Location = new System.Drawing.Point(184, 317);
            this.txt_edition.Margin = new System.Windows.Forms.Padding(5);
            this.txt_edition.Name = "txt_edition";
            this.txt_edition.Size = new System.Drawing.Size(199, 47);
            this.txt_edition.TabIndex = 7;
            // 
            // cb_author
            // 
            this.cb_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_author.FormattingEnabled = true;
            this.cb_author.Location = new System.Drawing.Point(184, 432);
            this.cb_author.Margin = new System.Windows.Forms.Padding(5);
            this.cb_author.Name = "cb_author";
            this.cb_author.Size = new System.Drawing.Size(370, 47);
            this.cb_author.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(365, 688);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(199, 75);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.header.Location = new System.Drawing.Point(295, 33);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(293, 63);
            this.header.TabIndex = 11;
            this.header.Text = "Thêm sách";
            // 
            // rtxt_desc
            // 
            this.rtxt_desc.Location = new System.Drawing.Point(184, 505);
            this.rtxt_desc.Name = "rtxt_desc";
            this.rtxt_desc.Size = new System.Drawing.Size(423, 149);
            this.rtxt_desc.TabIndex = 12;
            this.rtxt_desc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(44, 540);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mô tả";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 794);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxt_desc);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_author);
            this.Controls.Add(this.txt_edition);
            this.Controls.Add(this.txt_Isbn);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sách";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bookName;
        private System.Windows.Forms.TextBox txt_Isbn;
        private System.Windows.Forms.ComboBox cb_author;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txt_edition;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.RichTextBox rtxt_desc;
        private System.Windows.Forms.Label label6;
    }
}