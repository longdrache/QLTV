using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using QLTV.Book;
using QLTV.Student;
using System;
using System.Windows.Forms;

namespace QLTV.Issue
{
    public partial class IssueForm : Form
    {
        private IssueBUS _issueBUS;
        private int _bookId;
        public IssueForm()
        {
            InitializeComponent();
            _issueBUS = new IssueBUS();
            dtp_issue.Value = DateTime.Now;
            dtp_expirary.Value = DateTime.Now.AddMonths(4);
        }


        private void btn_chooseBook_Click(object sender, EventArgs e)
        {
            using (ChooseBookForm frm = new ChooseBookForm() { ChosenBook = new BookVO() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txt_bookName.Text = frm.ChosenBook.Title;
                    _bookId = frm.ChosenBook.BookId;
                }
            }
        }



        private void btn_chooseSt_Click(object sender, EventArgs e)
        {
            using (ChooseStudentForm frm = new ChooseStudentForm() { ChosenStudent = new GenerateStudentVO() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txt_studentId.Text = frm.ChosenStudent.StudentId.ToString();
                }
            }

        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            if (IsSafeForAdd())
            {
                AddIssue();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin cho mượn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private bool IsSafeForAdd()
        {
            if (txt_bookName.Text.Length == 0) return false;
            if (txt_studentId.Text.Length == 0) return false;
            return true;
        }
        private void AddIssue()
        {
            int studentId = Convert.ToInt32(txt_studentId.Text);
            int bookId = Convert.ToInt32(_bookId);
            DateTime issue_date = DateTime.Now;
            DateTime issue_return = Convert.ToDateTime(dtp_expirary.Value);

            IssueVO issue = new IssueVO();
            issue.StudentId = studentId;
            issue.BookId = bookId;
            issue.IssueDate = issue_date;
            issue.ReturnDate = issue_return;
            string err = string.Empty;
            bool IsAddSuc = _issueBUS.AddIssue(ref err, issue);

            if (IsAddSuc)
            {

                MessageBox.Show("Cho mượn thành công!", "Cho mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Cho mươn thất bại!", "Cho mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(err, "Lý do", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
