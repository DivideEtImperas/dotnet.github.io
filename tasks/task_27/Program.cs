﻿//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.WriteLine("Введите число:");//Ввывод на консоль сообщения
int number = int.Parse(Console.ReadLine() ?? "");// Преобразует строковое значение в целочисленное значение
{
    int sum = 0;//Объявление и инициализация переменной
    for (int i = number; i > 0; i = i / 10)//Цикл индекса
    {
        sum = sum + i % 10;//Арифметическое выражение
    }

    Console.WriteLine($"Сумма цифр в числе = {sum}");//Вывод на консоль
    Console.ReadKey();// Ожидание ввода клавиши 
}