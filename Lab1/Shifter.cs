using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Shifter
    {
        public string [] Shift(string[][] tokens)
        {
            List<string> linesfinished = new List<string>();

            //For each sentence, find all the lines
            foreach (var line in tokens)
            {
                //
                for (int i = 0; i < line.Length; i++)
                {
                    string newline="";
                    //create a new line starting from index i
                    for (int j = 0; j < line.Length; j++)
                    {
                        newline += line[(j + i) % line.Length] + " ";
                    }
                    linesfinished.Add(newline);
                }


            }


            return linesfinished.ToArray();
        }
    }
}
