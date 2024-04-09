using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Flyweight
{
    public class FileFactory
    {
        static Dictionary<string, FileContent> existingContent;
        static FileFactory()
        {
            existingContent= new Dictionary<string, FileContent>();
        }
        public static FileContent GetContent(string content)
        {
            
            if(existingContent.ContainsKey(content))
            {
                return existingContent[content];
            }
            FileContent content1 = new(content);
            existingContent.Add(content, content1);
            return content1;
        }
    }
}
