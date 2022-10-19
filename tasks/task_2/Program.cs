//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/* a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите два числа для сравнения");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB )
{
    Console.Write($"maxA = {numberA} minB = {numberB}");
}
if (numberA < numberB )
{
    Console.Write($"maxB = {numberB} minA = {numberA}");
}
if (numberA == numberB);
{
Console.Write("Эти числа равны");
}
