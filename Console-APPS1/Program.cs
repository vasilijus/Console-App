using System;

// using UsefullFunctions;
using System.Collections.Generic;
// AlignOutput - viravnivanie mnozestvo strok, dlia uludshenia vneshnego vida v output
// Some of the things that want to practice: 
// Trim(), Pad(), PadRight(), PadLeft(), String() и Concat()
namespace AlignOutput
{
    class Program
    {
        Program()
        {
            Console.WriteLine("Starting Program. \nNo arguments were passed.\nInit...");
            this.init();
        }

        Program(string args)
        {
            Console.WriteLine("Received: {0}", args);
        }
        
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Program p = new Program(args[0]);
            }
            else {
                Program p = new Program();
            }

        }

        public void init()
        {           
            // From WorkingWithStrings
            UsefullFunctions.Formatter.RemoveWhiteSpacesFromString(" this is a\nstring");
            
            UsefullTime.TimeWorks.IsYearLeapYear(2021);

            Console.WriteLine(ScriptsRandom.JSON.GetNamesJSON());

            ScriptsRandom.Script.Exit();
        }
        
    }
}