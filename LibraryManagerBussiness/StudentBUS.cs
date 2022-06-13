using LibraryManagerBussiness.VOs;
using LibraryManagerDataAccess.Models;
using LibraryManagerDataAccess.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LibraryManagerBussiness
{
    public partial class StudentBUS
    {
        public StudentBUS()
        {
        }
        public bool GenerateStudent(ref string err, GenerateStudentVO studentVO)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Student student = new Student();
                    student.StudentId = studentVO.StudentId;
                    student.BirthDate = studentVO.Birthday;
                    student.FullName = studentVO.FullName;
                    student.Sex = studentVO.Sex;
                    student.DepartmentId = studentVO.DepartmentId;
                    student.State = studentVO.State;

                    uow.StudentRepository.Add(student);
                    uow.SaveChanges();
                }
                s = true;
            }
            catch (SqlException)
            {
                err = "Database disconnect!";
                s = false;
            }

            return s;
        }

        public IList<StudentVO> GetAllStudents()
        {
            IList<StudentVO> students;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Student> list = uow.StudentRepository.GetAll().ToList();
                IEnumerable<StudentVO> studentConvert = from st in list
                                                        select new StudentVO
                                                        {
                                                            StudentId = st.StudentId,
                                                            FullName = st.FullName,
                                                            Sex = st.Sex ? "Nam" : "Nữ",
                                                            Birthday = st.BirthDate.Value,
                                                            DepartmentName = st.Departments.DepartmentName,
                                                            State = st.State,
                                                        };


                students = studentConvert.ToList();
            }

            return students;
        }

    }
}
