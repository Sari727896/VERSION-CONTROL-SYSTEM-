using project.Command;
using project.Flyweight;
using project.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace project.Composite
{
    public class Folder : BranchItems
    {
        public List<BranchItems> Items { get; set; }
        public Folder(string Name, double Size) : base(Name, Size)
        {
            Items = new List<BranchItems>();
        }
        public void AddItem(BranchItems item)
        { 
            Items.Add(item); 
        }
        public void RemoveItem(BranchItems item)
        {
            var itemToRemove=Items.Find(i=>i.Name==item.Name);
            Items.Remove(itemToRemove);
        }

        //public override string MergeFile(File file)
        //{
        //    return "Can not merge file with folder";
        //}

        public override string Merge(BranchItems item)
        {
            if(item is File)
                return "Can not merge file with folder";
            Folder folder = item as Folder;
            if (folder == null)
                return "Conversion to Folder type failed \n";
            State.Merge();
            this.Items.AddRange(folder.Items);
            return $"the files {this.Name} and {folder.Name} had merged. ";
        }

        public override object Clone()
        {
            Folder clonedFolder = new Folder(this.Name, this.Size);
            clonedFolder.State = this.State; // העתקה עמוקה של State

            // העתקה עמוקה של Reviewers
            //clonedFolder.Reviewers = new List<User>();
            //foreach (User reviewer in this.Reviewers)
            //{
            //    User clonedReviewer = new User(reviewer.UserName, reviewer.Password, reviewer.Email);
            //    clonedFolder.Reviewers.Add(clonedReviewer);
            //}

            // העתקה עמוקה של actionsCommand
            //clonedFolder.actionsCommand = new Queue<GitActionsCommand>(this.actionsCommand);

            // העתקה עמוקה של רשימת הפריטים בתוך התיקייה
            foreach (BranchItems item in this.Items)
            {
                clonedFolder.Items.Add((BranchItems)item.Clone());
            }

            return clonedFolder;
        }

        public override void ChangeContent(FileContent content)
        {
            throw new Exception("you can change only file"); 
        }

        public override BranchItemsMemento CreateState()
        {
            return new FolderMemento(DateTime.Now, Items);

        }

        public override void Restore(BranchItemsMemento state)
        {
            if (state is FolderMemento)
            {
                var folderMementoState = state as FolderMemento;
                Items = folderMementoState.Content;
            }
            //else
            //{
            //    throw new Exception("")
            //}
        }
    }
}
