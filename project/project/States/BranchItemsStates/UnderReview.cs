using project.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.States.BranchItemsStates
{
    public class UnderReview : BranchItemsState
    {
        public UnderReview(BranchItems branchItem) : base(branchItem)
        {
        }

        public override string Commit()
        {
            return "is wating to confirm";
        }

        public override void Merge()
        {
            throw new Exception("Cannot merge in merged state.\n");
        }

        public override string RequestAReview()
        {
            return "File is already under review.\n";
        }

        public override string UndoTheCommit()
        {
            return "Undoing the commit and reverting to the previous state.\n";
        }
    }
}
