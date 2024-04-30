using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Memento
{
    public abstract class BranchItemsMemento
    {
        public readonly DateTime TimeStamp;
        public BranchItemsMemento(DateTime timeStamp)
        {
            TimeStamp = timeStamp;
        }
    }
}
