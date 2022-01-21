using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] piles = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int n = 9;
            int count = 0;

            var groups = piles.GroupBy(x => x);
            foreach (var item in groups)
            {
                if(item.Count()!=1 && item.Count() % 2 != 0)
                {
                    count += (item.Count() - 1) / 2;
                }
                else if (item.Count() % 2 == 0)
                {
                    count += item.Count() / 2;
                }

                
            }

            Console.WriteLine(count);






        }
    }
}
