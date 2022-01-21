using System;
using System.Collections;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit, n = 123456789, count = 0;
            int number = n;

            ArrayList list = new ArrayList();

            while (number!=0)
            {
                digit = number % 10;
                list.Add(digit);
                number = number / 10;
            }
            
            foreach (int item in list)
            {
                if (item != 0)
                {
                    if (n % item == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);


        }
    }
}
