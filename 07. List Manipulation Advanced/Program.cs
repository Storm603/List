using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split().ToArray();

            string evenNumbers = String.Empty;
            string oddNumbers = String.Empty;
            int totalSum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                totalSum += numbers[i];
                if (numbers[numbers[i]] % 2 == 0)
                {
                    evenNumbers = string.Join(" ", numbers[numbers[i]].ToString());
                }
                else if (numbers[numbers[i]] % 1 == 0)
                {
                    oddNumbers = string.Join(" ", numbers[numbers[i]].ToString());
                }
            }

            switch (commands[0])
            {
                case "Contain":
                    if (numbers.Contains(int.Parse(commands[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;
            }
        }
    }
}
