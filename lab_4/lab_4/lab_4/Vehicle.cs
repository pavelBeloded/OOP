using System;

namespace lab_4
{
    internal abstract class Vehicle
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public double Weight { get; set; }

        public Vehicle(string name, int maxSpeed, double weight)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Vehicle: {Name}, Max Speed: {MaxSpeed} km/h, Weight: {Weight} kg";
        }

        public abstract string GetDescription();

        public virtual string GetInfo()
        {
            return $"Vehicle Info: {Name}, Max Speed: {MaxSpeed} km/h, Weight: {Weight} kg";
        }
    }
}