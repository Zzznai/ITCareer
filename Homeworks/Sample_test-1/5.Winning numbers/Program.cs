using System;

namespace winningnumbers.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int winner = 0;
            for(int i = 1; i <=9 ;i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (i + j == n && k % 2 == 0 && l == 3 || i + j == n && k % 2 == 0 && l == 6)
                            {
                                winner++;
                                Console.Write("{0}{1}{2}{3} ",i,j,k,l);
                            }

                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Count of winner numbers: {0}",winner);
        }
    }
}
