using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2015.Utilities
{
    public class FileReader
    {
        public IEnumerable<string> ReadLine(string fileName)
        {
            string line;
            using(var reader = new StreamReader(fileName))
            {
                while((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}
