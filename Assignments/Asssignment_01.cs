using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * Write a program that displays the range of all the floating and integral types of.NET CTS
 * 
 */
namespace Assignment_solutions
{
    internal class Asssignment_01
    {
        static void Main(string[] args)
        {
            RangeOffloat();
            RangeOfInteger();
        }

        private static void RangeOfInteger()
        {
            Console.WriteLine($"The minimum range of Float is {float.MinValue} and the Maximum range of Float is {float.MaxValue}");
            Console.WriteLine($"The minimum range of Double is {double.MinValue} and the Maximum range of Double is {double.MaxValue}");
            Console.WriteLine($"The minimum range of Decimal is {decimal.MinValue} and the Decimal range of Double is {decimal.MaxValue}");

        }

        private static void RangeOffloat()
        {
            Console.WriteLine($"The minimum range of Int is {int.MinValue} and the Maximum range of Int is {int.MaxValue}");
            Console.WriteLine($"The minimum range of Byte is {byte.MinValue} and the Maximum range of Byte is {byte.MaxValue}");
            Console.WriteLine($"The minimum range of SHort is {short.MinValue} and the Maximum range of Short is {short.MaxValue}");
        }
    }
}
