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
using project.Composite;
using project.Enums;
using System.Net.Mime;
namespace project
{//the user is a invoker
    public class User:IReviewer
    {
        public string UserName { get; private set; }
        public UserAllowingAccess AllowingAccess { get; set; }
        private static int nextId = 1;

        private int id;
        public string Password { get;private set; }
        public string Email { get; private set; }
        public BranchItems ItemToCheck { get; set; }

        Queue<GitActionsCommand> actionsCommand;

        public User(string UserName, string password, string Email, UserAllowingAccess AllowingAccess)
        {
            this.UserName = UserName;
            this.id = nextId++;
            this.Password = password;
            this.Email = Email;
            actionsCommand= new Queue<GitActionsCommand>();
            this.AllowingAccess = AllowingAccess;
        }
        public Queue<GitActionsCommand> GetActionsCommand()
        {
            return actionsCommand;
        }
        public void PlaceSystemItemRequest(GitActionsCommand command)
        {
            actionsCommand.Enqueue(command);
        }
        public string DoJob()
        {
            string s = "";
            while(actionsCommand.Count >0)
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
        private string fromAddress = "sari727896@gmail.com"; 
        public void Update( string toAddress,BranchItems item)
        {
            //// Specify the sender's email address and password
            //string from = "srykhn95@gmail.com";
            //string password = "DesignPatern1!";
            //// Specify the recipient's email address
            //string to = "sari727896@gmail.com";
            //// Create and configure the SMTP client

            //SmtpClient client = new SmtpClient("smtp.gmail.com");

            //client.Port = 587; // Gmail SMTP port
            //client.EnableSsl = true; // Enable SSL/TLS
            //client.Credentials = new NetworkCredential(from, password);
            //client.UseDefaultCredentials = false;
            //// Create the email message

            //MailMessage message = new MailMessage(from, to);
            //message.Subject = "Test Email";
            //message.Body = "This is a test email sent from C#.";
            //try
            //{
            //    // Send the email
            //    client.Send(message);
            //    Console.WriteLine("Email sent successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Failed to send email. Error message: " + ex.Message);
            //}
            System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
            try
            {
                mailMessage.From = new System.Net.Mail.MailAddress("srykhn95@gmail.com", "sari727896@gmail.com.com");
                mailMessage.To.Add("srykhn95@gmail.com");
                mailMessage.Subject = "Hullo";
                mailMessage.Body = "This is a test";
                mailMessage.IsBodyHtml = true;
                System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("my-smtp-server");

                //Specifies how email messages are delivered. Here Email is sent through the network to an SMTP server.
                smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

                // Need auth. ?
                string loginName = "srykhn95@gmail.com";
                string loginPassword = "DesignPatern1!";
                //string domain = "my-domain";

                //System.Net.NetworkCredential networkCredential = new System.Net.NetworkCredential((loginName, loginPassword, domain);
                System.Net.NetworkCredential networkCredential = new System.Net.NetworkCredential(loginName, loginPassword);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;

                smtpClient.Send(mailMessage);

                mailMessage.Dispose();
                smtpClient = null;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                mailMessage.Dispose();
            }
        }

        public void ConfirmRequest()
        {
           ItemToCheck.ConfirmCommit();
        }

        public  int GetId
        {
            get { return id; }
        }
        
    }
}
