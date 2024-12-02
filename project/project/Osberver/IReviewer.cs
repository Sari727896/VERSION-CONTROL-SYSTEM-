using project.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Osberver
{
    public interface IReviewer
    {
        public void Update(string toEmail, BranchItems item);
        public void ConfirmRequest();
    }
}
