using System.Windows.Forms;

namespace QLTV
{
    public partial class MainLayout : UserControl
    {
        private static MainLayout _instance;
        public MainLayout()
        {
            InitializeComponent();
            lbl_hello.Text = $"Xin chào {MainForm.UserName}";
        }


        public static MainLayout Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainLayout();
                return _instance;
            }
        }

        public static void SetInstanceNull()
        {
            _instance = null;
        }
    }
}
