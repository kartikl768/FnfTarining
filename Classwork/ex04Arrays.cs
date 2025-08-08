using System;
using System.Reflection;

namespace HelloWorld
{
    internal class ex04Arrays {
        static void Main(string[] args)
        {
            //SingleDimensionArray();
            MultiDimensionArray();
            JaggedArray();
        }

        private static void JaggedArray()
        {
            // array of array 
        }

        private static void MultiDimensionArray()
        {
            int[,] marks = new int[2, 3];
            marks = new int[,]
            {
                { 1, 0, 1 },
                { 1, 1, 2 }
            };
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    Console.Write($"{marks[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void SingleDimensionArray()
        {
            string[] names = new string[5];
            names[0] = "aaa";
            names[1] = "bbb";
            names[2] = "ccc";
            names[3] = "ddd";
            names[4] = "eee";
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }

}