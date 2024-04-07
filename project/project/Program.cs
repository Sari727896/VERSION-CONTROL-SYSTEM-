// See https://aka.ms/new-console-template for more information

using project;
using static System.Console;
User user = new("123", "456", "789");
//user.ChangePassword("456", "12");
//WriteLine(user.UserName);
List<string> list = new List<string>();
list.Add("aaa");
var a = list.Find(j => j.Length == 3);
WriteLine("hello", a);
