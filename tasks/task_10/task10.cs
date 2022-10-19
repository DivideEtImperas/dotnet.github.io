//Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число");

int number = int.Parse(Console.ReadLine() ?? "");

if (number > 99 && number <= 1000)
{
    Console.WriteLine(number / 10 % 10);
}

