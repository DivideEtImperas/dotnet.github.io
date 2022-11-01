/*Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/
int GetRandomNumber(int leftRange, int rightRange)
{
    Random rnd = new Random();
    int result = rnd.Next(leftRange, rightRange);// [leftRange, rightRange)
    return result;
}

int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if(firstDigit > secondDigit)
    return firstDigit;
    else
    return secondDigit;
}

int number = GetRandomNumber(10,100);
Console.WriteLine($"Рандомное число: {number}");

int maxDigit = GetMaxDigitOfNumber(number);
Console.WriteLine($"Максимальная цифра: {maxDigit}");

