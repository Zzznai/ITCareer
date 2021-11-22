using System;

namespace footballteam.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var tshirt=double.Parse(Console.ReadLine());
            var shorts = tshirt - tshirt * 0.25;
            var socks = shorts - shorts * 0.8;
            var shoes = (tshirt + shorts) * 2;
            var sum = (tshirt+shorts + socks + shoes)- (tshirt+shorts + socks + shoes) * 0.15;
            var gift=double.Parse(Console.ReadLine());
            
            if(gift-sum>0)
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine("He needs {0} lv. more.", (gift-sum).ToString("F2"));
            }
            else
            {
                
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine("His sum is {0} lv.",sum.ToString("F2"));

            }

        }
    }
}