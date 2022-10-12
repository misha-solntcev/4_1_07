using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 7
Дана целочисленная квадратная матрица. Определить:
1.произведение элементов в тех строках, которые не содержат отрицательных
элементов;
2.максимум среди сумм элементов диагоналей, параллельных главной диагонали
матрицы. */

namespace _4_1_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 8, 0, 6, -4, 8 },
                { 4, 1, 6, 7, 8 },
                { 7, 8, 9, 0, 2 },
                { 12, 0, 3, -4, 5 },
                { 13, 0, 6, 7, 8 }                
            };

            // Вывод в консоль исходного массива.
            Console.WriteLine($"Исходный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {array[i, j]}, ");
                }
                Console.WriteLine();
            }

            // Произведение элементов в тех строках, которые не содержат отрицательных элементов;
            List<int> list = new List<int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                bool flag = true;
                int product = 1;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    product *= array[i, j];
                    if (array[i, j] < 0)
                        flag = false;
                }
                if (flag)
                    list.Add(product);
            }
            Console.WriteLine("Произведения элементов строк.");
            foreach (int product in list)
                Console.Write($"{product}, ");
            Console.WriteLine();            

            // Объявляем массив списков элементов диагоналей.
            List<int>[] diag = new List<int>[array.GetLength(0) - 1]; 
            
            Console.WriteLine($"Диагонали слева: ");
            for (int k = 1; k < array.GetLength(0) - 1; k++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (i == j + k)
                        {
                            Console.Write($" {array[i, j]}, ");                            
                        }                            
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Диагонали справа: ");
            for (int k = 1; k < array.GetLength(0) - 1; k++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (j == i + k)
                            Console.Write($" {array[i, j]}, ");
                    }                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
