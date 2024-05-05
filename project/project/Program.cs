// See https://aka.ms/new-console-template for more information

using project;
using project.Command;
using project.Composite;
using project.Enums;
using project.Flyweight;
using project.Singelton;
using project.States.BranchItemsStates;
using System.Drawing;
using System.Reflection.Emit;
using System.Xml.Linq;
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
//Branch branchMain = new("main");
Branch branch2 = new("Feature branch", gitApp.MainBranch);
Branch branch3= new("Release branch", gitApp.MainBranch);
Branch branch4 = new("Hotfix branch", gitApp.MainBranch);
gitApp.AddBranch(gitApp.MainBranch);
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
project.Composite.Folder folder2 = new("my second folder", 4.2);
project.Composite.Folder folder3 = new("my third folder", 4.2);
project.Composite.Folder folder4 = new("my fourth folder", 4.2);
#region composite
folder1.AddItem(file1);
folder1.AddItem(file2);
folder2.AddItem(file3);
folder4.AddItem(file5);
folder4.AddItem(file6);
folder4.AddItem(file7);
folder4.AddItem(file4);
folder3.AddItem(folder4);
folder2.AddItem(folder3);
folder1.AddItem(folder2);



folder4.RemoveItem(file7);
#endregion
#endregion
List<BranchItems> items = new();
items.Add(folder1);
WriteLine(folder1.ShowDetails(""));
List<UserAccess> userAccess = new();
//to do validates
UserAccess userAccess1 = new(UserAllowingAccess.write, user1);
UserAccess userAccess2=new(UserAllowingAccess.read, user2);
UserAccess userAccess3=new(UserAllowingAccess.write, user3);
UserAccess userAccess4=new(UserAllowingAccess.read, user4);
UserAccess userAccess5 = new(UserAllowingAccess.write, user5);
UserAccess userAccess6 = new(UserAllowingAccess.write, user6);
UserAccess userAccess7=new(UserAllowingAccess.write, user7);
UserAccess userAccess8=new(UserAllowingAccess.read, user8);
UserAccess userAccess9 = new(UserAllowingAccess.read, user9);
UserAccess userAccess10 = new(UserAllowingAccess.write, user10);
userAccess.Add(userAccess1);
userAccess.Add(userAccess2);
userAccess.Add(userAccess3);
userAccess.Add(userAccess4);
userAccess.Add(userAccess5);
userAccess.Add(userAccess6);
userAccess.Add(userAccess7);
userAccess.Add(userAccess8);
userAccess.Add(userAccess9);
userAccess.Add(userAccess10);
Branch brancha = new("main");
Branch branchb = new("Feature branch", brancha);
Branch branchc = new("Release  branch", brancha);
Branch branchd = new("Hotfix  branch", brancha);
List<Branch> branches = new() { brancha, branchb, branchc, branchd };
gitApp.MainBranch.Branches= branches;
brancha.AddItem(folder1);
branchb.AddItem(folder2);
branchc.AddItem(folder3);
branchd.AddItem(file7);

//to define list of branch item & user access
//to do list of reviers
//user.Update("sari727896@gmail.com");

//branch item is a reciver and the user is the invoker
#region command

CommitCommand commitCommand = new(folder2);
MergeCommand mergeCommand = new(folder2,folder1);
RequestAReviewCommand requestAReviewCommand = new(folder2);
UndoTheCommitCommand undoTheCommitCommand = new(folder2); 
user1.PlaceSystemItemRequest(commitCommand);
user1.PlaceSystemItemRequest(mergeCommand);
user1.PlaceSystemItemRequest(requestAReviewCommand);
user1.PlaceSystemItemRequest(undoTheCommitCommand);
WriteLine(user1.DoJob());
#endregion
#region prototype
brancha.Branches.Add(branchb);
brancha.Branches.Add(branchc);
WriteLine(brancha.CreateBranch("Release  branch", "Cloned Release  branch"));
#endregion
#region flyweight
brancha.AddItem(file1);
brancha.AddItem(file2);
brancha.ChangeFile("my first file", "We try to change the file;");
brancha.ChangeFile("my second file", "this is my second content");

#endregion