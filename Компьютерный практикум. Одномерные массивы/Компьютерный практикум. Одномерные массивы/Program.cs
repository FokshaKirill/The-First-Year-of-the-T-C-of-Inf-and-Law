using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум.Одномерные_массивы
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

        //ОТВЕТ
        public static void Answer(int answer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ответ: {answer}");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
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

        public static void PartOne()
        {
            Random random = new Random();

            //Task 1
            Program.Head("Task 1");

            int[] array1 = new int[8];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write($"Элементы массива {nameof(array1)}: ");

            foreach (var item in array1)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            //Task 2
            Program.Head("Task 2");

            int[] array2 = new int[10];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(-100, 100);
            }

            Console.Write($"Элементы массива {nameof(array2)}: ");

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] >= 0)
                {
                    Console.Write($"{array2[i]} ");
                }
            }

            Console.WriteLine();

            //Task 3
            Program.Head("Task 3");

            int[] array3 = new int[6] { -7, 10, 5, 16, -4, 18 };

            Console.Write($"Элементы массива {nameof(array3)}: ");

            for (int i = array3.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array3[i]} ");
            }

            Console.WriteLine();

            //Task 4
            Program.Head("Task 4");

            int[] array4 = new int[12];

            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] = random.Next(162, 191);
            }

            Console.Write($"Элементы массива {nameof(array4)}: ");

            for (int i = 0; i < array4.Length; i++)
            {
                Console.Write($"{array4[i]} ");
            }

            Console.WriteLine();

            Program.Next();
        }

        public static void PartTwo()
        {
            Random random = new Random();

            //Task 1
            Head("Task 1");

            int[] array1 = new int[10];
            int count = 0;

            Console.Write($"Элементы массива {nameof(array1)}: ");

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(0, 101);
                Console.Write($"{array1[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Кол-во четных чисел в массиве {nameof(array1)}: {count}");

            //Task 2
            Head("Task 2");

            double[] array2 = new double[10];
            double sum1 = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(0, 101);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] % 5 == 0)
                {
                    sum1 += array2[i];
                }
            }

            Console.Write($"Элементы массива {nameof(array2)}: ");

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }

            Console.WriteLine($"\nСумма элементов массива {nameof(array2)}, кратных 5: {sum1}");

            //Task 3
            Head("Task 3");

            int[] array3 = new int[15];

            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = random.Next(0, 101);
            }



            End();
        }

        static void Main(string[] args)
        {
            //PartOne();
            PartTwo();
        }
    }
}
