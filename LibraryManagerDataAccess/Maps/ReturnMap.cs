using LibraryManagerDataAccess.Models;
using System.Data.Entity.ModelConfiguration;

namespace LibraryManagerDataAccess.Maps
{
    public class ReturnMap : EntityTypeConfiguration<Return>
    {
        public ReturnMap()
        {

            Property(r => r.ReturnDate)
                .HasPrecision(10);
        }
    }
}
