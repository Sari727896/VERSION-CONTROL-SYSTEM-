using project.Flyweight;
using project.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Composite
{
    public class File : BranchItems
    {
        public FileContent Content { get; set; }
        public File(string Name, double Size, FileContent Content) : base(Name, Size)
        {
            this.Content = Content;
        }
        public override string ShowDetails(string level)
        {
            level += '\t';
            return $"{level}{Name}, {Math.Round(Size, 2)}KB";
        }
        public override string Merge(BranchItems item)
        {
            //State.Merge();
            //this.Content += file.Content;
            if (item is Folder)
                return "Can not merge file with folder";
            File file = item as File;
            if (file == null)
                return "Conversion to Folder type failed \n";
            State.Merge();
            this.Content.Content = string.Concat(this.Content, file.Content);
            return $"the files {this.Name} and {file.Name} had merged. ";
        }

        public override object Clone()
        {
            File clonedItem = new File(this.Name, this.Size,this.Content);
            //clonedItem.State = this.State;
            //clonedItem.Reviewers = new List<User>(this.Reviewers);
            return clonedItem;
        }

        public override void ChangeContent(FileContent content)
        {
            this.Content=content;
        }

        public override BranchItemsMemento CreateState()
        {
            return new FileMemento(DateTime.Now,Content.Content);
        }

        public override void Restore(BranchItemsMemento state)
        {
            if(state is FileMemento)
            {
                var fileMementoState = state as FileMemento;
                Content.Content = fileMementoState.Content;
            }
            //else
            //{
            //    throw new Exception("")
            //}
        }

        //public override string MergeFolder(Folder folder)
        //{
        //    return "Can not merge file with folder";
        //}
    }
}
