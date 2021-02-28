using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.FileProcessors
{
    public class TextProcessor : IFileProcessor
    {
        public void Process(string content)
        {
            Console.WriteLine("This is simple text");
        }

        private string type = "text";
        public string ReturnType()
        {
            return type;
        }
    }
}
