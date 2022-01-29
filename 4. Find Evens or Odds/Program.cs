using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            List<int> output = new List<int>();
            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                output.Add(i);
            }
            Predicate<int> currEvenNums = x => x % 2 == 0;
            Predicate<int> currOddNums = x => x % 2 != 0;

            if (command == "even")
            {
                foreach (var number in output)
                {
                    if (currEvenNums(number))
                    {
                        Console.Write(number + " ");
                    }
                } 
            }
            else
            {
                foreach (var number in output)
                {
                    if (!currEvenNums(number))
                    {
                        Console.Write(number + " ");
                    }
                }
            }

            
        }
    }
}
