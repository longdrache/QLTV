using LibraryManagerBussiness;
using LibraryManagerDataAccess.Models;
using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class LoginForm : Form
    {
        private UserBUS _userBUS;
        public LoginForm()
        {
            InitializeComponent();
            _userBUS = new UserBUS();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }
        private bool IsValidLogin()
        {
            if (txt_username.Text.Trim() == "" || txt_username.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txt_pass.Text == string.Empty)
            {
                MessageBox.Show("Xin vui lòng điền mật khẩu", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void Login()
        {
            if (IsValidLogin())
            {
                this.Cursor = Cursors.WaitCursor;
                string err = null;
                (bool IsLoginSuc, Role? Role) = _userBUS.Login(ref err, txt_username.Text.Trim(), txt_pass.Text);
                this.Cursor = Cursors.Default;
                if (IsLoginSuc)
                {

                    MessageBox.Show("Đăng nhập thành công!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new MainForm(txt_username.Text, Role.Value).Show();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(err, "Lý do", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_pass.Clear();

                }

            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_pass.Text == "")
                {
                    txt_pass.Focus();
                    e.SuppressKeyPress = true;
                }
                else
                    Login();
            }


        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_username.Text != "")
                    Login();
                if (txt_username.Text == "")
                {
                    txt_username.Focus();
                    e.SuppressKeyPress = true;
                }

            }

        }

    }
}
