using System;

using System.Collections.Generic;
// AlignOutput - viravnivanie mnozestvo strok, dlia uludshenia vneshnego vida v output
// Some of the things that want to practice: 
// Trim(), Pad(), PadRight(), PadLeft(), String() и Concat()
namespace UsefullFunctions
{
    public class Formatter
    {
        public static void RemoveWhiteSpacesFromString(string raw)
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
                s = String.Concat(before, after);
            }

            Console.WriteLine("Removeing white Spaces ( after ): '{0}'", s);
        }


        public static void RemoveWhiteSpacesFromArray(string raw)
        {
            List<string> listStringNames = new List<string> {
                " Sergio",
                "Michael  ",
                " Juango",
                "Ewona ",
                "Lorez"
            };
            // Display Names
            Console.WriteLine("Sledushie imena imejut raznily dliny:");
            
            foreach (string name in listStringNames)
            {
                Console.WriteLine("Name: '{0}' before change", name);
            }
            Console.WriteLine();

            List<string> namesToAlign = new List<string>();
            for (int index = 0; index < listStringNames.Count; index++)
            {
                string trimedName = listStringNames[index].Trim();
                namesToAlign.Add(trimedName);
            }

            // Get the longest name length (int)
            int maxLength = 0;
            foreach (string name in namesToAlign)
            {
                if (name.Length > maxLength)
                {
                    maxLength = name.Length;
                }
            }
            Console.WriteLine("Longest name is '{0}' letters.", maxLength);

            // Vyravnivaem vse stroki k max dline
            for (int i = 0; i < namesToAlign.Count; i++)
            {
                namesToAlign[i] = namesToAlign[i].PadRight(maxLength + 1);
            }

            // Show formatted strings
            foreach (string name in namesToAlign)
            {
                Console.WriteLine("Name: '{0}', after formattign.", name);
            }

        }
    }
}