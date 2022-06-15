using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using PagedList;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class UserListLayout : UserControl
    {
        private static UserListLayout _instance;
        private UserBUS _userBUS;
        private IPagedList<UserVO> userPageList;
        int pageNumber = 1;
        public UserListLayout()
        {
            InitializeComponent();
            _userBUS = new UserBUS();
        }
        public static UserListLayout Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserListLayout();
                return _instance;
            }
        }

        private void add_menu_Click(object sender, EventArgs e)
        {
            new UpdateAuthorForm().ShowDialog();
        }

        private void UserManagerLayout_Load(object sender, EventArgs e)
        {
            GetDataUser(true);
        }

        private void GetDataUser(bool isStart = false)
        {
            if (isStart)
                pageNumber = 1;
          
            userPageList = _userBUS.GetSearchPageList(txttimkiem.Text);
            btn_prev.Enabled = userPageList.HasPreviousPage;
            btn_next.Enabled = userPageList.HasNextPage;
            lbl_PageNumber.Text = String.Format("Page {0}/{1}", pageNumber, userPageList.PageCount);
            usergv.DataSource = userPageList.ToList();
            usergv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            usergv.Columns[0].Width = 100;
            usergv.Columns[0].HeaderText = "ID";
            usergv.Columns[1].HeaderText = "UserName";
            usergv.Columns[2].HeaderText = "Vai trò";
            usergv.RowHeadersWidth = 25;
           
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (userPageList.HasNextPage)
            {
                pageNumber++;
                GetDataUser();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (userPageList.HasPreviousPage)
            {
                pageNumber--;
                GetDataUser();
            }

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            GetDataUser(true);
        }
    }
}
