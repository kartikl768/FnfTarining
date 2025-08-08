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
    internal class asgn_05
    {
        class Movie
        {
            public int id;
            public string name;
            public int year;

            public int MovieId
            {
                get { return id; }
                set { id = value; } // value is sp keyword
            }
            public string Moviename
            {
                get { return name; }
                set { name = value; }

            }
            public int Movieyear
            {
                get { return year; }
                set { year = value; }
            }
        }
        class moviesRepo
        {
            static List<Movie> movies = new List<Movie>();
            public void AddMovie(Movie mv)
            {
                movies.Add(mv);
                Console.WriteLine($"{mv} movie added.");
            }
            public void RemoveMovie(Movie mv)
            {
                movies.Remove(mv);
                Console.WriteLine($"{mv} is removed");
            }
            public void UpdateMovie(Movie mv)
            {
                for(int i=0;i<movies.Count;i++)
                {
                    if (movies[i].id==mv.id)
                    {
                        movies[i] = new Movie(); 
                        movies[i].id = mv.id;
                        movies[i].name = mv.name;
                        movies[i].year = mv.year;
                        Console.WriteLine($"{mv.name} updated.");
                        return;
                    }

                }
            }
            public Movie Findmovie(int id)
            {
                return movies.Find(mv => mv.id == id);
            }
            public void GetAllMovies()
            {
                foreach (var movie in movies)
                {
                    Console.WriteLine($"id: {movie.id} name: {movie.name} year: {movie.year}");
                }
            }
           
            public void DeleteMovie(int id)
            {
                var rec = movies.Find(mv => mv.id == id);
                if (rec == null)
                {
                    Console.WriteLine($"No MOvie found with ID {id} to delete.");
                    return;
                }
                movies.Remove(rec);
                Console.WriteLine("Movie deleted.");
            }
        }

        static moviesRepo repo = new moviesRepo();
        static void Main(string[] args)
        {
            bool processing = true;
            do
            {
                Console.WriteLine("Enter the choice:");
                Console.WriteLine("1. ADD\n 2.Remove\n 3.Update\n 4.find\n 5.List all");
                int choice = Convert.ToInt32(Console.ReadLine());
                processing = processMenu(choice);
            }while(processing);
        }
        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1: addmovie(); return true;
                case 2: removemovie(); return true;
                case 3: updatemovie(); return true;
                case 4: findmovie(); return true;
                case 5: listallmovies(); return true;
                default: Console.WriteLine("Invalid Choice"); return false;
            }
        }

        private static void listallmovies()
        {
            repo.GetAllMovies();
        }

        private static void updatemovie()
        {
            Movie mv = new Movie();
            Console.WriteLine("Enter the movie id");
            int mvid= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the movie name");
            string name= Console.ReadLine();
            Console.WriteLine("Enter the movie Year");
            int year= int.Parse(Console.ReadLine());
            repo.UpdateMovie(mv);
        }

        private static void findmovie()
        {
            Console.WriteLine("Enter the movie id to find");
            int mvid=int.Parse(Console.ReadLine()); 
            repo.Findmovie(mvid);
        }

        private static void removemovie()
        {
            Console.WriteLine("Enter the movie id to remove:");
            int mid=int.Parse(Console.ReadLine());  
            repo.DeleteMovie(mid);
        }

        private static void addmovie()
        {
            Movie mv = new Movie();

            mv.id=int.Parse(Console.ReadLine());
            mv.name = Console.ReadLine();
            mv.year = int.Parse(Console.ReadLine());
            repo.AddMovie(mv);
        }
    }
}
