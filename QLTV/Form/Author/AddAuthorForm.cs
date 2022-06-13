using LibraryManagerBussiness;
using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class AddAuthorForm : Form
    {
        private AuthorBUS _authorBUS;
        public AddAuthorForm()
        {
            InitializeComponent();
            _authorBUS = new AuthorBUS();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_author.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Xin vui lòng điền tên tác giả", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Add();
            }

        }
        private void Add()
        {
            string err = string.Empty;
            bool IsAddSuc = _authorBUS.AddAuthor(ref err, txt_author.Text.Trim());

            if (IsAddSuc)
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
