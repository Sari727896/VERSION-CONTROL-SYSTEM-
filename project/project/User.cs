using project.Command;
using project.Osberver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System;




namespace project
{//the user is a invoker
    public class User:IReviewer
    {
        public string UserName { get; private set; }

        private static int nextId = 1;

        private int id;
        public string Password { get;private set; }
        public string Email { get; private set; }

        Queue<GitActionsCommand> actionsCommand;

        public User(string UserName, string password, string Email)
        {
            this.UserName = UserName;
            this.id = nextId++;
            this.Password = password;
            this.Email = Email;
            actionsCommand= new Queue<GitActionsCommand>();
        }
        public Queue<GitActionsCommand> GetActionsCommand()
        {
            return actionsCommand;
        }
        public void PlacesystemItemRequest(GitActionsCommand command)
        {
            actionsCommand.Enqueue(command);
        }
        public string DoJob()
        {
            string s = "";
            while(actionsCommand.Count > 0)
            {
                var commandToDO = actionsCommand.Dequeue();
                s += commandToDO.Execute();
                s += "\n";
            }
            return s;
        }
        public void ChangePassword(string Password, string newPassword)
        {
            if (this.Password == Password)
            {
                this.Password = newPassword;
                Console.WriteLine("Password changed successfully");
            }
            else
                Console.WriteLine("You do not have permission to change the password");
        }

        private string fromAddress = "sari727896@gmail.com"; // המייל שלך

        public void Update( string toAddress)
        {
            try
            {
                string subject = "File Review Notification";
                string body ="Review you need to check some file";

                SmtpClient smtpClient = new SmtpClient("smtp.example.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromAddress, Environment.GetEnvironmentVariable("EMAIL_PASSWORD")),
                    EnableSsl = true,
                };

                MailMessage mailMessage = new MailMessage(fromAddress, toAddress, subject, body);

                smtpClient.Send(mailMessage);

                Console.WriteLine("Email sent successfully from: " + fromAddress + " to: " + toAddress);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }

        public  int GetId
        {
            get { return id; }
        }
        
    }
}
