using System;
using System.Collections.Generic;

namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Лабораторная работа 4 ===");
            Console.WriteLine();

            Engine v8Engine = new Engine("V8", 400);
            Car bmw = new Car("BMW X5", 250, 2000, v8Engine);

            Human john = new Human("John", 110, bmw);
            Human alice = new Human("Alice", 120); 

            Transformer optimus = new Transformer("Optimus Prime", 180, "Truck", false);

            Console.WriteLine("=== Работа через абстрактные классы ===");
            IntelligentBeing[] beings = new IntelligentBeing[] { john, alice, optimus };

            foreach (var being in beings)
            {
                Console.WriteLine(being.ToString());
                being.Think();
                being.Speak();
                Console.WriteLine($"GetInfo: {being.GetInfo()}");
                Console.WriteLine();
            }

            Console.WriteLine("=== Работа через интерфейс IDrivable ===");
            IDrivable[] drivables = new IDrivable[] { bmw, john, optimus };

            foreach (var drivable in drivables)
            {
                Console.WriteLine($"Тип объекта: {drivable.GetType().Name}");

                Car car = drivable as Car;
                if (car != null)
                {
                    Console.WriteLine("Это автомобиль!");
                }

                if (drivable is Human human)
                {
                    Console.WriteLine("Это человек! IQ: " + human.IQ);
                }

                drivable.Start();
                drivable.Accelerate(100);
                drivable.Stop();

                Console.WriteLine($"Interface GetInfo: {drivable.GetInfo()}");
                Console.WriteLine();
            }

            Console.WriteLine("=== Демонстрация одноименных методов ===");
            Console.WriteLine("John.GetInfo() из абстрактного класса: " + john.GetInfo());
            Console.WriteLine("John.GetInfo() из интерфейса: " + ((IDrivable)john).GetInfo());
            Console.WriteLine();

            Console.WriteLine("=== Демонстрация переопределения Object методов ===");
            Human human1 = new Human("John", 110);
            Human human2 = new Human("John", 110);
            Human human3 = new Human("Alice", 120);

            Console.WriteLine($"human1.Equals(human2): {human1.Equals(human2)}"); 
            Console.WriteLine($"human1.Equals(human3): {human1.Equals(human3)}"); 
            Console.WriteLine($"human1 HashCode: {human1.GetHashCode()}");
            Console.WriteLine($"human2 HashCode: {human2.GetHashCode()}");
            Console.WriteLine($"human3 HashCode: {human3.GetHashCode()}");
            Console.WriteLine();

            Console.WriteLine("=== Демонстрация класса Printer ===");
            Printer printer = new Printer();

            IDrivable[] objects = new IDrivable[] { bmw, john, optimus, alice };

            foreach (var obj in objects)
            {
                printer.IAmPrinting(obj);
            }

            Console.WriteLine("=== Демонстрация sealed класса Car ===");
            Console.WriteLine(bmw.ToString());
            Console.WriteLine($"Car GetInfo: {bmw.GetInfo()}");
            Console.WriteLine($"Car GetDescription: {bmw.GetDescription()}");

            Console.WriteLine();
            Console.WriteLine("=== Программа завершена ===");
            Console.ReadKey();
        }
    }
}