using System;

namespace MIU
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { };

            Console.WriteLine(IsPairedN(a,5));
        }


        private static int HasSingleMaximum(int[] a)
        {
            int index=0;

            int maxElement = a[0];

            if(a.Length<=0 || a == null)
            {
                return 0;
            }

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] > maxElement)
                {
                    maxElement = a[i];
                    index = i;
                }
            }

            for(int j = 0; j < a.Length; j++)
            {
                if(j!=index && a[j] == maxElement)
                {
                    return 0;
                }
            }

            return 1;
        }

        //[1,2,3,0]

        private static int IsFunArray(int[] a)
        {
            if (a.Length % 2 != 0)
                return 0;

            bool isFunArray = false;
            for(int i=0; i <= a.Length-4; i+=2)
            {
                if (a[i] + a[i + 1] == a[i+2] + a[i+3])
                {
                    isFunArray = true;
                    break;
                    
                }

            }

            if (!isFunArray)
            {
                return 0;
            }

            return 1;

        }



        private static int IsPairedN(int[]a, int n)
        {

            bool isPaired = false;
            if (a.Length <= 1 || a == null)
            {
                return 0;
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j< a.Length; j++)
                {
                    if (i != j && (a[i] + a[j]) == n && i + j == n)
                    {
                        isPaired = true;
                        break;
                    }
                }
            }
            if (!isPaired) {
                return 0;

            }

            return 1;

        }
    }
}
