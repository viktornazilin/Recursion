/*
 Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
N = 4532 -> 4

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;

namespace MultiArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 64
            
            Console.WriteLine("Задача 64");
            Console.WriteLine("Введите число");

            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);

            Console.WriteLine(countNumbers(number));
            Console.WriteLine();

            //Задача 66
            Console.WriteLine("Задача 66");
            Console.WriteLine("Введите число m");
            Console.WriteLine();
            string inputM = Console.ReadLine();
            int numberM = Convert.ToInt32(inputM);

            Console.WriteLine("Введите число n");
            string inputN = Console.ReadLine();
            int numberN = Convert.ToInt32(inputN);

            SumBetween(numberM, numberN, 0);
        }

        static void SumBetween(int numberM, int numberN, int sum)
        {

            if (numberM > numberN)
            {
                Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N включительно: {sum}");
                return;
            }
            sum = sum + (numberM++);
            SumBetween(numberM, numberN, sum);
        }

        static int countNumbers(int n)
        {
            if (n / 10 != 0)
                return 1 + countNumbers(n / 10);
            else
                return 1;
        }
    }

}