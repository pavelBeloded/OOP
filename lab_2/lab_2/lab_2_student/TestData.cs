using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class TestData
    {
        // Имена
        public static readonly string[] Names = {
            "Павел", "Александр", "Дмитрий", "Иван", "Никита",
            "Екатерина", "Анастасия", "Мария", "Ольга", "Елена",
            "Сергей", "Владимир", "Анна", "Юлия", "Ксения"
        };

        // Фамилии
        public static readonly string[] Surnames = {
            "Белодед", "Иванов", "Петров", "Сидоров", "Кузнецов",
            "Смирнов", "Попов", "Лебедев", "Козлов", "Новиков",
            "Морозов", "Васильев", "Александров", "Николаев", "Григорьев"
        };

        // Отчества
        public static readonly string[] Patronymics = {
            "Иванович", "Петрович", "Сергеевич", "Александрович", "Николаевич",
            "Андреевич", "Владимирович", "Дмитриевич", "Егорович", "Фёдорович",
            "Александровна", "Ивановна", "Петровна", "Сергеевна", "Николаевна"
        };

        // Адреса
        public static readonly string[] Addresses = {
            "Минск", "Гомель", "Брест", "Витебск", "Могилев",
            "Гродно", "Борисов", "Жодино", "Слуцк", "Лида",
            "Бобруйск", "Мозырь", "Орша", "Полоцк", "Новополоцк"
        };

        // Факультеты (аббревиатуры)
        public static readonly string[] Faculties = {
            "ЛХФ", "ЛИД", "ХТиТ", "ПиМ", "ИЭФ", "ФИТ"
        };

        // Курсы
        public static readonly int[] Courses = { 1, 2, 3, 4, 5, 6, 7 };

        // Группы
        public static readonly string[] Groups = {
            "ФИТ-21", "ФИТ-22", "ИЭФ-11", "ИЭФ-12", "ХТиТ-31",
            "ХТиТ-32", "ПиМ-41", "ПиМ-42", "ЛХФ-51", "ЛХФ-52",
            "ЛИД-61", "ЛИД-62"
        };

        // Даты рождения
        public static readonly DateOnly[] BirthDays = {
            new DateOnly(2003, 1, 15), new DateOnly(2004, 2, 10), new DateOnly(2005, 3, 5),
            new DateOnly(2006, 4, 20), new DateOnly(2007, 5, 25), new DateOnly(2008, 6, 30),
            new DateOnly(2003, 7, 12), new DateOnly(2004, 8, 8), new DateOnly(2005, 9, 17),
            new DateOnly(2006, 10, 3), new DateOnly(2007, 11, 27), new DateOnly(2008, 12, 14)
        };
    }
}
