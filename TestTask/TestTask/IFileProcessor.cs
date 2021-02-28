using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask
{
    public interface IFileProcessor
    {
        void Process(string content);
        string ReturnType();
    }
}
