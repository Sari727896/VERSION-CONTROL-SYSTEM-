using project.Composite;
using project.Flyweight;
using project.State.BranchState;
using project.States.BranchStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Branch:ICloneable
    {//to do id
        List<BranchItems> branchItems;
        public string Name { get; set; }
        public Branch Parent { get; set; }

        List<UserAccess> userAccesses;
        private static int nextId = 1;
        public int Id { get;  }
        public BranchState State {private get; set; }
        public ContentFactory FileFactory { get; set; }
        public Branch(string Name,Branch Parent=null)
        {
            branchItems=new List<BranchItems>();
            this.Name = Name;
            this.Parent = Parent;
            userAccesses=new List<UserAccess>();
            State=new LockBranchState(this);
            Id=nextId++;
            FileFactory = ContentFactory.GetInstance();
        }
        public void ChangeState(BranchState newState)
        {
            State= newState;
        }
        public string AddItem(BranchItems item)
        {
            branchItems.Add(item);
            return $"File {item.Name} successfully added";
        }
        public string RemoveItem(BranchItems item)
        {
            var itemToRemove= branchItems.Find(i=>i.Name==item.Name);
            branchItems.Remove(itemToRemove);
            return $"The file {item.Name}  has been removed successfully";
        }
        public void CreateBranch(string branchName)
        {

        }
        public string LockBranch()
        {
            return State.LockBranch();
        }
        public string UnlockBranch()
        {
             return State.UnlockBranch();
        }
        public string HandleBranch()
        {
            return State.HandleBranch();
        }
        public string MergeBranch()
        {
            return State.Merge();
        }
        public void grantAccess(String branchName, User user)
        {
            //userAccesses.computeIfAbsent(branchName, k-> new HashSet<>()).add(user);
        }
        public void ChangeFile(string name, string content)
        {
            var file= branchItems.Find(f=>f.Name==name);
            FileContent content1=ContentFactory.GetContent(Id, name,content);
            content1.Content = content;
            file.ChangeContent(content1);
            // אם זה תכולה של הבראנצ הנוכחי ואם לא מייצרת חדשאני לא יוצרת אובקיט חדש לתכולה רק מצביע חדש וכשאר רוצים לשנות אני בודקת 
        }
        public object Clone()
        {
            Branch clonedBranch = new Branch(this.Name, this);
            clonedBranch.userAccesses = new List<UserAccess>();
            foreach (UserAccess access in this.userAccesses)
            {
                clonedBranch.userAccesses.Add((UserAccess)access.Clone());
            }
            clonedBranch.branchItems = new List<BranchItems>();
            foreach (BranchItems item in this.branchItems)
            {
                clonedBranch.branchItems.Add((BranchItems)item.Clone());
            }
            return clonedBranch;
        }
    }
}
