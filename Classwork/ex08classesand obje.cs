using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    class Employee
    {
        private int _id;
        private string _name;
        private string _address;
        private string _salary;

        public int Empid
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Empname
        { 
            get { return  _name; }
            set {  _name = value ; }// here value is a sp keyword: outside the set funtion it is used as variable name
        }

        //propfull is a special feature that it automatically generates the geterrs and setters.
        // propfull+2*tab
        public string Empaddress
        {
            get { return _address; }
            set { _address = value; }
        }

    }
    internal class ex08classesand_obje
    {

        static void Main(string[] args)
        {
            Employee emp =new Employee();
            emp.Empid = 1;
            emp.Empaddress = "Bangalore";
            emp.Empname = "Kartik";
            Console.WriteLine($"the empl id id {emp.Empid} and the name is {emp.Empname} and he lives in {emp.Empaddress}");
        }
    }
}
