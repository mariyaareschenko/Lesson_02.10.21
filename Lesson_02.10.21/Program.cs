using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02._10._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите коэффициент а:");
            double mya = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b:");
            double myb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c:");
            double myc = Convert.ToDouble(Console.ReadLine());
            double myx1, myx2;
            switch (Program.Roots(mya, myb, myc, out myx1, out myx2))
            {
                case 2:
                    Console.WriteLine("Уравнение имеет 2 корня: x1 = {0}, x2 = {1}", myx1, myx2);
                    break;
                case 1:
                    Console.WriteLine("Уравнение имеет 1 корень: x = {0}", myx1);
                    break;
                case 0:
                    Console.WriteLine("Уравнение не имеет корней");
                    break;
                case -1:
                    Console.WriteLine("Неверно введены данные. Попробуйте еще раз");
                    break;
                case -2:
                    Console.WriteLine("Данное уравнение не является квадратным.");
                    break;
            }

            Console.WriteLine("Задание 2");
            Random r = new Random();
            int[] numbers = new int [20];
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next();
            }
            Console.WriteLine("Исходный массив:");
            for(int i = 0; i< 20; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Введите два числа, которые нужно поменять в массиве");
            int num1 = Convert.ToInt32(Console.ReadLine()), num2 = Convert.ToInt32(Console.ReadLine());
            if (numbers.Contains(num1) & numbers.Contains(num2))
            {
                int ind1 = Array.IndexOf(numbers, num1);
                int ind2 = Array.IndexOf(numbers, num2);
                (numbers[ind1], numbers[ind2]) = (numbers[ind2], numbers[ind1]);
                Console.WriteLine("Полученный массив: ");
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            else
            {
                Console.WriteLine("Введенные числа не принадлежат массиву");
            }

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите кол-во чисел в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа массива");
            int[] array = new int[n];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Bubble(array);
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите кол-во чисел в массиве");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа массива");
            double[] mas = new double[n];
            double prz = 1, sr_znach;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Сумма элементов: ");
            Calculations(ref prz, out sr_znach, mas);
            Console.WriteLine("Произведение элементов: {0}\n Среденее арифметическое элементов: {1}", prz, sr_znach);
            Calculations(ref prz, out sr_znach, mas);

            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите число от 0 до 9");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                string text;
                switch (num)
                {
                    case 0:
                        text = System.IO.File.ReadAllText(@"C:\Users\asus\OneDrive\Рабочий стол\прога 1 семестр\Lesson_02.10.21\0.txt");
                        Console.WriteLine(text);
                        break;
                    case 1:
                        text = System.IO.File.ReadAllText(@"C:\Users\asus\OneDrive\Рабочий стол\прога 1 семестр\Lesson_02.10.21\1.txt");
                        Console.WriteLine(text);
                        break;
                    case 2:
                        text = System.IO.File.ReadAllText(@"C:\Users\asus\OneDrive\Рабочий стол\прога 1 семестр\Lesson_02.10.21\2.txt");
                        Console.WriteLine(text);
                        break;
                    case 3:
                        text = System.IO.File.ReadAllText(@"C:\Users\asus\OneDrive\Рабочий стол\прога 1 семестр\Lesson_02.10.21\3.txt");
                        Console.WriteLine(text);
                        break;
                    case 4:
                        text = System.IO.File.ReadAllText(@"C:\Users\asus\OneDrive\Рабочий стол\прога 1 семестр\Lesson_02.10.21\4.txt");
                        Console.WriteLine(text);
                        break;
                    case 5:
                        text = System.IO.File.ReadAllText(@"C:\Users\asus\OneDrive\Рабочий стол\прога 1 семестр\Lesson_02.10.21\5.txt");
                        Console.WriteLine(text);
                        break;
                    case 6:
                        text = System.IO.File.ReadAllText(@"C:\Users\asus\OneDrive\Рабочий стол\прога 1 семестр\Lesson_02.10.21\6.txt");
                        Console.WriteLine(text);
                        break;
                    case 7:
                        text = System.IO.File.ReadAllText(@"C:\Users\asus\OneDrive\Рабочий стол\прога 1 семестр\Lesson_02.10.21\7.txt");
                        Console.WriteLine(text);
                        break;
                    case 8:
                        text = System.IO.File.ReadAllText(@"C:\Users\asus\OneDrive\Рабочий стол\прога 1 семестр\Lesson_02.10.21\8.txt");
                        Console.WriteLine(text);
                        break;
                    case 9:
                        text = System.IO.File.ReadAllText(@"C:\Users\asus\OneDrive\Рабочий стол\прога 1 семестр\Lesson_02.10.21\9.txt");
                        Console.WriteLine(text);
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("Введеное число не принадлежит диапозону");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный формат");
            }
            
            Console.ReadKey();
        }

        //task1
        public static int Roots(double a, double b, double c, out double x1, out double x2)
        {
            x1 = 0; x2 = 0;
            double d = b * b - 4 * a * c;
            if (a == 0)
            {
                return -2;
            }
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return 2;
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                return 1;
            }
            else if (d < 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        //task3
        public static int [] Bubble(int [] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        //task4
        public static void Calculations(ref double pr, out double sr, params double [] numbers)
        {
                double sum = 0; 
                pr = 1; sr = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                    pr *= numbers[i];
                    sr = sum / numbers.Length;
                }
                Console.WriteLine(sum);                
        }
    }
}
