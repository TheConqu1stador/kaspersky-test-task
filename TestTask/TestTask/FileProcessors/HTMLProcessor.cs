using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.FileProcessors
{
    class HTMLProcessor : IFileProcessor
    {
        public void Process(string content)
        { 
            Console.WriteLine("This is HTML");
        }

        private string type = "html";

        public string ReturnType()
        {
            return type;
        }
    }
}
