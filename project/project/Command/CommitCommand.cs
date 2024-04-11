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
        public CommitCommand(GitApp GitApp) : base(GitApp)
        {
        }

        public override string Execute()
        {
            throw new NotImplementedException();
        }
    }
}
