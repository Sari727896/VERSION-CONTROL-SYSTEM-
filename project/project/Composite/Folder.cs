using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
