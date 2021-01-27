using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", input));
                }
                else
                {
                    input = input.Select(Operator(command)).ToArray();
                }
                command = Console.ReadLine();
            }
        }
        static Func<int, int> Operator(string OP)
        {
            Func<int, int> func = x => x + 1;
            if (OP == "subtract")
            {
                func = x => x - 1;
            }
            else if (OP == "multiply")
            {
                func = x => x * 2;
            }
            return func;
        }
    }
}
