using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Singelton
{//לשנות לממש אם קיים userלפי הפונקציה שיצרנו שבודקת
    public class GitApp
    {
        public List<Branch> Branches { get; set; }
        public User CurrentUser { get; set; }
        public static List<User> Users { get; set; }//האם נכון לעשות את זה static
        public Branch MainBranch { get; set; }

        static GitApp gitApp;
        private GitApp(User CurrentUser)
        {
            Branches=new List<Branch>();
            Users=new List<User>();
            AddUserIfNotExists(CurrentUser);
            this.CurrentUser = CurrentUser;
            MainBranch = new Branch("Main");
        }
        public static object locker;
        static GitApp()
        {
            locker = new object();
        }

        public static GitApp GetInstance()
        {
            User currentUser = new("Sari727896", "Sa326", "sari727896@gmail.com");
            if (gitApp == null)
            {
                lock (locker)
                {
                    if (gitApp == null)
                    {
                        gitApp = new GitApp(currentUser);
                    }
                }
            }
            return gitApp;
        }
        public void AddBranch(Branch branch)
        {
            Branches.Add(branch);          
        }
        public void DeleteBranch(Branch branch)
        {
            var branchToRemoove = Branches.Find(B => B.Name == branch.Name);
            Branches.Remove(branchToRemoove);
        }
        public void AddUser(User user)
        {
            AddUserIfNotExists(user);
        }
        public void DeleteUser(User user)
        {
            var userToAdd = Users.Find(u => u.GetId == user.GetId);
            if (userToAdd == null)
            {
                Users.Remove(user);
            }
        }
        public void ChangeCurrentUser(User user)
        {
            AddUserIfNotExists(user);
            this.CurrentUser = user;
        }
        public void AddUserIfNotExists(User user)
        {
            var userToAdd = Users.Find(u => u.GetId == user.GetId);
            if (userToAdd == null)
            {
                Users.Add(userToAdd);
            }
        }
        public static User GetUserById(int  id)
        {
            var user= Users.Find(u => u.GetId ==id);
            return user;
        }
    }
}
