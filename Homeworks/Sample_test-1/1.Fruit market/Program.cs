using System;

namespace fruitmarket.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var strawberry_price=double.Parse(Console.ReadLine());
            var raspberry_price = strawberry_price/2;
            var orange_price = raspberry_price - raspberry_price * 0.4;
            var banana_price = raspberry_price - raspberry_price * 0.8;
            var banana_kg=double.Parse(Console.ReadLine());
            var orange_kg = double.Parse(Console.ReadLine());
            var raspberry_kg=double.Parse(Console.ReadLine());
            var strawberry_kg = double.Parse(Console.ReadLine());
            var result = strawberry_kg * strawberry_price + raspberry_price * raspberry_kg + orange_kg * orange_price + banana_kg * banana_price;
            Console.WriteLine(result);

        }
    }
}
