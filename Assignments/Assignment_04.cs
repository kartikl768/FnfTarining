using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a program that creates an array and displays the contents of the array. The array should be created dynamically. It means that the size, type should be set by the user of the Program. Take inputs for the values also. Finally it should display the values of the array.
 */
namespace Assignment_solutions
{
    internal class Assignment_04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int s= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Type of array elements: int, float, double, string");
            string tp= Console.ReadLine();
            createarray(s,tp);
        }

        private static void createarray(int s, string? tp)
        {

            switch (tp.ToUpper())
            {
                case "INT":
                    intarray(s);
                    break;
                case "DOUBLE":
                    doublearray(s);
                    break;
                case "STRING":
                    stringarray(s);
                    break;
                default:
                    Console.WriteLine("Unsupported type.");
                    break;
            }

        }

        private static void stringarray(int s)
        {
            String[] array = new string[s];
            Console.WriteLine("Enter the array elements:");
            for(int i = 0; i < s; i++)
            {
                array[i]=Console.ReadLine();
            }
            printarr(array);
        }

        

        private static void doublearray(int s)
        {
            Double[] array = new Double[s];
            Console.WriteLine("Enter the array elements:");

            for (int i = 0; i < s; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            printarr(array);
        }

        

        private static void intarray(int s)
        {
            int [] array = new int[s];
            Console.WriteLine("Enter the array elements:");

            for (int i = 0; i < s; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            printarr(array);
        }

        private static void printarr<T>(T[] array)
        {
            Console.WriteLine("Array Elements are: ");
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
