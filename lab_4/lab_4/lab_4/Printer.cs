using System;

namespace lab_4
{
    internal class Printer
    {
        public void IAmPrinting(IDrivable someobj)
        {
            Console.WriteLine("=== IAmPrinting Method ===");

            if (someobj is Car car)
            {
                Console.WriteLine($"Object type: Car");
                Console.WriteLine(car.ToString());
            }
            else if (someobj is Human human)
            {
                Console.WriteLine($"Object type: Human");
                Console.WriteLine(human.ToString());
            }
            else if (someobj is Transformer transformer)
            {
                Console.WriteLine($"Object type: Transformer");
                Console.WriteLine(transformer.ToString());
            }
            else
            {
                Console.WriteLine("Unknown object type");
            }

            Console.WriteLine("===========================");
            Console.WriteLine();
        }
    }
}