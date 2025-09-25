
using System.Text;

namespace Lab
{
    class Program
    {
        static void Main()
        {
            Section_types();
            Section_String();
            section_Arrays();
            Section_Tuples();

            (int, int) findMinMax(int[] array)
            {
                int min = array[0], max = array[0];

                for (int i = 0; i < array.Length; i++)
                {
                    int current = array[i];
                    min = Math.Min(min, current);
                    max = Math.Max(max, current);
                }
                return (min, max);
            }

            int findSum(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }

            (int, int, int, char) returnTuple(int[] arr, string str)
            {
                (int min, int max) minmax = findMinMax(arr);
                int sum = findSum(arr);

                return (minmax.min, minmax.max, sum, str[0]);
            }

            void CheckedDemo()
            {
                try
                {
                    checked
                    {
                        int max = int.MaxValue;
                        Console.WriteLine("В checked до переполнения: " + max);
                        int overflow = max + 1;
                        Console.WriteLine("После переполнения: " + overflow);
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Исключение в checked: " + ex.Message);
                }
            }

            void UncheckedDemo()
            {
                unchecked
                {
                    int max = int.MaxValue;
                    Console.WriteLine("В unchecked до переполнения: " + max);
                    int overflow = max + 1;
                    Console.WriteLine("После переполнения: " + overflow);
                }
            }

            CheckedDemo();
            UncheckedDemo();
        }


        static void Section_types()
        {
            bool bl = true;
            sbyte sb = -100;
            byte by = 200;
            short sh = -30000;
            ushort ush = 60000;
            int i = -123456;
            uint ui = 3_000_000_000;
            long l = -9_000_000_000;
            ulong ul = 18_000_000_000;
            char ch = 'Я';
            float fl = 3.14f;
            double db = 2.718281828;
            decimal dc = 1.23456789m;
            string str = "Привет";
            object obj = 42;

            Console.Write("Введите целое (int): ");
            int inInt = int.Parse(Console.ReadLine());

            Console.Write("Введите число с плавающей точкой (double): ");
            double inDouble = double.Parse(Console.ReadLine());

            Console.Write("Введите символ (char): ");
            char inChar = (Console.ReadLine())[0];

            Console.Write("Введите логическое (true/false): ");
            bool inBool = bool.Parse(Console.ReadLine());


            byte b1 = 120;
            int iFromByte = b1;


            char ch2 = 'A';
            int iFromChar = ch2;


            int i2 = 1000;
            long lFromInt = i2;


            uint u2 = 4000000000;
            long lFromUInt = (long)u2;

            float f2 = 5.5f;
            double dFromFloat = f2;

            double d1 = 123.99;
            int intFromDouble = (int)d1;

            decimal dec1 = 10.75m;
            float floatFromDecimal = (float)dec1;

            long big = 9_000_000_000;
            int intFromLong = (int)big;


            int code = 66;
            char charFromInt = (char)code;

            object boxed = 123;
            int intFromObject = (int)boxed;


            string sNum = "255";
            int viaConvert = Convert.ToInt32(sNum);

            int val = 777;
            object box = val;
            int unboxed = (int)box;

            var greeting = "Hello, var!";

            int? maybe = null;
            maybe = 20;
            //maybe = "fef";
        }

        static void Section_String()
        {
            string lit1 = "Hello";
            string lit2 = @"C:\\Temp\\file.txt";
            string lit3 = "Он сказал: \"Привет\"";

            Console.WriteLine($"Сравнение Equals(lit1, \"Hello\"): {string.Equals(lit1, "Hello")}");
            Console.WriteLine($"String.Compare(lit1, lit3): {string.Compare(lit1, lit3)} (0  — равны, <0 — меньше, >0 — больше)\n");


            string a = "яблоко", b = "банан", c = "вишня";
            string concat = string.Concat(a, " ", b, " ", c);
            string copy = new string(a);
            string sub = concat.Substring(0, 6);

            string[] words = concat.Split(' ');
            string inserted = concat.Insert(2, " (sharp)");
            int pos = concat.IndexOf("банан");
            string removed = pos >= 0 ? concat.Remove(pos, "вишня".Length) : concat;


            Console.WriteLine($"Сцепление: {concat}");
            Console.WriteLine($"Копия: {copy}");
            Console.WriteLine($"Подстрока первых 6 символов: {sub}");
            Console.WriteLine("Слова из предложения:");
            foreach (var w in words) Console.WriteLine(" - " + w);
            Console.WriteLine($"Вставка: {inserted}");
            Console.WriteLine($"Удаление: {removed}");


            Console.WriteLine($"Интерполяция: Фрукты — {a}, {b} и {c}.\n");


            string empty = string.Empty;
            string? nstr = null;
            Console.WriteLine($"string.IsNullOrEmpty(empty)={string.IsNullOrEmpty(empty)}, IsNullOrEmpty(null)={string.IsNullOrEmpty(nstr)}");
            Console.WriteLine($"Длина пустой строки: {empty.Length}");
            Console.WriteLine($"Длина null через ?. : {nstr?.Length}\n");


            var strbuilder = new StringBuilder("[Пример работы со StringBuilder]");
            strbuilder.Remove(1, 6);
            strbuilder.Insert(0, "<");
            strbuilder.Append(">");
            Console.WriteLine($"StringBuilder: {strbuilder}\n");
        }



        static void section_Arrays()
        {


            int rows = 3, cols = 4;
            int[,] matrix = new int[rows, cols];
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    matrix[r, c] = (r + 1) * (c + 1);


            Console.WriteLine("Матрица:");
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                    Console.Write($"{matrix[r, c],5}");
                Console.WriteLine();
            }
            Console.WriteLine();
            string[] texts = { "one", "two", "three", "four" };
            Console.WriteLine($"Массив строк: [" + string.Join(',', texts) + "]");
            Console.WriteLine(texts.Length);

            Console.Write($"Введите индекс для изменения: 0 - {texts.Length - 1}");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое значение: ");
            string? userinp = Console.ReadLine();
            texts[index] = userinp ?? string.Empty;
            Console.WriteLine(string.Join(",", texts));

            double[][] jagged = new double[3][];
            jagged[0] = new double[2];
            jagged[1] = new double[3];
            jagged[2] = new double[4];

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"Введите значение jagged[{i}][{j}]: ");
                    string? userInput = Console.ReadLine();
                    jagged[i][j] = double.Parse(userInput);
                }
            }

            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j]);
                    if (j < jagged[i].Length - 1) Console.Write(", ");
                }
            }

            var implicitArray = new[] { 1, 2, 3, 5, 8 };
            var implicitString = "Неявно типизированная строка";



        }

        static void Section_Tuples()
        {

            var tuple = (42, "answer", 'X', "tuple", 123UL);


            Console.WriteLine($"Кортеж целиком: {tuple}");
            Console.WriteLine($"Выборочно: 1-й={tuple.Item1}, 3-й={tuple.Item3}, 4-й={tuple.Item4}");


            (int tInt, string tStr1, char tChar, string tStr2, ulong tUlong) = tuple;
            Console.WriteLine($"Деконструкция: tInt={tInt}, tChar={tChar}, tStr2={tStr2}");


            (int onlyInt, _, _, string onlyString, _) = tuple;
            Console.WriteLine($"С отбросом (_): onlyInt={onlyInt}, onlyString={onlyString}");


            var named = (count: 5, text: "hi", letter: 'A', word: "ok", big: 42UL);
            Console.WriteLine($"Именованный кортеж: count={named.count}, text={named.text}, big={named.big}");


            var t1 = (1, "a", 'Q', "x", 1UL);
            var t2 = (1, "b", 'Q', "x", 1UL);
            Console.WriteLine($"Равенство t1==t2: {t1 == t2}");
        }
    }
}