using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _8._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<int, int, bool> isDividable = (x, number) => x % number == 0;
            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            List<int> result = new List<int>();
            List<int> dividers = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = 0;
                for (int j = 0; j < dividers.Count; j++)
                {
                    if (isDividable(numbers[i], dividers[j]))
                    {
                        currNum = numbers[i];
                    }
                    else
                    {
                        currNum = 0;
                    }


                }
                if (currNum != 0)
                {
                    result.Add(currNum);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
