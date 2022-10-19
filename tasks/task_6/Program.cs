//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введитее число:");
int numberA = int.Parse(Console.ReadLine() ?? "");

if (numberA % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


