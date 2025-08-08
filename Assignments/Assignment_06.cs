using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


/*
 * Implement the body for the following function:

static boolean isValidDate(int year, int month, int day) { 
	// do stuff here
	return false;
}
The function should check if the parameter values constitute a valid calendar date or not. Accordingly return true or false.

For example,

year=2018, month=13, day=1 is an invalid date as the possible values for month is 1 to 12.

year=2018, month=2, day=29 is an invalid date as the maximum days in February is 28 in the year 2018

year=2016, month=2, day=29 is a valid date.

Write a C# program to call the above function multiple times with different values.
 * 
 */
namespace Assignment_solutions
{
    internal class Assignment_06
    {
        static void Main(string[] args)
        {
            do
            {
                bool valid = false;
                int year = GetIntinput("Enter the Year: ");
                int month = GetIntinput("Enter the Month: ");
                int day = GetIntinput("Enter the Day: ");
                valid = IsValidDate(year, month, day);
                Console.WriteLine(valid); 
            } while (true);
        }

        private static bool IsValidDate(int year, int month, int day)
        {
            if((day <1 || day > 31) || (month<1 || month>12 ))
            {
                return false;
            }
            // leap year 
            else if (year % 400 ==0 || year % 4 ==0)
            {
                // leap year 2cd month have 29 days
                if(month == 2)
                {
                    if(day>29) return false;
                    else return true;
                }
                // months with 31 days
                else if ((month == 1) || (month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
                {
                    if (day < 32) return true;
                    else return false;
                }
                // months with 30 days
                else
                {
                    if (day > 30) return false;
                    else return true;
                }
            }
            // not leap year but to handle months with 31 days
            else if((month ==1) ||  (month == 3) || (month == 5) || (month == 7) || (month == 8)  || (month == 10) ||  (month == 12) ) {
                if (day < 32) return true;
                else return false;
            }
            
            // not a leap year 
            else if(month == 2)
            {
                if(day > 28) return false; 
                else return true;
            }
            // months with 30 days
            else
            {
                if (day > 30) return false;
                else return true;
            }
            
        }

        private static int GetIntinput(string v)
        {
            Console.WriteLine(v);
            string input = Console.ReadLine();
            return int.Parse(input);
        }

        
    }
}
