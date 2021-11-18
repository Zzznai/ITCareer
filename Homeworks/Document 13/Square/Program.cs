using System;

namespace _13._3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int mid = n * 2 - 4 - 2 * (n / 2);

            Console.WriteLine("/{0}\\{1}/{2}\\", new string('^', n / 2), new string('_', mid), new string('^', n / 2));
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', n * 2 - 2));
            }
            Console.WriteLine("|{0}{1}{2}|", new string(' ', n / 2 + 1), new string('_', mid), new string(' ', n / 2 + 1));
            Console.WriteLine("\\{0}/{1}\\{2}/", new string('_', n / 2), new string(' ', mid), new string('_', n / 2));
        }
    }
}

