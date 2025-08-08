using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
    1. Word frequency counter allows you to count the frequency usage of each word in your text. Write a program to find the word and its frequency.
    Input

    A text (alphabets i.e. a-z, A-Z)

    Output

    If the input doesn’t contain even a single alphabet, print 0. For all other valid cases, print the frequency followed up by the word. The first line will print the word with highest frequency; the second line will print the word with next lower frequency value and so on. If two words have equal frequency, it will be prioritised by reverse alphabet order.

    Sample Input: Hello World. This is a nice World.

    Sample Output

    2 world

    1 this

    1 nice

    1 is

    1 hello

    1 a
*/

namespace Hackathon_assessment
{
    internal class assessment_01
    {
        static void Main(string[] args)
        {
            List<string> sentence = getstringinput("Enter the string: ");
            frequencecounter(sentence);
        }

        private static void frequencecounter(List<string> sentence)
        {
            if (sentence.Count == 0)
            {
                Console.WriteLine(" ");
                return;
            }
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in sentence)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }
            }
            // 
            var sorted = dict.OrderByDescending(pair => pair.Value).ThenByDescending(pair => pair.Key);
            foreach (var pair in sorted)
            {
                Console.WriteLine($"{pair.Value} {pair.Key}");
            }
        }

        public static List<string> getstringinput(string ques)
        {
            Console.WriteLine(ques);
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input) || !ContainsAlphabet(input))
            {
                return new List<string>();
            }
            string cleaned = cleanup(input);
            //return cleaned.ToList();
              return cleaned.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries ).ToList();
        }

        private static string cleanup(string input)
        {
            // Remove punctuation manually
            char[] punctuation = { '.', ','};
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
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
