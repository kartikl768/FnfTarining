using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal class ex15Constructors
    {
        class superclass
        {
            public superclass()
            {
                Console.WriteLine("i am superclass constructor");
            }
            public superclass (string value) 
            {
                Console.WriteLine($"{value}i am superclass another constructor");
            }
        }
        class baseclass: superclass
        {
            public baseclass() 
            {
                Console.WriteLine(" i am baseclass constructor");
            }
            public baseclass(string msg): base( msg)
            {
                Console.WriteLine(" i am also a baseclass constructor");
            }
        }
        class derivedclass : baseclass
        {
            public derivedclass()
            {
                Console.WriteLine("hello i am derived class consrtuctor");
            }
            public derivedclass(string msg) : base(msg)
            {
                Console.WriteLine($"hi i am {msg}" );
            }
        }
        static void Main(string[] args)
        {
            derivedclass bc = new derivedclass();
            string val = Console.ReadLine();
            baseclass bc2 = new baseclass(val);  
        }
    }
}
