using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a Math Calc Program that allows Users to enter the values and operation and the Program should display the result based on the operator the user has typed. It should be in a loop until the user specifies to close it.
 */
namespace Assignment_solutions
{
    internal class Assignment_03
    {
        static void Main(string[] args)
        {
            do
            {
                TakeUserInput();
            }while(true);


        }

        private static void TakeUserInput()
        {
            Console.WriteLine("Enter the Values Ex: value1, value2");
            long v1= Convert.ToInt64(Console.ReadLine());
            long v2= Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Operation to perform");
            Console.WriteLine("+ for Addition, - for Substraction, * for multification, / for Division");
            string op= Console.ReadLine();
            switch (op)
            {
                case "+": Addition(v1,v2); break;
                case "-": Substraction(v1, v2); break;
                case "*": multiplication(v1, v2); break;    
                case "/": division(v1, v2); break;
            }

        }

        private static void division(long v1, long v2)
        {
            if(v2 == 0)
            {
                Console.WriteLine("invalid input ");
            }
            else
            {
                Console.WriteLine($"the result is {v1/v2}");
            }
        }

        private static void multiplication(long v1, long v2)
        {
            Console.WriteLine($"the result is {v1 * v2}");
        }

        private static void Substraction(long v1, long v2)
        {
            Console.WriteLine($"the result is {v1 - v2}");
        }

        private static void Addition(long v1,long v2)
        {
            Console.WriteLine($"the result is {v1 + v2}");
        }
    }
}
