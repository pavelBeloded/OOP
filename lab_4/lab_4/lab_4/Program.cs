using System;
using System.Collections.Generic;

namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Engine v8Engine = new Engine("V8", 400);
            Car bmw = new Car("BMW X5", 250, 2000, v8Engine);

            Human john = new Human("John", 110, 2000, bmw);
            Human alice = new Human("Alice", 120, 2005);
            Transformer optimus = new Transformer("Optimus Prime", 1000, 180, 2044, "Truck", TransformerType.Autobot, false);
            Transformer megatron = new Transformer("Megatron", 950, 180, 2044, "Jet", TransformerType.Decepticon, true);

            ArmyControl control = new ArmyControl();

            control.army.addSoldier(optimus);
            control.army.addSoldier(megatron);
            control.army.addSoldier(john);
            control.army.addSoldier(alice); 

            Console.WriteLine("=== Army ===");
            control.army.printArmy();

            Console.WriteLine("\n=== Find by Year (2000) ===");
            var found = control.FindSoldierByYear(2000);
            Console.WriteLine(found != null ? found.GetInfo() : "No unit found for this year.");

            Console.WriteLine("\n=== Transformers by Power (180) ===");
            control.PrintTransformersByPower(180);

            Console.WriteLine($"\n=== Total Units in Army ===");
            Console.WriteLine($"Total: {control.GetArmyCount()}");

        }
    }
}