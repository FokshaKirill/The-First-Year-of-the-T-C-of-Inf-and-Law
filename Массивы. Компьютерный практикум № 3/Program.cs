using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Массивы.Компьютерный_практикум___3
{
    class Program
    {
        public static void Head(string Head)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.CursorLeft = Console.WindowWidth / 2 - Head.Length / 2;
            Console.WriteLine(Head);
            Console.WriteLine();
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            
            Random random = new Random();

            //Max and Index
            Head("Max and Index");

            int[] array1 = new int[10];
            int index = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(0, 10);
                Console.Write(array1[i] + " ");

                if (array1[i] == array1.Max())
                {
                    index = i;
                }
            }

            Console.WriteLine($"\nMax: {array1[index]}\tIndex: {index}");

            //Max and Min Replace
            Head("Max and Min Replace");

            int[] array2 = new int[] { 4, 7, 2, 9, 10, 13, 11, 5};
            int indexMax = 0;   int maxChange = 0;
            int indexMin = 0;   int minChange = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");

                if (array2[i] == array2.Max())
                {
                    indexMax = i;
                    maxChange = array2[i];
                }
                if (array2[i] == array2.Min())
                {
                    indexMin = i;
                    minChange = array2[i];
                }
            }

            Console.WriteLine($"\nMax: {array2[indexMax]}\tIndex: {indexMax}");
            Console.WriteLine($"Min: {array2[indexMin]}\tIndex: {indexMin}");

            array2[indexMax] = minChange;
            array2[indexMin] = maxChange;

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] == array2.Max())
                {
                    indexMax = i;
                }
                if (array2[i] == array2.Min())
                {
                    indexMin = i;
                }
            }

            Console.WriteLine($"\nMax: {array2[indexMax]}\tIndex: {indexMax}");
            Console.WriteLine($"Min: {array2[indexMin]}\tIndex: {indexMin}");

            //Count Max and Min
            Head("Count Max and Min");

            int[] array3 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int count = 0;

            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + " ");

                if (array3[i] > array3.Min() && array3[i] < array3.Max())
                {
                    count++;
                }
            }

            Console.WriteLine($"\nCount: {count}");

            //TEST
            int[] TestArray1 = new int[] { 1, 5, 6, 7, 2 };

            int[] TestArray2 = new int[TestArray1.Length];

            string path = @"C:\Users\Студент\Desktop\TestFile.txt";

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < TestArray1.Length; i++)
                {
                    sw.WriteLine(TestArray1[i]);
                }
            }

            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < TestArray2.Length; i++)
                {
                    TestArray2[i] = int.Parse(Console.ReadLine());
                }
            }


            Console.ReadKey();
        }
    }
}
