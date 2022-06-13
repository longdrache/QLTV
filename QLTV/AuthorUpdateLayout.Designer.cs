namespace QLTV
{
    partial class AuthorUpdateLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorUpdateLayout));
            this.luoi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.add_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_search = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.luoi.Location = new System.Drawing.Point(0, 332);
            this.luoi.Margin = new System.Windows.Forms.Padding(6);
            this.luoi.Name = "luoi";
            this.luoi.RowHeadersWidth = 82;
            this.luoi.Size = new System.Drawing.Size(1735, 868);
            this.luoi.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(34, -54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "CẬP NHẬT THỂ LOẠI SÁCH";
            // 
            // menu_strip
            // 
            this.menu_strip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu_strip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_menu,
            this.remove_menu,
            this.edit_menu,
            this.refresh_menu});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(1735, 42);
            this.menu_strip.TabIndex = 13;
            this.menu_strip.Text = "menuStrip1";
            // 
            // add_menu
            // 
            this.add_menu.Name = "add_menu";
            this.add_menu.Size = new System.Drawing.Size(172, 38);
            this.add_menu.Text = "Thêm tác giả";
            this.add_menu.Click += new System.EventHandler(this.add_menu_Click);
            // 
            // remove_menu
            // 
            this.remove_menu.Name = "remove_menu";
            this.remove_menu.Size = new System.Drawing.Size(151, 38);
            this.remove_menu.Text = "Xóa tác giả";
            // 
            // edit_menu
            // 
            this.edit_menu.Name = "edit_menu";
            this.edit_menu.Size = new System.Drawing.Size(157, 38);
            this.edit_menu.Text = "Sửa tác giả ";
            // 
            // refresh_menu
            // 
            this.refresh_menu.Name = "refresh_menu";
            this.refresh_menu.Size = new System.Drawing.Size(133, 38);
            this.refresh_menu.Text = "Làm mới ";
            this.refresh_menu.Click += new System.EventHandler(this.làmMớiTrangToolStripMenuItem_Click);
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(887, 177);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(211, 79);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseCompatibleTextRendering = true;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.txttimkiem.Location = new System.Drawing.Point(293, 194);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(6);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(582, 54);
            this.txttimkiem.TabIndex = 14;
            // 
            // AuthorUpdateLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luoi);
            this.Controls.Add(this.menu_strip);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AuthorUpdateLayout";
            this.Size = new System.Drawing.Size(1735, 1200);
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.MenuStrip menu_strip;
        private System.Windows.Forms.ToolStripMenuItem add_menu;
        private System.Windows.Forms.ToolStripMenuItem remove_menu;
        private System.Windows.Forms.ToolStripMenuItem edit_menu;
        private System.Windows.Forms.ToolStripMenuItem refresh_menu;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}
