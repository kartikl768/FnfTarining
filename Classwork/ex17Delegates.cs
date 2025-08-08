//Similar to Function pointers of C++. They are used to pass functions are arguments to other Functions. Example could be predicates that are passed for filtering a collection. The Predicate shall provide a logic on how to filter the collection.
//In C#, callbacks and predicates are implementing using delegate. 
//A Delegate is a signature of a method that can be used to call inside another function. 
//Delegate is more like a function type. 
//Delegates are type-safe and secure, meaning they can only call methods that match their signature.

// there are list of built-in delegates like- Action<> and func<> 
namespace SampleConApp
{
    internal class ex17Delegates
    {
        delegate double mathop(double a, double b);

        // func is a generic delegate used to perform operations on differnt types and parameters
        static void Invokefunc(Func<double, double,double> func)
        {
            double v1 = Convert.ToDouble(Console.ReadLine());
            double v2 = Convert.ToDouble(Console.ReadLine());
            double res = func(v1, v2);
            Console.WriteLine("result is : " + res);
        }
        static void InvokeMethod(mathop fun)
        {
            double v1= Convert.ToDouble(Console.ReadLine());
            double v2= Convert.ToDouble(Console.ReadLine());
            double res = fun(v1,v2);
            Console.WriteLine("result is : " + res);
        }
        static void Main(string[] args)
        {
            //InvokeMethod(add);
            Invokefunc((d1, d2) => d1 * d2);
        }
        static double add(double a, double b) => a+b;
    }
}
