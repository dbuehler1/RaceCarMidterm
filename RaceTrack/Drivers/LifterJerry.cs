using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;
namespace RaceTrack.RaceTrack.Drivers
{
    public class LifterJerry : Driver
    {
        public LifterJerry(RaceCar car) : base(car)
        {
            Name = "Big man Jerry";
            SkillLevel = 2;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
