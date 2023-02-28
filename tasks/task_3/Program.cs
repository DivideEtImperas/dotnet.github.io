// Напишите программу, которая будет выдавать 
//название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели:");

string numberStr = (Console.ReadLine()??"");

if (numberStr == "1")
{
    Console.WriteLine("Понедельник");
}
else if (numberStr == "2")
{
    Console.WriteLine("Вторник");
}
else if (numberStr == "3")
{
    Console.WriteLine("Среда");
}
else if (numberStr == "4")
{
    Console.WriteLine("Четверг");
}
else if (numberStr == "5")
{
    Console.WriteLine("Пятница");
}
else if (numberStr == "6")
{
    Console.WriteLine("Суббота");
}
else if (numberStr == "7")
{
    Console.WriteLine("Воскресенье");
    
}
