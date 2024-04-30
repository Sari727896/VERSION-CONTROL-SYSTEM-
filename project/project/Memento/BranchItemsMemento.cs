using project.Composite;
using project.States.BranchItemsStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Memento
{
    public class BranchItemsMemento
    {
       public readonly BranchItemsState Content;
        public BranchItemsMemento(BranchItemsState Content)
        {
            this.Content=Content;
        }
    }
}
