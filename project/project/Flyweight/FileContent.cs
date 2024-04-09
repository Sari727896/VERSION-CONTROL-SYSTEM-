using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Flyweight
{
    public class FileContent
    {
        public string Content { get; set; }
        public FileContent(string Content)
        {
            this.Content=Content;
        }
    }
}
