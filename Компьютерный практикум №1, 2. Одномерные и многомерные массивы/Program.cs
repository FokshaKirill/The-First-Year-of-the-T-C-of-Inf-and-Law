using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум__1__2.Одномерные_и_многомерные_массивы
{
    internal class Program
    {
        //ТЕКСТ ПО ЦЕНТРУ
        public static void Head(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorLeft = Console.WindowWidth / 2 - s.Length / 2;
            Console.WriteLine(s);
            Console.ResetColor();
            Console.WriteLine();
        }

        //ВЫВОД МАССИВА
        public static void Output(Array arrayName)
        {
            Console.Write($"Элементы массива: ");
            foreach (var item in arrayName)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
        }

        //ПЕРЕХОД К СЛЕДУЮЩЕМУ БЛОКУ ЗАДАНИЙ
        public static void Next()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }

        //КОНЕЦ РАБОТЫ ПРОГРАММЫ
        public static void End()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nНажмите любую клавишу, чтобы завершить работу программы...");
            Console.ReadKey();
        }
        
        //PART ONE
        public static void PartOne()
        {
            Random random = new Random();
            //Task 1
            Head("Task 1");

            int[] array1 = new int[4];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"Введите значение {i + 1} элемента массива: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Output(array1);

            //Task 2
            Head("Task 2");

            int[] array2 = new int[] { 3, 5, 7, 2, 4, 6 };

            Output(array2);

            //Task 3
            Head("Task 3");

            int[] array3 = new int[9];

            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = i;
            }

            Output(array3);

            //Task 4
            Head("Task 4");

            int[] array4 = new int[10];

            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] = random.Next(0, 100);
            }

            Output(array4);

            Next();
        }

        //PART TWO
        public static void PartTwo()
        {
            Random random = new Random();

            //Task 1
            Head("Task 1");

            int[] array1 = new int[6];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(0, 6);
            }

            Output(array1);

            for (int i = 1; i < array1.Length-1; i++)
            {
                if (array1[i] == array1[0])
                {
                    Console.WriteLine($"Значение элемента №{i+1} совпадает со значением элемента №0");
                }
            }

            //Task 2
            Head("Task 2");

            int[] array2 = new int[10];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(-100, 500);
            }

            Output(array2);

            Console.Write("а) Неотрицательные элементы: ");
            foreach (var item in array2)
            {
                if (item >= 0)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine("\n");

            Console.Write("б) Элементы, не превышающие число 100: ");
            foreach (var item in array2)
            {
                if (item <= 100)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine("\n");

            Console.Write("в) Четные элементы: ");
            foreach (var item in array2)
            {
                if (item % 2 == 0)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine("\n");

            //Task 3
            Head("Task 3");

            int count = 0;
            int[] array3 = new int[] { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };

            Output(array3);

            foreach (var item in array3)
            {
                if (item < 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Кол-во отрицательных элементов: {count}");

            //Task 4
            Head("Task 4");

            int sum = 0;
            int[] array4 = new int[10];

            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] = random.Next(0, 100);
            }

            Output(array4);

            foreach (var item in array4)
            {
                if (item % 2 != 0)
                {
                    sum += item;
                }
            }

            Console.WriteLine($"Среднее арифметическое массива {nameof(array4)}: {(sum / array4.Length)}");

            //Task 5
            Head("Task 5");

            int[] array5 = new int[] { 1, 2, 3, 6, 7, 8 };

            Console.Write($"Элементы массива {nameof(array5)} до умножжения: ");
            foreach (var item in array5)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < array5.Length; i++)
            {
                array5[i] *= 5;
            }

            Console.Write($"Элементы массива {nameof(array5)} после умножжения: ");
            foreach (var item in array5)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            End();
        }

        static void Main(string[] args)
        {
            PartOne();
            PartTwo();
        }
    }
}
