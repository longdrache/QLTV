using LibraryManagerBussiness;
using QLTV.Issue;
using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class IssueBookLayout : UserControl
    {
        private static IssueBookLayout _instance;
        private IssueBUS _issueBUS;
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


        private void issue_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void issuebook_Click(object sender, EventArgs e)
        {
            new IssueForm().ShowDialog();
        }

        private void IssueBookLayout_Load(object sender, EventArgs e)
        {
            issue_gv.DataSource = _issueBUS.GetAllIssues();
            issue_gv.Columns[4].Visible = false;
            issue_gv.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            issue_gv.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}
