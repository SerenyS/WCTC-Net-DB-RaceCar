using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    internal class Camaro : RaceCar
    {

        public Camaro()
        {
            Name = "Camaro";
            TopSpeed = 180;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} is basically flying by");
        }

        public override void StopEngine(){
             Console.WriteLine($"The {Name} has stopped");
        }


        public override void Brake()
        {
            Console.WriteLine($"The {Name} is having a hard time stopping!");
            base.Brake();
        }
    }
}
