namespace QLTV.Issue
{
    partial class IssueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueForm));
            this.btn_chooseSt = new System.Windows.Forms.Button();
            this.txt_bookName = new System.Windows.Forms.TextBox();
            this.btn_chooseBook = new System.Windows.Forms.Button();
            this.btn_issue = new System.Windows.Forms.Button();
            this.txt_studentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_expirary = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_issue = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_chooseSt
            // 
            this.btn_chooseSt.Location = new System.Drawing.Point(505, 181);
            this.btn_chooseSt.Name = "btn_chooseSt";
            this.btn_chooseSt.Size = new System.Drawing.Size(136, 71);
            this.btn_chooseSt.TabIndex = 32;
            this.btn_chooseSt.Text = "Nhập  sinh viên";
            this.btn_chooseSt.UseVisualStyleBackColor = true;
            this.btn_chooseSt.Click += new System.EventHandler(this.btn_chooseSt_Click);
            // 
            // txt_bookName
            // 
            this.txt_bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_bookName.Location = new System.Drawing.Point(789, 201);
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.ReadOnly = true;
            this.txt_bookName.Size = new System.Drawing.Size(273, 41);
            this.txt_bookName.TabIndex = 31;
            // 
            // btn_chooseBook
            // 
            this.btn_chooseBook.Location = new System.Drawing.Point(1093, 188);
            this.btn_chooseBook.Name = "btn_chooseBook";
            this.btn_chooseBook.Size = new System.Drawing.Size(236, 71);
            this.btn_chooseBook.TabIndex = 30;
            this.btn_chooseBook.Text = "Chọn sách";
            this.btn_chooseBook.UseVisualStyleBackColor = true;
            this.btn_chooseBook.Click += new System.EventHandler(this.btn_chooseBook_Click);
            // 
            // btn_issue
            // 
            this.btn_issue.Location = new System.Drawing.Point(584, 537);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(231, 135);
            this.btn_issue.TabIndex = 29;
            this.btn_issue.Text = "Cho mượn ";
            this.btn_issue.UseVisualStyleBackColor = true;
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // txt_studentId
            // 
            this.txt_studentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_studentId.Location = new System.Drawing.Point(286, 195);
            this.txt_studentId.Name = "txt_studentId";
            this.txt_studentId.ReadOnly = true;
            this.txt_studentId.Size = new System.Drawing.Size(193, 47);
            this.txt_studentId.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(57, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 36);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã số sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(366, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 76);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quản lý cho mượn sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(672, 374);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 44);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ngày hẹn trả";
            // 
            // dtp_expirary
            // 
            this.dtp_expirary.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtp_expirary.CustomFormat = "dd/MM/yyyy";
            this.dtp_expirary.Enabled = false;
            this.dtp_expirary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtp_expirary.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_expirary.Location = new System.Drawing.Point(941, 377);
            this.dtp_expirary.Margin = new System.Windows.Forms.Padding(6);
            this.dtp_expirary.Name = "dtp_expirary";
            this.dtp_expirary.Size = new System.Drawing.Size(238, 41);
            this.dtp_expirary.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(67, 361);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 44);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ngày mượn";
            // 
            // dtp_issue
            // 
            this.dtp_issue.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtp_issue.CustomFormat = "dd/MM/yyyy";
            this.dtp_issue.Enabled = false;
            this.dtp_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtp_issue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_issue.Location = new System.Drawing.Point(301, 364);
            this.dtp_issue.Margin = new System.Windows.Forms.Padding(6);
            this.dtp_issue.Name = "dtp_issue";
            this.dtp_issue.Size = new System.Drawing.Size(238, 41);
            this.dtp_issue.TabIndex = 26;
            this.dtp_issue.Value = new System.DateTime(2020, 6, 1, 23, 36, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(650, 200);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 44);
            this.label9.TabIndex = 24;
            this.label9.Text = " Sách";
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 737);
            this.Controls.Add(this.btn_chooseSt);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.btn_chooseBook);
            this.Controls.Add(this.btn_issue);
            this.Controls.Add(this.txt_studentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_expirary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_issue);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IssueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cho mượn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chooseSt;
        private System.Windows.Forms.TextBox txt_bookName;
        private System.Windows.Forms.Button btn_chooseBook;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.TextBox txt_studentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_expirary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_issue;
        private System.Windows.Forms.Label label9;
    }
}