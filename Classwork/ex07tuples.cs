using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    internal class ex07tuples
    {
        static void Main(string[] args)      
        {
            var myex = (20, "Kartik");
            Console.WriteLine($"my age {myex.Item1} my name {myex.Item2} ");
            var person = (name: " Kartik", age: 22, location: "Bangalore");
            Console.WriteLine($" name is {person.name} and the age is {person.age} and he lives in {person.location}");
            var (longi, lotid)=GetCoordinates();
            Console.WriteLine($"the Coordinates are ({longi}, {lotid})");
        }
        /// <summary>
        /// Implements a method that returns the tuple with double values representing the coordinates
        /// </summary>
        /// <returns>
        /// return the longitude and the lotitude </returns>
        static (double, double) GetCoordinates()
        {
            return (12.56,15.69);
        }

    }
}



///<summary>
///
/// </summary>
///<return>
///
///</return>