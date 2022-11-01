//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

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

int GetMultiple(int number)
{
    int result = 1;


    for (int i = 1; i <= number; i++)
    {
        result = result*i;
    }

    return result;
}

int number = GetNumber("Введите число:");
int result = GetMultiple(number);

Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");

