using project.Flyweight;
using project.Memento;
using project.State.BranchState;
using project.States.BranchItemsStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
        public HistoryBranchItemCareTaker History { get; set; }

        public BranchItems(string Name, double Size)
        {
            this.Name = Name;
            this.Size = Size;
            State = new Draft(this);
            this.Reviewers = new List<User>();
            History = new();
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
            this.Restore(History.Pop());
            return $"the file {this.Name} returned to its previous state.";
        }
        public string RequestAReview()
        {
            //to do with observer
           
            State.RequestAReview();
            Notify("sari727896@gmail.com");
            return "to do with observer";
        }
        public abstract void ChangeContent(FileContent content);
        public abstract string Merge(BranchItems item);
        public string Commit()
        {
            //to do with memnto
            State.Commit();
            History.Push(this.CreateState());
            return $"the brnachItem {this.Name} had commited successfuly ";
        }
        public abstract BranchItemsMemento CreateState();

        public abstract void Restore(BranchItemsMemento memento);

        public string ShowHistoryToUser()
        {
            return History.ShowHistory();
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
        public void Notify(string toAddress)
        {
           
            foreach (var observer in Reviewers)
            {
                observer.Update(toAddress);
            }
        }

        public abstract object Clone();

    }
}
