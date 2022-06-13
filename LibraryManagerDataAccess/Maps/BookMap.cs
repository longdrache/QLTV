using LibraryManagerDataAccess.Models;
using System.Data.Entity.ModelConfiguration;

namespace LibraryManagerDataAccess.Maps
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            Property(b => b.ISBN)
                .HasMaxLength(13);
            Property(b => b.Title)
               .IsRequired()
               .HasMaxLength(100);
            HasMany(b => b.Issues)
                 .WithRequired(i => i.Book)
                 .HasForeignKey(i => i.BookId)
                 .WillCascadeOnDelete(false);
            HasMany(b => b.Returns)
               .WithRequired(i => i.Book)
               .HasForeignKey(i => i.BookId)
               .WillCascadeOnDelete(false);
        }

    }
}
