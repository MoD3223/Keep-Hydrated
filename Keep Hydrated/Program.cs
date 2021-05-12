using System;

namespace Keep_Hydrated
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Hydration();
            }


        }

        public static void Hydration()
        {
            Console.WriteLine("Keep Hydrated!");
            int litres;
            double timeInHours;
            string stringTimeInHours;
            stringTimeInHours = Console.ReadLine();


            if (stringTimeInHours.Contains('.'))
            {
                stringTimeInHours = stringTimeInHours.Replace('.',',');
            }
            if (Double.TryParse(stringTimeInHours, out timeInHours))
            {
                timeInHours /= 2;
                litres = (int)timeInHours;

                Console.WriteLine("Your water intake should be: " + litres);
            }
            else
            {
                Console.WriteLine("Error, couldn't calculate");
                Console.WriteLine("Try Again!");
            }
        }
    }
}
