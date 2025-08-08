using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;



// generics-> generic type parameter T, you can write a single class that other client code can use without incurring the cost or risk of runtime casts or boxing operations, as shown here:
namespace SampleConApp.Emp
{
    public class Employee : Object
    {
        private int _id;
        string _name;
        string _address;
        double _salary;
        string _designation;

        public int EmpID
        {
            get { return _id; }
            set { _id = value; }//value is the smart keyword that refers to the value being assigned to the property
        }

        public string EmpName
        {
            get { return _name; }
            set { _name = value; }
        }


        public string EmpAddress
        {
            get { return _address; }
            set { _address = value; }
        }


        public double EmpSalary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }


        // if we want unique elements in the Hashset of our Class we need to explicitly test the employee class which extends the object class
        // which will override the tostring() to compare

        public override string ToString()
        {
            return EmpID.ToString();

        }

        // then the hashcode of it is compared 
        public override int GetHashCode()
        {
            return _id;
        }
        // if the hashcode of the 2 values is equal then we will compare it through the equals() method
        // now we will compare the unique prop of the method
        public override bool Equals(object? obj)
        {
            if (obj is Employee emp)
            {
                if (this.EmpID == emp.EmpID)
                {
                    return true;
                }
            }
            return false;
        }

    }

    internal class ex19generics
    {
        
        static void Main(string[] args)
        {
            //listexample();
            //hashsetexample();
            //hashsetonemploye();
            dictionaryexample();
        }

        private static void dictionaryexample()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("kartik", "ka123");
            users.Add("anmole", "anm123");
            users.Add("alex", "alx123");
            users.Add("adam", "adm123");
            users["jenny"] = "jny123"; // if the key already exits it will update it
            Console.WriteLine("1. sign in  2. signup");
            int op= Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1: signin(); break;
                case 2: signup(); break;
            }
            Console.WriteLine("Enter the username and the apssword to login");
            var username= Console.ReadLine();
            var password= Console.ReadLine();
            if(users.ContainsKey(username) && users[username] == password)
            {
                Console.WriteLine("welcome to system");
            }
            else
            {
                Console.WriteLine("wrong username or password");
            }
        }

        private static void signup()
        {
            throw new NotImplementedException();
        }

        private static void signin()
        {
            throw new NotImplementedException();
        }

        private static void hashsetonemploye()
        {
            
            HashSet<Employee> employees = new HashSet<Employee>();
            //employees.Add(new Employee { Empid = 1, EmpName="kartik", Designation= "trainee", EmpAddress="Dharwad", EmpSalary=15000} );
            //employees.Add(new Employee { Empid = 2, EmpName="kitrak", Designation= "sde", EmpAddress="blr", EmpSalary=55000} );
            //employees.Add(new Employee { Empid = 3, EmpName="anmol", Designation= "qa", EmpAddress="mysore", EmpSalary=15000} );
            //employees.Add(new Employee { Empid = 4, EmpName="robert", Designation= "devops", EmpAddress="Ooty", EmpSalary=45000} );
            //employees.Add(new Employee { Empid = 5, EmpName="alex", Designation= "HR", EmpAddress="chennai", EmpSalary=15000} );
            //employees.Add(new Employee { Empid = 1, EmpName="kartik", Designation= "trainee", EmpAddress="Dharwad", EmpSalary=15000} );
            foreach ( Employee emp in employees )
            {
                Console.WriteLine($"{emp.EmpName} earns a salary of {emp.EmpSalary:C}");
            }

        }

        // hashset is similar to list it doesnot allow duplicates. only unique values
        private static void hashsetexample()
        {
            HashSet<string> list = new HashSet<string>();
            list.Add("kartik");
            list.Add("kitrak");
            list.Add("john");
            list.Add("doe");
            list.Add("kartik");
            if (!list.Add("doe"))
            {
                Console.WriteLine("doe already exist ");
            }
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine($"{list.Count}");
        }

        private static void listexample()
        {
            List<string> list = new List<string>();
            list.Add("john");
            list.Add("doe");
            list.Add("alice");
            list.Add("bob");
            list.Insert(3, "joe");
            Console.WriteLine(list.GetHashCode());
            foreach (string item in list)
            {
                Console.WriteLine(item.ToUpper());
            }
            Console.WriteLine("enter the name to search");
            string nametosearch = Console.ReadLine();
            if (!list.Contains(nametosearch))
            {
                Console.WriteLine("not found");
            }
            else
            {
                Console.WriteLine(list.IndexOf(nametosearch));
                //for(int i=0;i<list.Count;i++)
                //{
                //    if (list[i].ToUpper() == nametosearch.ToUpper())
                //    {
                //        Console.WriteLine($" {nametosearch} found at index {i}");
                //        break;
                //    }
                //}
            }
        }
    }
}
