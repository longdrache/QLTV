using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class AuthorUpdateLayout : UserControl
    {
        private static AuthorUpdateLayout _instance;
        public AuthorUpdateLayout()
        {
            InitializeComponent();
        }
        public static AuthorUpdateLayout Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AuthorUpdateLayout();
                return _instance;
            }
        }

        private void làmMớiTrangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void add_menu_Click(object sender, EventArgs e)
        {
            new UpdateAuthorForm().ShowDialog();
        }
    }
}
