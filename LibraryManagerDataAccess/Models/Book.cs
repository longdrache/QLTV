using System.Collections.Generic;

namespace LibraryManagerDataAccess.Models
{
    public partial class Book
    {
        public Book()
        {
            Issues = new HashSet<Issue>();
            Returns = new HashSet<Return>();
        }
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int Book_Edition { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<Return> Returns { get; set; }
    }
}