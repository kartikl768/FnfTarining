using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    interface isimple
    {
        public void simpleshow();
    }
    interface Icomplex
    {
        public void complexshow();
    }

    interface Iexample
    {
        public void showexample();
    }
    interface Iexample2 { 
        public void showexample(); 
    }

    class exm : Iexample, Iexample2
    {
        public void showexample()
        {
            Console.WriteLine(" std example");
        }
        void Iexample.showexample()
        {
            Console.WriteLine("example 1");
        }
        void Iexample2.showexample()
        {
            Console.WriteLine("example 2");
        }
    }
    class display : isimple, Icomplex // multiple iterface implementation
    {
        public void complexshow()
        {
            Console.WriteLine("i am simple one");
        }

        public void simpleshow()
        {
            Console.WriteLine("i am complex one");

        }
    }
    internal class ex13advInterface
    {
        static void Main(string[] args)
        {
            //isimple isimple = new isimple();
            //isimple.simpleshow();
            //Icomplex iscomplex = new Icomplex(); 
            //iscomplex.complexshow();

            Iexample ie1 = new exm();
            exm e = new exm();
            Iexample2 ie2 = new exm();
            ie1.showexample();
            e.showexample();
            ie2.showexample();
        }
    }
}
