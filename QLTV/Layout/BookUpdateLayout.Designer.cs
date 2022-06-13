using System;

namespace QLTV
{
    partial class BookUpdateLayout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookUpdateLayout));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.bookgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addBook_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBook_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.editBook_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAuthor_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.export_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.recover_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(6, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1723, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.txttimkiem.Location = new System.Drawing.Point(390, 49);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(6);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(891, 54);
            this.txttimkiem.TabIndex = 2;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // bookgv
            // 
            this.bookgv.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.bookgv.AllowUserToAddRows = false;
            this.bookgv.AllowUserToDeleteRows = false;
            this.bookgv.AllowUserToResizeColumns = false;
            this.bookgv.AllowUserToResizeRows = false;
            this.bookgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.bookgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookgv.ColumnHeadersHeight = 40;
            this.bookgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookgv.Location = new System.Drawing.Point(0, 244);
            this.bookgv.Margin = new System.Windows.Forms.Padding(0);
            this.bookgv.MultiSelect = false;
            this.bookgv.Name = "bookgv";
            this.bookgv.ReadOnly = true;
            this.bookgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.bookgv.RowHeadersWidth = 82;
            this.bookgv.RowTemplate.Height = 50;
            this.bookgv.RowTemplate.ReadOnly = true;
            this.bookgv.Size = new System.Drawing.Size(1735, 956);
            this.bookgv.TabIndex = 23;
            this.bookgv.VirtualMode = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBook_menu,
            this.deleteBook_menu,
            this.editBook_menu,
            this.updateAuthor_menu,
            this.recover_menu,
            this.refresh_menu,
            this.export_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1735, 118);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // addBook_menu
            // 
            this.addBook_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBook_menu.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.addBook_menu.Image = ((System.Drawing.Image)(resources.GetObject("addBook_menu.Image")));
            this.addBook_menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBook_menu.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addBook_menu.Name = "addBook_menu";
            this.addBook_menu.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.addBook_menu.Size = new System.Drawing.Size(251, 118);
            this.addBook_menu.Text = "Thêm sách";
            this.addBook_menu.Click += new System.EventHandler(this.menu_addBook_Click);
            // 
            // deleteBook_menu
            // 
            this.deleteBook_menu.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.deleteBook_menu.Image = ((System.Drawing.Image)(resources.GetObject("deleteBook_menu.Image")));
            this.deleteBook_menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteBook_menu.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.deleteBook_menu.Name = "deleteBook_menu";
            this.deleteBook_menu.Padding = new System.Windows.Forms.Padding(8, 20, 8, 0);
            this.deleteBook_menu.Size = new System.Drawing.Size(161, 118);
            this.deleteBook_menu.Text = "Xóa";
            this.deleteBook_menu.Click += new System.EventHandler(this.deleteBook_menu_Click);
            // 
            // editBook_menu
            // 
            this.editBook_menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editBook_menu.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.editBook_menu.Image = ((System.Drawing.Image)(resources.GetObject("editBook_menu.Image")));
            this.editBook_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBook_menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editBook_menu.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.editBook_menu.Name = "editBook_menu";
            this.editBook_menu.Padding = new System.Windows.Forms.Padding(8, 20, 8, 0);
            this.editBook_menu.Size = new System.Drawing.Size(161, 118);
            this.editBook_menu.Text = "Sửa";
            this.editBook_menu.Click += new System.EventHandler(this.editBook_menu_Click);
            // 
            // updateAuthor_menu
            // 
            this.updateAuthor_menu.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.updateAuthor_menu.Image = ((System.Drawing.Image)(resources.GetObject("updateAuthor_menu.Image")));
            this.updateAuthor_menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateAuthor_menu.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.updateAuthor_menu.Name = "updateAuthor_menu";
            this.updateAuthor_menu.Padding = new System.Windows.Forms.Padding(8, 20, 8, 0);
            this.updateAuthor_menu.Size = new System.Drawing.Size(351, 118);
            this.updateAuthor_menu.Text = "Cập nhật tác giả";
            this.updateAuthor_menu.Click += new System.EventHandler(this.updateAuthor_menu_Click);
            // 
            // refresh_menu
            // 
            this.refresh_menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refresh_menu.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_menu.ForeColor = System.Drawing.Color.Black;
            this.refresh_menu.Image = ((System.Drawing.Image)(resources.GetObject("refresh_menu.Image")));
            this.refresh_menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refresh_menu.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.refresh_menu.Name = "refresh_menu";
            this.refresh_menu.Padding = new System.Windows.Forms.Padding(8, 20, 8, 0);
            this.refresh_menu.Size = new System.Drawing.Size(234, 118);
            this.refresh_menu.Text = "Làm mới";
            this.refresh_menu.Click += new System.EventHandler(this.menu_refresh_Click);
            // 
            // export_menu
            // 
            this.export_menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.export_menu.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.export_menu.Image = ((System.Drawing.Image)(resources.GetObject("export_menu.Image")));
            this.export_menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.export_menu.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.export_menu.Name = "export_menu";
            this.export_menu.Size = new System.Drawing.Size(225, 118);
            this.export_menu.Text = "Xuất file";
            this.export_menu.Click += new System.EventHandler(this.export_menu_Click);
            // 
            // recover_menu
            // 
            this.recover_menu.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.recover_menu.Image = ((System.Drawing.Image)(resources.GetObject("recover_menu.Image")));
            this.recover_menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.recover_menu.Name = "recover_menu";
            this.recover_menu.Size = new System.Drawing.Size(260, 118);
            this.recover_menu.Text = "Khôi phục";
            this.recover_menu.Click += new System.EventHandler(this.recover_menu_Click);
            // 
            // BookUpdateLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BookUpdateLayout";
            this.Size = new System.Drawing.Size(1735, 1200);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridView bookgv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addBook_menu;
        private System.Windows.Forms.ToolStripMenuItem deleteBook_menu;
        private System.Windows.Forms.ToolStripMenuItem editBook_menu;
        private System.Windows.Forms.ToolStripMenuItem refresh_menu;
        private System.Windows.Forms.ToolStripMenuItem updateAuthor_menu;
        private System.Windows.Forms.ToolStripMenuItem export_menu;
        private System.Windows.Forms.ToolStripMenuItem recover_menu;
    }
}
