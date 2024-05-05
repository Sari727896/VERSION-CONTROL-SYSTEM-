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
        public BranchItems ItemToMerge { get; set; }
        public MergeCommand(BranchItems BranchItem, BranchItems itemToMerge) : base(BranchItem)
        {
            ItemToMerge = itemToMerge;
        }

        public override string Execute()
        {
          return BranchItem.Merge(ItemToMerge);
        }
    }
}
