using project.Flyweight;
using project.State.BranchState;
using project.States.BranchItemsStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Composite
{
    public abstract class BranchItems : ICloneable
    {
        public string Name { get; set; }
        public double Size { get; set; }
        public BranchItemsState State { protected get; set; }
        public List<User> Reviewers { get; set; }
        public BranchItems(string Name, double Size)
        {
            this.Name = Name;
            this.Size = Size;
            State = new Draft(this);
            this.Reviewers = new List<User>();
        }
        public void ChangeItemState(BranchItemsState newState)
        {
            State = newState;
        }
        public void AddReviewer(User user)
        {
            this.Reviewers.Add(user);
        }
        public string UndoTheCommit()
        {
            //to do with memnto
            State.UndoTheCommit();
            return "to do with memnto";
        }
        public string RequestAReview()
        {
            //to do with observer
            State.RequestAReview();
            return "to do with observer";
        }
        public abstract void ChangeContent(FileContent content);
        public abstract string Merge(BranchItems item);
        public string Commit()
        {
            //to do with memnto
            State.Commit();
            return "we need to implement the function";
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

        public abstract object Clone();

    }
}
