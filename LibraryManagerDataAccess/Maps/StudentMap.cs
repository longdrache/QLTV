using LibraryManagerDataAccess.Models;
using System.Data.Entity.ModelConfiguration;

namespace LibraryManagerDataAccess.Maps
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            Property(st => st.FullName)
               .IsRequired()
               .HasMaxLength(60);
            Property(st => st.BirthDate).HasPrecision(0);
            Property(st => st.Address).HasMaxLength(100);
            Property(st => st.PhoneNumber).HasMaxLength(11);
            HasMany(st => st.Issues)
             .WithRequired(i => i.Student)
             .HasForeignKey(i => i.StudentId)
             .WillCascadeOnDelete(false);
            HasMany(st => st.Returns)
           .WithRequired(i => i.Student)
           .HasForeignKey(i => i.StudentId)
           .WillCascadeOnDelete(false);
        }
    }
}
