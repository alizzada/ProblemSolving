using System;
using System.Linq;

namespace DeleteAndAppend
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7, m = 7, s = 2;
            int candy = m;

            if (m < n)
            {
                candy = m;
            }
            else if (m > n)
            {
               
                candy = m % n;
            }
            

            
            

            for (int i = s; i <= n; i++)
            {
                candy--;
                if (candy == 0)
                    Console.WriteLine(i);
            }


        }
    }
}
