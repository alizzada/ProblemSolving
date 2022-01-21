using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] types = new int[] { 1, 2, 3, 4, 5 };
            int[] birds = new int[] {1,2,3,4,5,4,3,2,1,3,4 };
            int[] difference = new int[] {0,0,0,0,0 };

            

            for(int i=0; i < types.Length; i++)
            {
                for (int j = 0; j < birds.Length; j++)
                {
                    if (types[i] == birds[j])
                    {
                        difference[i] = difference[i] + 1;
                    }
                }
            }

            int maxValue = difference.Max();
            int maxPos = difference.ToList().IndexOf(maxValue);

            Console.WriteLine(maxPos + 1);
            
        }
    }
}
