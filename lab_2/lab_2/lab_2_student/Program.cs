using lab_2;
using lab_2_student;
using System.Runtime.InteropServices;

class Programm
{
    static void printGroup (string group, Student[] students)
    {
        foreach (Student student in students) {
            if (student.Group.ToLower() == group.ToLower()) { 
               printStudent (student);
            }
        }
    }

    static void printFaculty(string faculty, Student[] students)
    {
        foreach(Student student in students) {
            if (student.Faculty.ToLower() == faculty.ToLower())
            {
                printStudent(student);
            }
        }
    }

    static void printStudent(Student student) {
        Console.WriteLine($"{student.Id}: {student.Surname} {student.Name} {student.Patronymic}, {student.Faculty}, {student.Group}, {student.Age} лет");
    }

        static void Main(string[] args)
    {
        var random = new Random();
        Console.WriteLine("Введите количество студентов");
        int n = int.Parse(Console.ReadLine());
        Student[] students = new Student[n];

        for (int i = 0; i < n; i++)
        {
            students[i] = new Student(
                TestData.Names[random.Next(TestData.Names.Length)],
                TestData.Surnames[random.Next(TestData.Surnames.Length)],
                TestData.Patronymics[random.Next(TestData.Patronymics.Length)],
                TestData.Addresses[random.Next(TestData.Addresses.Length)],
                TestData.Faculties[random.Next(TestData.Faculties.Length)],
                TestData.Courses[random.Next(TestData.Courses.Length)],
                TestData.Groups[random.Next(TestData.Groups.Length)],
                TestData.BirthDays[random.Next(TestData.BirthDays.Length)]
            );
        }

        foreach (Student s in students)
        {
            printStudent(s);
        }


        while (true)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Выберите:");
            Console.WriteLine("1-Вывести студентов заданного факультета:");
            Console.WriteLine("2-Список учебной группы");
            Console.WriteLine("q-выход");
            char ans = Console.ReadKey().KeyChar;
            Console.WriteLine("-------------------------------------");
            switch (ans)
            {
                case '1':
                    Console.WriteLine("Введите факультет: ");
                    Console.WriteLine("-------------------------------------");
                    printFaculty(Console.ReadLine(), students);
                    Console.WriteLine("-------------------------------------");

                    break;

                case '2':
                    Console.WriteLine("Введите группу: ");
                    Console.WriteLine("-------------------------------------");
                    printGroup(Console.ReadLine(), students);
                    Console.WriteLine("-------------------------------------");

                    break;
                case 'q': case 'Q': case 'Й' : case 'й':
                    return;
                default: continue;
            }
        }
        
    }}