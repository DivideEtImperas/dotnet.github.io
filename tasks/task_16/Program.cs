int GetNumber()
{
    Console.WriteLine("Введите число");
    string numberStr = Console.ReadLine()??"";
    int number = int.Parse(numberStr);
    return number;
}

int number1 = GetNumber();
int number2 = GetNumber();

if (number1 * number1 == number2 || number2 * number2 == number1)
Console.WriteLine("да");
else 
Console.WriteLine("нет");
