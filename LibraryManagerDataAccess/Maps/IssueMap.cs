using LibraryManagerDataAccess.Models;
using System.Data.Entity.ModelConfiguration;

namespace LibraryManagerDataAccess.Maps
{
    public class IssueMap : EntityTypeConfiguration<Issue>
    {
        public IssueMap()
        {
            Property(i => i.DateIssue)
                .HasPrecision(10);
            Property(i => i.DateExpirary)
                .HasPrecision(10);
            HasMany(i => i.Returns)
              .WithRequired(i => i.Issue)
              .HasForeignKey(i => i.IssueId)
              .WillCascadeOnDelete(false);
        }
    }
}
