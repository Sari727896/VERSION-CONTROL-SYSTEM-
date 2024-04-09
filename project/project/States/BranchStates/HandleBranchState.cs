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

        public override void HandleBranch()
        {
            throw new NotImplementedException();
        }

        public override void LockBranch()
        {
            throw new NotImplementedException();
        }

        public override void Merge()
        {
            throw new NotImplementedException();
        }

        public override void UnlockBranch()
        {
            throw new NotImplementedException();
        }
    }
}
