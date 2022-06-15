namespace QLTV
{
    partial class IssueBookLayout
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.issuebook = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issue_gv = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.lbl_PageNumber = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issue_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issuebook,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1735, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // issuebook
            // 
            this.issuebook.Name = "issuebook";
            this.issuebook.Size = new System.Drawing.Size(147, 36);
            this.issuebook.Text = "Cho mượn";
            this.issuebook.Click += new System.EventHandler(this.issuebook_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.refreshToolStripMenuItem.Text = "Làm mới";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // issue_gv
            // 
            this.issue_gv.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.issue_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issue_gv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.issue_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.issue_gv.ColumnHeadersHeight = 50;
            this.issue_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.issue_gv.DefaultCellStyle = dataGridViewCellStyle2;
            this.issue_gv.Location = new System.Drawing.Point(0, 270);
            this.issue_gv.Margin = new System.Windows.Forms.Padding(0);
            this.issue_gv.MultiSelect = false;
            this.issue_gv.Name = "issue_gv";
            this.issue_gv.ReadOnly = true;
            this.issue_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.issue_gv.RowHeadersWidth = 82;
            this.issue_gv.RowTemplate.Height = 50;
            this.issue_gv.RowTemplate.ReadOnly = true;
            this.issue_gv.Size = new System.Drawing.Size(1735, 792);
            this.issue_gv.TabIndex = 25;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.txttimkiem.Location = new System.Drawing.Point(422, 155);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(6);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(891, 54);
            this.txttimkiem.TabIndex = 40;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // lbl_PageNumber
            // 
            this.lbl_PageNumber.AutoSize = true;
            this.lbl_PageNumber.Location = new System.Drawing.Point(837, 1118);
            this.lbl_PageNumber.Name = "lbl_PageNumber";
            this.lbl_PageNumber.Size = new System.Drawing.Size(60, 25);
            this.lbl_PageNumber.TabIndex = 43;
            this.lbl_PageNumber.Text = "page";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(935, 1106);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(116, 48);
            this.btn_next.TabIndex = 42;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(684, 1106);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(135, 48);
            this.btn_prev.TabIndex = 41;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // IssueBookLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_PageNumber);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.issue_gv);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "IssueBookLayout";
            this.Size = new System.Drawing.Size(1735, 1200);
            this.Load += new System.EventHandler(this.IssueBookLayout_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issue_gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem issuebook;
        private System.Windows.Forms.DataGridView issue_gv;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label lbl_PageNumber;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
    }
  
}


