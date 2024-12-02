using project.Composite;
using project.Singelton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Command
{
    public abstract class GitActionsCommand
    {
        protected BranchItems BranchItem { get; set; }
        public GitActionsCommand(BranchItems BranchItem)
        {
            this.BranchItem = BranchItem;
        }
        public abstract string Execute();
    }
}
