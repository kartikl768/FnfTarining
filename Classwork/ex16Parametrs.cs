using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


// 
namespace SampleConApp
{
    internal class ex16Parametrs
    {
        static void normalfunc(int x)
        {
            Console.WriteLine(x);
            x = 123;
            Console.WriteLine($"The value {x}");
        }

        // out parameter -> which will output the method if the return type is void 
        static void Addfunc(int a,int b, out double res)
        {
            res = a + b;
        }

        // params parameter -> it is more similar to the rest operator in js it allows us to give multiple parameters 
        public static long addition(params long[] arr)
        {
            long sum = 0;
            foreach(long i in arr)
            {
                sum+= i;
            }
            return sum;
        }

        // ref parameter -> 
        public static void Arthimaticop(int a, int b, ref double add, ref double sub, ref double mul, ref double dvd)
        {
            add = a + b;
            sub = a-b;
            mul = a * b;
            dvd = a / b;
        }
        static void Main(string[] args)
        {
            //int x = 10;
            //normalfunc(x);
            //Console.WriteLine($"the value of the x is {x}");
            //double res;
            //Addfunc(10,20, out res);
            //Console.WriteLine("the res is "+res);
            //long sum = addition(1,2,3,4,5,6,7,8,9,10,11,12);
            //Console.WriteLine(" sum is : " + sum);
            double add=0, sub=0, mul =1, dvd=1;
            Arthimaticop(20, 10, ref add, ref sub, ref mul, ref dvd);

            Console.WriteLine($"Addition: {add}");
            Console.WriteLine($"Subtraction: {sub}");
            Console.WriteLine($"Multiplication: {mul}");
            Console.WriteLine($"Division: {dvd}");

        }
    }
}
