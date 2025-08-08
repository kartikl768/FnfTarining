using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.OperatorOverloading
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmpSalary { get; set; }

    //operator overloading can be implemented using a static keyword and the "operator" keyword follwed by the operator(+,-,*)
    public static Employee operator +(Employee lhs, int rhs)
        {
            lhs.EmpSalary += rhs;
            return lhs;
        }
        public static Employee operator -(Employee lhs, int rhs)
        {
            lhs.EmpSalary -= rhs;
            return lhs;
        }

    }
}
namespace SampleConApp.OperatorOverloading
{
    internal class ex25OperatorOverloading
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee
            {
                Id = 1,
                Name = "Ramesh",
                EmpSalary = 15000
            };
            emp1 += 500;
            Console.WriteLine("The employee salary is "+emp1.EmpSalary);
            emp1 -= 1000;
            Console.WriteLine("the employee salary after deduction is: " + emp1.EmpSalary);
        }
    }
}
