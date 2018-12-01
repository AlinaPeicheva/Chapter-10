using System;

namespace Task_03
{
    class Program
    {
        // Напишете рекурсивна програма, която генерира всички комбинации с повторение на n елемента от k-ти клас.

        static void GetCombo(int[] arr, int index, int start, int end)
        {
            // генерирует число от  n до k .Выводит как множество( n - с какого по какое число, k - количество чисел в множестве)
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write("{0} ", arr[i]);
                    else Console.Write(arr[i]);
                Console.Write("), ");
            }
            else
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GetCombo(arr, index + 1, i, end);
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете K: ");
            int k = Int32.Parse(Console.ReadLine());
            int[] arr = new int[k];
            GetCombo(arr, 0, 1, n);
        }
    }
}
