using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class ChangeNameAuthorForm : Form
    {
        private int _authorId;
        private AuthorBUS _authorBUS;
        public ChangeNameAuthorForm(int authorId)
        {
            InitializeComponent();
            _authorId = authorId;
            _authorBUS = new AuthorBUS();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ChangeNameAuthor();
        }

        private void ChangeNameAuthor()
        {
            AuthorVO author = new AuthorVO();
            author.AuthorId = _authorId;
            author.AuthorName = txt_author.Text.Trim();
            string err = string.Empty;
            bool IsEditSuc = _authorBUS.UpdateAuthor(ref err, author);


            if (IsEditSuc)
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
    }
}
