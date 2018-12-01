using System;

namespace Task_01
{
    class Program
    {
        //Напишете рекурсивна програма, която генерира и отпечатва всички вариации с повторение на k елемента над n-елементно множество.

        static void Recur(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                foreach (int element in arr) Console.Write("{0} ", element);
                Console.WriteLine();
            }
            else
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    Recur(arr, index + 1);
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете N: "); // не больше 5, выводит подрят чифри(например если 5, то выведет 5-значное число с чифрами от 1 до 5)
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Recur(arr, 0);
        }
    }
}
