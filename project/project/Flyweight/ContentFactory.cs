using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace project.Flyweight
{
    public class ContentFactory
    {
        static Dictionary<string, FileContent> existingContent;
        static ContentFactory fileFactory;
        public static object locker;

        static ContentFactory()
        {
            existingContent = new Dictionary<string, FileContent>();
            locker = new object();
        }
        public static ContentFactory GetInstance()
        {
            if (fileFactory == null)
            {
                lock (locker)
                {
                    if (fileFactory == null)
                    {
                        fileFactory = new ContentFactory();
                    }
                }
            }
            return fileFactory;
        }
        public static FileContent GetContent(int brnachId, string fileName, string content)
        {
            string contentKey = $"{brnachId.ToString()}_{fileName}";
            if (existingContent.ContainsKey(contentKey))
            {
                return existingContent[contentKey];
            }
            FileContent content1 = new(content);
            existingContent.Add(contentKey, content1);
            return content1;
        }
    }
}
