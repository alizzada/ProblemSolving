using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = "12:01:00AM";
            string second = date.Substring(6, 2);
            string minute = date.Substring(3, 2);
            string format = date.Substring(date.Length - 2, 2);
            string hour = date.Substring(0, 2);

            if(format=="PM" && int.Parse(hour) < 12)
            {
                hour = (Convert.ToInt32(hour) + 12).ToString(); ;
            }
            if(format=="AM" && int.Parse(hour) == 12)
            {
                hour = "00";
            }



            Console.WriteLine(hour.ToString()+":"+minute.ToString()+":"+second.ToString());
        }
    }
}
