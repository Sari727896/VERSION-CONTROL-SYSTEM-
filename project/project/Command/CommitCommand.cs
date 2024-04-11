using project.Composite;
using project.Singelton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Command
{
    public class CommitCommand : GitActionsCommand
    {
        public CommitCommand(BranchItems BranchItem) : base(BranchItem)
        {
        }

        public override string Execute()
        {
            return BranchItem.Commit();
        }
    }
}
