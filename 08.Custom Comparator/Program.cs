using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int[]> sortBy = x =>
            {
                int[] arr = new int[x.Length];

                List<int> even = new List<int>();
                List<int> odd = new List<int>();

                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] % 2 == 0)
                    {
                        even.Add(x[i]);
                    }
                    else
                    {
                        odd.Add(x[i]);
                    }
                }

                even = even.OrderBy(x => x).ToList();
                odd = odd.OrderBy(x => x).ToList();

                for (int i = 0; i < even.Count; i++)
                {
                    arr[i] = even[i];
                }
                for (int i = even.Count; i < arr.Length; i++)
                {
                    arr[i] = odd[i - even.Count];
                }
                return arr;
            };

            numbers = sortBy(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
