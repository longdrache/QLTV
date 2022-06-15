namespace QLTV.Return
{
    partial class LookBorrowedBookOfStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookBorrowedBookOfStudent));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_chooseSt = new System.Windows.Forms.Button();
            this.txt_studentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 95);
            this.button1.TabIndex = 40;
            this.button1.Text = "Xem sách đã mượn ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_chooseSt
            // 
            this.btn_chooseSt.Location = new System.Drawing.Point(458, 93);
            this.btn_chooseSt.Name = "btn_chooseSt";
            this.btn_chooseSt.Size = new System.Drawing.Size(136, 71);
            this.btn_chooseSt.TabIndex = 39;
            this.btn_chooseSt.Text = "Nhập  sinh viên";
            this.btn_chooseSt.UseVisualStyleBackColor = true;
            this.btn_chooseSt.Click += new System.EventHandler(this.btn_chooseSt_Click);
            // 
            // txt_studentId
            // 
            this.txt_studentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_studentId.Location = new System.Drawing.Point(239, 101);
            this.txt_studentId.Name = "txt_studentId";
            this.txt_studentId.ReadOnly = true;
            this.txt_studentId.Size = new System.Drawing.Size(193, 47);
            this.txt_studentId.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 36);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã số sinh viên";
            // 
            // LookBorrowedBookOfStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_chooseSt);
            this.Controls.Add(this.txt_studentId);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LookBorrowedBookOfStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem sách mượn ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_chooseSt;
        private System.Windows.Forms.TextBox txt_studentId;
        private System.Windows.Forms.Label label2;
    }
}