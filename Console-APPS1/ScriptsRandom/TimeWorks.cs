using System;

using System.Collections.Generic;
// AlignOutput - viravnivanie mnozestvo strok, dlia uludshenia vneshnego vida v output
// Some of the things that want to practice: 
// Trim(), Pad(), PadRight(), PadLeft(), String() и Concat()
namespace ScriptsRandom
{
    public class Script
    {
        public static void Exit()
        {
            Console.WriteLine("Please enter [exit,quit] exit the program...");
            string sentence = "";

            for(;;)
            {
                string line = Console.ReadLine();
                string[] terms = {"EXIT", "exit", "quit", "QUIT"};
                bool quitting = false;
                foreach (string term in terms)
                {
                    if (String.Compare(line, term) == 0)
                    {
                        quitting = true;
                    }
                }
                if (quitting)
                {
                    break;
                }
                sentence = String.Concat(sentence, line);
                Console.WriteLine("\nYou entered: " + sentence);
            }
        }
    }
}