using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            int minCount = 0;
            int maxCount = 0;

            int maxScore = scores[0];
            int minScore = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i]>maxScore)
                {
                    maxScore = scores[i];
                    maxCount++;
                }
                if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    minCount++;
                }
            }

            Console.WriteLine(maxCount.ToString());
            
        }
    }
}
