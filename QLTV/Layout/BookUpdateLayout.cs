using ClosedXML.Excel;
using LibraryManagerBussiness;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLTV
{
    public partial class BookUpdateLayout : UserControl
    {
        private static BookUpdateLayout _instance;
        private BookBUS _bookBUS;
        private DataTable m_DataTable;
        public BookUpdateLayout()
        {
            InitializeComponent();
            _bookBUS = new BookBUS();
            GetDataBook();
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
            GetDataBook();
        }
        private void GetDataBook()
        {


            m_DataTable = _bookBUS.GetAllBooks().ToDataTable();



            m_DataTable.Columns[0].ColumnName = "Mã số";

            m_DataTable.Columns[1].ColumnName = "Tên sách";

            m_DataTable.Columns[2].ColumnName = "ISBN";

            m_DataTable.Columns[3].ColumnName = "Tên tác giả";
            m_DataTable.Columns[4].ColumnName = "Mã tác giả";
            m_DataTable.Columns[5].ColumnName = "Miêu tả";
            m_DataTable.Columns[6].ColumnName = "Tái bản";
            bookgv.DataSource = m_DataTable;
            bookgv.Columns[0].Width = 80;
            bookgv.RowHeadersWidth = 25;
            bookgv.Columns[1].Width = 400;

            bookgv.Columns[2].Width = 250;

            bookgv.Columns[3].Width = 360;
            bookgv.Columns[4].Visible = false;//authorId

            //set font
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
                            DataTable exportData = m_DataTable;
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
            bookgv.DataSource = m_DataTable.SearchInAllColums(txttimkiem.Text, StringComparison.OrdinalIgnoreCase);
        }

        private void recover_menu_Click(object sender, EventArgs e)
        {
            new RecoverBookForm().ShowDialog();
        }
    }
}
