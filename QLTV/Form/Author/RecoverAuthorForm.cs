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

                bookgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                this.Close();
                MessageBox.Show("Danh sách rỗng", "Xem sách đã mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                    MessageBox.Show("Thêm tác giả thành công!", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Thêm tác giả thất bại!", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(err, "Lý do", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {

            }
        }
    }
}
