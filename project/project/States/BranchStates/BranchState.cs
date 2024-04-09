using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.State.BranchState
{
    public abstract class BranchState
    {
        protected Branch branch;
        public BranchState(Branch branch)
        {
            this.branch=branch;
        }
        public abstract void HandleBranch();
        public abstract void UnlockBranch();
        public abstract void LockBranch();
        public abstract void Merge();
        
    }
}
