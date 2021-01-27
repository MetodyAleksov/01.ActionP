using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Min(input));
        }
        static int Min(int[] input)
        {
            int min = int.MaxValue;

            foreach (var item in input)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }
    }
}
