using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Party!")
            {
                names = Command(names, command[0], command[1], command[2]);

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static List<string> IsLenght(List<string> names, int n)
        {
            List<string> namesWithlenght = new List<string>();

            foreach (var name in names)
            {
                if (name.Length == n)
                {
                    namesWithlenght.Add(name);
                }
            }

            return namesWithlenght;
        }
        static List<string> StartsWith(List<string> names, string letter)
        {
            List<string> startsWith = new List<string>();

            foreach (var name in names)
            {
                bool startWith = true;
                for (int i = 0; i < letter.Length; i++)
                {
                    if (name.Length <= i)
                    {
                        break;
                    }

                    if (name[i] != letter[i])
                    {
                        startWith = false;
                    }
                }

                if (startWith)
                {
                    startsWith.Add(name);
                }
            }

            return startsWith;
        }
        static List<string> EndsWith(List<string> names, string letter)
        {
            List<string> EndsWith = new List<string>();

            foreach (var name in names)
            {
                bool EndWith = true;
                for (int i = 0; i < name.Length; i++)
                {
                    if (letter.Length <= i)
                    {
                        break;
                    }

                    if (name[name.Length - 1 - i] != letter[letter.Length - 1 - i])
                    {
                        EndWith = false;
                        break;
                    }
                }

                if (EndWith)
                {
                    EndsWith.Add(name);
                }
            }

            return EndsWith;
        }
        static List<string> Predicate(List<string> names, string command, string word)
        {
            if (command == "StartsWith")
            {
                return StartsWith(names, word);
            }
            else if (command == "EndsWith")
            {
                return EndsWith(names, word);
            }
            else if (command == "Length")
            {
                return IsLenght(names, int.Parse(word));
            }

            return new List<string>();
        }
        static List<string> Command(List<string> names, string command, string predicate, string word)
        {
            if (command == "Remove")
            {
                List<string> comparer = Predicate(names, predicate, word);

                for (int i = 0; i < names.Count; i++)
                {
                    if (comparer.Contains(names[i]))
                    {
                        names.RemoveAt(i);
                    }
                }
                
                return names;
            }
            else if (command == "Double")
            {
                List<string> result = new List<string>();

                foreach (var item in names)
                {
                    if (Predicate(names, predicate, word).Contains(item))
                    {
                        result.Add(item);
                    }
                    result.Add(item);
                }

                return result;
            }

            return new List<string>();
        }
    }
}
