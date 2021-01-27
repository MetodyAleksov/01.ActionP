using System;
using System.Linq;

namespace _04.FindEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string predicate = Console.ReadLine();

            for (int i = input[0]; i <= input[1]; i++)
            {
                PrintEvenOrOdd(predicate, i);
            }
        }
        static void PrintEvenOrOdd(string predicate, int n)
        {
            Func<int, bool> func = x => x % 2 == 0;

            if (predicate == "odd")
            {
                func = x => x % 2 != 0;
            }

            if (func(n) == true)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
