using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.FileProcessors
{
    class JSONProcessor : IFileProcessor
    {
        public void Process(string content)
        {
            Console.WriteLine("This is JSON");
        }

        private string type = "json";
        public string ReturnType()
        {
            return type;
        }
    }
}
