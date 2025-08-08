//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SampleConApp
//{
//    internal class ex22anonymous
//    {

//        static Action<double> action;
//        static void Main(string[] args)
//        {
//            double val= double.Parse(Console.ReadLine());
//            action = callthis(val);
//            //action = delegate (double x)
//            //{
//            //    Console.WriteLine($"the value of the x is {x}");
//            //};
//            if(action != null)
//            {
//                action(val);
//            }
//            usingLambdaInList();
//        }
//        private static void usingLambdaInList()
//        {
//            var list = new List<Employee>
//            {
//                new Employee { EmpID = 1, EmpName = "John", EmpAddress = "New York", EmpSalary = 50000, Designation = "Manager" },
//                new Employee { EmpID = 2, EmpName = "Jane", EmpAddress = "Los Angeles", EmpSalary = 60000, Designation = "Developer" },
//                new Employee { EmpID = 3, EmpName = "Sam", EmpAddress = "Chicago", EmpSalary = 55000, Designation = "Designer" }
//            };

//            //var id = ConsoleUtil.GetInputInt("Enter the Id of the Employee to search");
//            int id= int.Parse(Console.ReadLine());  
//            //var predicate = new Predicate<Employee>((rec) => rec.EmpID == id);
//            var foundRec = list.Find((rec) => rec.EmpID == id);
//            if (foundRec == null)
//            {
//                Console.WriteLine("No record found with the given Id");
//                return;
//            }
//            Console.WriteLine($"{foundRec.EmpName}");
//        }
//        private static void callthis(double val)
//        {
//            Console.WriteLine($"the double value is {val}");
//        }
//    }
//}
