using LibraryManagerDataAccess.Models;
using System;

namespace LibraryManagerBussiness.VOs
{
    public sealed class StudentVO
    {
        public int StudentId { get; set; }
        public string FullName { set; get; }
        public DateTime Birthday { set; get; }
        public string Sex { get; set; }
        public string DepartmentName { set; get; }
        public StudentState State { set; get; }


    }
}
