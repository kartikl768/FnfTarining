using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace SampleConApp
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Billamount { get; set; }
    }
    internal class ex21FileIoexample
    {
        const string filepath = "created.csv";
        
        static void Main(string[] args)
        {
            
            //createdir();
            //createCSV();
            List<Customer> customers = readcsv();
            foreach (Customer customer in customers)
            {
                Console.WriteLine($" id: {customer.Id} name : {customer.Name} amt: {customer.Billamount}");
            }
        }

        private static List<Customer> readcsv()
        {
            List<Customer> customers = new List<Customer>();

            if(File.Exists(filepath))
            {
                // read all the lines from the csv
                var line= File.ReadLines(filepath);
                foreach(var ln in line)
                {
                    var word = ln.Split(',');
                    customers.Add(new Customer
                    {
                        Id = int.Parse(word[0]),
                        Name = word[1],
                        Billamount= double.Parse(word[2])
                    });
                }
            }
            return customers;
        }




        private static void createCSV()
        {
            var customer = new Customer
            {
                Id = 123,
                Name = "kartik",
                Billamount = 123
            };
            var customer1 = new Customer
            {
                Id = 143,
                Name = "alexa",
                Billamount = 659
            };
            var customer2 = new Customer
            {
                Id = 985,
                Name = "Robert",
                Billamount = 742
            };
            List<Customer> customers= new List<Customer> { customer,customer1, customer2 };
            //var content = $"{customer.Id}, {customer.Name}, {customer.Billamount}";
            foreach(var cst in customers)
            {
                var content = $"{cst.Id} {cst.Name} {cst.Billamount} ";
                File.AppendAllText(filepath, content+Environment.NewLine);
            }
            //File.WriteAllText(filepath, content );
        }

        private static void createdir()
        {
            var files = Directory.GetFiles("C:\\Kartik_L_Assignments\\Assignment_solutions\\Assignment_solutions");
            foreach (var file in files)
            {
                var file_info = new FileInfo(file);
                Console.WriteLine($"file name: {file_info.Name} and {file_info.CreationTime}");
                Console.WriteLine();
            }
            Console.WriteLine("Displaying Directories and its Info");
            var directorys = Directory.GetDirectories("C:\\Kartik_L_Assignments\\Assignment_solutions");
            foreach (var dirPath in directorys)
            {
                var dir = new DirectoryInfo(dirPath);
                Console.WriteLine(dir.Name);
            }
            Console.WriteLine("/////./////");
            var newDir = "C:\\Kitrak";
            var dirinfo = Directory.CreateDirectory(newDir);
            var parent = dirinfo.Parent;
            foreach (var file in files)
            {
                var info = new DirectoryInfo((string)file);
                foreach (var file_info in info.GetFiles())
                {
                    Console.WriteLine(file_info.Name);
                }
            }
        }
    }
}
