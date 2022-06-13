using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using System;
using System.Collections;
using System.Windows.Forms;

namespace QLTV.Issue
{
    public partial class LookBorrowedBook : Form
    {
        private int _studentId;
        private IssueBUS _issueBUS;
        private ReturnBUS _returnBUS;
        public LookBorrowedBook(int studentId)
        {
            InitializeComponent();
            _studentId = studentId;
            _issueBUS = new IssueBUS();
            _returnBUS = new ReturnBUS();
        }

        private void ListBorrowedBook_Load(object sender, EventArgs e)
        {
            IList issueList = _issueBUS.GetAllIssuesNotReturnByStudentId(_studentId);
            if (issueList.Count > 0)
            {
                bookgv.DataSource = issueList;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Text = "Trả sách";
                btn.UseColumnTextForButtonValue = true;
                bookgv.Columns.Add(btn);

                bookgv.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                bookgv.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
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
            if (e.ColumnIndex == 7)
            {

                int issueId = Convert.ToInt32(bookgv.CurrentRow.Cells[0].Value);
                int bookId = Convert.ToInt32(bookgv.CurrentRow.Cells[5].Value);
                string err = string.Empty;
                ReturnVO returnVO = new ReturnVO();
                returnVO.IssueId = issueId;
                returnVO.ReturnDate = DateTime.Now;
                returnVO.StudentId = _studentId;
                returnVO.BookId = bookId;
                bool isAddSuc = _returnBUS.AddReturnBook(ref err, returnVO);

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
