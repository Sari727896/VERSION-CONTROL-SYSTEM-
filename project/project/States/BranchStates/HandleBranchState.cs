using project.State.BranchState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.States.BranchStates
{
    internal class HandleBranchState : BranchState
    {
        public HandleBranchState(Branch branch) : base(branch)
        {
        }

        public override string HandleBranch()
        {
            return "Handling branch...";
        }

        public override string LockBranch()
        {
            return "Cannot lock branch, it is being handled.";
        }

        public override string Merge()
        {
            branch.ChangeState(new MergeState(branch));
            return "Branch is now in merge state.";
        }

        public override string UnlockBranch()
        {
            return "Cannot unlock branch, it is being handled.";
        }
    }
}
