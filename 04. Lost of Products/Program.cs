using System;
using System.Collections.Generic;

namespace _04._Lost_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<string> list = new List<string>(numberOfProducts);

            for (int i = 0; i < numberOfProducts; i++)
            {
                list.Add(Console.ReadLine());
            }

            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
