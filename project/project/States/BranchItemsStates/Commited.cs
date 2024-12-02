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

        public override void Merge()
        {
            branchItem.ChangeItemState(new Merged(branchItem));
        }

        public override string RequestAReview()
        {
            branchItem.ChangeItemState(new UnderReview(branchItem));
            return "Requesting review for changes.\n";
        }

        public override string UndoTheCommit()
        {
            return "Cannot undo commit in commited state.\n";
        }
    }
}
