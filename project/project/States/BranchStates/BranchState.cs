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
            this.branch = branch;
        }
        public abstract string HandleBranch();
        public abstract string UnlockBranch();
        public abstract string LockBranch();
        public abstract string Merge();

    }
}
