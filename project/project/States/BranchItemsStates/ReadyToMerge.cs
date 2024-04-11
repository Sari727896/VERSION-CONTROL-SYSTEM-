using project.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.States.BranchItemsStates
{
    public class ReadyToMerge : BranchItemsState
    {
        public ReadyToMerge(BranchItems branchItem) : base(branchItem)
        {
        }



        public override string Commit()
        {
            return "Cannot commit in merged state.\n";
        }



        public override void Merge()
        {
            branchItem.ChangeItemState(new Merged(branchItem));
            ////return "Merge changes to merged state";
        }



        public override string RequestAReview()
        {
            branchItem.ChangeItemState(new UnderReview(branchItem));
            return "Request a review changes to merged state";
        }



        public override string UndoTheCommit()
        {
            return "Cannot undo the commit in merged state.\n";
        }
    }
}