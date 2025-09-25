using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab_2
{
    internal partial class Person
    {
        string name;
        int age;
        private readonly int id;
        const string prefix = "pre-";
        static int objectsCounter = 0;
        private readonly DateTime _createdAt;


        static public Person createNewObject(int age, string name = "none")
        {
            Person person = new Person(age, name);
            return person;
        }

        public static void AddPrefix(ref string input)
        {
            input = prefix + input;
        }

        public void GetArea(int width, int height, out int area)
        {
            area = width * height;
        }

        static public int Count()
        {
            return objectsCounter;
        }

        public string Name { get; set; }

        public int Id { get; }

        public int Age { get; set; }


        public string Prefix
        {
            get => prefix;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            if (obj is null || obj.GetType() != this.GetType()) return false;
            var other = (Person)obj;
            return this.id == other.id;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 31 + (name?.GetHashCode() ?? 0);
                hash = hash * 31 + age;
                hash = hash * 31 + _createdAt.GetHashCode();
                return hash;
            }
        }

        public override string ToString()
        {
            string output = string.Empty;
            output += prefix;
            output += ',';
            output += id;
            output += ',';
            output += name;
            output += ",";
            output += age;
            output += ",";
            output += _createdAt;
            return output;
        }
    }
}
