
using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using PagedList;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLTV.Book
{
    public partial class ChooseBookForm : Form
    {
        public BookVO ChosenBook { get; set; }
        private BookBUS _bookBUS;
        int pageNumber = 1;
        IPagedList<BookVO> bookPageList;
        public ChooseBookForm()
        {
            InitializeComponent();
            _bookBUS = new BookBUS();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (bookgv.Rows.Count != 0)
            {
                string bookName = bookgv.CurrentRow.Cells[1].Value.ToString();
                int authorId = Convert.ToInt32(bookgv.CurrentRow.Cells[4].Value);
                int bookId = Convert.ToInt32(bookgv.CurrentRow.Cells[0].Value);
                int edition = Convert.ToInt32(bookgv.CurrentRow.Cells[6].Value);
                string description = bookgv.CurrentRow.Cells[5].Value.ToString();
                string isbn = bookgv.CurrentRow.Cells[2].Value.ToString();
                ChosenBook.BookId = bookId;
                ChosenBook.Title = bookName;
                ChosenBook.AuthorId = authorId;
                ChosenBook.Edition = edition;
                ChosenBook.Description = description;
                ChosenBook.ISBN = isbn;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }



        }

        private void ChooseBookForm_Load(object sender, EventArgs e)
        {
            GetDataBook(true);
        }
        private void GetDataBook(bool isStart = false)
        {
            if (isStart)
                pageNumber = 1;

            bookPageList = _bookBUS.GetSearchPageList(txt_search.Text, pageNumber);
            btn_prev.Enabled = bookPageList.HasPreviousPage;
            btn_next.Enabled = bookPageList.HasNextPage;
            lbl_PageNumber.Text = String.Format("Page {0}/{1}", pageNumber, bookPageList.PageCount);

            bookgv.DataSource = bookPageList.ToList();
            SetHeaderName();
        }

        private void SetHeaderName()
        {
            // Set header name
            bookgv.Columns[0].HeaderText = "Mã số";

            bookgv.Columns[1].HeaderText = "Tên sách";

            bookgv.Columns[2].HeaderText = "ISBN";

            bookgv.Columns[3].HeaderText = "Tên tác giả";
            bookgv.Columns[4].HeaderText = "Mã tác giả";
            bookgv.Columns[5].HeaderText = "Miêu tả";
            bookgv.Columns[6].HeaderText = "Tái bản";

            bookgv.Columns[0].Width = 80;
            bookgv.RowHeadersWidth = 25;
            bookgv.Columns[1].Width = 400;

            bookgv.Columns[2].Width = 250;

            bookgv.Columns[3].Width = 360;
            bookgv.Columns[4].Visible = false;//authorId

            // Set font
            bookgv.Columns[0].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            bookgv.Columns[1].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            bookgv.Columns[2].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            bookgv.Columns[3].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            bookgv.Columns[4].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            bookgv.Columns[5].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            bookgv.Columns[6].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
        }

        private void bookgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ok.PerformClick();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (bookPageList.HasNextPage)
            {
                pageNumber++;
                GetDataBook();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (bookPageList.HasPreviousPage)
            {
                pageNumber--;
                GetDataBook();
            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            GetDataBook(true);
        }
    }
}
