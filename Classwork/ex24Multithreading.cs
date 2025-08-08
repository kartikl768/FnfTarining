using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal class ex24Multithreading
    {
        static int count = 0;
        static void somecomplexcode()
        {
            lock (typeof(ex24Multithreading))
            {
                var currentthread = Thread.CurrentThread;
                for (int i = 0; i < 5; i++)
                {
                    count++;
                    Console.WriteLine($"complex thread running with {count} and the {currentthread.Name}");
                    Thread.Sleep(1000);
                }
                Console.WriteLine($"Exiting the {currentthread.Name}");
            }
            
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("main thread will starts soon");
            Thread t1 = new Thread(somecomplexcode);
            Thread t2 = new Thread(someultracomplexcode);
            t1.Name = "thread1";
            t1.Start();
            t2.Start();
            //somecomplexcode();
            for(int i = 0; i < 5; i++)
            {
                //count++ ;
                Console.WriteLine($"Main thread is running with the count{count}");
                Thread.Sleep(1000);
            }
        }

        private static void someultracomplexcode(object? obj)
        {
            var currentthread = Thread.CurrentThread;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"ultra complex {currentthread.Name} is running");
                Thread.Sleep(1000);
            }
        }
    }
}
