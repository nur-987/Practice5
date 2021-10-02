using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthquakeEvents
{
    delegate void TsunamiDelegate(double probability);
    delegate void EarthQuakeDelegate();
    class Earthquake
    {
        public event EarthQuakeDelegate EarthQuakeEvent;
        public double Intensity { get; set; }
        public double Ocurence { get; set; }
        public string Location { get; }
        public double Intesity { get; }

        Tsunami tsunami = new Tsunami();

        public Earthquake(string tempLocation, double tempIntensity)
        {
            Location = tempLocation;
            Intesity = tempIntensity;

            //if(EarthQuakeEvent!= null)
            //{
            //    EarthQuakeEvent.Invoke();
            //}
            //tsunami.CalculateProbabilityofTsunami(Intensity);

        }

        public void EarthQuakeOccured()
        {
            Console.WriteLine("EarthQuake happened");
            tsunami.CalculateProbabilityofTsunami(Intensity);
        }

    }

    class Tsunami
    {
        public event TsunamiDelegate TsunamiEvent;
        public void CalculateProbabilityofTsunami(double intensity)
        {
            //calculation
            Random random = new Random();
            double probability = intensity * 0.7 + 0.3 * random.Next(0, 1);

            if(TsunamiEvent != null)
            {
                TsunamiEvent.Invoke(probability);
            }

        }
    }
}
