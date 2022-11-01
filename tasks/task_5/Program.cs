/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
int number = GetRandomNumber(100,1000);
Console.WriteLine(number);

int twoDigits = DeleteSecondDigit(number);
Console.WriteLine(twoDigits);

int GetRandomNumber (int leftRange, int rightRange ) // [100-1000)
{
    Random rnd = new Random();
     int result = rnd.Next (leftRange, rightRange); // [leftRange,rightRange)
    return result;
}

int DeleteSecondDigit(int number)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;

    return firstDigit * 10 + thirdDigit;
}


