using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Implement the C# function listed below:

public static void printCalendar(int month, int year) {
	/// do stuff here
}
The function should accept month and year and print the calendar for the same. If inputs are invalid, appropriate error message/s should be printed.

Sample output for the inputs (8, 2018): image

PS: Do not use any builtin C# classes like DateTime Divide the function into small reusable functions, if possible.
 * 
 */

namespace Assignment_solutions
{
    internal class Assignment_08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Year: ");
            int year = int.Parse(Console.ReadLine());
            printCalendar(month, year);
        }

        public static void printCalendar(int month, int year)
        {
            if (month < 1 || month > 12 || year < 1)
            {
                Console.WriteLine("Invalid month or year.");
                return;
            }

            string[] days = { "Su", "Mo", "Tu", "We", "Th", "Fr", "Sa" };
            int daysInMonth = GetDaysInMonth(month, year);
            int startDay = GetStartDay(month, year); // 0 = Sunday

            Console.WriteLine($"\nCalendar for {GetMonthName(month)} {year}\n");

            // Print header
            foreach (var day in days)
                Console.Write(day + " ");
            Console.WriteLine();

            // Print initial spaces
            for (int i = 0; i < startDay; i++)
                Console.Write("   ");

            // Print days
            for (int date = 1; date <= daysInMonth; date++)
            {
                Console.Write($"{date,2} ");
                if ((startDay + date) % 7 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();
        }

        static int GetDaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 2:
                    return IsLeapYear(year) ? 29 : 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static string GetMonthName(int month)
        {
            string[] names = { "January", "February", "March", "April", "May", "June",
                               "July", "August", "September", "October", "November", "December" };
            return names[month - 1];
        }

        static int GetStartDay(int month, int year)
        {
            // Zeller's Congruence algorithm
            if (month < 3)
            {
                month += 12;
                year--;
            }

            int q = 1; // Day of month
            int m = month;
            int k = year % 100;
            int j = year / 100;

            int h = (q + (13 * (m + 1)) / 5 + k + (k / 4) + (j / 4) + 5 * j) % 7;

            // Zeller's returns: 0=Saturday, 1=Sunday, ..., 6=Friday
            // Convert to: 0=Sunday, ..., 6=Saturday
            return (h + 6) % 7;

        }
    }
}
