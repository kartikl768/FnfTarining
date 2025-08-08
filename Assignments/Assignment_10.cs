using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a function called "inWords" that takes a number between 1 and 99,99,99,999 and returns a String representing the input number in words.

public static String inWords(int num) {
	// do stuff here
	return null;
}
For example,

inWords(12345); // should return "twelve thousand three hundred forty five"

inWords(1,02,03,040); // should return "one crore two lakh three thousand forty"

inWords(101); // should return "one hundred one"

Call the function in main, multiple times by supplying multiple values and verify the same.
 */
namespace Assignment_solutions
{
    internal class Assignment_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number (1 to 99,99,99,999):");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num >= 1 && num <= 999999999)
                {
                    string res = inWords(num); // Call the inWords function.
                    Console.WriteLine($"The number in words is: {res}");
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 99,99,99,999.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

        }

        public static string inWords(int num)
        {
            if (num == 0) return "zero"; // Handle zero explicitly.

            Hashtable unitplace = new Hashtable();
            unitplace.Add(0, "");
            unitplace.Add(1, "one");
            unitplace.Add(2, "two");
            unitplace.Add(3, "three");
            unitplace.Add(4, "four");
            unitplace.Add(5, "five");
            unitplace.Add(6, "six");
            unitplace.Add(7, "seven");
            unitplace.Add(8, "eight");
            unitplace.Add(9, "nine");

            Hashtable tensplace = new Hashtable();
            tensplace.Add(0, "");
            tensplace.Add(1, "ten");
            tensplace.Add(2, "twenty");
            tensplace.Add(3, "thirty");
            tensplace.Add(4, "forty");
            tensplace.Add(5, "fifty");
            tensplace.Add(6, "sixty");
            tensplace.Add(7, "seventy");
            tensplace.Add(8, "eighty");
            tensplace.Add(9, "ninety");

            Hashtable teens = new Hashtable(); // Define teens specifically
            teens.Add(10, "ten");
            teens.Add(11, "eleven");
            teens.Add(12, "twelve");
            teens.Add(13, "thirteen");
            teens.Add(14, "fourteen");
            teens.Add(15, "fifteen");
            teens.Add(16, "sixteen");
            teens.Add(17, "seventeen");
            teens.Add(18, "eighteen");
            teens.Add(19, "nineteen");

            string words = "";

            // Crores (1,00,00,000)
            if ((num / 10000000) > 0)
            {
                // Recursively convert the crores part and append "crore".
                words += inWords(num / 10000000) + " crore ";
                num %= 10000000;
            }

            // Lakhs (1,00,000)
            if ((num / 100000) > 0)
            {
                // Recursively convert the lakhs part and append "lakh".
                words += inWords(num / 100000) + " lakh ";
                num %= 100000;
            }

            // Thousands (1,000)
            if ((num / 1000) > 0)
            {
                // Recursively convert the thousands part and append "thousand".
                words += inWords(num / 1000) + " thousand ";
                num %= 1000;
            }

            // Hundreds (100)
            if ((num / 100) > 0)
            {
                // Convert the hundreds digit using unitplace and append "hundred".
                words += unitplace[num / 100] + " hundred ";
                num %= 100;
            }

            // Tens and Units
            if (num > 0)
            {
                if (words != "")
                {
                    words += "and "; // Add "and" if previous words exist.
                }

                if (num < 20)
                {
                    // Handle teens using the 'teens' Hashtable.
                    words += teens[num];
                }
                else
                {
                    // Handle tens using 'tensplace' Hashtable.
                    words += tensplace[num / 10];
                    if ((num % 10) > 0)
                    {
                        // Add unit place if it's not zero.
                        words += " " + unitplace[num % 10];
                    }
                }
            }
            return words.Trim(); // Remove any extra spaces at the beginning or end.


        }
    }
}
