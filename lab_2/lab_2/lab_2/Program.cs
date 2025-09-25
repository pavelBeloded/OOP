using lab_2;
using System.Net.NetworkInformation;

class Programm
{
    static void Main(string[] args)
    {
        Person person = new Person("pavel", 192);
        string str = "processing";

        Person.AddPrefix(ref str);

        Person person2 = new Person();
        Console.WriteLine(person2.Name);
        Console.WriteLine(person2.Equals(person2));
        Console.WriteLine(person.Equals(person2));
        Person person3 = new Person("Alex", 12423);
        Person person4 = Person.createNewObject(15, "Jonny");

        Console.WriteLine(Person.Count());
        Console.WriteLine(person3.GetHashCode());
        Console.WriteLine(person4.ToString());
    }

}







