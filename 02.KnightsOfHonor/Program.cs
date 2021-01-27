using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> output = x => {
                foreach (var item in x)
                {
                    Console.WriteLine($"Sir {item}");
                }
            };

            output(input);
        }
    }
}
