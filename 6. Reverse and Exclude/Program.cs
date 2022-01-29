using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int input = int.Parse(Console.ReadLine());
            Func<int, int, bool> result = (x, y) => x % y != 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (result(numbers[i], input))
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
