//Код для защиты от дурака


int GetNumber(string message)
{
    int result = 0;
    bool correctInput = false;

    while (true)
    {
        Console.WriteLine(message);
        correctInput = int.TryParse(Console.ReadLine(), out result);

        if (!correctInput)
            Console.WriteLine("Вы ввели не корректное число");
        Console.WriteLine();
        return result;
    }
}

int temp = GetNumber("Введите число");