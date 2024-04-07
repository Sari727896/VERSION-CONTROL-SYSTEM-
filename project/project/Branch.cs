using project.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Branch
    {
        List<BranchItems> branchItems;
        public string Name { get; set; }
        public Branch Parent { get; set; }

        //List<UserAccess> userAccesses;
        //public 
        
    }
}
