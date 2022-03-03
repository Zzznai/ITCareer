using System;
using System.Linq;

namespace _18._03
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ').ToList();
            while(true)
            {
                var commands = command[0];
                if (commands == "Even" || commands == "Odd")
                {
                    if (commands == "Even")
                    {
                        foreach (var num in nums)
                        {
                            if (num % 2 == 0)
                                Console.Write(num + " ");
                        }
                    }
                    else
                    {
                        foreach (var num in nums)
                            if (num % 2 != 0)
                                Console.Write(num + " ");
                    }
                    break;
                }
                var number = int.Parse(command[1]);
                if (commands == "Insert")
                {
                    var index = int.Parse(command[2]);
                    nums.Insert(index, number);
                }
                else
                if (commands == "Delete")
                    nums.RemoveAll(item => item == number);

                command= Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
