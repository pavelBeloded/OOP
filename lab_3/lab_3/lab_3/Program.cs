using System;
using System.Collections.Generic;
using System.Linq;
class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ТЕСТИРОВАНИЕ SET<INT> ===");

        Set<int> set1 = new Set<int>();
        set1 = set1 + 5 + 3 + 8 + 1 + 5;
        Console.WriteLine($"Set1: {set1}");

        Set<int> set2 = new Set<int>([2, 7, 3, 9, 2, 4]);
        Console.WriteLine($"Set2: {set2}");

        Set<int> union = set1 + set2;
        Console.WriteLine($"Объединение: {union}");

        Set<int> intersection = set1 * set2;
        Console.WriteLine($"Пересечение: {intersection}");

        Console.WriteLine($"Мощность set1: {(int)set1}");

        

        bool isEmpty = set1 ? false : true;
        Console.WriteLine($"Set1 пустой: {isEmpty}");

        int sum = set1.Sum();
        Console.WriteLine($"Сумма set1: {sum}");

        int diff = set1.DifferenceBetweenMaxAndMin();
        Console.WriteLine($"Разница max-min set1: {diff}");

        int elementsCount = set1.CountElements();
        Console.WriteLine($"Количество элементов set1: {elementsCount}");

        int min = set1.Min();
        int max = set1.Max();
        Console.WriteLine($"Min: {min}, Max: {max}");

        Console.WriteLine("\n=== ТЕСТИРОВАНИЕ СТРОК ===");
        string text = "hello   world\nfrom\tC#";
        string withCommas = text.AddCommas();
        Console.WriteLine($"Исходный текст: '{text}'");
        Console.WriteLine($"С запятыми: '{withCommas}'");

        Console.WriteLine("\n=== ИНФОРМАЦИЯ О ПРОЕКТЕ ===");
        Console.WriteLine(set1.ProductionInfo);
        Console.WriteLine(set1.DeveloperInfo);
    }

}



public class Set<Type>
{
    public List<Type> items;

    public Set()
    {
        this.items = new List<Type>();
        this.ProductionInfo = new Production(1, "BSTU");
        this.DeveloperInfo = new Developer(101, "Pavel Beloded", "Software Engineering");
    }

    public Set(IEnumerable<Type> items)
    {
        if (items == null)
        {
            this.items = new List<Type>();
        }
        else this.items = items.Distinct().ToList();
        this.items.Sort();

        this.ProductionInfo = new Production(1, "BSTU");

        this.DeveloperInfo = new Developer(101, "Pavel Beloded", "Software Engineering");

    }

    public bool Contains(Type item)
    {
        return items.Contains(item);
    }

    public void Add(Type item)
    {
        if (!this.Contains(item))
        {
            this.items.Add(item);
        }
        this.items.Sort();
    }

    public void Remove(Type item)
    {
        items.Remove(item);
    }

    
    public static Set<Type> operator +(Set<Type> set, Set<Type> other)
    {
        foreach (var item in other.items)
        {
            set.Add(item);
        }

        return set;
    }

    public static Set<Type> operator +(Set<Type> set, Type item)
    {
        set.Add(item);
        return set;
    }

    public static Set<Type> operator *(Set<Type> set, Set<Type> other)
    {
        Set<Type> result = new Set<Type>();
        foreach (var item in set.items)
        {
            if (other.Contains(item))
            {
                result.Add(item);
            }
        }

        return result;

    }

    public static explicit operator int(Set<Type> set) => set.items.Count;

    public static bool operator false(Set<Type> set) => set.items.Count == 0;

    public static bool operator true(Set<Type> set) => (set.items.Count != 0);

    public override string ToString()
    {
        string result = string.Empty;
        foreach (var item in this.items) result += item + ",";
        return result.Substring(0, result.Length - 1);
    }

    public struct Production
    {
        public int Id { get; set; }
        public string OrganizationName { get; set; }

        public Production(int id, string organizationName)
        {
            this.Id = id;
            this.OrganizationName = organizationName;
        }

        public override string ToString()
        {
            return $"Production [ID: {Id}, Organization: {OrganizationName}]";
        }
    }
    public class Developer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }

        public Developer(int id, string fullName, string department)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Department = department;
        }

        public override string ToString()
        {
            return $"Developer [ID: {this.Id}, Name: {this.FullName}, Department: {this.Department}]";
        }
    }

    public Production ProductionInfo { get; private set; }
    public Developer DeveloperInfo { get; private set; }
}


public static class StatisticOperation
{
    public static Type Sum<Type>(this Set<Type> set) where Type : struct, IComparable<Type>
    {
        if (set == null || (int)set == 0)
            return default;

        dynamic sum = default(Type);
        foreach (var item in set.items)
        {
            sum += (dynamic)item;
        }
        return sum;
    }

    public static Type DifferenceBetweenMaxAndMin<Type>(this Set<Type> set) where Type : IComparable<Type>
    {
        if (set == null || (int)set < 2)
            throw new InvalidOperationException("Множество должно содержать хотя бы 2 элемента");

        Type min = set.Min();
        Type max = set.Max();

        dynamic result = (dynamic)max - (dynamic)min;
        return result;
    }

    public static int CountElements<Type>(this Set<Type> set)
    {
        return (int)set;
    }

    public static Type Min<Type>(this Set<Type> set) where Type : IComparable<Type>
    {
        if (set == null || (int)set == 0)
            throw new InvalidOperationException("Множество пустое");

        Type min = set.items.First();
        foreach (var item in set.items)
        {
            if (item.CompareTo(min) < 0)
                min = item;
        }
        return min;
    }

    public static Type Max<Type>(this Set<Type> set) where Type : IComparable<Type>
    {
        if (set == null || (int)set == 0)
            throw new InvalidOperationException("Множество пустое");

        Type max = set.items.First();
        foreach (var item in set.items)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }
        return max;
    }

    public static string AddCommas(this string text)
    {

        string [] split = text.Split([' ', '\t', '\n'], StringSplitOptions.RemoveEmptyEntries);
        return string.Join(", ", split).TrimEnd(' ').TrimEnd(',');
    }
}