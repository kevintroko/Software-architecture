using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab1
{
    class Reader
    {
        public string[] Read(string inputfile)
        {
            TextReader inFile = new StreamReader(inputfile);    //open input for reading

            List<string> lines = new List<string>();
            string line;
            while ((line = inFile.ReadLine()) != null)      //repeat next statement until end of file
            {
                lines.Add(line);
            }
            inFile.Close();     // close input file
            return lines.ToArray();
        }
    }
}
