using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;


namespace RaceTrack.RaceTrack.Drivers
{
    public class Carmen : Driver
    {
        public Carmen(RaceCar car) : base(car)
        {
            Name = "Carmen";
            SkillLevel = 5;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
