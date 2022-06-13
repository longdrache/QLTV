using System;
using System.Collections.Generic;

namespace LibraryManagerDataAccess.Models
{
    public partial class Student
    {
        public Student()
        {
            Issues = new HashSet<Issue>();
            Returns = new HashSet<Return>();
        }
        public int StudentId { get; set; }

        public string FullName { get; set; }
        public bool Sex { get; set; }
        public DateTime? BirthDate { get; set; }
        public StudentState State { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public byte[] Photo { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Departments { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<Return> Returns { get; set; }

    }
}
