using System;
using System.IO;
using System.Text;

namespace TestTask
{
    public class FileContentProvider : IFileContentProvider
    {
        public string GetContent(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return new StreamReader(fileStream).ReadToEnd();
            }
        }
    }
}
