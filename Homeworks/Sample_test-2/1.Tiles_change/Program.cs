using System;

namespace change_tiles.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine()); 
            var w = double.Parse(Console.ReadLine()); 
            var l = double.Parse(Console.ReadLine()); 
            var m = double.Parse(Console.ReadLine()); 
            var o = double.Parse(Console.ReadLine());
            var area_playground = n * n;
            var area_tile = w * l;
            var area_bench = m * o;
            var number_tiles = (area_playground - area_bench)/area_tile;
            var time = number_tiles * 0.2;
            Console.WriteLine(number_tiles);
            Console.WriteLine(time);

        }
    }
}