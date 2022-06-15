using LibraryManagerDataAccess.Models;
using System.Windows.Forms;

namespace QLTV
{
    public partial class MainForm : Form
    {
        private Role? _role;
        public static string UserName;
        private bool _isClosed = false; //prevent double messagebox 

        public MainForm(string userName, Role role)
        {

            UserName = userName;
            _role = role;
            InitializeComponent();
            if (_role != Role.Admin)
            {
                btn_generate_user.Hide();
                btn_userManager.Hide();
            }
            ShowMainLayout();
        }

        private void btn_home_Click(object sender, System.EventArgs e)
        {
            ShowMainLayout();
        }

        private void btn_exit_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _isClosed = true;
                Application.Exit();

            }
        }

        private void btn_logout_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                MainLayout.SetInstanceNull();
                new LoginForm().Show();
            }

        }

        private void btn_generate_user_Click(object sender, System.EventArgs e)
        {
            ShowGenerateUserLayout();
        }
        private void btn_update_book_Click(object sender, System.EventArgs e)
        {
            ShowBookUpdateLayout();
        }
        private void btn_issue_Click(object sender, System.EventArgs e)
        {
            ShowIssueBookLayout();
        }

        private void btn_updateAuthor_Click(object sender, System.EventArgs e)
        {
            ShowAuthorUpdateLayout();
        }
        private void btn_getBooksFromStudent_Click(object sender, System.EventArgs e)
        {
            ShowReturnBookLayout();
        }
        //Show Layout 
        private void ShowMainLayout()
        {
            if (!panelForChange.Controls.Contains(MainLayout.Instance))
            {
                panelForChange.Controls.Add(MainLayout.Instance);
                MainLayout.Instance.Dock = DockStyle.Fill;


            }
            MainLayout.Instance.BringToFront();
        }
        private void ShowGenerateUserLayout()
        {
            if (!panelForChange.Controls.Contains(GenerateUserLayout.Instance))
            {
                panelForChange.Controls.Add(GenerateUserLayout.Instance);
                GenerateUserLayout.Instance.Dock = DockStyle.Fill;


            }
            GenerateUserLayout.Instance.BringToFront();
        }
        private void ShowAuthorUpdateLayout()
        {
            if (!panelForChange.Controls.Contains(UserListLayout.Instance))
            {
                panelForChange.Controls.Add(UserListLayout.Instance);
                UserListLayout.Instance.Dock = DockStyle.Fill;


            }
            UserListLayout.Instance.BringToFront();
        }
        private void ShowIssueBookLayout()
        {
            if (!panelForChange.Controls.Contains(IssueBookLayout.Instance))
            {
                panelForChange.Controls.Add(IssueBookLayout.Instance);
                IssueBookLayout.Instance.Dock = DockStyle.Fill;


            }
            IssueBookLayout.Instance.BringToFront();
        }
        private void ShowBookUpdateLayout()
        {
            if (!panelForChange.Controls.Contains(BookUpdateLayout.Instance))
            {
                panelForChange.Controls.Add(BookUpdateLayout.Instance);
                BookUpdateLayout.Instance.Dock = DockStyle.Fill;


            }
            BookUpdateLayout.Instance.BringToFront();
        }
        private void ShowReturnBookLayout()
        {
            if (!panelForChange.Controls.Contains(ReturnBookLayout.Instance))
            {
                panelForChange.Controls.Add(ReturnBookLayout.Instance);
                ReturnBookLayout.Instance.Dock = DockStyle.Fill;


            }
            ReturnBookLayout.Instance.BringToFront();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClosed == false)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            _isClosed = true;
            Application.Exit();

        }
    }
}
