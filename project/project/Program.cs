// See https://aka.ms/new-console-template for more information

using project;
using project.Singelton;
using static System.Console;
User user = new("123", "456", "789");
//user.ChangePassword("456", "12");
GitApp gitApp = GitApp.GetInstance();
gitApp.ChangeCurrentUser(user);
WriteLine(user.UserName);

//user.Update("sari727896@gmail.com");
