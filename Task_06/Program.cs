using System;

namespace Task_06
{
    class Program
    {
        /*Реализирайте алгоритъма "сортиране чрез сливане" (merge-sort).
        При него началният масив се разделя на две равни по големина части, които се сортират (рекурсивно чрез merge-sort) и след това двете сортирани
        части се сливат, за да се получи целият масив в сортиран вид.*/
        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {   // вводим в начале длинну массива до 25, и вводим числа, которые отсортируются
            int[] temp = new int[25];
            int i, leftEnd, numElements, tmpPos;

            leftEnd = (mid - 1);                          // разделение массива на две равних части
            tmpPos = left;
            numElements = (right - left + 1);

            while ((left <= leftEnd) && (mid <= right)) 
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmpPos++] = numbers[left++];
                else
                    temp[tmpPos++] = numbers[mid++];
            }

            while (left <= leftEnd)
                temp[tmpPos++] = numbers[left++];

            while (mid <= right)
                temp[tmpPos++] = numbers[mid++];

            for (i = 0; i < numElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSortRecursive(int[] numbers, int left, int right) // соединение двух частей, которые отсортируются
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSortRecursive(numbers, left, mid);
                MergeSortRecursive(numbers, (mid + 1), right);
                DoMerge(numbers, left, (mid + 1), right);
            }
        }


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

            Console.WriteLine("\nСортировка");

            MergeSortRecursive(arr, 0, length - 1);
            for (int i = 0; i < length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
