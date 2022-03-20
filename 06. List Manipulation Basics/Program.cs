using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            string evenNumbers = String.Empty;
            string oddNumbers = String.Empty;
            int totalSum = 0;

            bool madeChanges = false;

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int addedNumber = int.Parse(command[1]);
                    numbers.Add(addedNumber);
                    madeChanges = true;
                }
                else if (command[0] == "Remove")
                {
                    int removedNumber = int.Parse(command[1]);
                    numbers.Remove(removedNumber);
                    madeChanges = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    int removedAt = int.Parse(command[1]);
                    numbers.RemoveAt(removedAt);
                    madeChanges = true;
                }
                else if (command[0] == "Insert")
                {
                    int insertedNumber = int.Parse(command[1]);
                    int insertedIndex = int.Parse(command[2]);
                    numbers.Insert(insertedIndex, insertedNumber);
                    madeChanges = true;
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    totalSum += numbers[i];
                    if (numbers[i] % 2 == 0 && command[0] == "PrintEven")
                    {
                        Console.Write(numbers[i] + " ");
                    }
                    else if (numbers[i] % 2 == 1 && command[0] == "PrintOdd")
                    {
                        Console.Write(numbers[i] + " ");

                    }
                }

                if (command[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    Console.WriteLine(evenNumbers);
                }
                else if (command[0] == "PrintOdd")
                {
                    Console.WriteLine(oddNumbers);
                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(totalSum);
                }
                else if (command[0] == "Filter")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        switch (command[1])
                        {
                            case "<":
                                if (int.Parse(command[2]) > numbers[i])
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                                break;
                            
                            case ">":
                                if (int.Parse(command[2]) < numbers[i])
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                                break;

                            case "<=":
                                if (int.Parse(command[2]) >= numbers[i])
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                                break;

                            case ">=":
                                if (int.Parse(command[2]) <= numbers[i])
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                                break;
                        }
                    }
                    Console.WriteLine();
                }
                evenNumbers = String.Empty;
                oddNumbers = String.Empty;
                totalSum = 0;

                command = Console.ReadLine().Split().ToArray();
            }

            if (madeChanges == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
