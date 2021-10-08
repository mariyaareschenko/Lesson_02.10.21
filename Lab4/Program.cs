using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result;
            result = Program.Comparison(num1, num2);
            Console.WriteLine("Наибольшее число: {0}", result);

            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine("Числа до изменения: {0}, {1}", num1, num2);
            Program.Exchange(ref num1, ref num2);
            Console.WriteLine("Числа после изменения: {0}, {1}", num1, num2);

            Console.WriteLine("Упражнение 5.3");
            int f;
            bool good;
            Console.WriteLine("Введите число для рассчета факториала");
            num1 = Convert.ToInt32(Console.ReadLine());
            good = Program.Factorial(num1, out f);
            if (good)
                Console.WriteLine("Факториал чила = {0}", f);
            else
                Console.WriteLine("Невозможно вычислить этот факториал");

            Console.WriteLine("Упражнение 5.4");
            result = Program.Recursion(num1);
            Console.WriteLine("Факториал чила рекурсивным методом = {0}", result);

            Console.WriteLine("Домашнее задание 5.1");
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введиет второе число");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введиет третье число");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("НОД чисел = {0}", GCD(GCD(num1,num2), num3));

            Console.WriteLine("Домашнее задание 5.2");
            Console.WriteLine("Введите номер числа");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение этого элемента в ряду Фибоначчи: {0}", Fibonachi(num1));
            Console.ReadKey();           
        }
        public static int Comparison(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static void Exchange(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static bool Factorial(int a, out int answer)
        {
            int f;
            bool good = true;
            if (a < 0)
                good = false;
            try
            {
                checked
                {
                    f = 1;
                    for(int i = 2; i <= a; i++)
                    {
                        f = f * i;
                    }
                }
            }
            catch
            {
                f = 0;
                good = false;
            }
            answer = f;
            return good;
        }
        public static int Recursion(int a)
        {
            if (a == 0)
                return 1;
            else
                return a * Recursion(a - 1);
        }
        public static int GCD(int a, int b)
        {
            while(a!= 0 & b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            int answer = a + b;
            return answer;
        }
        public static int Fibonachi(int n)
        {
            if (n == 1 | n == 2)
                return 1;
            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

    }
    
}
