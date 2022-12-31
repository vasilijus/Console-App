using System;

// See https://aka.ms/new-console-template for more information
namespace MyNamespace
{
    public class ConsoleApp1
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a integer");
            string s = Console.ReadLine();
            Console.WriteLine();

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
            if( string.IsNullOrEmpty(raw)) return false;

            foreach( char c in raw ) 
            {
                if( !char.IsDigit(c) )
                {
                    Console.WriteLine("{0}, is not a digit.", c);

                    return false;
                }
            }
            return true;
        }
      
    }
}