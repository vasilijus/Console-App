using System;

// See https://aka.ms/new-console-template for more information
namespace MyNamespace
{
    public class ConsoleApp1
    {
        string[] options = {
            "1",
            "2",
            "3",
            "4",
        };
        ConsoleApp1()
        {
            Console.WriteLine("Welcome to my App, NO ARGS");
            this.init();
        }
        ConsoleApp1(string argument)
        {
            Console.WriteLine("Hello, World!, ARGS: " + argument);
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello: "+args.Length);
            
            if(args.Length > 0)
            {
                ConsoleApp1 app = new ConsoleApp1(args[0]);
            }
            else
            {
                ConsoleApp1 app = new ConsoleApp1();
            }

            IsAllDigitsP dig = new IsAllDigitsP();

            
        }

        public void init() {
            this.WorkingWithDate();
            // this.HelloComrad();

            Student s1 = new Student();
            s1.Name = "Sergio";
            Console.WriteLine(s1.greeting());


            this.ExitScript();
        }

        public void ExitScript() {
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
            string favFood = "Cheeseburger";
            foreach (char letter in favFood)
            {
                Console.Write(letter+ " ");
            }
        }

        public void randomTestCases() {
            decimal dec1 = 100M;
            Console.WriteLine("Decimal"+ dec1);
        }
        public void isYearLeapYear(int year) {
            Console.WriteLine("Function: isYearLeapYear \n");
            DateTime thisYear = new DateTime(year, 1, 1);
            bool isLeapYear = DateTime.IsLeapYear(thisYear.Year);
            Console.WriteLine("Year: " + thisYear.Year + ", is leap year: " + isLeapYear);
        }

        public void WorkingWithDate() {
            DateTime thisMoment = DateTime.Now;
            Console.WriteLine(thisMoment + ", " + thisMoment.DayOfWeek + ", " + thisMoment.DayOfYear);
            DateTime anHourFromNow = thisMoment.AddHours(1);
            TimeSpan duration3d = new TimeSpan(3, 0, 0, 0); // days
            DateTime threeDaysAfter = thisMoment.Add(duration3d);
            Console.WriteLine("In 1hour: "+anHourFromNow + ", After a span of 3 days: " + threeDaysAfter);
            
            TimeSpan duration1h = new TimeSpan(1, 0, 0);
            DateTime anHourAfterMidnight = DateTime.Today.Add(duration1h);
            Console.WriteLine("Hour after midnight - {0}", anHourAfterMidnight);
            DateTime anHourBeforeMidnight = DateTime.Today.Subtract(duration1h);
            Console.WriteLine("Hour before midnight - {0}", anHourBeforeMidnight);
        }

        public void HelloComrad() {
            Console.WriteLine(" Whats your name ?");
            string name = Console.ReadLine();
            Console.WriteLine(" Hello, " + name);
        }

        public void DisplayUnicodeChars() {
            int nChars = 0x044F + 1; // 1104
            char[] chars = new char[nChars];
            ushort codePoint = 0x0410;
            for (int ctr = 0; ctr < chars.Length; ctr++) {
                chars[ctr]  = (char)codePoint;
                codePoint++;
            }
            Console.WriteLine("Int num: {0}", nChars);

            Console.WriteLine(
                "Current code page: {0}\n",
                Console.OutputEncoding.CodePage
            );
            foreach (var ch in chars)
            {
                Console.Write("{0}  ",ch);
                if(Console.CursorLeft >= 70)
                    Console.WriteLine();
            }
        }

        
    }

    class Student
    {
        public String Name;
        public string greeting() {
            return "Hello ,"+this.Name.ToUpper()+"!!!";
        }
    }

    class IsAllDigitsP
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