using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        public static int roundUp(int n)
        {
            return (n + 4) / 5 * 5;
        }
        static void Main(string[] args)
        {
            //string words = "saveChangesInTheEditor";
            //int count = 0;

            //for(int i = 0; i < words.Length; i++)
            //{
            //    if (char.IsUpper(words[i]))
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count + 1);

            List<int> grades = new List<int> { 73, 67, 38, 33 };

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    grades[i] = grades[i];
                }
                else if ((roundUp(grades[i]) - grades[i]) < 3)
                {
                    grades[i] = roundUp(grades[i]);
                }
                else if((roundUp(grades[i]) - grades[i]) >= 3 )
                {
                    grades[i] = grades[i];
                }
                
            }

            Console.WriteLine(String.Join("\n", grades));

        }
    }
}
