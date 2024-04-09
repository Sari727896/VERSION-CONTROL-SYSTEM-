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

        public override string commit()
        {
            throw new NotImplementedException();
        }

        public override string merge()
        {
            throw new NotImplementedException();
        }

        public override string requestAReview()
        {
            throw new NotImplementedException();
        }

        public override string undoTheCommit()
        {
            throw new NotImplementedException();
        }
    }
}
