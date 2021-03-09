using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Forklift : RaceCar
    { 
        public Forklift()
        {
            Name = "Rusty Forklift";
            TopSpeed = 15;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} sputters and pops to life!");
        }
    }
}