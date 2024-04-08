using project.Composite;
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
        public void AddItem(BranchItems item)
        {


        }
        public void LockBranch()
        {

        }
        public void UnlockBranch()
        {

        }
        public void HandleBranch()
        {

        }
        public void GrantAccess()
        {

        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
