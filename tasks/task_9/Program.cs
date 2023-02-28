/*Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8 
*/

Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine()??"");

if (num > 99 && num < 1000)
{
    Console.WriteLine(num % 10);
}

else 
{
    Console.WriteLine("Третьего числа нет");
}

    


