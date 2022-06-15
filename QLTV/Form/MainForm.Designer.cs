namespace QLTV
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_update_book = new System.Windows.Forms.Button();
            this.btn_issueBook = new System.Windows.Forms.Button();
            this.btn_getBooksFromStudent = new System.Windows.Forms.Button();
            this.btn_userManager = new System.Windows.Forms.Button();
            this.btn_generate_user = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panelForChange = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btn_home);
            this.flowLayoutPanel1.Controls.Add(this.btn_update_book);
            this.flowLayoutPanel1.Controls.Add(this.btn_issueBook);
            this.flowLayoutPanel1.Controls.Add(this.btn_getBooksFromStudent);
            this.flowLayoutPanel1.Controls.Add(this.btn_userManager);
            this.flowLayoutPanel1.Controls.Add(this.btn_generate_user);
            this.flowLayoutPanel1.Controls.Add(this.btn_logout);
            this.flowLayoutPanel1.Controls.Add(this.btn_exit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(265, 1200);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(3, 371);
            this.btn_home.Margin = new System.Windows.Forms.Padding(3, 90, 3, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(262, 70);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Trang chủ";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_update_book
            // 
            this.btn_update_book.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_update_book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_book.Location = new System.Drawing.Point(3, 454);
            this.btn_update_book.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_update_book.Name = "btn_update_book";
            this.btn_update_book.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_book.Size = new System.Drawing.Size(262, 70);
            this.btn_update_book.TabIndex = 1;
            this.btn_update_book.Text = "Cập nhật sách";
            this.btn_update_book.UseVisualStyleBackColor = true;
            this.btn_update_book.Click += new System.EventHandler(this.btn_update_book_Click);
            // 
            // btn_issueBook
            // 
            this.btn_issueBook.Location = new System.Drawing.Point(3, 537);
            this.btn_issueBook.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_issueBook.Name = "btn_issueBook";
            this.btn_issueBook.Size = new System.Drawing.Size(262, 70);
            this.btn_issueBook.TabIndex = 2;
            this.btn_issueBook.Text = "Cho mượn sách";
            this.btn_issueBook.UseVisualStyleBackColor = true;
            this.btn_issueBook.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // btn_getBooksFromStudent
            // 
            this.btn_getBooksFromStudent.Location = new System.Drawing.Point(3, 620);
            this.btn_getBooksFromStudent.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_getBooksFromStudent.Name = "btn_getBooksFromStudent";
            this.btn_getBooksFromStudent.Size = new System.Drawing.Size(262, 70);
            this.btn_getBooksFromStudent.TabIndex = 4;
            this.btn_getBooksFromStudent.Text = "Nhận  lại sách";
            this.btn_getBooksFromStudent.UseVisualStyleBackColor = true;
            this.btn_getBooksFromStudent.Click += new System.EventHandler(this.btn_getBooksFromStudent_Click);
            // 
            // btn_userManager
            // 
            this.btn_userManager.Location = new System.Drawing.Point(3, 703);
            this.btn_userManager.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_userManager.Name = "btn_userManager";
            this.btn_userManager.Size = new System.Drawing.Size(262, 70);
            this.btn_userManager.TabIndex = 5;
            this.btn_userManager.Text = "Danh sách tài khoản";
            this.btn_userManager.UseVisualStyleBackColor = true;
            this.btn_userManager.Click += new System.EventHandler(this.btn_updateAuthor_Click);
            // 
            // btn_generate_user
            // 
            this.btn_generate_user.Location = new System.Drawing.Point(3, 786);
            this.btn_generate_user.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_generate_user.Name = "btn_generate_user";
            this.btn_generate_user.Size = new System.Drawing.Size(262, 70);
            this.btn_generate_user.TabIndex = 6;
            this.btn_generate_user.Text = "Cấp tài khoản ";
            this.btn_generate_user.UseVisualStyleBackColor = true;
            this.btn_generate_user.Click += new System.EventHandler(this.btn_generate_user_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(3, 869);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(262, 70);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Location = new System.Drawing.Point(3, 952);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(262, 70);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panelForChange
            // 
            this.panelForChange.BackColor = System.Drawing.Color.White;
            this.panelForChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForChange.Location = new System.Drawing.Point(265, 0);
            this.panelForChange.Name = "panelForChange";
            this.panelForChange.Size = new System.Drawing.Size(1735, 1200);
            this.panelForChange.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2000, 1200);
            this.Controls.Add(this.panelForChange);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_update_book;
        private System.Windows.Forms.Panel panelForChange;
        private System.Windows.Forms.Button btn_issueBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_getBooksFromStudent;
        private System.Windows.Forms.Button btn_userManager;
        private System.Windows.Forms.Button btn_generate_user;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_exit;
    }
}

