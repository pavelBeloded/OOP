using System;

namespace lab_4
{
    internal abstract class IntelligentBeing
    {
        public string Name { get; set; }
        public int IQ { get; set; }

        public IntelligentBeing(string name, int iq)
        {
            Name = name;
            IQ = iq;
        }

        public virtual void Think()
        {
            Console.WriteLine($"{Name} is thinking...");
        }

        public abstract void Speak();

        public virtual string GetInfo()
        {
            return $"IntelligentBeing: {Name}, IQ: {IQ}";
        }

        public override string ToString()
        {
            return $"Being: {Name}, IQ: {IQ}";
        }
    }
}