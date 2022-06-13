using LibraryManagerBussiness.VOs;
using QLTV.Issue;
using QLTV.Student;
using System;
using System.Windows.Forms;

namespace QLTV.Return
{
    public partial class LookBorrowedBookOfStudent : Form
    {
        private int _studentId;
        public LookBorrowedBookOfStudent()
        {
            InitializeComponent();
        }

        private void btn_chooseSt_Click(object sender, EventArgs e)
        {
            using (ChooseStudentForm frm = new ChooseStudentForm() { ChosenStudent = new GenerateStudentVO() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _studentId = frm.ChosenStudent.StudentId;
                    txt_studentId.Text = _studentId.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LookBorrowedBook(_studentId).ShowDialog();
        }
    }
}
