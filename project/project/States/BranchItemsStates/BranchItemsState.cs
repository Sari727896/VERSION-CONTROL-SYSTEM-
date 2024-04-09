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
        public abstract string merge();
        public abstract string commit();
        public abstract string undoTheCommit();
        public abstract string requestAReview();
    }
}
