using System;
using System.Collections.Generic;

namespace LibraryManagerDataAccess.Models
{
    public partial class Issue
    {
        public Issue()
        {
            Returns = new HashSet<Return>();
        }

        public int IssueId { get; set; }
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateIssue { get; set; }
        public DateTime DateExpirary { get; set; }
        public virtual Book Book { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<Return> Returns { get; set; }
    }

}
