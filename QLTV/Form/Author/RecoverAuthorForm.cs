using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLTV
{
    public partial class RecoverAuthorForm : Form
    {
        private DataTable m_Datatable;
        private AuthorBUS _authorBUS;
        public RecoverAuthorForm()
        {
            InitializeComponent();
            _authorBUS = new AuthorBUS();
        }

        private void RecoverAuthorForm_Load(object sender, EventArgs e)
        {
            IList<AuthorVO> bookList = _authorBUS.GetAllDeletedAuthors();
            m_Datatable = bookList.ToDataTable();
            if (bookList.Count > 0)
            {
                bookgv.DataSource = m_Datatable;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Text = "Khôi phục";
                btn.UseColumnTextForButtonValue = true;
                bookgv.Columns.Add(btn);
                bookgv.Columns[0].HeaderText = "Mã tác giả";
                bookgv.Columns[1].HeaderText = "Tên tác giả";
                bookgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                bookgv.Columns[0].Width = 200;
                bookgv.RowHeadersWidth = 25;

            }
            else
            {
                this.Close();
                MessageBox.Show("Danh sách rỗng", "Xem danh sách khôi phục", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void bookgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {

                int authorId = Convert.ToInt32(bookgv.CurrentRow.Cells[0].Value);
                string err = string.Empty;
                bool isAddSuc = _authorBUS.RecoverAuthor(ref err, authorId);

                if (isAddSuc)
                {

                    MessageBox.Show("Khôi phục  tác giả thành công!", "Khôi phục", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Khôi phục tác giả thất bại!", "Khôi phục", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(err, "Lý do", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
