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
                    if (IsAllDigits(s))
                    {
                        int num = 0;
                        if (Int32.TryParse(s, out num))
                        {
                            Console.WriteLine("Another integer: {0}", num);

                            sum += num;
                        }
                        // In case of failure to Parse, moves to another segment
                    }
                }
                // Console.WriteLine(s);
            }
        }

        public static bool IsAllDigits(string raw)
        {
            bool isDigit = true;

            if( string.IsNullOrEmpty(raw)) return false;

            for(int index = 0; index < raw.Length; index++)
            {
                if (Char.IsDigit(raw[index]) == false)
                {
                    isDigit = false;
                }
            }

            return isDigit;
        }
    }
    
}