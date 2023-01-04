using System;

using System.Collections.Generic;
// AlignOutput - viravnivanie mnozestvo strok, dlia uludshenia vneshnego vida v output
// Some of the things that want to practice: 
// Trim(), Pad(), PadRight(), PadLeft(), String() и Concat()
namespace UsefullFunctions
{
    public class Formatter
    {
        public static void RemoveWhiteSpaces(string raw)
        {

            Console.WriteLine("Removeing white Spaces ( before ): ' this is a\nstring'");
            char[] whiteSpace = { ' ', '\n', '\t' };
            string s = raw;
            for (; ; ) // infinite loop
            {
                int offset = s.IndexOfAny(whiteSpace);

                if (offset == -1)
                {
                    break;
                }

                string before = s.Substring(0, offset);
                string after = s.Substring(offset + 1);
                Console.WriteLine("B: '{0}', A: '{1}'", before, after);

                s = String.Concat(before, after);
            }

            Console.WriteLine("Removeing white Spaces ( after ): '{0}'", s);

        }
    }
}