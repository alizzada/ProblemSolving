using System;
using System.Collections;

namespace BeautifulDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 13, j = 45, k = 3, b;
            int count = 0;
             
            ArrayList list = new ArrayList();
            ArrayList reversedNumbers = new ArrayList();

            for (int m = i; m <= j; m++)
            {
                list.Add(m);
            }

            ArrayList clone = (ArrayList)list.Clone();

            

            for (int t = 0; t < clone.Count; t++)
            {
                int reverse = 0;
                while ((int)clone[t] != 0)
                {

                    b = (int)clone[t] % 10;
                    reverse = (reverse * 10) + b;
                    clone[t] = (int)clone[t] / 10;
                }
                reversedNumbers.Add(reverse);

                
            }


            for (int l = 0; l < list.Count; l++)
            {
                if (Math.Abs((int)list[l] - (int)reversedNumbers[l]) % k == 0)
                {
                    count++;
                }

            }

            Console.WriteLine(count);

        }


    }
}
