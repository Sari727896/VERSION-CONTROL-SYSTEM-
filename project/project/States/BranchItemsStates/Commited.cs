using project.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.States.BranchItemsStates
{
    public class Commited : BranchItemsState
    {
        public Commited(BranchItems branchItem) : base(branchItem)
        {
        }

        public override string Commit()
        {
            return "Nothing to commit.\n";
        }

        public override string Merge()
        {
            branchItem.ChangeItemState(new Merged(branchItem));
            return "Merge successful! Your changes have been integrated into the main branch. Great teamwork!\n";
        }

        public override string RequestAReview()
        {
            branchItem.ChangeItemState(new UnderReview(branchItem));
            return "Requesting review for changes.\n";
        }

        public override string UndoTheCommit()
        {
            return "Cannot undo commit in commited state.\n"
        }
    }
}
