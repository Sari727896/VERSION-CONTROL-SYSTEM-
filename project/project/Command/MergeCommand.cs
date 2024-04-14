using project.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Command
{
    public class MergeCommand : GitActionsCommand
    {
        public MergeCommand(BranchItems BranchItem) : base(BranchItem)
        {
        }

        public override string Execute()
        {
          return BranchItem.Merge(BranchItem);
        }
    }
}
