using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Create a CRUD based App for developing a Movie Database software where the user can add, remove and update movies of his Video library. It should be a menu driven program that has 4 use cases for add, removing, finding and updating movie info in the application.
 */
namespace Assignment_solutions
{
    internal class Assignment_05
    {
        
        static List<string> movies = new List<string>();
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("enter the Choice");
                Console.WriteLine(" 1 add\n 2. removing\n 3. finding\n 4. updating\n 5. List All Movies");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1: addnewMovie(); break;
                    case 2: removeMovie(); break;
                    case 3: FindMovie(); break;
                    case 4: UpdateMovie(); break;
                    case 5: ListAllMovie(); break;
                    
                }  
            } while (true);
            
            
        }

        

        private static void ListAllMovie()
        {
            foreach(var movie in movies)
            {
                Console.WriteLine(movie);
            }
        }

        private static void UpdateMovie()
        {
            Console.WriteLine("Enter Name of the movie to update: ");
            string movie = Console.ReadLine();
            Console.WriteLine("Enter the new name");
            string newmovie = Console.ReadLine();
            int index= movies.IndexOf(movie);
            if(index != -1)
            {
                movies[index] = newmovie;
                Console.WriteLine($"{movie} updated to {newmovie} successfully");
            }
            else
            {
                Console.WriteLine("Movie didn't exit in the Database");
            }
        }

        private static void removeMovie()
        {
            Console.WriteLine("Enter Name of the movie to remove: ");
            string movie = Console.ReadLine();
            if(movies.Contains(movie))
            {
                movies.Remove(movie);
                Console.WriteLine($"{movie} removed Successfully");
            }
            else
            {
                Console.WriteLine("Movie didn't exit in the database");
            }
        }

        private static void FindMovie()
        {
            Console.WriteLine("Enter the Movie name:");
            string movie= Console.ReadLine();
            //string foundMovie = movies.Find(m => m.Equals(movie, StringComparison.OrdinalIgnoreCase));
            if (movies.Contains(movie) )
            {
                Console.WriteLine($"Movie found in the Library: {movie}");
            }
            else
            {
                Console.WriteLine($"Can't find {movie} in the library");
            }
        }

        private static void addnewMovie()
        {
            Console.WriteLine("Enter the new movie");
            string movie = Console.ReadLine();
            if(movies.Contains(movie))
            {
                Console.WriteLine("MOvie already exits in the movie Database");
                return ;
            }
            movies.Add(movie);
            Console.WriteLine("Movie added successfully");
        }
    }
}
