// See https://aka.ms/new-console-template for more information

using project;
using project.Composite;
using project.Flyweight;
using project.Singelton;
using static System.Console;
#region GitApp
User user1 = new("Sari Choen", "123456789", "sari727896@gmail.com");
User user2 = new("Rivky Friedman", "987654321", "rivka0504173291@gmail.com");
User user3 = new("Malki Domb", "246813579", "md382@gmail.com");
GitApp gitApp = GitApp.GetInstance();
gitApp.ChangeCurrentUser(user1);
gitApp.AddUser(user2);
gitApp.AddUser(user3);
Branch branchMain = new("main");
Branch branch2 = new("fitcher", branchMain);
gitApp.AddBranch(branchMain);
gitApp.AddBranch(branch2);
gitApp.DeleteBranch(branch2);
gitApp.DeleteUser(user3);
#endregion
#region branch

FileContent content1 = new("this is my first content");
FileContent content2 = new("this is my second content");
FileContent content3 = new("this is my third content");
FileContent content4 = new("this is my fourth content");
FileContent content5 = new("this is my fifth content");
FileContent content6 = new("this is my sixth content");
FileContent content7 = new("this is my seventh content");
project.Composite.File file1 = new("my first file", 1.3, content1);
project.Composite.File file2 = new("my second file",2, content2);
project.Composite.File file3 = new("my third file", 2.3, content3);
project.Composite.File file4 = new("my fourth file", 2.7, content4);
project.Composite.File file5 = new("my fifth file", 2.5, content5);
project.Composite.File file6 = new("my sixth file", 2.9, content6);
project.Composite.File file7 = new("my seventh file", 3.1, content7);
project.Composite.Folder folder1 = new("my first folder",4.2);
project.Composite.Folder folder2 = new("my first folder", 4.2);
project.Composite.Folder folder3 = new("my first folder", 4.2);
project.Composite.Folder folder4 = new("my first folder", 4.2);

#endregion
//to define list of branch item & user access

//user.Update("sari727896@gmail.com");


