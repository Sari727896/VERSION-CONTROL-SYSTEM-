﻿using project.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Memento
{
    public class FolderMemento : BranchItemsMemento
    {
        public readonly List<BranchItems> Content;

        public FolderMemento(DateTime timeStamp, List<BranchItems> Content) : base(timeStamp)
        {
            this.Content = Content;
        }
        public override string GetContent()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Content)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
