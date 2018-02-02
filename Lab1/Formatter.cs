using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Formatter
    {
        public string[][]Format(string[] input)
        {
            List<string[]> sentence = new List<string[]>();
            foreach (var line in input)
            {
                string[] tokens = line.Split(' ');
                sentence.Add(tokens);
            }


            return sentence.ToArray();
        }
    }
}
