using System;

namespace _17._02
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums= Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            Console.WriteLine(string.Join(" <= ",nums));
        }
    }
}

