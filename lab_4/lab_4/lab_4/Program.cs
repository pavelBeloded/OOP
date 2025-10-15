namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Human invalidHuman = new Human("Invalid", -50, 2000);
                }
                catch (InvalidParameterException ex)
                {
                    Console.WriteLine($"Exception");
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.ParamName);
                    Console.WriteLine(ex.StackTrace?.Substring(0, ex.StackTrace.IndexOf('\n')));
                }

                try
                {
                    var army = new BeingsArmy();
                    army.addSoldier(new Human("John", 110, 2000));
                    var soldier = army.getSoldierByIndex(5);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Exception");
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    PerformRiskyArmySearch(null); 
                }
                catch (EntityNotFoundException ex)
                {
                    Console.WriteLine($"Exception");
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace?.Substring(0, ex.StackTrace.IndexOf('\n')));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\n--- finally ---");
                Console.WriteLine("Work is done");
            }

            Console.WriteLine("\n--- Assert ---");
            ArmyControl control = new ArmyControl();
            control.army = null;
            control.PrintTransformersByPower(180); 

            Console.ReadKey();
        }

        static void PerformRiskyArmySearch(ArmyControl controller)
        {
            try
            {
                var found = controller.FindSoldierByYear(2000);
                if (found == null)
                {
                    throw new EntityNotFoundException("Soldier from 2000");
                }
            }
            catch (NullReferenceException ex) 
            {
                throw new EntityNotFoundException("Controller object", "Controller was not initialized");
            }
        }
    }
}
//Engine v8Engine = new Engine("V8", 400);
//Car bmw = new Car("BMW X5", 250, 2000, v8Engine);

//Human john = new Human("John", 110, 2000, bmw);
//Human alice = new Human("Alice", 120, 2005);
//Transformer optimus = new Transformer("Optimus Prime", 1000, 180, 2044, "Truck", TransformerType.Autobot, false);
//Transformer megatron = new Transformer("Megatron", 950, 180, 2044, "Jet", TransformerType.Decepticon, true);

//ArmyControl control = new ArmyControl();

//control.army.addSoldier(optimus);
//control.army.addSoldier(megatron);
//control.army.addSoldier(john);
//control.army.addSoldier(alice); 

//Console.WriteLine("=== Army ===");
//control.army.printArmy();

//Console.WriteLine("\n=== Find by Year (2000) ===");
//var found = control.FindSoldierByYear(2000);
//Console.WriteLine(found != null ? found.GetInfo() : "No unit found for this year.");

//Console.WriteLine("\n=== Transformers by Power (180) ===");
//control.PrintTransformersByPower(180);

//Console.WriteLine($"\n=== Total Units in Army ===");
//Console.WriteLine($"Total: {control.GetArmyCount()}");