namespace QLTV
{
    partial class UpdateAuthorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAuthorForm));
            this.author_list = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit_r_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_r_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_r_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.add_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.recover_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // author_list
            // 
            this.author_list.ContextMenuStrip = this.contextMenuStrip;
            this.author_list.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.author_list.DisplayMember = "AuthorName";
            this.author_list.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.author_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.author_list.FormattingEnabled = true;
            this.author_list.ItemHeight = 33;
            this.author_list.Items.AddRange(new object[] {
            "a",
            "b",
            "ba",
            "c",
            "c"});
            this.author_list.Location = new System.Drawing.Point(0, 142);
            this.author_list.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.author_list.Name = "author_list";
            this.author_list.ScrollAlwaysVisible = true;
            this.author_list.Size = new System.Drawing.Size(668, 499);
            this.author_list.TabIndex = 17;
            this.author_list.ValueMember = "authorId";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_r_menu,
            this.delete_r_menu,
            this.refresh_r_menu});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 118);
            // 
            // edit_r_menu
            // 
            this.edit_r_menu.Name = "edit_r_menu";
            this.edit_r_menu.Size = new System.Drawing.Size(180, 38);
            this.edit_r_menu.Text = "Sửa";
            this.edit_r_menu.Click += new System.EventHandler(this.edit_r_menu_Click);
            // 
            // delete_r_menu
            // 
            this.delete_r_menu.Name = "delete_r_menu";
            this.delete_r_menu.Size = new System.Drawing.Size(180, 38);
            this.delete_r_menu.Text = "Xóa";
            this.delete_r_menu.Click += new System.EventHandler(this.delete_r_menu_Click);
            // 
            // refresh_r_menu
            // 
            this.refresh_r_menu.Name = "refresh_r_menu";
            this.refresh_r_menu.Size = new System.Drawing.Size(180, 38);
            this.refresh_r_menu.Text = "Làm mới";
            this.refresh_r_menu.Click += new System.EventHandler(this.refresh_r_menu_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_menu,
            this.remove_menu,
            this.edit_menu,
            this.recover_menu,
            this.refresh_menu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(668, 54);
            this.menuStrip.TabIndex = 19;
            this.menuStrip.Text = "menuStrip1";
            // 
            // add_menu
            // 
            this.add_menu.Name = "add_menu";
            this.add_menu.Size = new System.Drawing.Size(95, 50);
            this.add_menu.Text = "Thêm";
            this.add_menu.Click += new System.EventHandler(this.add_menu_Click);
            // 
            // remove_menu
            // 
            this.remove_menu.Name = "remove_menu";
            this.remove_menu.Size = new System.Drawing.Size(74, 50);
            this.remove_menu.Text = "Xóa";
            this.remove_menu.Click += new System.EventHandler(this.remove_menu_Click);
            // 
            // edit_menu
            // 
            this.edit_menu.Name = "edit_menu";
            this.edit_menu.Size = new System.Drawing.Size(73, 50);
            this.edit_menu.Text = "Sửa";
            this.edit_menu.Click += new System.EventHandler(this.edit_menu_Click);
            // 
            // recover_menu
            // 
            this.recover_menu.Name = "recover_menu";
            this.recover_menu.Size = new System.Drawing.Size(142, 50);
            this.recover_menu.Text = "Khôi phục";
            this.recover_menu.Click += new System.EventHandler(this.recover_menu_Click);
            // 
            // refresh_menu
            // 
            this.refresh_menu.AutoSize = false;
            this.refresh_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refresh_menu.Image = ((System.Drawing.Image)(resources.GetObject("refresh_menu.Image")));
            this.refresh_menu.Name = "refresh_menu";
            this.refresh_menu.Size = new System.Drawing.Size(242, 50);
            this.refresh_menu.Text = "Làm mới";
            this.refresh_menu.Click += new System.EventHandler(this.refresh_menu_Click);
            // 
            // UpdateAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 641);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.author_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "UpdateAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tác giả";
            this.Load += new System.EventHandler(this.UpdateAuthorForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox author_list;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem edit_r_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_r_menu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem add_menu;
        private System.Windows.Forms.ToolStripMenuItem remove_menu;
        private System.Windows.Forms.ToolStripMenuItem edit_menu;
        private System.Windows.Forms.ToolStripMenuItem recover_menu;
        private System.Windows.Forms.ToolStripMenuItem refresh_r_menu;
        private System.Windows.Forms.ToolStripMenuItem refresh_menu;
    }
}