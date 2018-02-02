using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Sorter
    {
        public string[] Sort(string[] unsorted)
        {
            string[] sorted = new string[unsorted.Length];
            Array.Copy(unsorted, sorted, unsorted.Length);
            Array.Sort(sorted);
            return sorted;
        }
    }
}
