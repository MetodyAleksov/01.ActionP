using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length <= n)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, arr));
        }
    }
}
