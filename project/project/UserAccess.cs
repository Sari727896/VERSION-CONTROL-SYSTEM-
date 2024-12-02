using project.Enums;
using project.Singelton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class UserAccess : ICloneable
    {
        private UserAccess userAccess;

        public UserAllowingAccess AllowingAccess { get; set; }
        public int UserId { get; set; }
        public UserAccess(UserAllowingAccess AllowingAccess, User user)
        {
            this.AllowingAccess = AllowingAccess;
            this.UserId = user.GetId;
        }



        public object Clone()
        {
            UserAllowingAccess clonedAllowingAccess = this.AllowingAccess;
            User user = GitApp.GetUserById(this.UserId);
            return new UserAccess(clonedAllowingAccess, user);
        }

    }
}
