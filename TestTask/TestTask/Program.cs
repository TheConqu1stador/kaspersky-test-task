using System;
using System.IO;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFunc("tests\\testEmptyExtension");
        }

        private static void TestFunc(string fileName)
        {
            FileContentProvider provider = new FileContentProvider();
            var file = (content:provider.GetContent(fileName), extension: Path.GetExtension(fileName));

            FileProcessorFactory fileProcessorFactory = new FileProcessorFactory();
            var fileProcessor = fileProcessorFactory.CreateFileProcessor(file.content, file.extension);
            fileProcessor.Process(file.content);
        }
    }
}
