using project.State.BranchState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.States.BranchStates
{
    public class UnlockBranchState : BranchState
    {
        public UnlockBranchState(Branch branch) : base(branch)
        {
        }

        public override string HandleBranch()
        {
            branch.ChangeState(new HandleBranchState(branch));
            return "Handling branch...";
        }

        public override string LockBranch()
        {
            branch.ChangeState(new LockBranchState(branch));
            return "Branch is now locked.";
        }

        public override string Merge()
        {
            branch.ChangeState(new MergeState(branch));
            return "Branch is being merged.";
        }

        public override string UnlockBranch()
        {
            return "Branch is already unlocked.";
        }
    }
}
