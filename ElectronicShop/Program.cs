using System;
using System.Collections;

namespace ElectronicShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 60;
            int[] keyboards = new int[] { 40, 50, 60 };
            int[] drives = new int[] { 5, 8, 12 };
            bool check = false;
            int result = 0;

            ArrayList list = new ArrayList();
            int sum;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    list.Add( keyboards[i] + drives[j]);
                }
            }

            list.Sort();
            for (int i = list.Count-1; i >= 0; i--)
            {
                if ((int)list[i]<=b)
                {
                    result=(int)list[i];
                    check = true;
                    break;
                }
            }
            if (!check)
                result =- 1;

            Console.WriteLine(result);
            
        }


    }
}
