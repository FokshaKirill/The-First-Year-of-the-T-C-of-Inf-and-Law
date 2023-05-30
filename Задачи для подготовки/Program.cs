using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_для_подготовки
{
    class Program
    {
        public static void Header(string header)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(header);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Random random = new Random();

            #region №12
            Header("№12");

            Console.Write("Введите любое двухзначное число: "); //Запрашиваем двухзначное число
            int x = int.Parse(Console.ReadLine()); //Принимаем любое двухзначное число

            Console.WriteLine($"Перевёрнутое число: {x % 10}{x / 10}\n"); //Переворачиваем число
            #endregion

            #region №13
            Header("№13");

            Console.Write("Введите любое целое число: "); //Запрашиваем любое целое число
            x = int.Parse(Console.ReadLine()); //Принимаем это число в перменную x

            if (x >= 0) //Если x больше или равно 0, т.е. - положительное,
            {
                x += 1; //то к нему прибавляем 1
            }
            else //иначе
            {
                x -= 2; //отнимаем от него 2
            }

            Console.WriteLine($"Итог: {x}\n"); //Вывод числа в консоль
            #endregion

            #region №14
            //Header("№14");

            //Console.Write("Введите любое целое число: "); //Запрашиваем любое целое число
            //x = int.Parse(Console.ReadLine()); //Принимаем это число в перменную x

            //if (x > 0) //Если x больше или равно 0, т.е. - положительное,
            //{
            //    x += 1; //то к нему прибавляем 1
            //}
            //else if (x < 0) //иначе
            //{
            //    x -= 2; //отнимаем от него 2
            //}
            //else
            //{

            //}

            //Console.WriteLine($"Итог: {x}\n"); //Вывод числа в консоль
            #endregion



            #region №18
            Header("№18");

            int[] arrayRand = new int[10];

            Console.Write("Элементы массива: ");

            for (int i = 0; i < arrayRand.Length; i++)
            {
                arrayRand[i] = random.Next(-30, 30);
                Console.Write($"{arrayRand[i]}; ");
            }

            Console.WriteLine();

            for (int i = 0; i < arrayRand.Length; i++)
            {
                if (arrayRand[i] >= 0)
                {
                    Console.WriteLine($"{arrayRand[i]} - положительное");
                }
                else
                {
                    Console.WriteLine($"{arrayRand[i]} - отрицательное");
                }
            }

            Console.WriteLine();
            #endregion

            #region №19
            Header("№19");

            arrayRand = new int[8];

            Console.Write("Элементы массива: ");

            for (int i = 0; i < arrayRand.Length; i++)
            {
                arrayRand[i] = random.Next(-20, 330);
                Console.Write($"{arrayRand[i]}; ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < arrayRand.Length; i++)
            {
                if (arrayRand[i] % 2 == 0)
                {
                    Console.WriteLine($"{arrayRand[i]} - чётное");
                }
                else
                {
                    Console.WriteLine($"{arrayRand[i]} - нечётное");
                }
            }

            Console.WriteLine();
            #endregion

            #region №20
            Header("№20");

            Console.Write("Введите любое целое число для переменной A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите любое целое число для переменной B: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"Переменная A({a}) больше переменной B({b}) на {a-b}");
            }
            else if (b > a)
            {
                Console.WriteLine($"Переменная B({b}) больше переменной A({a}) на {b-a}");
            }
            else
            {
                Console.WriteLine($"Переменные A({a}) и B({b}) равны");
            }

            Console.WriteLine();
            #endregion

            #region №21
            Header("№21");

            Console.Write("Введите любое целое число от 1 до 7: ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;

                case 2:
                    Console.WriteLine("Вторник");
                    break;

                case 3:
                    Console.WriteLine("Среда");
                    break;

                case 4:
                    Console.WriteLine("Четверг");
                    break;

                case 5:
                    Console.WriteLine("Пятница");
                    break;

                case 6:
                    Console.WriteLine("Суббота");
                    break;

                case 7:
                    Console.WriteLine("Воскресенье");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверное число!");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine();
            #endregion

            #region №22
            Header("№22");

            for (int i = 0; i < 15; i++)
            {
                x = random.Next(10, 99);
                if (x % 2 == 0)
                {
                    Console.Write($"{x}; ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region №23
            Header("№23");

            for (int i = 0; i < 15; i++)
            {
                x = random.Next(10, 99);
                if (x % 2 != 0)
                {
                    Console.Write($"{x}; ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region №24
            Header("№24");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Привет!");
            }

            Console.WriteLine();
            #endregion

            #region №25
            Header("№25");

            Console.Write("Введите любое целое число: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Информатика");
            }

            Console.WriteLine();
            #endregion

            #region №26
            Header("№26");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            #endregion

            #region №27
            Header("№27");

            for (int i = 0; i < 18; i++)
            {
                Console.Write('#');
            }

            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region №28
            Header("№28");

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            #endregion

            #region №29
            Header("№29");

            for (int i = 0; i < 18; i++)
            {
                Console.Write('#');
            }

            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region №30
            Header("№30");

            Console.WriteLine();
            #endregion

            #region №31
            Header("№31");

            for (int i = 1; i <= 11; i += 2)
            {
                if (i != 3)
                {
                    Console.Write(i + ";\t");
                }
            }

            Console.WriteLine("\n");
            #endregion

            #region №32
            Header("№32");

            for (int i = 100; i <= 200; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + "; ");
                }
            }

            Console.WriteLine("\n");
            #endregion

            #region №33
            Header("№33");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i}\t{i * 20.4:C2}");
            }

            Console.WriteLine();
            #endregion

            #region №34
            Header("№34");

            int[] array = new int[6];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите значение для {i}-го элемента массива: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nЭлементы массива: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}; ");
            }

            Console.WriteLine("\n");
            #endregion

            #region №35
            Header("№35");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите значение для {i}-го элемента массива: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nЭлементы массива: ");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]}; ");
            }

            Console.WriteLine("\n");
            #endregion

            #region №36
            Header("№36");

            double[] array2 = new double[6];

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"Введите значение для {i}-го элемента массива: ");
                array2[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write($"\nПервый элемент массива: {array2[0]:F2}\n\n");

            #endregion

            #region №37
            Header("№37");

            double[] arrayDoub = new double[10];

            for (int i = 0; i < arrayDoub.Length; i++)
            {
                arrayDoub[i] = random.Next(-10, 10);
                arrayDoub[i] += Math.Round(random.NextDouble(), 2);
            }

            Console.WriteLine($"{arrayDoub[array.Length-1]}\n");
            #endregion

            #region №38
            Header("№38");

            int[] array1 = new int[] { 3, 4, -9, 8, 1, -6, 2, -5, 7, 5, 9 };

            Console.Write("Элементы массива: ");

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]}; ");
            }

            Console.WriteLine("\n");
            #endregion

            #region №39
            Header("№39");

            int[] array4 = new int[] { -5, 2, 3, 6, 7, 9, -4, 8, 1, 2 ,7, -3 };

            Console.Write("Элементы массива: ");

            for (int i = 0; i < array4.Length; i++)
            {
                Console.Write($"{array4[i]}; ");
            }

            Console.WriteLine("\n");
            #endregion

            #region №40
            Header("№40");

            int[] array5 = new int[8] { -37, 0, 50, 46, 34, 46, 4, 13};
            int count = 0;

            for (int i = 0; i < array5.Length; i++)
            {
                if (i < 0)
                {
                    count++;
                }
                Console.Write($"{array5[i]}; ");
            }

            Console.WriteLine($"\nКол-во отрицательных значений в массиве: {count}\n");
            #endregion

            #region №41
            Header("№41");

            int[] array6 = new int[6];

            for (int i = 0; i < array6.Length; i++)
            {
                array6[i] = random.Next(0, 100);
            }

            Console.Write("Элементы массива: ");

            foreach (var item in array6)
            {
                Console.Write(item + "; ");
            }

            Console.WriteLine();
            #endregion

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Нажмите людую клавишу для завершения работы программы...");
            Console.ReadKey();
        }
    }
}
