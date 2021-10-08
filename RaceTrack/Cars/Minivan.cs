﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Minivan : RaceCar
    {
        public Minivan()
        {
            Name = "Minivan";
            TopSpeed = 80;
        }

        public override void StopEngine(){
             Console.WriteLine($"The {Name} has stopped");
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts");
        }
    }
}
