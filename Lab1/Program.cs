using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab1
{
    class Program
    {
        /*
         * This program is an example of working with files in C#
         * In order to use it open command line and type:
         * 
         *          example input.txt output.txt
         * 
         * where input.txt is an input file from which this example will read text
         * and output.txt is an output file that this example will create and write some text in it
         * 
         * Note: If you do not specify output file it will be automaticaly created
         *
         */
        static int Main(string[] args)
        {
            int result = 0; //return 0 for success
           
            //did we provide at least one argument?
            if (args.Length < 1)
            {
                //no arguments where provided on start of application
                Console.Out.WriteLine("Error: Please provide input file name as an argument!");
                result = -1;
            }
            else
            {
                string inFile = args[0];                //input file taken from arguments
                string outFile = "out_" + args[0];      //default output file
                if (args.Length > 1) outFile = args[1]; //if we have second argument use that as output file

                //does provided input file actually exist?
                if (File.Exists(inFile))
                {
                    //start with algorithm...
                    Algorithm(inFile, outFile);
                    Console.Out.WriteLine("Output file " + outFile + " successfully created!");
                }
                else
                {
                    //input file provided as argument does not exist!
                    Console.Out.WriteLine("Error: Provided input file " + inFile + " does not exist!");
                    result = -1;
                }
            }

            Console.Out.Write("Press any key to exit...");
            Console.ReadKey(true);

            return result;
        }

        private static void Algorithm(string input, string output)
        {
            Reader reader = new Reader();
            Formatter formatter = new Formatter();
            Shifter shifter = new Shifter();
            Sorter sorter = new Sorter();
            Writter writter = new Writter();
            string[] sentences = reader.Read(input);
            string[][] tokens = formatter.Format(sentences);
            string[] unsorted_lines = shifter.Shift(tokens);
            string[] sorted_lines = sorter.Sort(unsorted_lines);
            writter.Write(output, sorted_lines);
        }

        
    }
}
