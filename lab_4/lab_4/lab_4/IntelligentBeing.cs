using System;

namespace lab_4
{
    internal abstract class IntelligentBeing
    {
        public string Name { get; set; }
        public int IQ { get; set; }

        public IntelligentBeing(string name, int iq)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new InvalidParameterException(nameof(name), "Name cannot be null or empty.");
            }
            if (iq <= 0)
            {
                throw new InvalidParameterException(nameof(iq), "Iq must be a positiv number");
            }
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