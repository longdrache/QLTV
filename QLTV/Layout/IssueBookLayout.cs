using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using PagedList;
using QLTV.Issue;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class IssueBookLayout : UserControl
    {
        private static IssueBookLayout _instance;
        private IssueBUS _issueBUS;
        IPagedList<IssueVO> returnPageList;
        int pageNumber = 1;
        public IssueBookLayout()
        {
            InitializeComponent();
            _issueBUS = new IssueBUS();
        }
        public static IssueBookLayout Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new IssueBookLayout();
                return _instance;
            }
        }

        private void issuebook_Click(object sender, EventArgs e)
        {
            new IssueForm().ShowDialog();
        }


        private void IssueBookLayout_Load(object sender, EventArgs e)
        {
            GetDataIssue(true);
        }

        private void GetDataIssue(bool isStart = false)
        {
            if (isStart)
                pageNumber = 1;
            returnPageList = _issueBUS.GetSearchAllIssues(txttimkiem.Text,pageNumber);
            issue_gv.DataSource = returnPageList.ToList();
            btn_prev.Enabled = returnPageList.HasPreviousPage;
            btn_next.Enabled = returnPageList.HasNextPage;
            lbl_PageNumber.Text = String.Format("Page {0}/{1}", pageNumber, returnPageList.PageCount);
            SetHeaderAndFormat();
        }

        private void SetHeaderAndFormat()
        {
            issue_gv.RowHeadersWidth = 25;
            issue_gv.Columns[0].Width = 150;
            issue_gv.Columns[0].HeaderText = "Mã";
            issue_gv.Columns[1].HeaderText = "MSSV";
            issue_gv.Columns[2].HeaderText = "Họ và tên";
            issue_gv.Columns[3].HeaderText = "Ngày mượn";
            issue_gv.Columns[4].HeaderText = "Ngày dự kiến trả";
            issue_gv.Columns[6].HeaderText = "Tên sách";
            issue_gv.Columns[5].Visible = false;
            issue_gv.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            issue_gv.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

            issue_gv.Columns[0].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            issue_gv.Columns[1].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            issue_gv.Columns[2].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            issue_gv.Columns[3].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            issue_gv.Columns[4].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            issue_gv.Columns[5].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
            issue_gv.Columns[6].DefaultCellStyle.Font = new Font("Segoe UI Variable Display", 11);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataIssue(true);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (returnPageList.HasNextPage)
            {
                pageNumber++;
                GetDataIssue();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (returnPageList.HasPreviousPage)
            {
                pageNumber--;
                GetDataIssue();
            }

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            GetDataIssue(true);
        }
    }
}
