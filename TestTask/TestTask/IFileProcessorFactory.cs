using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask
{
    interface IFileProcessorFactory
    {
        IFileProcessor CreateFileProcessor(string fileContent, string fileExtension);
    }
}
