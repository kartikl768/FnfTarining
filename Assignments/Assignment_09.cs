using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a function called "reverseByWords", that takes a sentence (string) as an input, and returns another string. The return value must be a sentence in which the words in the original sentence appear in reverse order.

public static string reverseByWords(string sentence) {
	// do stuff here
	return null;
}
For example,

String out = reverseByWords("my name is vinod and i live in bangalore");

// the variable "out" should be equal to "bangalore in live i and vinod is name my".

Call the function in main, multiple times by supplying multiple values and verify the same.
 */
namespace Assignment_solutions
{
    internal class Assignment_09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine(reverseByWords(sentence));

        }

        private static string reverseByWords(string? sentence)
        {

            //my name is vinod and i live in bangalore
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ",words);
        }
    }
}
