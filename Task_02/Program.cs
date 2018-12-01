using System;

namespace Task_02
{
    class Program
    {
        // Напишете програма, която симулира изпълнението на n вложени цикъла от 1 до n.
        static void GetCombo(int[] arr, int index, int start, int end)
        {
            // генерирует число до n .Выводит как множество( n - от 1 до n-числа, n - количество чисел в множестве)
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write("{0} ", arr[i]);
                    else Console.Write(arr[i]);
                Console.Write(")   ");
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
            int k = n;
            int[] arr = new int[k];
            GetCombo(arr, 0, 1, n);
        }
    }
}
