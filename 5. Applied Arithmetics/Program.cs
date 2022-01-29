using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Action<int[]> addNumbers = elements =>
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i]++;
                }
            };
            Action<int[]> substractNumbers = elements =>
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i]--;
                }
            };
            Action<int[]> multyplyNumbers = elements =>
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i] = elements[i] * 2;
                }
            };
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        addNumbers(numbers);
                        break;


                    case "multiply":
                        multyplyNumbers(numbers);
                        break;


                    case "subtract":
                        substractNumbers(numbers);
                        break;


                    case "print":
                        Printing(numbers);
                        break;
                    default:
                        break;
                        
                }


                command = Console.ReadLine();
            }
        }

        private static void Printing(int[] nums)
        {
            Console.WriteLine(string.Join(" ", nums));

            
        }

        
        
    }
}
