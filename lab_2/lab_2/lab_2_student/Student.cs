using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab_2_student
{
    internal class Student
    {


        private static int lastId = 0; 
        private readonly int id;
        private string name;
        private string surname;
        private string patronymic;
        private DateOnly birthDate;
        private string adress;
        private string faculty;
        private int course;
        private string group;


        public Student(string name, string surname, string patronymic, string adress, string faculty, int course, string group, DateOnly birthDay ){
            id = ++lastId;
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Adress = adress;
            this.Faculty = faculty;
            this.Course = course;
            this.Group = group;
            this.BirthDay = birthDay;
        }

        public int Id => id;
        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value)
                    ||
                    !Regex.IsMatch(value, @"^[А-Яa-я]{2,50}$"))
                {
                    throw new ArgumentException("Неверный формат отчества. Требования: только кириллические буквы.", nameof(value));
                }
                this.name = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());

            }
        }
        public string Surname
        {
            get => this.surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value)
                    ||
                    !Regex.IsMatch(value, @"^[А-Яa-я]{2,50}$"))
                {
                    throw new ArgumentException("Неверный формат отчества. Требования: только кириллические буквы.", nameof(value));
                }
                this.surname = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());

            }
        }
        public string Patronymic
        {
            get => this.patronymic;
            set
            {
                string cleaned = value.Trim();
                if (!Regex.IsMatch(cleaned, @"^[А-ЯЁ][а-яё]{1,49}$"))
                {
                    throw new ArgumentException("Неверный формат отчества. Требования: только кириллические буквы.", nameof(value));
                }
                this.patronymic = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cleaned.ToLower());

            }
        }
        public string Group
        {
            get => this.group;
            set
            {
                if (string.IsNullOrWhiteSpace(value)
                    ||
                    !Regex.IsMatch(value.ToUpper(), @"^[А-Я]{2,5}-\d{2}$"))
                {
                    throw new ArgumentException("Неверный формат группы (например: ПИ-9)", nameof(value));
                }
                this.group = value.ToUpper();
            }
        }

        public int Course
        {
            get => this.course;
            set
            {
                if (value < 1 || value > 7) { throw new ArgumentException("Введите корректный курс", nameof(value)); }
                this.course = value;
            }


        }

        public string Faculty
        {
            get => this.faculty;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^(ЛХФ|ЛИД|ХТиТ|ПиМ|ИЭФ|ФИТ)$", RegexOptions.IgnoreCase))
                {
                    throw new ArgumentException("Введите существующий факультет", nameof(value));
                }
                this.faculty = value;
            }
        }

        public string Adress { get; set; }

        public DateOnly BirthDay {
            get => this.birthDate;
            
            set
            {
                if (value.Day < 1 || value.Day > 31) { 
                    throw new ArgumentException("Неверный день", nameof(value.Day));
                }

                if (value.Month < 1 || value.Month > 12)
                {
                    throw new ArgumentException("Неверный месяц", nameof(value.Month));
                }

                if (value.Year < 1940 || value.Year > DateTime.Now.Year - 10) 
                {
                    throw new ArgumentException("Неверный год", nameof(value.Year));
                }

                this.birthDate = new DateOnly(value.Year, value.Month, value.Day);
            }
        }

        public int Age { 
            get
            {
                var today = DateOnly.FromDateTime(DateTime.Now);
                int age = today.Year - birthDate.Year;
                if (today < birthDate.AddYears(age))
                    age--;
                return age;
            }
        }

    }


   
}
