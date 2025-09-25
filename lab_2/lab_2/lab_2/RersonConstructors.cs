using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal partial class Person
    {
        private Person(int age, string name = "none")
        {
            this.age = age;
            Name = name ;
            Person.objectsCounter++;
            _createdAt = DateTime.UtcNow;
        }

        static Person()
        {
            Person.objectsCounter++;
        }

        public Person()
        {
            Console.WriteLine("Создание объекта Person");
            name = "undefined";
            age = 18;
            _createdAt = DateTime.UtcNow;

        }

        public Person(string name, int id = -1)
        {
            this.name = name;
            this.age = 18;
            this.id = id;
            Person.objectsCounter++;
            _createdAt = DateTime.UtcNow;
        }
    }
}
