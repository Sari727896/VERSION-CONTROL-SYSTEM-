using project.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.States.BranchItemsStates
{
    public abstract class BranchItemsState
    {
        protected BranchItems branchItem;
        public BranchItemsState(BranchItems branchItem)
        {
            this.branchItem=branchItem;
        }
        public abstract void Merge();
        public abstract string Commit();
        public abstract string UndoTheCommit();
        public abstract string RequestAReview();
    }
}
