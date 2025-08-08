using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

// all exception are derived from the system.Exception u can create a Custom exception to meet ur 
// Exception Handling 
namespace SampleConApp
{
    internal class ex14ExceptionHandling
    {
        static void Main(string[] args)
        {
            //firstExample();
            //secondExample();
            try
            {
                thirdExample();
            }
            catch (DbFailureException ex)
            {
                Console.WriteLine($"the message is {ex}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"THe messahe is {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Executed Successfully");
            }

        }

        [Serializable]
        public class DbFailureException : Exception
        {
            public DbFailureException() { }
            public DbFailureException(string message) : base(message) { }
            public DbFailureException(string message, Exception inner) : base(message, inner) { }
            
        }

        private static void thirdExample()
        {
            bool isConnected = true;
            Console.WriteLine("db");
            isConnected = false;
            if(!isConnected)
            {
                throw new DbFailureException("the connection failed");
            }
            Console.WriteLine("db connected");
        }

        private static void secondExample()
        {
        Retry:
            try
            {
                throwingExceptionex();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("retry ");
                goto Retry;
            }
        }

        /// <summary>
        /// Validate the username and the password
        /// </summary>
        /// <exception cref="UnauthorizedAccessException">username and the passowrd are wrong or incorrect</exception>
        private static void throwingExceptionex()
        {
            Console.WriteLine("enter the username");
            string uname= Console.ReadLine();
            Console.WriteLine("enter the password");
            string pwd = Console.ReadLine();
            if( uname == "admin" && pwd == "admin")
            {
                Console.WriteLine("welcome to the system");
            }
            else
            {
                throw new UnauthorizedAccessException("Invalid username or Password");
            }
        }

        private static void firstExample()
        {
        Retry:
            try
            {
                Console.WriteLine("Enter the age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"the entered age is {age}");
            }
            catch (FormatException ex1)
            {
                Console.WriteLine($"the message is {ex1.Message}");
                goto Retry;
            }
            catch (OverflowException ex2)
            {
                Console.WriteLine($"the message is {ex2.Message}");
                goto Retry;
            }
            finally
            {
                Console.WriteLine("the executed always !");
            }
        }
    }
}
