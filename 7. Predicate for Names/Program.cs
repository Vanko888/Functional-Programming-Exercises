using System;

namespace _7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Predicate<string> isTrue = x => x.Length <= n;
            foreach (var name in names)
            {
                if (isTrue(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
