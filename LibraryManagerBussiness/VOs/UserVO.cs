using LibraryManagerDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBussiness.VOs
{
    public sealed class UserVO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public Role Role { get; set; }
    }
}
