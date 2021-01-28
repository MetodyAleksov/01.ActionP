using System;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> isEqualTo = (string name, int num) =>
            {
                int sum = 0;
                foreach (char item in name)
                {
                    sum += (int)item;
                }

                if (sum >= num)
                {
                    return true;
                }
                return false;
            };

            Action<string[], int> printer = (string[] names, int num) =>
            {
                foreach (string name in names)
                {
                    if (isEqualTo(name, num))
                    {
                        Console.WriteLine(name);
                        break;
                    }
                }
            };

            printer(names, n);
        }
    }
}
