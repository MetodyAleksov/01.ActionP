using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", ReverseAndExclude(arr, n)));
        }
        static List<int> ReverseAndExclude(int[] arr, int n)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % n != 0)
                {
                    output.Add(arr[i]);
                }
            }

            output.Reverse();

            return output;
        }
    }
}
