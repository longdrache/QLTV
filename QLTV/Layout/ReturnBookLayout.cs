using LibraryManagerBussiness;
using QLTV.Return;
using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class ReturnBookLayout : UserControl
    {
        private static ReturnBookLayout _instance;
        private ReturnBUS _returnBUS;
        private int _studentId;
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

        private void GetDataReturn()
        {
            return_gv.DataSource = _returnBUS.GetAllReturn();
            return_gv.Columns[3].Visible = false;
            return_gv.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            return_gv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void xemSáchĐãMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LookBorrowedBookOfStudent().ShowDialog();
        }
    }
}
