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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.stgv = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_search.Location = new System.Drawing.Point(389, 193);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stgv.ColumnHeadersHeight = 80;
            this.stgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.stgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stgv.EnableHeadersVisualStyles = false;
            this.stgv.Location = new System.Drawing.Point(0, 302);
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
            this.stgv.Size = new System.Drawing.Size(1762, 779);
            this.stgv.TabIndex = 27;
            this.stgv.VirtualMode = true;
            this.stgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stgv_CellDoubleClick);
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(969, 182);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(138, 76);
            this.btn_ok.TabIndex = 29;
            this.btn_ok.Text = "Chọn";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ChooseStudentForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 1081);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.stgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ChooseStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentChoseForm";
            this.Load += new System.EventHandler(this.ChoseStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView stgv;
        private System.Windows.Forms.Button btn_ok;
    }
}