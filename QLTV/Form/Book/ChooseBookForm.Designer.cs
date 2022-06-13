namespace QLTV.Book
{
    partial class ChooseBookForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bookgv
            // 
            this.bookgv.AllowUserToAddRows = false;
            this.bookgv.AllowUserToDeleteRows = false;
            this.bookgv.AllowUserToResizeColumns = false;
            this.bookgv.AllowUserToResizeRows = false;
            this.bookgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.bookgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bookgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
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
            this.bookgv.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookgv.Location = new System.Drawing.Point(0, 272);
            this.bookgv.Margin = new System.Windows.Forms.Padding(0);
            this.bookgv.MultiSelect = false;
            this.bookgv.Name = "bookgv";
            this.bookgv.ReadOnly = true;
            this.bookgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.bookgv.RowHeadersWidth = 50;
            this.bookgv.RowTemplate.Height = 50;
            this.bookgv.RowTemplate.ReadOnly = true;
            this.bookgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookgv.Size = new System.Drawing.Size(1968, 856);
            this.bookgv.StandardTab = true;
            this.bookgv.TabIndex = 24;
            this.bookgv.VirtualMode = true;
            this.bookgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookgv_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(406, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(867, 56);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(1337, 113);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(138, 76);
            this.btn_ok.TabIndex = 26;
            this.btn_ok.Text = "Chọn";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ChooseBookForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 1128);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bookgv);
            this.MaximizeBox = false;
            this.Name = "ChooseBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseBookForm";
            this.Load += new System.EventHandler(this.ChooseBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookgv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ok;
    }
}