using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using PagedList;
using QLTV.Return;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class ReturnBookLayout : UserControl
    {
        private static ReturnBookLayout _instance;
        private ReturnBUS _returnBUS;
        private int _studentId;
        IPagedList<ReturnVO> returnPageList;
        int pageNumber = 1;
        public ReturnBookLayout()
        {
            InitializeComponent();
            _returnBUS = new ReturnBUS();
        }


        public static ReturnBookLayout Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReturnBookLayout();
                return _instance;
            }
        }

        public static void SetInstanceNull()
        {
            _instance = null;
        }

        private void ReturnBookLayout_Load(object sender, System.EventArgs e)
        {
            GetDataReturn();
        }

        private void GetDataReturn(bool isStart = false)
        {

            if (isStart)
                pageNumber = 1;

            returnPageList = _returnBUS.GetSearchAllReturn(txttimkiem.Text,pageNumber);
            return_gv.DataSource = returnPageList.ToList();
            btn_prev.Enabled = returnPageList.HasPreviousPage;
            btn_next.Enabled = returnPageList.HasNextPage;
            lbl_PageNumber.Text = String.Format("Page {0}/{1}", pageNumber, returnPageList.PageCount);
            SetHeaderAndFormat();
        }

        private void SetHeaderAndFormat()
        {
            return_gv.Columns[2].Visible = false;
            return_gv.Columns[0].HeaderText = "Mã trả";
            return_gv.Columns[3].HeaderText = "Tên sách";
            return_gv.Columns[4].HeaderText = "MSSV";
            return_gv.Columns[5].HeaderText = "Họ và tên sinh viên";
            return_gv.Columns[6].HeaderText = "Ngày trả";
            return_gv.Columns[1].HeaderText = "Mã phát hành";
            return_gv.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            return_gv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            return_gv.RowHeadersWidth = 25;
            return_gv.Columns[0].Width = 150;
            return_gv.Columns[1].Width = 150;
        }

        private void xemSáchĐãMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LookBorrowedBookOfStudent().ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataReturn(true);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (returnPageList.HasNextPage)
            {
                pageNumber++;
                GetDataReturn();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (returnPageList.HasPreviousPage)
            {
                pageNumber--;
                GetDataReturn();
            }

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            GetDataReturn(true);
        }
    }
}
