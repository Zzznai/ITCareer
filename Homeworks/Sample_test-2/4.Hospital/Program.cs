using System;

namespace hospital.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var days=int.Parse(Console.ReadLine());
            int treated = 0, untreated = 0;
            var doctors = 7;
            for(var i = 1; i <= days; i++)
            {
                if (i % 3 == 0 && untreated > treated)
                {
                    doctors++;
                }
                var patients=int.Parse((Console.ReadLine()));
                if(patients > doctors)
                {
                    treated = treated + doctors;
                    untreated = untreated + (patients - doctors);
                }
                else
                {
                    treated = treated + patients;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}