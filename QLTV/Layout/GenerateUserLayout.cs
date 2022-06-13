using LibraryManagerBussiness;
using LibraryManagerBussiness.Models;
using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class GenerateUserLayout : UserControl
    {
        private static GenerateUserLayout _instance;
        private UserBUS _userBUS;
        public GenerateUserLayout()
        {
            InitializeComponent();
            _userBUS = new UserBUS();

        }
        public static GenerateUserLayout Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GenerateUserLayout();
                return _instance;
            }
        }
        private void btn_generate_Click(object sender, EventArgs e)
        {
            GenerateUser();
        }
        private bool IsValidGenerate()
        {
            if (txt_username.Text.Trim() == "" || txt_username.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ!", "Cấp tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txt_pass.Text == "")
            {
                MessageBox.Show("Xin vui lòng điền mật khẩu", "Cấp tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txt_cpass.Text == "" || txt_cpass.Text != txt_pass.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không hợp lệ", "Cấp tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void GenerateUser()
        {
            if (IsValidGenerate())
            {
                this.Cursor = Cursors.WaitCursor;
                string err = null;
                RegisterVO user = new RegisterVO();
                user.UserName = txt_username.Text.Trim();
                user.Password = txt_pass.Text;
                user.ConfirmPassword = txt_cpass.Text;
                bool IsSuccessful = _userBUS.GenerateUser(ref err, user);
                this.Cursor = Cursors.Default;
                if (IsSuccessful)
                {

                    MessageBox.Show("Tạo  thành công!", "Tạo tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_username.Clear();
                    txt_pass.Clear();
                    txt_cpass.Clear();
                }
                else
                {
                    MessageBox.Show("Tạo thất bại!", "Tạo tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(err, "Lý do", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
