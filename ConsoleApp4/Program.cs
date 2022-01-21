using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 1, 3, 2, 6, 1, 2 };
            int k = 3;

            int count = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length; j++)
                {
                    if(i<j && (ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
