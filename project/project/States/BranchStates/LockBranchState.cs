using project.State.BranchState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.States.BranchStates
{
    public class LockBranchState : BranchState
    {
        public LockBranchState(Branch branch) : base(branch)
        {
        }

        public override string HandleBranch()
        {
            return "Cannot handle branch, it is locked.";
        }

        public override string LockBranch()
        {
            return "Branch is already locked.";
        }

        public override string Merge()
        {
            return "Cannot merge while branch is locked.\n";
        }

        public override string UnlockBranch()
        {
            branch.ChangeState(new UnlockBranchState(branch));
            return "Unlocking branch...";
        }
    }
}
