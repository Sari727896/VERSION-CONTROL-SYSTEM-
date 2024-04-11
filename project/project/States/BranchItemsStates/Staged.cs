using project.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.States.BranchItemsStates
{
    public class Staged : BranchItemsState
    {
        public Staged(BranchItems branchItem) : base(branchItem)
        {
        }
        
        public override string Commit()
        {
            branchItem.ChangeItemState(new Commited(branchItem));
            return "Committing changes to staged state.\n";
        }

        public override void Merge()
        {
            //return "Cannot merge in Staged state.\n";
            throw new Exception("Cannot merge in Staged state.\n");
        }

        public override string RequestAReview()
        {
            branchItem.ChangeItemState(new UnderReview(branchItem));
            return "Requesting review for changes.\n";
        }

        public override string UndoTheCommit()
        {
            return "Cannot undo The Commit in Staged state.\n";
        }
    }





}
