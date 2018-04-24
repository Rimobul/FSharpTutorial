using System;
using System.Collections.Generic;

namespace Interoperability.CLibrary
{
    public class ExportToFSharp
    {
        public float SomeNumber { get; set; }
        
        public List<string> NotesInTheScale()
        {
            return new List<string> { "do", "re", "mi" };
        }

        public string UseDelegate(Func<int, string> del, int arg)
        {
            string result = del(arg);
            return $"The delegate returned {result}";
        }
    }
}
