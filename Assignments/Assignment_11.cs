using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a Function that returns a interest amount for a Principal Amount for a term with a specific rate of interest Let the inputs for the function be in the form of parameters.
 */
namespace Assignment_solutions
{
    internal class Assignment_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the priciple amount");
            int p= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Duration in months");
            int t=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of Interest");
            double r= double.Parse(Console.ReadLine());
            double res= CalculateInterest(p, t, r);
            Console.WriteLine($"The Interest amount for {p} is {res}");
        }

        private static double CalculateInterest(int p, int t, double r)
        {
            double res= 0;
            res = (p * t * r) / 100;
            res+=p;
            return res;
        }
    }
}
