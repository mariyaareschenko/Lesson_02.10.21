using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите кол-во чисел в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа массива");
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] sorted_array = QuikSort(array, 0, array.Length-1);
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
        public static int[] QuikSort(int[] array, int min_index, int max_index)
        {
            if (min_index >= max_index)
                return array;
            int pivot_index = GetPivotIndex(array,min_index,max_index);
            QuikSort(array, min_index, pivot_index - 1);
            QuikSort(array, pivot_index + 1, max_index);
            return array;
        }
        public static int GetPivotIndex(int [] array, int min_index, int max_index)
        {
            int pivot = min_index - 1;
            for(int i = min_index; i <= max_index; i++)
            {
                if (array[i] < array[max_index])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[max_index]);
            return pivot;
        }
        public static void Swap(ref int first, ref int last)
        {
            int temp = first;
            first = last;
            last = temp;
        }
    }
}
