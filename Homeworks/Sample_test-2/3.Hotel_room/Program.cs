using System;

namespace hotel_room.cs
{
    class Program
    {
        static void Main(string[] args)
        {
           var month=Console.ReadLine();
           var days=int.Parse(Console.ReadLine());
           double studio=0,apartment=0;
           if(month == "May" || month == "October")
            {
                studio = days * 50;
                apartment = days * 65;
                if(days>7 && days<=14)
                {
                    studio = studio * 0.95;
                }
                else
                 if(days>14)
                {
                    studio = studio * 0.70;
                    apartment = apartment * 0.90;
                }
            }
           else
            if(month =="June" || month == "September")
            {
                studio = days * 75.20;
                apartment = days * 68.70;
                if(days > 14)
                {
                    studio = studio * 0.80;
                    apartment = apartment * 0.90;
                }
            }
           else
            if(month == "July" || month == "August")
            {
                studio = days * 76;
                apartment = days * 77;
                if(days > 14)
                {
                    apartment = apartment * 0.90;
                }
            }
            Console.WriteLine("Apartment: {0} lv.", apartment.ToString("F2"));
            Console.WriteLine("Studio: {0} lv.", studio.ToString("F2"));
               
            
        }
    }
}
