using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> inputTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> containsTwoLists = new List<int>();
            int counter = 0;

            for (int i = 0; i < Math.Min(inputOne.Count, inputTwo.Count); i++)
            {
                containsTwoLists.Add(inputOne[i]);
                containsTwoLists.Add(inputTwo[i]);
                counter++;
            }

            for (int j = counter; j < Math.Max(inputOne.Count, inputTwo.Count); j++)
            {
                if (inputOne.Count > inputTwo.Count)
                {
                    containsTwoLists.Add(inputOne[j]);
                }
                else
                {
                    containsTwoLists.Add(inputTwo[j]);
                }
            }
            Console.WriteLine(string.Join(" ", containsTwoLists));
        }
    }
}
