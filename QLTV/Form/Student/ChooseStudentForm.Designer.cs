namespace QLTV.Student
{
    partial class ChooseStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseStudentForm));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.stgv = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_PageNumber = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_search.Location = new System.Drawing.Point(572, 141);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(520, 56);
            this.txt_search.TabIndex = 28;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // stgv
            // 
            this.stgv.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.stgv.AllowUserToAddRows = false;
            this.stgv.AllowUserToDeleteRows = false;
            this.stgv.AllowUserToResizeColumns = false;
            this.stgv.AllowUserToResizeRows = false;
            this.stgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.stgv.ColumnHeadersHeight = 80;
            this.stgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.stgv.EnableHeadersVisualStyles = false;
            this.stgv.Location = new System.Drawing.Point(9, 235);
            this.stgv.Margin = new System.Windows.Forms.Padding(0);
            this.stgv.MultiSelect = false;
            this.stgv.Name = "stgv";
            this.stgv.ReadOnly = true;
            this.stgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stgv.RowHeadersWidth = 50;
            this.stgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stgv.RowTemplate.Height = 100;
            this.stgv.RowTemplate.ReadOnly = true;
            this.stgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stgv.Size = new System.Drawing.Size(2181, 792);
            this.stgv.TabIndex = 27;
            this.stgv.VirtualMode = true;
            this.stgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stgv_CellDoubleClick);
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(1163, 138);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(138, 76);
            this.btn_ok.TabIndex = 29;
            this.btn_ok.Text = "Chọn";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_PageNumber
            // 
            this.lbl_PageNumber.AutoSize = true;
            this.lbl_PageNumber.Location = new System.Drawing.Point(914, 1066);
            this.lbl_PageNumber.Name = "lbl_PageNumber";
            this.lbl_PageNumber.Size = new System.Drawing.Size(60, 25);
            this.lbl_PageNumber.TabIndex = 33;
            this.lbl_PageNumber.Text = "page";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(1012, 1054);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(116, 48);
            this.btn_next.TabIndex = 32;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(761, 1054);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(135, 48);
            this.btn_prev.TabIndex = 31;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // ChooseStudentForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2187, 1124);
            this.Controls.Add(this.lbl_PageNumber);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.stgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChooseStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn học sinh";
            this.Load += new System.EventHandler(this.ChoseStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView stgv;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_PageNumber;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
    }
}