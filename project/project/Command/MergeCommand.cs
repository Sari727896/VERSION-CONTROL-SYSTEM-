using project.Singelton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Command
{
    public class MergeCommand : GitActionsCommand
    {
        public MergeCommand(GitApp GitApp) : base(GitApp)
        {
        }

        public override string Execute()
        {
            throw new NotImplementedException();
        }
    }
}
