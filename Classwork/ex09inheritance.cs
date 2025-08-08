// C# doesnot support multiple inheritance but it supports the multilevel inheritance

namespace HelloWorld
{
    class BaseClass // it is internal which can accessed within the project only 
    {
        public void Display()
        {
            Console.WriteLine("I am base class");
        }
    }

    // a derived class that inherits from baeclass is required if u want to add a new functionality or to overrride 
    // A class is immutable by default but it is (open - closed principle of SOLID)
   
    class DerivedClass : BaseClass
    {
        public void show()
        {
            Console.WriteLine(" I am derived class");
        }
    }
    class inheritance
    {
        static void Main()
        {
            DerivedClass derived = new DerivedClass();
            // through the derived class we can call the base class methods also
            derived.Display();
            derived.show();
        }
    }
}
