using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    sealed internal class Car : Vehicle, IDrivable
    {
        private Engine _engine;

        public Car(string name, int maxSpeed, double weight, Engine engine)
            : base(name , maxSpeed, weight)
        {
            _engine = engine;
        }

        void IDrivable.Start()
        {
            Console.WriteLine($"{Name} was started");
            _engine.IsRunning = true;
        }

        void IDrivable.Stop()
        {
            Console.WriteLine($"{Name} was stopped");
            _engine.IsRunning = false;
        }

        void IDrivable.Accelerate(int power)
        {
            Console.WriteLine($"{Name} is accelerating with power {power}");
        }

        public override string GetDescription()
        {
            return $"This is a car named {Name} with max speed {MaxSpeed} km/h";
        }

        string IDrivable.GetInfo()
        {
            return $"Car (IDrivable): {Name}, Engine: {_engine.Type}";
        }

        public override string GetInfo()
        {
            return $"Car Info: {Name}, Weight: {Weight} kg, Engine Power: {_engine.HorsePower} HP";
        }

        public override string ToString() {
            return $"{this.Name}; {this.MaxSpeed}; {this.Weight}" + $"Engine: {_engine.ToString()}";
        }
    }
}
