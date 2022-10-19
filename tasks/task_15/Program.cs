//Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет



Console.WriteLine("Введите номер дня недели:");

string numberStr =Console.ReadLine() ?? "";

if (numberStr == "1")
{
    Console.WriteLine("Понедельник");
    Console.WriteLine("Это выходной день?");
    if (numberStr == "1")
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
else if (numberStr == "2")
{
    Console.WriteLine("Вторник");
    Console.WriteLine("Это выходной день?");
    if (numberStr == "2")
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
else if (numberStr == "3")
{
    Console.WriteLine("Среда");
    Console.WriteLine("Это выходной день?");
    if (numberStr == "3")
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
else if (numberStr == "4")
{
    Console.WriteLine("Четверг");
    Console.WriteLine("Это выходной день?");
    if (numberStr == "4")
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
else if (numberStr == "5")
{
    Console.WriteLine("Пятница");
    Console.WriteLine("Это выходной день?");
    if (numberStr == "5")
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
else if (numberStr == "6")
{
    Console.WriteLine("Суббота");
    Console.WriteLine("Это выходной день?");
    if (numberStr == "6")
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else if (numberStr == "7")
{
    Console.WriteLine("Воскресенье");
    Console.WriteLine("Это выходной день?");
    if (numberStr == "7")
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}


