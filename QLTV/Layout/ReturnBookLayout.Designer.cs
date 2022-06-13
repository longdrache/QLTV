namespace QLTV
{
    partial class ReturnBookLayout
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
            this.return_gv = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xemSáchĐãMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.return_gv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // return_gv
            // 
            this.return_gv.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.return_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.return_gv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.return_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.return_gv.ColumnHeadersHeight = 40;
            this.return_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.return_gv.DefaultCellStyle = dataGridViewCellStyle2;
            this.return_gv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.return_gv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.return_gv.Location = new System.Drawing.Point(0, 260);
            this.return_gv.Margin = new System.Windows.Forms.Padding(0);
            this.return_gv.MultiSelect = false;
            this.return_gv.Name = "return_gv";
            this.return_gv.ReadOnly = true;
            this.return_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.return_gv.RowHeadersVisible = false;
            this.return_gv.RowHeadersWidth = 82;
            this.return_gv.RowTemplate.Height = 50;
            this.return_gv.RowTemplate.ReadOnly = true;
            this.return_gv.Size = new System.Drawing.Size(1735, 940);
            this.return_gv.TabIndex = 37;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemSáchĐãMượnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1735, 40);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xemSáchĐãMượnToolStripMenuItem
            // 
            this.xemSáchĐãMượnToolStripMenuItem.Name = "xemSáchĐãMượnToolStripMenuItem";
            this.xemSáchĐãMượnToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.xemSáchĐãMượnToolStripMenuItem.Text = "Xem sách đã mượn ";
            this.xemSáchĐãMượnToolStripMenuItem.Click += new System.EventHandler(this.xemSáchĐãMượnToolStripMenuItem_Click);
            // 
            // ReturnBookLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.return_gv);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ReturnBookLayout";
            this.Size = new System.Drawing.Size(1735, 1200);
            this.Load += new System.EventHandler(this.ReturnBookLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.return_gv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView return_gv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemSáchĐãMượnToolStripMenuItem;
    }
}
