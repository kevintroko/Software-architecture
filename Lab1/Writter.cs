using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab1
{
    class Writter
    {
        public void Write(string outputfile, string[] output)
        {
            
            TextWriter outFile = new StreamWriter(outputfile);  //create output (overwrite if exist!)



            foreach (string line in output)
            {

            
                outFile.WriteLine(line);  //some algorithm performing on the each line
            }
            outFile.Close();    // close output file
            
        }
    }
}
