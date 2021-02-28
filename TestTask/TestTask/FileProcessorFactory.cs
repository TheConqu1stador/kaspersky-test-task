using System;
using TestTask.FileProcessors;
using System.Text;

namespace TestTask
{
    public class FileProcessorFactory : IFileProcessorFactory
    {
        public const string EmptyExtensionMessage = "File must have an extension";
        public const string EmptyFileMessage = "File must not be empty";
        public IFileProcessor CreateFileProcessor(string fileContent, string fileExtension)
        {
            if (string.IsNullOrEmpty(fileExtension))
                throw new ArgumentException(EmptyExtensionMessage);
            if (string.IsNullOrEmpty(fileContent))
                throw new ArgumentException(EmptyFileMessage);

            if (fileExtension == ".html"
                && fileContent.Substring(0, 6) == "<html>"
                && fileContent.EndsWith("</html>"))
                return new HTMLProcessor();
                
            else if (fileExtension == ".json"
                     && fileContent[0] == '{' 
                     && fileContent.EndsWith("}"))
                return new JSONProcessor();
            else
                return new TextProcessor();
        }
    }
}
