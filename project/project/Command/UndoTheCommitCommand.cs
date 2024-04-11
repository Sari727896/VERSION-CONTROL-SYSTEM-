using project.Composite;
using project.Singelton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Command
{
    public class UndoTheCommitCommand : GitActionsCommand
    {
        public UndoTheCommitCommand(BranchItems BranchItem) : base(BranchItem)
        {
        }

        public override string Execute()
        {
            return BranchItem.UndoTheCommit();
        }
    }
}
