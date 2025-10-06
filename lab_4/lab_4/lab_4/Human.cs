using System;

namespace lab_4
{
    internal class Human : IntelligentBeing, IDrivable
    {
        private Car? _car;
        struct HumanInfo
        {
            public int birthYear;
        }

        HumanInfo info;

        public int BirthYear { get => info.birthYear; set => info.birthYear = value; }
        public Human(string name, int iq, int year) : base(name, iq)
        {
            _car = null;
            this.info.birthYear = year;
        }

        public Human(string name, int iq, int year, Car car) : base(name, iq)
        {
            _car = car;
            this.info.birthYear = year;

        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Hello!");
        }

        void IDrivable.Start()
        {
            if (_car != null)
            {
                Console.WriteLine($"{Name} starts the car");
                ((IDrivable)_car).Start();
            }
            else
            {
                Console.WriteLine($"{Name} has no car to start");
            }
        }

        void IDrivable.Stop()
        {
            if (_car != null)
            {
                Console.WriteLine($"{Name} stops the car");
                ((IDrivable)_car).Stop();
            }
            else
            {
                Console.WriteLine($"{Name} has no car to stop");
            }
        }

        void IDrivable.Accelerate(int power)
        {
            if (_car != null)
            {
                Console.WriteLine($"{Name} accelerates the car with power {power}");
                ((IDrivable)_car).Accelerate(power);
            }
            else
            {
                Console.WriteLine($"{Name} has no car to accelerate");
            }
        }

        public override string GetInfo()
        {
            return $"Human from abstract class: {Name}, IQ: {IQ}, Has Car: {_car != null}";
        }

        string IDrivable.GetInfo()
        {
            return $"Human from interface: {Name} is a driver";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Human other)
            {
                return Name == other.Name && IQ == other.IQ;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, IQ);
        }

        public override string ToString()
        {
            string carInfo = _car != null ? $"Drives: {_car.Name}" : "No car";
            return $"Human: {Name}, IQ: {IQ},Year: {this.info.birthYear} , {carInfo}";
        }

        public Car Car
        {
            get => _car;
            set => _car = value;
        }
    }
}