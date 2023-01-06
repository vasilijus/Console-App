using System;

namespace UsefullFunctions
{
    class DisplayUnicodeChars
    {
        public static void Show()
        {
            int nChars = 0x0044F + 1; // 1104
            char[] chars = new char[nChars];
            ushort codePoint = 0x0410;
            for(int ctr = 0; ctr < chars.Length; ctr++)
            {
                chars[ctr] = (char)codePoint;
                codePoint++;
            }
            Console.WriteLine("Int num: {0}", nChars);

            Console.WriteLine(
                "Current code page: {0}\n",
                Console.OutputEncoding.CodePage
            );

            foreach(char ch in chars)
            {
                Console.Write("{0}  ",ch);
                if(Console.CursorLeft >= 70)
                    Console.WriteLine();
            }
        }
    }
}