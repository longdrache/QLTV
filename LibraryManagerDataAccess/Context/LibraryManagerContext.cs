using LibraryManagerDataAccess.Maps;
using LibraryManagerDataAccess.Models;
using System.Data.Entity;

namespace LibraryManagerDataAccess.Context
{
    public partial class LibraryManagerContext : DbContext
    {

        public LibraryManagerContext()
            : base("name=LibraryManagerConnectionString")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Department> Deparments { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<Return> Returns { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new IssueMap());
            modelBuilder.Configurations.Add(new ReturnMap());
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
        }

    }
}
