// Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
int RecursionNum(int a, int b)
{

    if (b == 1)
    {
        return a;
    }
    return a * RecursionNum(a, b - 1);

}
int a = GetNumber("Введите число m");
int b = GetNumber("Введите число n");

Console.Write(RecursionNum(a, b));
