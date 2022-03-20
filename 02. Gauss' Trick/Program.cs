using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

            int staticCount = input.Count;

            for (int i = 0; i < staticCount / 2; i++)
            {
                input[i] += input[input.Count - 1];
                input.Remove(input[input.Count - 1]);
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
