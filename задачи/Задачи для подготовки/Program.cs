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



            Console.ReadKey();
        }
    }
}
