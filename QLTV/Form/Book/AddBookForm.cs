using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class AddBookForm : Form
    {
        private BookBUS _bookBUS;
        private AuthorBUS _authorBUS;
        public AddBookForm()
        {
            InitializeComponent();
            _bookBUS = new BookBUS();
            _authorBUS = new AuthorBUS();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (IsSafeForAdd())
                AddBook();
        }

        private void AddBook()
        {
            string err = string.Empty;
            BookVO book = new BookVO();
            book.Title = txt_bookName.Text.Trim();
            book.ISBN = txt_Isbn.Text;
            book.AuthorId = Convert.ToInt32(cb_author.SelectedValue);
            book.Description = rtxt_desc.Text.Trim();
            book.Edition = Convert.ToInt32(cb_edition.Text);
            bool IsAddSuc = _bookBUS.AddBook(ref err, book);

            if (IsAddSuc)
            {
                MessageBox.Show("Thêm sách thành công!", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Thêm sách  thất bại!", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(err, "Lý do", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsSafeForAdd()
        {
            if (txt_bookName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Tên không được để trống!", "Tên sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Char.IsNumber(cb_edition.Text,0))
            {
                MessageBox.Show("Giá trị không hợp lệ", "Tái bản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
             
            }
            if (cb_author.SelectedValue == null)
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Tác giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void GetAuthor()
        {
            cb_author.DataSource = _authorBUS.GetAllAuthors();
            cb_author.DisplayMember = "AuthorName";
            cb_author.ValueMember = "AuthorId";
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            GetAuthor();
        }
    }
}
