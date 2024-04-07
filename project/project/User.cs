using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class User
    {
        public string UserName { get;private set; }

        private static int nextId = 1;

        private int id;
        private string Password {  get; set; }
        public string Email { get;private set; }
        public User(string UserName,string password,string Email)
        {
            this.UserName = UserName;
            this.id= nextId++;
            this.Password=password;
            this.Email=Email;
        }
        public void ChangePassword(string Password,string newPassword)
        {
            if (this.Password == Password)
            {
                this.Password = newPassword;
                Console.WriteLine("Password changed successfully");
            }
            else
                Console.WriteLine("You do not have permission to change the password");
        }
        public int GetId
        {
            get { return id; }
        }
    }
}
