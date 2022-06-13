using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class EditBookForm : Form
    {

        private BookBUS _bookBUS;
        private AuthorBUS _authorBUS;
        private string _namebook;
        private int _authorId;
        private int _edition;
        private string _isbn;
        private string _description;
        private int _bookId;

        public EditBookForm(int bookId, string namebook, int authorId, int edition, string isbn, string description)
        {
            InitializeComponent();
            _bookBUS = new BookBUS();
            _authorBUS = new AuthorBUS();
            _isbn = isbn;
            _description = description;
            _namebook = namebook;
            _authorId = authorId;
            _edition = edition;
            _bookId = bookId;
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            InitToChange();
        }

        private void InitToChange()
        {
            GetAuthor();
            txt_bookName.Text = _namebook;
            txt_edition.Text = _edition.ToString();
            txt_isbn.Text = _isbn.ToString();
            rtxt_desc.Text = _description;
            cb_author.SelectedValue = _authorId;
        }

        private void GetAuthor()
        {
            cb_author.DataSource = _authorBUS.GetAllAuthors();
            cb_author.DisplayMember = "AuthorName";
            cb_author.ValueMember = "AuthorId";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            BookVO book = new BookVO();
            book.Title = txt_bookName.Text;
            book.Edition = Convert.ToInt32(txt_edition.Text);
            book.ISBN = txt_isbn.Text;
            book.Description = rtxt_desc.Text;
            book.AuthorId = Convert.ToInt32(cb_author.SelectedValue);
            book.BookId = _bookId;
            string err = string.Empty;
            bool IsEditSuc = _bookBUS.UpdateBook(ref err, book);


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
