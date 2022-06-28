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
            Console.WriteLine($"Случайное число : {randomNumber} , минимальную степень двойки, превосходящую заданное число : {degree} , итоговое минимальное число : {numberDegree}");
        }
    }
}