using project.Composite;
using project.States.BranchItemsStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Memento
{
    public class FileMemento : BranchItemsMemento
    {
       public readonly string Content;

        public FileMemento(DateTime timeStamp,string Content) : base(timeStamp)
        {
            this.Content = Content;
        }
        public override string GetContent()
        {
            return Content;
        }
    }
}
