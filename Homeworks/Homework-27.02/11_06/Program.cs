using System;
using System.Linq;

namespace _11._06
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split(' ').ToList();
            var quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            var command = Console.ReadLine();
            while (command != "done")
            {
                var commands = command.Split(' ').ToList();
                var product = commands[0];
                var quantity = long.Parse(commands[1]);
                int index = products.IndexOf(product);
                long stock = index < quantities.Count ? quantities[index] : 0;
                if (stock >= quantity)
                {
                    var totalPrice = quantity * prices[index];
                    Console.WriteLine($"{products[index]} x {quantity} costs {totalPrice}");
                    quantities[index] -= quantity;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[index]}");
                }
                command = Console.ReadLine();
            }
        }
    }
}