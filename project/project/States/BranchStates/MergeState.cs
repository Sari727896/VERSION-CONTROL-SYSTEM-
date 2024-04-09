using project.State.BranchState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.States.BranchStates
{
    public class MergeState : BranchState
    {
        public MergeState(Branch branch) : base(branch)
        {
        }

        public override string HandleBranch()
        {
            return "Cannot handle branch, it is in merge state.";
        }

        public override string LockBranch()
        {
            return "Cannot lock branch, it is in merge state.";
        }

        public override string Merge()
        {
            return "Branch is already in merge state.";
        }

        public override string UnlockBranch()
        {
            return "Cannot unlock branch, it is in merge state.";
        }
    }
}
