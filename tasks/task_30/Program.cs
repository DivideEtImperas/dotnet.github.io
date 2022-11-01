//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36


int GetNumber(string message)
{
    int result = 0;
    bool correctInput = false;    

    while(!correctInput)
    {
        Console.WriteLine(message);
        correctInput = int.TryParse(Console.ReadLine(), out result);

        if(result < 1)
            correctInput = false;

        if(!correctInput)
            Console.WriteLine("Вы ввели некорректное число");

        Console.WriteLine();
    }

    return result;
}

int GetSumm(int number)
{
    int summ = 0;

    for (int i = 1; i <= number; i++)
    {
        summ += i;
    }

    return summ;
}

int number = GetNumber("Введите число:");
int summ = GetSumm(number);

Console.WriteLine($"Сумма чисел от 1 до {number} = {summ}");


