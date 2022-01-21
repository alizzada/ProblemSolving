using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<char>("i am working as a developer");
            foreach (var item in set) Console.WriteLine(item);
        }

    }

    abstract class Car
    {
        public abstract void Run();
    }

    abstract class BMW : Car
    {
        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}
