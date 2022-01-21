using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));

            }

           
        }
    }
}
