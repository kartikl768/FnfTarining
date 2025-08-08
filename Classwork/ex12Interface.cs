
namespace SampleConApp
{
    // Assuming this is your Employee class
    public class Employee
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }
        public string Designation { get; set; }

        public override string ToString()
        {
            return $"ID: {Empid}, Name: {EmpName}, Address: {EmpAddress}, Salary: {EmpSalary}, Designation: {Designation}";
        }
    }

    interface IEmployee
    {
        void AddEmp(Employee emp);
        void UpdateEmp(Employee emp);
        void DeleteEmp(int id);
        List<Employee> GetallEmp();
    }

    class Emprepo : IEmployee
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmp(Employee emp)
        {
            employees.Add(emp);
        }

        public void DeleteEmp(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Empid == id)
                {
                    employees.RemoveAt(i);
                    return;
                }
            }
        }

        public List<Employee> GetallEmp()
        {
            return employees;
        }

        public void UpdateEmp(Employee emp)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Empid == emp.Empid)
                {
                    employees[i] = emp;
                    return;
                }
            }
        }
    }

    internal class RepoCreator
    {
        public static IEmployee CreateRepo(string type)
        {
            return new Emprepo();
        }
    }

    internal class ex12Interface
    {
        static void Main(string[] args)
        {
            var repo = RepoCreator.CreateRepo("Employee");

            // Add employee
            repo.AddEmp(new Employee
            {
                Empid = 1,
                EmpName = "John Doe",
                EmpAddress = "123 Main St",
                EmpSalary = 50000,
                Designation = "Developer"
            });

            // Update employee
            repo.UpdateEmp(new Employee
            {
                Empid = 1,
                EmpName = "Jane Doe",
                EmpAddress = "456 Elm St",
                EmpSalary = 60000,
                Designation = "Manager"
            });

            // Delete employee
            repo.DeleteEmp(1);

            // Display all employees
            var data = repo.GetallEmp();
            foreach (var emp in data)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("EmpCount: " + data.Count);
        }
    }
}
