using System;

namespace lab_4
{
    internal class Transformer : IntelligentBeing, IDrivable
    {
        public string VehicleMode { get; set; }
        public bool IsTransformed { get; set; }

        public Transformer(string name, int iq, string vehicleMode, bool isTransformed = false)
            : base(name, iq)
        {
            VehicleMode = vehicleMode;
            IsTransformed = isTransformed;
        }

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

        public override string GetInfo()
        {
            string mode = IsTransformed ? VehicleMode : "Robot";
            return $"Transformer (abstract): {Name}, Mode: {mode}, IQ: {IQ}";
        }

        string IDrivable.GetInfo()
        {
            return $"Transformer (interface): {Name} can transform into {VehicleMode}";
        }

        public override string ToString()
        {
            string status = IsTransformed ? $"Transformed as {VehicleMode}" : "In robot mode";
            return $"Transformer: {Name}, IQ: {IQ}, {status}";
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