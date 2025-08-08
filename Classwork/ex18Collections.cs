using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal class ex18Collections
    {
        static Hashtable users = new Hashtable();
        static void Main(string[] args)
        {
            //arraylist();
            //hashlist();
            userlogin();
        }

        private static void userlogin()
        {
            do
            {
                Console.WriteLine("Enter R to register and L to login");
                string choice = Console.ReadLine();
                if(choice.ToUpper() == "R")
                {
                    registeruser();
                }
                else if (choice.ToUpper()=="L")
                {
                    loginuser();
                }
                else
                {
                    break;
                }
            }while(true);
        }

        private static void loginuser()
        {
            Console.WriteLine("enter the username");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter the passowrd");
            string pass = Console.ReadLine();
            if (!users.ContainsKey(uname))
            {
                Console.WriteLine("user didnt exits");
            }
            else if (users[uname].ToString() != pass)
            {
                Console.WriteLine("invalid password");
            }else if (users[uname].ToString() == pass)
            {
                Console.WriteLine("welcome to the system");
            }
        }

        private static void registeruser()
        {
            Console.WriteLine("enter the username");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter the passowrd");
            string pass = Console.ReadLine();
            if (users.ContainsKey(uname))
            {
                Console.WriteLine("username already exits");
            }
            users[uname] = pass;
            // the above syntax is similar to .Add but it will update the value if the key is already present

        }

        private static void hashlist()
        {
            Hashtable table = new Hashtable();
            table.Add("a", "65");
            table.Add("b", "66");
            table.Add("c", "67");
            table.Add("d", "68");
            table.Add("e", "69");
            table.Add("f", "70");
            
        }

        private static void arraylist()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Remove(30);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                if ((int)list[i] == x)
                {
                    Console.WriteLine($"Element found at {i}th idex");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
