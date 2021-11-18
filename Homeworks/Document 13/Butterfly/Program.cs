using System;

namespace _13._4.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string top1 = new string('*', n - 2) + "\\ /" + new string('*', n - 2);
            string top2 = new string('-', n - 2) + "\\ /" + new string('-', n - 2);
            string bottom1 = new string('*', n - 2) + "/ \\" + new string('*', n - 2);
            string bottomSecond = new string('-', n - 2) + "/ \\" + new string('-', n - 2);

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(top1);
                }
                else
                {
                    Console.WriteLine(top2);
                }
            }
            Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(bottom1);
                }
                else
                {
                    Console.WriteLine(bottomSecond);
                }
            }
        }
    
    }
}

