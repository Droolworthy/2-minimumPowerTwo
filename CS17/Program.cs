//Найдите минимальную степень двойки, превосходящую заданное число.
//К примеру, для числа 4 будет 2 в степени 3, то есть 8. 4<8.
//Для числа 29 будет 2 в степени 5, то есть 32. 29<32.
//В консоль вывести число (лучше получить от Random), степень и само число 2 в найденной степени.
using System;

namespace CS17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int degree = 1;
            int number = 2;
            int maxRandomValue = 50;
            int minRandomValue = 2;
            int numberDegree;
            int randomNumber = random.Next(minRandomValue, maxRandomValue);
            numberDegree = number;
            
            while (numberDegree < randomNumber)
            {
                numberDegree *= number;
                degree++;
            }
            Console.WriteLine($"Случайное число : {randomNumber} , минимальную степень двойки, " +
                $"превосходящую заданное число : {degree} , итоговое минимальное число : {numberDegree}");
        }
    }
}
