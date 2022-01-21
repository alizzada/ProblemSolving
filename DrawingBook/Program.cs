using System;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the page count");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the page number");
            int p = Convert.ToInt32(Console.ReadLine());

            int sheetCount = n/2;

            int sheetCountFromFront = p / 2;
            int sheetCountFromBack = sheetCount - sheetCountFromFront;

            Console.WriteLine(Math.Min(sheetCountFromFront, sheetCountFromBack));

           
            

            
        }
    }
}
