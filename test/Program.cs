using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //    •	Everyone that has his name starting with a given string
            //    •	Everyone that has a name ending with a given string
            //    •	Everyone that has a name with a given length



            List<string> people = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            Func<string, string, bool> startWith = (x, str) => x.StartsWith(str);
            Func<string, string, bool> endsWith = (x, str) => x.EndsWith(str);
            Func<int, int, bool> lenghtIs = (x, str) => x == str;
            List<string> tempPeople = new List<string>();
            while (command != "Party!")
            {
                
                string[] currCommand = command.Split();
                if (currCommand[0] == "Remove")
                {
                    if (currCommand[1] == "StartsWith")
                    {
                        foreach (var person in people)
                        {
                            if (startWith(person, currCommand[2].ToString()))
                            {
                                tempPeople.Add(person);
                            }
                        }
                    }
                    else if (currCommand[1] == "EndsWith")
                    {
                        foreach (var person in people)
                        {
                            if (endsWith(person, currCommand[2].ToString()))
                            {
                                tempPeople.Add(person);
                            }
                        }
                    }
                    else if (currCommand[1] == "Length")
                    {
                        foreach (var person in people)
                        {
                            int lenght = person.Length;
                            if (lenghtIs(lenght, int.Parse(currCommand[2])))
                            {
                                tempPeople.Add(person);
                            }
                        }
                    }

                    foreach (var item in tempPeople)
                    {
                        people.Remove(item);
                    }
                }
                else if (currCommand[0] == "Double")
                {
                    if (currCommand[1] == "StartsWith")
                    {
                        foreach (var person in people)
                        {
                            if (startWith(person, currCommand[2].ToString()))
                            {
                                tempPeople.Add(person);
                            }
                        }
                    }
                    else if (currCommand[1] == "EndsWith")
                    {
                        foreach (var person in people)
                        {
                            if (endsWith(person, currCommand[2].ToString()))
                            {
                                tempPeople.Add(person);
                            }
                        }
                    }
                    else if (currCommand[1] == "Length")
                    {
                        foreach (var person in people)
                        {
                            int lenght = person.Length;
                            if (lenghtIs(lenght, int.Parse(currCommand[2])))
                            {
                                tempPeople.Add(person);
                            }
                        }
                    }

                    foreach (var item in tempPeople)
                    {
                        people.Add(item);
                    }
                }

                tempPeople.Clear();
                command = Console.ReadLine();
            }

            if (people.Any())
            {
                Console.Write(string.Join(", ", people));
                Console.WriteLine(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            
        }
    }
}
