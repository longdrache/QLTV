using LibraryManagerDataAccess.Models;
using System.Data.Entity.ModelConfiguration;

namespace LibraryManagerDataAccess.Maps
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            HasMany(au => au.Books)
              .WithRequired(b => b.Author)
              .HasForeignKey(b => b.AuthorId)
              .WillCascadeOnDelete(false);
        }
    }
}
