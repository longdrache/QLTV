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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            // ListBorrowedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 866);
            this.Controls.Add(this.bookgv);
            this.Name = "ListBorrowedBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBorrowedBook";
            this.Load += new System.EventHandler(this.ListBorrowedBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookgv;
    }
}