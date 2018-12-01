using System;

namespace Task_04
{
    class Program
    {
        /*Нека е дадено множество от символни низове. Да се напише рекурсивна
        програма, която генерира всички подмножества, съставени
        от точно k на брой символни низа, избрани измежду елементите на това множество.*/
        static string[] wordsArr;

        static void FindSubsets(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0}", wordsArr[arr[i]]);
                    if (i != arr.Length - 1) Console.Write(" ");
                }
                Console.Write("), ");
            }
            else
                for (int i = start; i < end; i++)
                {
                    arr[index] = i;
                    FindSubsets(arr, index + 1, i + 1, end);
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете дължината на масива: "); // длинна массива = количество  слов в массиве(4)
            int length = Int32.Parse(Console.ReadLine());
            wordsArr = new string[length];
            Console.WriteLine();
            for (int i = 0; i < wordsArr.Length; i++)
            {
                Console.Write("Въведете {0} дума: ", i + 1); // ввести различные слова(ябълка груша слива банан)
                wordsArr[i] = Console.ReadLine();
            }
            Console.Write("\nВъведете K: ");                 // вводим К < от длинны массива, К-количество слов в множестве сгенерированых слов из данного массива
            int k = Int32.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Console.WriteLine();
            FindSubsets(arr, 0, 0, length);
            Console.ReadLine();
        }
    }
}
