using System;

namespace harvest.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double wine = 0.4 * (x * y) / 2.5;
            if(wine<z)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor( z - wine ));
            }
            else
            {
                double liter = Math.Ceiling(wine - z);
                double literperperson = Math.Ceiling(liter / workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", liter,literperperson);
            }

        }
    }
}
