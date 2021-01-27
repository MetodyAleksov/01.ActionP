using System;

namespace FunctionalProgramingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> output = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            output(input);
        }
    }
}
