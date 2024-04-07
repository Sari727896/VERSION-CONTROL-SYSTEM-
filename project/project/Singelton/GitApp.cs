using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Singelton
{
    public class GitApp
    {
        public List<Branch> Branches { get; set; }
        public User CurrentUser { get; set; }
        public List<User> Users { get; set; }
        public Branch MainBranch { get; set; }

        static GitApp gitApp;
        private GitApp(User CurrentUser)
        {
            Branches=new List<Branch>();
            Users=new List<User>();
            var user=Users.Find(u=>u.GetId==CurrentUser.GetId);
        }
        public static object locker;
        static GitApp()
        {
            locker = new object();
        }

        public static GitApp GetInstance()
        {
            if (gitApp == null)
            {
                lock (locker)
                {
                    if (gitApp == null)
                    {
                        //gitApp = new GitApp();
                    }
                }
            }
            return gitApp;
        }
    }
}
