using System.Collections.Generic;

namespace LibraryManagerDataAccess.Models
{
    public partial class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}