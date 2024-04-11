using project.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.States.BranchItemsStates
{
    public class Merged : BranchItemsState
    {
        public Merged(BranchItems branchItem) : base(branchItem)
        {
        }

        public override string Commit()
        {
            return "Cannot commit in Merged state.\n";

        }

        public override string Merge()
        {
            return "Cannot merge in merged state.\n";
        }

        public override string RequestAReview()
        {
            branchItem.ChangeItemState(new UnderReview(branchItem));
            return "Request a review changes in merged state";
        }

        public override string UndoTheCommit()
        {
            //To do
            return "Undoing the commit and reverting to the previous state.\n";
        }
    }
}