using System;

using System.Collections.Generic;
// AlignOutput - viravnivanie mnozestvo strok, dlia uludshenia vneshnego vida v output
// Some of the things that want to practice: 
// Trim(), Pad(), PadRight(), PadLeft(), String() и Concat()
namespace UsefullFunctions
{
    public class Numbers
    {
        public static void OutputFloat()
        {
            for(;;)
            {
                Console.WriteLine("Enter a floating number...\nTo exit press [Enter]");
                string numberInput = Console.ReadLine();
                if (numberInput.Length == 0)
                {
                    break;
                }
                double number = Double.Parse(numberInput);

                Console.WriteLine("Enter the format you prefer, seperated by whitespace: \n\t( C E F1 N0 0000000.00000 0:00.0% )");
                char[] seperator = {' ', '\t'};
                string formatString = Console.ReadLine();
                string[] formats = formatString.Split(seperator);

                foreach (string format in formats)
                {
                    if (format.Length != 0)
                    {
                        string formatCommand = "{0:" + format + "}";

                        Console.WriteLine("Modifier {0} gives ", formatCommand);

                        try
                        {
                            Console.WriteLine(formatCommand, number);
                        } 
                        catch (Exception)
                        {
                            Console.WriteLine("Exception: Wrong modifier...");
                        }
                        Console.WriteLine();
                    }
                }
            }

            
        }

    }
}