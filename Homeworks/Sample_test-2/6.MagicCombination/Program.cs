using System;

namespace magical_numbers.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var num=int.Parse(Console.ReadLine());
            for(var n1 = 1 ; n1 <= 9 ; n1++)
            {
                for (var n2 = 1; n2 <= 9; n2++)
                {
                    for (var n3 = 1; n3 <= 9; n3++)
                    {
                        for (var n4 = 1; n4 <= 9; n4++)
                        {
                            for (var n5 = 1; n5 <= 9; n5++)
                            {
                                for (var n6 = 1; n6 <= 9; n6++)
                                {
                                    if (n1 * n2 * n3 * n4 * n5 * n6 == num)
                                        Console.Write($"{n1}{n2}{n3}{n4}{n5}{n6} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}