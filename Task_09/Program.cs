using System;

namespace Task_09
{
    class Program
    {
        /*Даден е масив с цели положителни числа. Напишете програма, която проверява дали в масива съществуват едно или повече числа (подмножество),
        чиято сума е N. Можете ли да решите задачата без рекурсия?
        
        1. вводим длинну массива
        2. вводим елементы(чифры)
        3. вводим сумму которая может оброзоваться из введенных чифр
        4. выводит на экран множество из которых образуется сумму*/
        static void Main(string[] args)
        {
            Console.Write("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете {0} eлемент: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Въведете сума: ");
            int sum = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int first = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int second = arr[j];

                    if ((first + second) == sum)
                        Console.WriteLine("Подмножество с дадена сума съществува: ({0}, {1}) ", first, second);
                    else
                        Console.Write("Подмножество с дадена сума няма."); 
                }
            }
        }
    }
}
