using System;

namespace footballgame.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sector=Console.ReadLine();
            var rows=int.Parse(Console.ReadLine());
            var seats=int.Parse(Console.ReadLine());
            double profit=rows*seats;
            if (sector == "Sector A")
            {
                profit = profit * 11.60;
            }
            else
            if(sector =="Sector B")
            {
                profit = profit * 14.50;
            }
            else
            if(sector=="Sector C")
            {
                profit = profit * 16.10;
            }
            else
            {
                profit = profit * 8.40;
            }
            Console.WriteLine("{0} profit is {1} lv.", sector, profit.ToString("F2"));


        }
    }
}