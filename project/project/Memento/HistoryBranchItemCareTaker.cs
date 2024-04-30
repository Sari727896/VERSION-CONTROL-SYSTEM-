using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Memento
{
    public class HistoryBranchItemCareTaker
    {
        private List<BranchItemsMemento> mementoes = new List<BranchItemsMemento>();
        public void Push(BranchItemsMemento state)
        {
            mementoes.Add(state);
        }
        public BranchItemsMemento Pop()
        {
            var lastIndex = mementoes.Count - 1;
            var lastState = mementoes[lastIndex];
            mementoes.Remove(lastState);
            return lastState;
        }
    }
}
