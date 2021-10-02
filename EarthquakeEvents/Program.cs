using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthquakeEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Tsunami tsunami = new Tsunami();
            tsunami.TsunamiEvent += Tsunami_TsunamiEvent;

            Console.WriteLine( "Enter Location:");
            string tempLocation = Console.ReadLine();
            Console.WriteLine("Enter intensity:");
            double tempIntensity = Convert.ToDouble(Console.ReadLine());

            Earthquake eQuake = new Earthquake(tempLocation, tempIntensity);

            Console.ReadLine();

        }

        private static void Tsunami_TsunamiEvent(double probability)
        {
            Console.WriteLine("Tsunami Alert!");
            Console.WriteLine("Probability is: " + probability);
        }
    }
}
