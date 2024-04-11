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
        protected GitApp GitApp { get; set; }
        public GitActionsCommand(GitApp GitApp)
        {
            this.GitApp=GitApp;
        }
        public abstract string Execute();
    }
}
