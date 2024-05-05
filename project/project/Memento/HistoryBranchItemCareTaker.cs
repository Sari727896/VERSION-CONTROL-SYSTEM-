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
        //public BranchItemsMemento Pop()
        //{
        //    var lastIndex = mementoes.Count - 1;
        //    var lastState = mementoes[lastIndex];
        //    mementoes.Remove(lastState);
        //    return lastState;
        //}
        public BranchItemsMemento Pop()
        {
            if (mementoes.Count == 0)
            {
                // כאן ניתן להחזיר ערך ברירת מחדל או לטפל באופן אחר במצב ריקות הרשימה
                return null;
            }
            var lastState = mementoes[mementoes.Count - 1];
            mementoes.Remove(lastState);
            return lastState;
        }
        public string ShowHistory()
        {
            string result = "History of Branch Items Mementos:\n";

            foreach (var memento in mementoes)
            {
                result += $"Memento: {memento.GetContent()}, TimeStamp: {memento.TimeStamp}\n";
            }

            return result;
        }
    }

}
