using System;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> smallest = numbers =>
            {
                int minNumber = int.MaxValue;
                foreach (var number in numbers)
                {
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }

                }

                return minNumber;
            };
            int result = smallest(numbers);
            Console.WriteLine(result);
        }
    }
}
