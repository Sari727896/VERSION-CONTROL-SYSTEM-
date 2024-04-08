using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Composite
{
    public abstract class BranchItems
    {
        public string Name { get; set; }
        public double Size { get; set; }
        //public BrnachItemsState State { get; set; }
        public List<User> Reviewers { get; set; }
        public BranchItems(string Name, double Size/*, BrnachItemsState State*/)
        {
            this.Name = Name;
            this.Size = Size;
            //this.State=State
            this.Reviewers = new List<User>();
        }
        public void AddReviewer(User user)
        {
            this.Reviewers.Add(user);
        }
        public void UndoTheCommit()
        {

        }
        public void RequestAReview()
        {

        }
        public void ChangeContent(string textToChange)
        {

        }
        public void Merge()
        {

        }
        public void Commit()
        {

        }
        public void CreateState()/*: BranchItemsMemento*/
        {

        }
        public void Restore()
        {

        }
        public void ShowHistory()
        {

        }
        public string RemoveReviewer(User user)
        {
            bool removedSuccessfully = this.Reviewers.Remove(user);

            if (removedSuccessfully)
            {
                return "Reviewer removed successfully.\n";
            }
            
               return "Reviewer not found in the list.\n";
            
        }
        public void Notify()
        {

        }
    }
}
