using System;
using System.Collections.Generic;
using System.Text;

namespace ExamLibrary
{
    interface IParagraph
    {
        List<string> Split(string file);
        void Output(List<string> data,string path);
    }
}
