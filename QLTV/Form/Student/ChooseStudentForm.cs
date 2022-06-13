using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using System;
using System.Data;
using System.Windows.Forms;
namespace QLTV.Student
{
    public partial class ChooseStudentForm : Form
    {
        private StudentBUS _studentBUS;
        private DataTable m_DataTable;
        public GenerateStudentVO ChosenStudent { get; set; }
        public ChooseStudentForm()
        {
            InitializeComponent();
            _studentBUS = new StudentBUS();
        }

        private void ChoseStudentForm_Load(object sender, EventArgs e)
        {

            m_DataTable = _studentBUS.GetAllStudents().ToDataTable();



            m_DataTable.Columns[0].ColumnName = "MSSV";
            m_DataTable.Columns[1].ColumnName = "Họ và tên";
            m_DataTable.Columns[2].ColumnName = "Ngày sinh";
            m_DataTable.Columns[3].ColumnName = "Giới tính";
            m_DataTable.Columns[4].ColumnName = "Khoa";
            m_DataTable.Columns[5].ColumnName = "Tình trạng";

            stgv.DataSource = m_DataTable;
            stgv.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            stgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (stgv.Rows.Count != 0)
            {
                int studnetId = Convert.ToInt32(stgv.CurrentRow.Cells[0].Value);
                ChosenStudent.StudentId = studnetId;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }



        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            stgv.DataSource = m_DataTable.SearchInAllColums(txt_search.Text, StringComparison.OrdinalIgnoreCase);
        }

        private void stgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ok.PerformClick();
        }
    }
}
