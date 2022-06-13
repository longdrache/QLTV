using LibraryManagerDataAccess.Models;
using System;

namespace LibraryManagerBussiness.VOs
{
    public sealed class GenerateStudentVO
    {
        public int StudentId { get; set; }
        public string FullName { set; get; }
        public DateTime Birthday { set; get; }
        public int DepartmentId { set; get; }
        public bool Sex { get; set; }
        public StudentState State { set; get; }
    }
}
