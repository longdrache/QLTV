using LibraryManagerBussiness;
using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class UpdateAuthorForm : Form
    {
        private AuthorBUS _authorBUS;
        public UpdateAuthorForm()
        {
            InitializeComponent();
            _authorBUS = new AuthorBUS();

        }
        private void GetDataAuthor()
        {
            author_list.DataSource = _authorBUS.GetAllAuthors();
            author_list.DisplayMember = "AuthorName";
            author_list.ValueMember = "AuthorId";
        }



        private void add_menu_Click(object sender, EventArgs e)
        {
            new AddAuthorForm().ShowDialog();
        }

        private void UpdateAuthorForm_Load(object sender, EventArgs e)
        {
            GetDataAuthor();
        }

        private void refresh_menu_Click(object sender, EventArgs e)
        {
            GetDataAuthor();
        }

        private void refresh_r_menu_Click(object sender, EventArgs e)
        {
            GetDataAuthor();
        }

        private void remove_menu_Click(object sender, EventArgs e)
        {
            DeleteAuthor();

        }

        private void delete_r_menu_Click(object sender, EventArgs e)
        {
            DeleteAuthor();

        }

        private void DeleteAuthor()
        {
            int index = author_list.SelectedIndex;
            string err = string.Empty;
            if (index > -1)
                _authorBUS.RemoveAuthor(ref err, Convert.ToInt32(author_list.SelectedValue));

            GetDataAuthor();
        }

        private void edit_menu_Click(object sender, EventArgs e)
        {
            int index = author_list.SelectedIndex;
            if (index > -1)
                new ChangeNameAuthorForm(Convert.ToInt32(author_list.SelectedValue)).ShowDialog();
        }

        private void recover_menu_Click(object sender, EventArgs e)
        {
            new RecoverAuthorForm().ShowDialog();

        }

        private void edit_r_menu_Click(object sender, EventArgs e)
        {
            int index = author_list.SelectedIndex;
            if (index > -1)
                new ChangeNameAuthorForm(Convert.ToInt32(author_list.SelectedValue)).ShowDialog();
        }
    }
}
