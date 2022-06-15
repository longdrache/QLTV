namespace QLTV.Issue
{
    partial class LookBorrowedBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookBorrowedBook));
            this.bookgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bookgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bookgv
            // 
            this.bookgv.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.bookgv.AllowUserToDeleteRows = false;
            this.bookgv.AllowUserToOrderColumns = true;
            this.bookgv.AllowUserToResizeColumns = false;
            this.bookgv.AllowUserToResizeRows = false;
            this.bookgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.bookgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.bookgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bookgv.ColumnHeadersHeight = 40;
            this.bookgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.bookgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookgv.Location = new System.Drawing.Point(0, 0);
            this.bookgv.Margin = new System.Windows.Forms.Padding(0);
            this.bookgv.Name = "bookgv";
            this.bookgv.ReadOnly = true;
            this.bookgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.bookgv.RowHeadersVisible = false;
            this.bookgv.RowHeadersWidth = 82;
            this.bookgv.RowTemplate.Height = 50;
            this.bookgv.RowTemplate.ReadOnly = true;
            this.bookgv.Size = new System.Drawing.Size(1709, 866);
            this.bookgv.TabIndex = 25;
            this.bookgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookgv_CellClick);
            // 
            // LookBorrowedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 866);
            this.Controls.Add(this.bookgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LookBorrowedBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem sách mượn";
            this.Load += new System.EventHandler(this.ListBorrowedBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookgv;
    }
}