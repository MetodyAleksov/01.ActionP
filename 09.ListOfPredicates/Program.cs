using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<int, int, bool> divisible = (int x, int y) => { 
                if (x % y == 0)
                {
                    return true;
                }
                return false;
                };

            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                bool isDivisible = true;
                foreach (int num in arr)
                {
                    if (!divisible(i, num))
                    {
                        isDivisible = false;
                    }
                }

                if (isDivisible)
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
