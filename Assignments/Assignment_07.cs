using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Implement the body for the following function:

static boolean isPrimeNumber(int num) {
	// do stuff here
	return false;
}
The function should check and return true only if the number passed as argument is a prime number.
 * 
 */
namespace Assignment_solutions
{
    internal class Assignment_07
    {
        static void Main(string[] args)
        {
            do
            {
                bool ans = false;
                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());
                ans = isPrimeNumber(num);
                Console.WriteLine(ans); 
            } while (true);
        }

        private static bool isPrimeNumber(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
