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
            int indexMin2 = 0;   int minChange = 0;

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
                    indexMin2 = i;
                    minChange = array2[i];
                }
            }

            Console.WriteLine($"\nMax: {array2[indexMax]}\tIndex: {indexMax}");
            Console.WriteLine($"Min: {array2[indexMin2]}\tIndex: {indexMin2}");

            array2[indexMax] = minChange;
            array2[indexMin2] = maxChange;

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] == array2.Max())
                {
                    indexMax = i;
                }
                if (array2[i] == array2.Min())
                {
                    indexMin2 = i;
                }
            }

            Console.WriteLine($"\nMax: {array2[indexMax]}\tIndex: {indexMax}");
            Console.WriteLine($"Min: {array2[indexMin2]}\tIndex: {indexMin2}");

            //Count Max and Min
            Head("Count Max and Min");

            int[] array3 = new int[] { 4, 6, 7, 8, 9, 4, 6, 8, 9 };
            int count = 0;

            int indexMin3, indexMax2;
            indexMin3 = Array.IndexOf(array3, array3.Min());
            indexMax2 = Array.IndexOf(array3, array3.Max());

            if (indexMin3 > indexMax2)
            {
                indexMin3 = Array.IndexOf(array3, array3.Max());
                indexMax2 = Array.IndexOf(array3, array3.Min());
            }

            foreach (var item in array3)
            {
                Console.Write(item + " ");
            }

            for (var b = indexMin3; b <= indexMax2; b++)
            {
                count++;
            }

            Console.WriteLine($"\nCount: {count}");

            //Add Abs to Each Item
            Head("Add Abs to Each Item");

            int[] array4 = new int[10];

            Console.Write("Items in Array4 before addition: ");

            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] = random.Next(0, 10);
                Console.Write(array4[i] + " ");
            }

            int MaxPlusMin = array4.Max() + array4.Min();

            Console.Write("\nItems in Array4 after addition: ");

            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] += MaxPlusMin;
                Console.Write(array4[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
