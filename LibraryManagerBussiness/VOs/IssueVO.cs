using System;

namespace LibraryManagerBussiness.VOs
{
    public sealed class IssueVO
    {
        public int IssueId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }




    }
}
