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
        private List<BranchItemsMemento> mementoes1 = new List<BranchItemsMemento>();
        public void Push(BranchItemsMemento state)
        {
            mementoes.Add(state);
            mementoes1.Add(state);
        }

        public BranchItemsMemento Pop()
        {
            if (mementoes.Count == 0)
            {
                return null;
            }
            var lastState = mementoes[mementoes.Count - 1];
            mementoes.Remove(lastState);
            return lastState;
        }
        public string ShowHistory()
        {
            string result = "History of Branch Items Mementos:\n";

            foreach (var memento in mementoes1)
            {
                result += $"Memento: {memento.GetContent()}, TimeStamp: {memento.TimeStamp}\n";
            }

            return result;
        }
    }

}
