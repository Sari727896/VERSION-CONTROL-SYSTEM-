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
    {
        List<BranchItems> branchItems;
        public string Name { get; set; }
        public Branch Parent { get; set; }

        List<UserAccess> userAccesses;
        public BranchState State {private get; set; }
        public Branch(string Name,Branch Parent=null)
        {
            branchItems=new List<BranchItems>();
            this.Name = Name;
            this.Parent = Parent;
            userAccesses=new List<UserAccess>();
            State=new LockBranchState(this);
        }
        public void ChangeState(BranchState newState)
        {
            State= newState;
        }
        public string AddFile(BranchItems item)
        {
            branchItems.Add(item);
            return $"File {item.Name} successfully added";
        }
        public string RemoveFile(BranchItems item)
        {
            var itemToRemove= branchItems.Find(i=>i.Name==item.Name);
            branchItems.Remove(itemToRemove);
            return $"The file {item.Name}  has been removed successfully"
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
        public void GrantAccess()
        {

        }
        public void ChangeFile(string name, string content)
        {
            
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
