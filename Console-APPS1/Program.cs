namespace ParseSequenceWithSplit
{
using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a set of integers , seperated by a coma (,) : ");
            string input = Console.ReadLine();
            Console.WriteLine();
            // Console.WriteLine(input);
            
            char[] dividers = { ',',' ' };
            string[] segments = input.Split(dividers);

            int sum = 0;
            foreach( string s in segments ) 
            {
                if (s.Length > 0)
                {

                }
                Console.WriteLine(s);
            }
        }

    }
}