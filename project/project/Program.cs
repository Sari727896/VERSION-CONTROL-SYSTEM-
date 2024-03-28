// See https://aka.ms/new-console-template for more information

using project;
using static System.Console;
User user = new("123", "456", "789");
user.ChangePassword("456", "12");
WriteLine(user.UserName);
