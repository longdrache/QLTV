using ClosedXML.Excel;
using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using PagedList;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class BookUpdateLayout : UserControl
    {
        private static BookUpdateLayout _instance;
        private BookBUS _bookBUS;
        private IPagedList<BookVO> bookPageList;
        int pageNumber = 1;
        public BookUpdateLayout()
        {
            InitializeComponent();
            _bookBUS = new BookBUS();
            GetDataBook(true);
        }
        public static BookUpdateLayout Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BookUpdateLayout();
                return _instance;
            }
        }

        private void menu_addBook_Click(object sender, EventArgs e)
        {
            new AddBookForm().ShowDialog();
        }


        private void menu_refresh_Click(object sender, EventArgs e)
        {
            GetDataBook(true);
        }
        private void GetDataBook(bool isStart = false)
        {
            if (isStart)
                pageNumber = 1;

            bookPageList = _bookBUS.GetSearchPageList(txttimkiem.Text, pageNumber);
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

        private void updateAuthor_menu_Click(object sender, EventArgs e)
        {
            new UpdateAuthorForm().ShowDialog();
        }

        private void editBook_menu_Click(object sender, EventArgs e)
        {

            string bookName = bookgv.CurrentRow.Cells[1].Value.ToString();
            int authorId = Convert.ToInt32(bookgv.CurrentRow.Cells[4].Value);
            int bookId = Convert.ToInt32(bookgv.CurrentRow.Cells[0].Value);
            int edition = Convert.ToInt32(bookgv.CurrentRow.Cells[6].Value);
            string description = bookgv.CurrentRow.Cells[5].Value.ToString();
            string isbn = bookgv.CurrentRow.Cells[2].Value.ToString();
            new EditBookForm(bookId, bookName, authorId, edition, isbn, description).ShowDialog();
        }

        private void deleteBook_menu_Click(object sender, EventArgs e)
        {
            if (bookgv.Rows.Count != 0)
            {
                int bookId = Convert.ToInt32(bookgv.CurrentRow.Cells[0].Value);
                string err = string.Empty;
                bool isDelSuccessful = _bookBUS.RemoveBook(ref err, bookId);
                if (isDelSuccessful)
                {
                    MessageBox.Show("Xóa thành công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(err, "Xóa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void export_menu_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook xlw = new XLWorkbook())
                        {
                            DataTable exportData = _bookBUS.GetAllBooks().ToDataTable();
                            // Set column header name
                            exportData.Columns[0].ColumnName = "Mã số";
                            exportData.Columns[1].ColumnName = "Tên sách";
                            exportData.Columns[2].ColumnName = "ISBN";
                            exportData.Columns[3].ColumnName = "Tên tác giả";
                            exportData.Columns[4].ColumnName = "Mã tác giả";
                            exportData.Columns[5].ColumnName = "Miêu tả";
                            exportData.Columns[6].ColumnName = "Tái bản";

                            exportData.Columns.RemoveAt(4);//remove AuthorId
                            xlw.Worksheets.Add(exportData, "Book");
                            xlw.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("ok");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            GetDataBook(true);
            //bookgv.DataSource = exportData.SearchInAllColums(txttimkiem.Text, StringComparison.OrdinalIgnoreCase);
        }

        private void recover_menu_Click(object sender, EventArgs e)
        {
            new RecoverBookForm().ShowDialog();
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteBook_menu.PerformClick();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editBook_menu.PerformClick();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refresh_menu.PerformClick();
        }
    }
}
