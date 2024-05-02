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
User user4 = new User("David Levi", "111222333", "davidlevi@example.com");
User user5 = new User("Rachel Cohen", "444555666", "rachelc@example.com");
User user6 = new User("Yossi Goldberg", "777888999", "yossig@example.com");
User user7 = new User("Esther Schwartz", "333222111", "esthers@example.com");
User user8 = new User("Avi Cohen", "666777888", "avic@example.com");
User user9 = new User("Leah Rosenberg", "999888777", "leahr@example.com");
User user10 = new User("Yitzhak Green", "123123123", "yitzhakg@example.com");
GitApp gitApp = GitApp.GetInstance();
gitApp.ChangeCurrentUser(user1);
gitApp.AddUser(user2);
gitApp.AddUser(user3);
gitApp.AddUser(user4);
gitApp.AddUser(user5);
gitApp.AddUser(user6);
gitApp.AddUser(user7);
gitApp.AddUser(user8);
gitApp.AddUser(user9);
gitApp.AddUser(user10);
Branch branchMain = new("main");
Branch branch2 = new("Feature branch", branchMain);
Branch branch3= new("Release  branch", branchMain);
Branch branch4 = new("Hotfix  branch", branchMain);
gitApp.AddBranch(branchMain);
gitApp.AddBranch(branch2);
gitApp.AddBranch(branch3);
gitApp.AddBranch(branch4);
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
folder1.AddItem(file1);
folder1.AddItem(file2);
folder1.AddItem(folder2);
folder2.AddItem(file3);
folder2.AddItem(folder3);
folder3.AddItem(folder4);
folder4.AddItem(file4);
folder4.AddItem(file5);
folder4.AddItem(file6);
folder4.AddItem(file7);
folder4.RemoveItem(file7);

#endregion
//to define list of branch item & user access

//user.Update("sari727896@gmail.com");


