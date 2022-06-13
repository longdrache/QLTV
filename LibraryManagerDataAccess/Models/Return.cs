using System;

namespace LibraryManagerDataAccess.Models
{
    public partial class Return
    {
        public Return()
        {
        }

        public int ReturnId { get; set; }
        public int BookId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int StudentId { get; set; }
        public int IssueId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Issue Issue { get; set; }
        public virtual Student Student { get; set; }



    }
}
