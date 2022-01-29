using System;
using System.Threading.Channels;

namespace _1._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string> printName = (name) => Console.WriteLine($"Sir {name}");
            foreach (var name in names)
            {
                printName(name);
            }
        }
    }
}