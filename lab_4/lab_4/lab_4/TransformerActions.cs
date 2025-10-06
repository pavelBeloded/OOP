using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal partial class Transformer : IntelligentBeing, IDrivable
    {
        public override void Speak()
        {
            if (IsTransformed)
            {
                Console.WriteLine("Bleep bloop - speaking in vehicle mode!");
            }
            else
            {
                Console.WriteLine("Autobots, roll out!");
            }
        }

        public override void Think()
        {
            Console.WriteLine($"{Name} is processing complex calculations...");
        }

        void IDrivable.Start()
        {
            if (!IsTransformed)
            {
                Console.WriteLine($"{Name} transforms into {VehicleMode} mode!");
                IsTransformed = true;
            }
            Console.WriteLine($"{Name} as {VehicleMode} is starting movement!");
        }

        void IDrivable.Stop()
        {
            if (IsTransformed)
            {
                Console.WriteLine($"{Name} stops and transforms back to robot mode!");
                IsTransformed = false;
            }
            else
            {
                Console.WriteLine($"{Name} is already in robot mode");
            }
        }

        void IDrivable.Accelerate(int power)
        {
            if (IsTransformed)
            {
                Console.WriteLine($"{Name} as {VehicleMode} accelerates with power {power}!");
            }
            else
            {
                Console.WriteLine($"{Name} needs to transform first!");
            }
        }
        public void Transform()
        {
            IsTransformed = !IsTransformed;
            Console.WriteLine(IsTransformed ?
                $"{Name} transformed into {VehicleMode}!" :
                $"{Name} transformed back to robot mode!");
        }
    }
}
