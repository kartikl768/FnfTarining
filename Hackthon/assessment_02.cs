using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/* 2. Librarian has a list of books and their authors as a text. You need to write a program to assist him. Write a method that prints the output as the book titles and is sorted based on the alphabetical order of their author names and book titles.

The Function signature:

List<String> SortTitles (List<String>) {}


Assumptions & Limitations:

1. A title will not contain the double quote (") character.

2. If a book contains more than one author, consider only the first author's name for sorting.

3. If two books have the same first author, use the book title for sorting.

4. Book titles are unique.

Sample Input (List containing the following three entries) Sample Output (List containing the following three entries)

"The Canterbury Tales" by Chaucer

"Algorithms" by Sedgewick

"The C Programming Language" by Kernighan and Ritchie 
The Canterbury Tales 
The C Programming Language 
Algorithms

*/
namespace Hackthon_assesment
{
    internal class assessment_02
    {
        static void Main(string[] args)
        {
           List<string> books = getstringinput($"Enter the book name in {" "}follwed by the book author");
           books = SortTitles(books);
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
        }

        private static List<string> SortTitles(List<string> books)
        {
            // to store author and book
            List<string[]> booknauth = new List<string[]>();
            foreach (string book in books)
            {
                int idx = book.IndexOf(" by ");
                if (idx != -1)
                {
                    string title = book.Substring(0, idx).Trim('"'); ;

                    // idx + 4 = 2 spaces and 2 for by
                    string authorPart = book.Substring(idx + 4).Trim();
                    // Getting first author's name before "and"
                    string firstAuthor = authorPart.Split(' ')[0];
                    booknauth.Add(new string[] { firstAuthor, title });
                }
            }
            // sorting the book and authors using bubble sort
            List<string> sorted = sortbyauthor(booknauth);
            return sorted;
        }

        private static List<string> sortbyauthor(List<string[]> booknauth)
        {
            for (int i = 0; i < booknauth.Count - 1; i++)
            {
                for (int j = i + 1; j < booknauth.Count; j++)
                {
                    if (string.Compare(booknauth[i][0], booknauth[j][0]) > 0 ||
                        (booknauth[i][0] == booknauth[j][0] && string.Compare(booknauth[i][1], booknauth[j][1]) > 0))
                    {
                        // Swap
                        string[] temp = booknauth[i];
                        booknauth[i] = booknauth[j];
                        booknauth[j] = temp;
                    }
                }
            }
            List<string> sorted = new List<string>();
            foreach (var pair in booknauth)
            {
                sorted.Add(pair[1]);
            }

            return sorted;
        }

        public static List<string> getstringinput(string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine("Enter each book on a new line in this 'Title' by Author fromat. Type 'done' when finished:");
            var books = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "done") break;
                if (!string.IsNullOrWhiteSpace(input) && ContainsAlphabet(input))
                {
                    books.Add(cleanup(input));
                }
            }
            return books;
        }


        private static string cleanup(string input)
        {
            char[] punctuation = { '.', ',', ':' };
            foreach (char p in punctuation)
            {
                input = input.Replace(p.ToString(), "");
            }
            return input.ToLower();
        }

        private static bool ContainsAlphabet(string input)
        {
            foreach (char c in input)
            {
                if((c>= 'a' && c<='z') || (c>='A' && c <= 'Z'))
                {
                    return true;    
                }
            }
            return false;
        }
    }
}
