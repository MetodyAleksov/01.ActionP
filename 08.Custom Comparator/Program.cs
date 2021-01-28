using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            arr = SortEvenBeforeOdd(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
        static int[] SortEvenBeforeOdd(int[] arr)
        {
            int[] finalArr = new int[arr.Length];

            List<int> evenNums = new List<int>();
            List<int> oddNums = new List<int>();

            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    evenNums.Add(item);
                }
                else
                {
                    oddNums.Add(item);
                }
            }

            if (evenNums.Count > 0)
            {
                for (int i = 0; i < evenNums.Count; i++)
                {
                    finalArr[i] = evenNums[i];
                }
            }
            if (oddNums.Count > 0)
            {
                for (int i = 0; i < oddNums.Count; i++)
                {
                    finalArr[i + evenNums.Count] = oddNums[i];
                }
            }

            return finalArr;
        }
    }
}
