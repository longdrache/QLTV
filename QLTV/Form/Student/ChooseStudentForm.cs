using LibraryManagerBussiness;
using LibraryManagerBussiness.VOs;
using PagedList;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace QLTV.Student
{
    public partial class ChooseStudentForm : Form
    {
        private StudentBUS _studentBUS;
        private DataTable m_DataTable;
        private IPagedList<StudentVO> studentPageList;
        int pageNumber = 1;
        public GenerateStudentVO ChosenStudent { get; set; }
        public ChooseStudentForm()
        {
            InitializeComponent();
            _studentBUS = new StudentBUS();
        }

        private void ChoseStudentForm_Load(object sender, EventArgs e)
        {
            GetDataStudent(true);


        }
        private void GetDataStudent(bool isStart = false)
        {
            if (isStart)
                pageNumber = 1;

            studentPageList = _studentBUS.GetSearchPageAllStudents(txt_search.Text);
            btn_prev.Enabled = studentPageList.HasPreviousPage;
            btn_next.Enabled = studentPageList.HasNextPage;
            lbl_PageNumber.Text = String.Format("Page {0}/{1}", pageNumber, studentPageList.PageCount);
            stgv.DataSource = studentPageList.ToList();
            SetHeaderAndFormat();
        }
        private void SetHeaderAndFormat()
        {
            stgv.Columns[0].HeaderText = "MSSV";
            stgv.Columns[1].HeaderText = "Họ và tên";
            stgv.Columns[2].HeaderText = "Ngày sinh";
            stgv.Columns[3].HeaderText = "Giới tính";
            stgv.Columns[4].HeaderText = "Khoa";
            stgv.Columns[5].HeaderText = "Tình trạng";

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
            GetDataStudent(true);
        }

        private void stgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ok.PerformClick();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (studentPageList.HasNextPage)
            {
                pageNumber++;
                GetDataStudent();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (studentPageList.HasPreviousPage)
            {
                pageNumber--;
                GetDataStudent();
            }

        }
    }
}
