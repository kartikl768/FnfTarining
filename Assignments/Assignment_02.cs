using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a function that takes an array of numbers and it should display the Odd and Even numbers
 */
namespace Assignment_solutions
{
    internal class Assignment_02
    {
        static ArrayList arr = new ArrayList();
        static void Main(string[] args)
        {
            TakeArrayInput();
            PrintOddNumbers();
            PrintEvenNumbers();
        }

        private static void PrintOddNumbers()
        {
            Console.WriteLine("The odd numbers in the array are: ");
            foreach(int i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }

        private static void PrintEvenNumbers()
        {
            Console.WriteLine("The Even numbers in the array are: ");
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }

        private static void TakeArrayInput()
        {
            Console.WriteLine("Enter the size of the Array");
            int n= Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter the array Elements");
            for(int i = 0; i < n; i++)
            {
                arr.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
}
