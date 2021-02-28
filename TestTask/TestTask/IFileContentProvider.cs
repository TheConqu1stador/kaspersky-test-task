using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask
{
    interface IFileContentProvider
    {
        string GetContent(string fileName);
    }
}
