namespace QLTV
{
    partial class UserListLayout
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.lbl_PageNumber = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.usergv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usergv)).BeginInit();
            this.SuspendLayout();
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
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.txttimkiem.Location = new System.Drawing.Point(612, 187);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(6);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(582, 54);
            this.txttimkiem.TabIndex = 14;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // lbl_PageNumber
            // 
            this.lbl_PageNumber.AutoSize = true;
            this.lbl_PageNumber.Location = new System.Drawing.Point(836, 1136);
            this.lbl_PageNumber.Name = "lbl_PageNumber";
            this.lbl_PageNumber.Size = new System.Drawing.Size(60, 25);
            this.lbl_PageNumber.TabIndex = 33;
            this.lbl_PageNumber.Text = "page";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(934, 1124);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(116, 48);
            this.btn_next.TabIndex = 32;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(683, 1124);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(135, 48);
            this.btn_prev.TabIndex = 31;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // usergv
            // 
            this.usergv.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.usergv.AllowUserToAddRows = false;
            this.usergv.AllowUserToDeleteRows = false;
            this.usergv.AllowUserToResizeColumns = false;
            this.usergv.AllowUserToResizeRows = false;
            this.usergv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usergv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usergv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usergv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usergv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usergv.ColumnHeadersHeight = 40;
            this.usergv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usergv.DefaultCellStyle = dataGridViewCellStyle4;
            this.usergv.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.usergv.Location = new System.Drawing.Point(364, 292);
            this.usergv.Margin = new System.Windows.Forms.Padding(0);
            this.usergv.MultiSelect = false;
            this.usergv.Name = "usergv";
            this.usergv.ReadOnly = true;
            this.usergv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.usergv.RowHeadersWidth = 82;
            this.usergv.RowTemplate.Height = 50;
            this.usergv.RowTemplate.ReadOnly = true;
            this.usergv.Size = new System.Drawing.Size(1037, 792);
            this.usergv.TabIndex = 34;
            // 
            // UserManagerLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usergv);
            this.Controls.Add(this.lbl_PageNumber);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserManagerLayout";
            this.Size = new System.Drawing.Size(1735, 1200);
            this.Load += new System.EventHandler(this.UserManagerLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usergv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label lbl_PageNumber;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.DataGridView usergv;
    }
}
