namespace LibraryManagerDataAccess.Models
{
    public partial class User
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public Role role { get; set; }


    }
}
