using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Object is the Universal data type in c# All the data type in c# are derived from Object class. it is refernce type. object is like void* in c/c++. 
 * Boxing and Unboxing are 2 imp concepts. 
 * Boxing -> implicit type casting to every type to object
 * Unboxing -> Explicit type casting where object is converted to Original 
 * */
namespace HelloWorld
{
    internal class ex06Object
    {
        static void Main(string[] args)
        {
            object obj = 20;// Boxing - implicit conversion of any type to object type
            obj = "kartik";
            Console.WriteLine(obj.GetType().Name);
            obj = 20.32f;
            Console.WriteLine(obj.GetType().Name);
            float f = (float)obj;
            Console.WriteLine(f);
            f++;
        }
    }
}
