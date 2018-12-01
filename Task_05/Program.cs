using System;

namespace Task_05
{
    class Program
    {
        // Напишете рекурсивна програма, която отпечатва всички подмножества на дадено множество от думи.
        static string[] strings, str;
        static int length;
        /* 1. введите число (3-лучший вариант для примера)
           2. введите три слова
           3. программа генерирует групами слова которые не повторяются*/ 
        static void cycle(int iter, int index, int k)
        {
            if (iter == k)
            {
            for (int i = 0; i < length; i++)
                    Console.WriteLine("({0}) ", str[i]);
                return;
            }

        for (int i = index; i < strings.Length; i++)
            {
                str[iter] = strings[i];
                cycle(iter + 1, i + 1, k);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете дължината на масива от думи: ");
            length = Int32.Parse(Console.ReadLine());

            strings = new string[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете {0} дума: ", i + 1);
                strings[i] = Console.ReadLine();
            }

            for (int i = 0; i <= length; i++)
            {
                str = new string[length];
                cycle(0, 0, i);
            }
        }
    }
}
