using System;

namespace LibraryManagerBussiness.VOs
{
    public sealed class ReturnVO
    {
        public int ReturnId { get; set; }
        public int BookId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int StudentId { get; set; }
        public int IssueId { get; set; }
    }
}
