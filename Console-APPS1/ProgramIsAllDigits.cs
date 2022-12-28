using System;

namespace MyNamespace
{
    class ProgramIsAllDigits
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer");
            string s = Console.ReadLine();

            if (!IsAllDigits(s))
            {
                Console.WriteLine("This is not a number");
            }
            else
            {
                int n = Int32.Parse(s);
                Console.WriteLine("2 * {0} = {1}", n, 2*n);
            }
            Console.WriteLine("Press [Enter] for " +
                "finishing the app...");
            Console.Read();
        }

        public static bool IsAllDigits(string raw)
        {
            
        }
    }
}