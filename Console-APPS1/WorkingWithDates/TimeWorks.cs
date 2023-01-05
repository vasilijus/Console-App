using System;

using System.Collections.Generic;
// AlignOutput - viravnivanie mnozestvo strok, dlia uludshenia vneshnego vida v output
// Some of the things that want to practice: 
// Trim(), Pad(), PadRight(), PadLeft(), String() и Concat()
namespace UsefullTime
{
    public class TimeWorks
    {
        public static bool IsYearLeapYear(int year)
        {
            DateTime thisYear = new DateTime(year, 1, 1);
            bool isLeapYear = DateTime.IsLeapYear(thisYear.Year);
            Console.WriteLine("Year: " + thisYear.Year + ", is leap year: " + isLeapYear);
            return isLeapYear;
        }

        public static void WorkingWithDate() {
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
    }
}