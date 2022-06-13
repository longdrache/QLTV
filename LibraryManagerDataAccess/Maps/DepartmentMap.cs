using LibraryManagerDataAccess.Models;
using System.Data.Entity.ModelConfiguration;

namespace LibraryManagerDataAccess.Maps
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            HasMany(dp => dp.Students)
              .WithRequired(i => i.Departments)
              .HasForeignKey(i => i.DepartmentId)
              .WillCascadeOnDelete(false);
        }

    }
}
