using System;
using System.Collections;

namespace DesignerPDFViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "zaba";
            int[] numbers = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            string[] words = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            

            ArrayList list = new ArrayList();

            for(int i = 0; i < word.Length; i++)
            {
                list.Add(numbers[Array.IndexOf(words, word.Substring(i, 1))]);
            }
            list.Sort();
            int size = (int)list[list.Count - 1];

            int result = word.Length  * 1 * size;
            Console.WriteLine(result);





        }
    }
}
