using System;

namespace TheHurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 1;
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    height = height * 2;
                }
                else
                {
                    height = height + 1;
                }
            }

            Console.WriteLine(height);

            
        }
    }
}
