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
        //to do after observer state
        public UnderReview(BranchItems branchItem) : base(branchItem)
        {
        }

        public override string Commit()
        {
            throw new NotImplementedException();
        }

        public override void Merge()
        {
            throw new NotImplementedException();
        }

        public override string RequestAReview()
        {
            return "File is already under review.\n";
        }

        public override string UndoTheCommit()
        {//to implemnt with momento design patern
            return "Undoing the commit and reverting to the previous state.\n";
        }
    }
}
