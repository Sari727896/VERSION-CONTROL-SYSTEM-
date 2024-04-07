using project.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class UserAccess
    {
        public  UserAllowingAccess AllowingAccess { get; set; }
        public int UserId { get; set; }
        public UserAccess(UserAllowingAccess AllowingAccess,User user)
        {
            this.AllowingAccess= AllowingAccess;
            this.UserId = user.GetId;
        }
    }
}
