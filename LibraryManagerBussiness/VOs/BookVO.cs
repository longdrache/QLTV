namespace LibraryManagerBussiness.VOs
{
    public sealed class BookVO
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        public string AuthorName { get; set; }
        public int AuthorId { get; set; }
        
        public string Description { get; set; }
        public int Edition { get; set; }
    }
}
